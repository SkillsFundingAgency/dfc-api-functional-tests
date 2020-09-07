using DFC.API.JobProfiles.FunctionalTests.Model.ContentType.JobProfile;

namespace DFC.API.JobProfiles.FunctionalTests.Model.ContentType
{
    public class SOCCodeContentType : SocCodeData
    {
        public string JobProfileId { get; set; }

        public string JobProfileTitle { get; set; }

        public string Title { get; set; }
    }
}
