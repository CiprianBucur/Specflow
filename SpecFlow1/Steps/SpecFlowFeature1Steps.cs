using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlow1.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0) {
            ScenarioContext.Current["primulNumar"] = p0;
        }

        [Given(@"I have entered (.*) into the calculator2")]
        public void GivenIHaveEnteredIntoTheCalculator2(int p1) {
            ScenarioContext.Current["alDoileaNumar"] = p1;
        }

        [When(@"I press (.*)")]
        public void WhenIPress(string butonApasat) {
            calculeaza(butonApasat);
        }

        private void calculeaza(string butonApasat)
        {
            int p0 = int.Parse(ScenarioContext.Current["primulNumar"].ToString());
            int p1 = int.Parse(ScenarioContext.Current["alDoileaNumar"].ToString());
            if (butonApasat == "add")
                ScenarioContext.Current["rezultat"] = p0 + p1;
            else if (butonApasat == "minus")
                ScenarioContext.Current["rezultat"] = p0 - p1;
            else
                throw new NotSupportedException();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0) {
            int rezultat = int.Parse(ScenarioContext.Current["rezultat"].ToString());
            Assert.AreEqual(rezultat, p0, "Valorile nu sunt egale.");
        }
    }
}
