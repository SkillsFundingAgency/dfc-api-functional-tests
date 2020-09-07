using System.Collections.Generic;

namespace DFC.API.JobProfiles.FunctionalTests.Model.API.JobProfileSearch
{
    public class JobProfileSearchAPIResponse
    {
        public int Count { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public List<Result> Results { get; set; }
    }
}