using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver {
    class Field {
        public List<int> PossibleNumbers { get; } = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public int RowNumber { get; }
        public int ColumnNumber { get; }
        public int CellNumber { get { return RowNumber* ColumnNumber +RowNumber; } }
    }
}
