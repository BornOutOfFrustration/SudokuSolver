using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SudokuSolver.SudokuBoard {
    public class BoardEntity {
        public BoardEntity() {
            List<RowEntity> list = new List<RowEntity>();          
            
            for (int i = 0; i < 9; i++) {
                list.Add(new RowEntity());
            }

            Rows = new ReadOnlyCollection<RowEntity>(list);
        }


        public ReadOnlyCollection<RowEntity> Rows { get; }
        //        public ReadOnlyCollection<NineSetEntity> Columns { get; } 
        //        public ReadOnlyCollection<NineSetEntity> Rows { get; }
        //        public ReadOnlyCollection<NineSetEntity> Squares { get; } = new ReadOnlyCollection<NineSetEntity>(
        //            new List<NineSetEntity>() {
        //                new NineSetEntity(), new NineSetEntity(), new NineSetEntity(),
        //                new NineSetEntity(), new NineSetEntity(), new NineSetEntity(),
        //                new NineSetEntity(), new NineSetEntity(), new NineSetEntity() });
    }

    public class RowEntity {

    }
}
