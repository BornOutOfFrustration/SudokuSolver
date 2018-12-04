using System;
namespace BoardGuiTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.IO;
    using TechTalk.SpecFlow;
    using TestStack.White;

    [TestClass]
    public class ApplicationUnderTest
    {
        internal bool StartApp()
        {
            try
            {
                if (this.AppUnderTest != null && !this.AppUnderTest.HasExited)
                {
                    return true;
                }
            }
            catch
            {
                
            }

            //var testContext2 = ScenarioContext.Current.ScenarioContainer.Resolve<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>();
            //Context = testContext2;

            var applicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var applicationPath = Path.Combine(applicationDirectory, @"..\..\..\WpfSudokuViewer\bin\Debug\WpfSudokuViewer.exe");

            this.AppUnderTest = Application.Launch(applicationPath);

            var bogus = this.AppUnderTest.HasExited;

            if (this.AppUnderTest.HasExited)
            {
                throw new ApplicationHasExittedAtLaunch($"The application has exitted right after launch.{Environment.NewLine}{applicationPath}");
            }
        }

        internal Application AppUnderTest {
            get;
            private set;
        }

        internal bool CloseApp()
        {
            try
            {
                // If the app has closed because of "external" reason (crash?), HasExited is true.
                if (this.AppUnderTest != null && this.AppUnderTest.HasExited)
                {
                    this.AppUnderTest = null;
                    return false;
                }
            }
            catch
            {
                // If AppUnderTest.Close() is called before, an exception is thrown.
                return false;
            }

            this.AppUnderTest.Close();
            this.AppUnderTest.Dispose();
            this.AppUnderTest = null;
            return true;
        }
    }

    public class ApplicationHasExittedAtLaunch : Exception
    {
        public ApplicationHasExittedAtLaunch(string message) : base(message)
        {
        }
    }
}
