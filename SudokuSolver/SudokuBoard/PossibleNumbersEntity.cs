using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.SudokuBoard {
    class PossibleNumbersEntity {
        public PossibleNumbersEntity(IEnumerable<int> numbers) {
            this.Numbers.Clear();
            this.Numbers.AddRange(numbers);
        }
        public PossibleNumbersEntity() : this(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }) {
        }

        public List<int> Numbers { get; } = new List<int>();
    }
}
