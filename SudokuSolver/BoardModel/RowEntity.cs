﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.BoardModel {
    class RowEntity : NineSetEntity {
        public PossibleNumbersEntity PossibleNumbers { get; } = new PossibleNumbersEntity();
    }
}
