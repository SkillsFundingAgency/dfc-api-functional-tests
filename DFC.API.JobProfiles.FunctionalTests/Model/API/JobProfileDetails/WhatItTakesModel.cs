using System.Collections.Generic;

namespace DFC.API.JobProfiles.FunctionalTests.Model.API.JobProfileDetails
{
    public class WhatItTakesModel
    {
        public string DigitalSkillsLevel { get; set; }

        public List<Skill> Skills { get; set; }

        public RestrictionsAndRequirements RestrictionsAndRequirements { get; set; }
    }
}