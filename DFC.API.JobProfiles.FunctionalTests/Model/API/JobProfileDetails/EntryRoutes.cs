﻿using System.Collections.Generic;

namespace DFC.API.JobProfiles.FunctionalTests.Model.API.JobProfileDetails
{
    public class EntryRoutes
    {
        public University University { get; set; }

        public College College { get; set; }

        public Apprenticeship Apprenticeship { get; set; }

        public List<object> Work { get; set; }

        public List<string> Volunteering { get; set; }

        public List<object> DirectApplication { get; set; }

        public List<object> OtherRoutes { get; set; }
    }
}