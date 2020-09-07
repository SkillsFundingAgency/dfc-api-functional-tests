using System.Collections.Generic;

namespace DFC.API.JobProfiles.FunctionalTests.Model.API.JobProfileDetails
{
    public class HowToBecomeModel
    {
        public List<string> EntryRouteSummary { get; set; }

        public EntryRoutes EntryRoutes { get; set; }

        public MoreInformation MoreInformation { get; set; }
    }
}