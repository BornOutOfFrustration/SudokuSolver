using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SudokuSolver.SudokuBoard {
    public class BoardEntity {
        public BoardEntity() {
            List<RowEntity> list1 = new List<RowEntity>();          
            
            for (int i = 0; i < 9; i++) {
                list1.Add(new RowEntity());
            }

            Rows = new ReadOnlyCollection<RowEntity>(list1);

            List<ColumnEntity> list2 = new List<ColumnEntity>();

            for (int i = 0; i < 9; i++) {
                list2.Add(new ColumnEntity());
            }

            Columns = new ReadOnlyCollection<ColumnEntity>(list2);
        }


        public ReadOnlyCollection<RowEntity> Rows { get; }
        public ReadOnlyCollection<ColumnEntity> Columns { get; }
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
    public class ColumnEntity {
    }
}
