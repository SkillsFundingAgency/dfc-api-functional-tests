using DFC.API.JobProfiles.FunctionalTests.Model.API.JobProfileDetails;
using DFC.API.JobProfiles.FunctionalTests.Model.Support;
using DFC.API.JobProfiles.FunctionalTests.Support.API;
using DFC.API.JobProfiles.FunctionalTests.Support.API.RestFactory.Interfaces;
using FakeItEasy;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace DFC.API.JobProfiles.UnitTests
{
    public class APITests
    {
        private AppSettings appSettings;
        private APISettings apiSettings;
        private IRestClientFactory restClientFactory;
        private IRestRequestFactory restRequestFactory;
        private IJobProfileApi jobProfileApi;
        private IRestClient restClient;
        private IRestRequest restRequest;

        public APITests()
        {
            this.appSettings = new AppSettings()
            {
                APIConfig = new APIConfig()
                {
                    ApimSubscriptionKey = "apimKey",
                    Version = "v1",
                },
            };

            this.apiSettings = new APISettings();
            this.restClientFactory = A.Fake<IRestClientFactory>();
            this.restRequestFactory = A.Fake<IRestRequestFactory>();
            this.restClient = A.Fake<IRestClient>();
            this.restRequest = A.Fake<IRestRequest>();
            A.CallTo(() => this.restClientFactory.Create(A<Uri>.Ignored)).Returns(this.restClient);
            A.CallTo(() => this.restRequestFactory.Create(A<string>.Ignored)).Returns(this.restRequest);
            this.jobProfileApi = new JobProfileApi(this.restClientFactory, this.restRequestFactory, this.appSettings, this.apiSettings);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public async Task EmptyOrNullIdResultsInNullBeingReturned(string id)
        {
            Assert.Null(await this.jobProfileApi.GetById<JobProfileDetailsAPIResponse>(id).ConfigureAwait(true));
        }

        [Fact]
        public async Task SuccessfulGetRequest()
        {
            var apiResponse = new RestResponse<JobProfileDetailsAPIResponse>();
            apiResponse.StatusCode = HttpStatusCode.OK;
            A.CallTo(() => this.restClient.Execute<JobProfileDetailsAPIResponse>(A<IRestRequest>.Ignored)).Returns(apiResponse);
            var response = await this.jobProfileApi.GetById<JobProfileDetailsAPIResponse>("id").ConfigureAwait(false);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData("Accept", "application/json")]
        [InlineData("Ocp-Apim-Subscription-Key", "apimKey")]
        [InlineData("version", "v1")]
        public async Task AllRequestHeadersAreSet(string headerKey, string headerValue)
        {
            var response = await this.jobProfileApi.GetById<JobProfileDetailsAPIResponse>("id").ConfigureAwait(false);
            A.CallTo(() => this.restRequest.AddHeader(headerKey, headerValue)).MustHaveHappenedOnceExactly();
        }
    }
}
