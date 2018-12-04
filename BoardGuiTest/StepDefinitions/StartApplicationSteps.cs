namespace BoardGuiTest.StepDefinitions
{
    using BoardGuiTest.Helpers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;


    [Binding]
    public class StartApplicationSteps
    {
        private SudokuAppHelper SudokuAppHelper { get; } = new SudokuAppHelper();

        [When(@"I start the application")]
        public void WhenIStartTheApplication()
        {
            this.SudokuAppHelper.ApplicationStarted();
        }

        [Then(@"the screen should show a new sudoku field")]
        public void ThenTheScreenShouldShowANewSudokuField()
        {
            // ScenarioContext.Current.Pending();
        }

        [After]
        public void StopApplication()
        {
            Assert.IsTrue(this.SudokuAppHelper.ApplicationStopped());
        }
    }
}
