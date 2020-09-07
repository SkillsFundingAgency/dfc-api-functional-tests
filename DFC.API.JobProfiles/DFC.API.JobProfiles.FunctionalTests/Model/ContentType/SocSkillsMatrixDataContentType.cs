﻿using DFC.API.JobProfiles.FunctionalTests.Model.ContentType.JobProfile;
using System.Collections.Generic;

namespace DFC.API.JobProfiles.FunctionalTests.Model.ContentType
{
    public class SocSkillsMatrixDataContentType
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Contextualised { get; set; }

        public string ONetAttributeType { get; set; }

        public double Rank { get; set; }

        public double ONetRank { get; set; }

        public List<RelatedSkill> RelatedSkill { get; set; }

        public List<RelatedSOC> RelatedSOC { get; set; }
    }
}
