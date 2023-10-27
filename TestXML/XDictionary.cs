using System.Xml.Serialization;

namespace TestXML
{
    [XmlRoot(ElementName = "XDictionary")]
    public class XDictionary
    {
        [XmlElement(ElementName = "FileName")]
        public string FileName { get; set; }
        [XmlElement(ElementName = "Carrier")]
        public string Carrier { get; set; }
        [XmlElement(ElementName = "NamedInsured")]
        public string NamedInsured { get; set; }
        [XmlElement(ElementName = "LineOfCoverage")]
        public string LineOfCoverage { get; set; }
        [XmlElement(ElementName = "EmployeeIncrements")]
        public string EmployeeIncrements { get; set; }
        [XmlElement(ElementName = "EmployeeMaximum")]
        public string EmployeeMaximum { get; set; }
        [XmlElement(ElementName = "SpouseIncrementsOrPercentage")]
        public string SpouseIncrementsOrPercentage { get; set; }
        [XmlElement(ElementName = "SpouseMaximum")]
        public string SpouseMaximum { get; set; }
        [XmlElement(ElementName = "SpousePercOfEmployeeBenefitLimit")]
        public string SpousePercOfEmployeeBenefitLimit { get; set; }
        [XmlElement(ElementName = "ChildBenefitAmount")]
        public string ChildBenefitAmount { get; set; }
        [XmlElement(ElementName = "ChildMaximum")]
        public string ChildMaximum { get; set; }
        [XmlElement(ElementName = "ChildPercOfEmployeeBenefitLimit")]
        public string ChildPercOfEmployeeBenefitLimit { get; set; }
        [XmlElement(ElementName = "EmployeeGuaranteeIssue")]
        public string EmployeeGuaranteeIssue { get; set; }
        [XmlElement(ElementName = "SpouseGuaranteeIssue")]
        public string SpouseGuaranteeIssue { get; set; }
        [XmlElement(ElementName = "ChildGuaranteeIssue")]
        public string ChildGuaranteeIssue { get; set; }
        [XmlElement(ElementName = "InvasiveOrMalignantCancer")]
        public string InvasiveOrMalignantCancer { get; set; }
        [XmlElement(ElementName = "Category1Vascular")]
        public string Category1Vascular { get; set; }
        [XmlElement(ElementName = "OrganOrKidneyFailure")]
        public string OrganOrKidneyFailure { get; set; }
        [XmlElement(ElementName = "RecurrenceDifferentIllnessWaitingPeriod")]
        public string RecurrenceDifferentIllnessWaitingPeriod { get; set; }
        [XmlElement(ElementName = "SecondOccurrenceOfSameIllnessWaitingPeriod")]
        public string SecondOccurrenceOfSameIllnessWaitingPeriod { get; set; }
        [XmlElement(ElementName = "AgeReduction")]
        public string AgeReduction { get; set; }
        [XmlElement(ElementName = "PreExistingCondition")]
        public string PreExistingCondition { get; set; }
        [XmlElement(ElementName = "Portability")]
        public string Portability { get; set; }
        [XmlElement(ElementName = "WellnessBenefit")]
        public string WellnessBenefit { get; set; }
        [XmlElement(ElementName = "EmployerContributionLevel")]
        public string EmployerContributionLevel { get; set; }
        [XmlElement(ElementName = "AgeBasis")]
        public string AgeBasis { get; set; }
        [XmlElement(ElementName = "DependentAgeLimits")]
        public string DependentAgeLimits { get; set; }
        [XmlElement(ElementName = "ParticipationRequirement")]
        public string ParticipationRequirement { get; set; }
        [XmlElement(ElementName = "RateAge25")]
        public string RateAge25 { get; set; }
        [XmlElement(ElementName = "RateAge35")]
        public string RateAge35 { get; set; }
        [XmlElement(ElementName = "RateAge45")]
        public string RateAge45 { get; set; }
        [XmlElement(ElementName = "RateAge55")]
        public string RateAge55 { get; set; }
        [XmlElement(ElementName = "IsWellnessBenefitCostIncluded")]
        public string IsWellnessBenefitCostIncluded { get; set; } 
        [XmlElement(ElementName = "RateGuarantee")]
        public string RateGuarantee { get; set; }
    }
}
