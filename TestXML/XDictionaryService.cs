using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace TestXML
{
    public class XDictionaryService
    {
        private const string CheckSumWithDot = @"\$[0-9]+\.[0-9]+";
        private const string CheckSumWithComma = @"\$[0-9]+\,[0-9]+";
        private const string CheckSimpleSum = @"\$[0-9]";
        private const string CheckCondition= @"^\d{2}/\d{2}$";

        public XDictionary ParseXDictionaryFromXml(string xmlFilePath)
        {
            XDictionary xDictionary = new XDictionary();

            using (StreamReader reader = new StreamReader(xmlFilePath, System.Text.Encoding.Default))
            {
                XPathDocument doc = new XPathDocument(reader);
                XPathNavigator navigator = doc.CreateNavigator();

                var manager = new XmlNamespaceManager(navigator.NameTable);
                manager.AddNamespace("docset", "http://www.docugami.com/2021/dgml/Nelligan/CaseProposals10.16.23");
                manager.AddNamespace("dg", "http://www.docugami.com/2021/dgml");
                manager.AddNamespace("dgc", "http://www.docugami.com/2021/dgml/docugami/contracts");
                manager.AddNamespace("xhtml", "http://www.w3.org/1999/xhtml");

                xDictionary.FileName = GetValue(navigator,"//nonExistentElement", manager);
                xDictionary.Carrier = GetValue(navigator, "//docset:TheRetirementAndProtectionSubsidiaries[1]/dg:chunk[1]/dgc:Org[1]/text()[1]", manager);
                xDictionary.NamedInsured= GetValue(navigator, "//nonExistentElement", manager);
                xDictionary.LineOfCoverage = GetValue(navigator, "./dg:chunk[1]/dg:chunk[3]/dg:chunk[1]/dg:chunk[1]/text()[1]", manager);
                xDictionary.EmployeeIncrements = GetValue(navigator, "//xhtml:tr[15]/xhtml:td[2]/docset:RehabilitationPhysicalTherapyBenefit[1]/text()[1]", manager,CheckSumWithComma);
                xDictionary.EmployeeMaximum = GetValue(navigator, "//docset:_5000Increments[1]/text()[1]", manager, CheckSumWithComma);
                xDictionary.SpouseIncrementsOrPercentage = GetValue(navigator, "//docset:AdditionalInjuries-paralysis-Hemiplegia[1]/text()[1]", manager, CheckSumWithComma);
                xDictionary.SpouseMaximum = GetValue(navigator, "//docset:AdditionalInjuries-paralysis-Paraplegia[1]/text()[1]", manager, CheckSumWithComma);
                xDictionary.SpousePercOfEmployeeBenefitLimit = GetValue(navigator, "//docset:GroupAccidentalDeathDismemberment[1]/xhtml:table[1]/xhtml:tbody[1]/xhtml:tr[9]/xhtml:td[2]/docset:DismembermentBenefit[1]/dg:chunk[2]/docset:_100Hand/dgc:Percent[3]", manager);
                xDictionary.ChildBenefitAmount = GetValue(navigator, "//docset:AdditionalInjuries-paralysis-Hemiplegia[1]/text()[1]", manager, CheckSumWithComma);
                xDictionary.ChildMaximum = GetValue(navigator, "//xhtml:tr[15]/xhtml:td[2]/docset:RehabilitationPhysicalTherapyBenefit[1]/text()[1]", manager, CheckSumWithComma);
                xDictionary.ChildPercOfEmployeeBenefitLimit = GetValue(navigator, "//docset:GroupAccidentalDeathDismemberment[1]/xhtml:table[1]/xhtml:tbody[1]/xhtml:tr[9]/xhtml:td[2]/docset:DismembermentBenefit[1]/dg:chunk[2]/docset:_100Hand/dgc:Percent[3]", manager);
                xDictionary.EmployeeGuaranteeIssue = GetValue(navigator, "//docset:_5000Increments[1]/text()[1]", manager, CheckSumWithComma);
                xDictionary.SpouseGuaranteeIssue = GetValue(navigator, "//docset:AdditionalInjuries-paralysis-Paraplegia[1]/text()[1]", manager, CheckSumWithComma);
                xDictionary.ChildGuaranteeIssue = GetValue(navigator, "//xhtml:tr[15]/xhtml:td[2]/docset:RehabilitationPhysicalTherapyBenefit[1]/text()[1]", manager, CheckSumWithComma);
                xDictionary.InvasiveOrMalignantCancer = GetValue(navigator, "//docset:EmployerContribution[1]/text()[1]", manager);
                xDictionary.Category1Vascular = GetValue(navigator, "//docset:EmployerContribution[1]/text()[1]", manager);
                xDictionary.OrganOrKidneyFailure = GetValue(navigator, "//docset:EmployerContribution[1]/text()[1]", manager);
                xDictionary.RecurrenceDifferentIllnessWaitingPeriod = GetValue(navigator, "//docset:LifetimeMaximumPayout[1]/text()[1]", manager);
                xDictionary.SecondOccurrenceOfSameIllnessWaitingPeriod = GetValue(navigator, "//docset:TravelAssistance[1]/text()[1]", manager);
                xDictionary.AgeReduction = GetValue(navigator, "//docset:BenefitPlanAndFeaturesNone[1]/text()[1]", manager);
                xDictionary.PreExistingCondition = GetValue(navigator, "//xhtml:tr[15]/xhtml:td[2]/docset:Pre-ExistingConditionLimitation[1]/text()[1]", manager, CheckCondition);
                xDictionary.Portability = GetValue(navigator, "//docset:TravelAssistance[1]/text()[1]", manager);
                xDictionary.WellnessBenefit = GetValue(navigator, "//xhtml:tr[16]/xhtml:td[2]/docset:SurgicalNon-surgicalRepair[1]/dgc:Money[2]/text()[1]", manager, CheckSimpleSum);
                xDictionary.EmployerContributionLevel = GetValue(navigator, "//nonExistentElement", manager);
                xDictionary.AgeBasis = GetValue(navigator, "//docset:CriticalIllnessChildEligibility[1]/xhtml:table[1]/xhtml:tbody[1]/xhtml:tr[13]/xhtml:td[2]/docset:PremiumRateBasis[1]/text()[1]", manager);
                xDictionary.DependentAgeLimits = GetValue(navigator, "//dg:chunk[1]/dg:chunk[2]/dgc:Number[1]/text()[1]", manager);
                xDictionary.ParticipationRequirement = GetValue(navigator, "//nonExistentElement", manager);
                xDictionary.RateAge25 = GetValue(navigator, "//xhtml:tr[6]/xhtml:td[2]/docset:_10000[1]/text()[1]", manager, CheckSumWithDot);
                xDictionary.RateAge35 = GetValue(navigator, "//xhtml:td[3]/docset:_10000[1]/text()[1]", manager, CheckSumWithDot);
                xDictionary.RateAge45 = GetValue(navigator, "//xhtml:tr[6]/xhtml:td[4]/docset:_10000[1]/text()[1]", manager, CheckSumWithDot);
                xDictionary.RateAge55 = GetValue(navigator, "//xhtml:td[5]/docset:_10000[1]/text()[1]", manager, CheckSumWithDot);
                xDictionary.IsWellnessBenefitCostIncluded = GetValue(navigator, "//xhtml:tr[16]/xhtml:td[2]/docset:Included[1]",manager);
                xDictionary.RateGuarantee = GetValue(navigator,"//nonExistentElement", manager);
                return xDictionary;
            }
        }

        private static string GetValue(XPathNavigator navigator, string xpath, XmlNamespaceManager manager,string pattern = "")
        {
            var selectedNode = navigator.SelectSingleNode(xpath, manager);
            if (selectedNode != null && !String.IsNullOrEmpty(pattern))
            {
                string value = selectedNode.Value;

                Match match = Regex.Match(value, pattern);
                if (match.Success)
                {
                    return match.Value;
                }
            }

            return navigator.SelectSingleNode(xpath, manager)?.Value ?? "NOT_FOUND";
        }

        public void SerializeObjectToXml(List<XDictionary> list, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<XDictionary>));

            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, list);
            }
        }
    }
}
