using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using SpecFlow1.Models;

namespace SpecFlow1.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0) {
            Calculator.numbers.Add(p0);
        }

        [When(@"I press (.*)")]
        public void WhenIPress(string butonApasat) {
            Calculator.operația = butonApasat;
            calculeaza();
        }

        private void calculeaza() {
            int rezultat = Calculator.numbers[0];
            for (int i=1; i<Calculator.numbers.Count; i++) {
                int item = Calculator.numbers[i];
                if (Calculator.operația == "add")
                    rezultat += item;
                else if (Calculator.operația == "minus")
                    rezultat -= item;
                else
                    throw new NotSupportedException();
            }
            ScenarioContext.Current["rezultat"] = rezultat;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0) {
            int rezultat = int.Parse(ScenarioContext.Current["rezultat"].ToString());
            Assert.AreEqual(rezultat, p0, "Operația \"" + Calculator.operația + "\" nu a reușit.");
        }

        [AfterScenario]
        public void AfterScenario() {
            Calculator.numbers.Clear();
        }
    }
}