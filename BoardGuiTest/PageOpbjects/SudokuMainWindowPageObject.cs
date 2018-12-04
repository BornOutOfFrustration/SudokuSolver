using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGuiTest.PageOpbjects
{
    public class SudokuMainWindowPageObject
    {
        private readonly ApplicationUnderTest Appl = new ApplicationUnderTest();

        public void Start()
        {
            this.Appl.StartApp();
        }

        public bool Stop()
        {
            return this.Appl.CloseApp();
        }
    }
}
