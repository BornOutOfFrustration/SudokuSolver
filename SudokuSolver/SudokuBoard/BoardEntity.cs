using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SudokuSolver.SudokuBoard {
    class BoardEntity {
        public ReadOnlyCollection<NineSetEntity> Columns { get; } = new ReadOnlyCollection<NineSetEntity>(
            new List<NineSetEntity>() {
                new NineSetEntity(), new NineSetEntity(), new NineSetEntity(),
                new NineSetEntity(), new NineSetEntity(), new NineSetEntity(),
                new NineSetEntity(), new NineSetEntity(), new NineSetEntity() });
        public ReadOnlyCollection<NineSetEntity> Rows { get; } = new ReadOnlyCollection<NineSetEntity>(
            new List<NineSetEntity>() {
                new NineSetEntity(), new NineSetEntity(), new NineSetEntity(),
                new NineSetEntity(), new NineSetEntity(), new NineSetEntity(),
                new NineSetEntity(), new NineSetEntity(), new NineSetEntity() });
        public ReadOnlyCollection<NineSetEntity> Squares { get; } = new ReadOnlyCollection<NineSetEntity>(
            new List<NineSetEntity>() {
                new NineSetEntity(), new NineSetEntity(), new NineSetEntity(),
                new NineSetEntity(), new NineSetEntity(), new NineSetEntity(),
                new NineSetEntity(), new NineSetEntity(), new NineSetEntity() });
    }
}
