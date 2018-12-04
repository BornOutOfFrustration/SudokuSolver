using BoardGuiTest.PageOpbjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGuiTest.Helpers
{
    public class SudokuAppHelper
    {
        private readonly SudokuMainWindowPageObject MainWindowPageObject = new SudokuMainWindowPageObject();

        public bool ApplicationStarted()
        {
            this.MainWindowPageObject.Start();
            return true;
        }

        public bool ApplicationStopped()
        {
            return this.MainWindowPageObject.Stop();
        }
    }
}
