using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.SudokuBoard {
    class FieldEntity {
        public List<int> PossibleNumbers { get; } = new PossibleNumbersEntity().Numbers;
    }
}
