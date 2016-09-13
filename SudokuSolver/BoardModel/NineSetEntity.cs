using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SudokuSolver.BoardModel {
    class NineSetEntity {
        public ReadOnlyCollection<FieldEntity> Fields { get; } = new ReadOnlyCollection<FieldEntity>(
            new List<FieldEntity>() {
                new FieldEntity(), new FieldEntity(), new FieldEntity(),
                new FieldEntity(), new FieldEntity(), new FieldEntity(),
                new FieldEntity(), new FieldEntity(), new FieldEntity() });
        public PossibleNumbersEntity PossibleNumbers { get; } = new PossibleNumbersEntity();
    }
}
