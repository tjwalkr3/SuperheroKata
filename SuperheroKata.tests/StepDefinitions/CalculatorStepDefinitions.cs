using SuperheroKata.Console;
using Shouldly;
namespace SuperheroKata.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions(ScenarioContext context)
    {
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef

        [Given("I have a Calculator")]
        public void GivenIHaveACalculator()
        {
            var calc = new SuperMegaAwesomeCalculator();
            context.Set(calc);
        }

        [Given("the first number is {int}")]
        [Given("the next number is {int}")]

        public void GivenTheFirstNumberIs(int number)
        {
            var calculator = context.Get<SuperMegaAwesomeCalculator>();

            calculator.Numbers.Add(number);
        }


        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            var calculator = context.Get<SuperMegaAwesomeCalculator>();
            var sum = calculator.Add();
            context.Add("result", sum);
        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            context.Get<int>("result").ShouldBe(result);
        }
    }
}
