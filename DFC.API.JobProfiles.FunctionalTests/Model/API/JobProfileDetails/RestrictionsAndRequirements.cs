using System.Collections.Generic;

namespace DFC.API.JobProfiles.FunctionalTests.Model.API.JobProfileDetails
{
    public class RestrictionsAndRequirements
    {
        public List<string> RelatedRestrictions { get; set; }

        public List<object> OtherRequirements { get; set; }
    }
}