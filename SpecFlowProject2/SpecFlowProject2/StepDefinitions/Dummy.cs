using NUnit.Framework;

namespace SpecFlowProject2.StepDefinitions
{

    [Binding ]
    public class Dummy
    {
        private Person _person = new Person();
        private int _actualWeight;

        [Given(@"i want to go to the gym")]
        public void GivenIWantToGoToTheGym()
        {
            _person.Weight= 80;   
        }

        [When(@"wake train")]
        public void WhenWakeTrain()
        {
          _person.Train(1, _person.Weight);
        }

        [Then(@"musscle will increase to (.*) kg")]
        public void ThenMusscleWillIncreaseWithKg(int expectedWeight)
        {
            Assert.AreEqual(expectedWeight, _actualWeight);
        }

    }
}
