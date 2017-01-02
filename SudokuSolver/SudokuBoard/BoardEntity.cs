using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SudokuSolver.SudokuBoard {
    public class BoardEntity {
        public BoardEntity() {
            var list1 = new List<NineSetEntity>();
            var list2 = new List<NineSetEntity>();
            var list3 = new List<NineSetEntity>();

            for (int i = 0; i < 9; i++) {
                list1.Add(new NineSetEntity());
                list2.Add(new NineSetEntity());
                list3.Add(new NineSetEntity());
            }

            Rows = new ReadOnlyCollection<NineSetEntity>(list1);
            Columns = new ReadOnlyCollection<NineSetEntity>(list2);
            Regions = new ReadOnlyCollection<NineSetEntity>(list3);
        }


        public ReadOnlyCollection<NineSetEntity> Rows { get; }
        public ReadOnlyCollection<NineSetEntity> Columns { get; }
        public ReadOnlyCollection<NineSetEntity> Regions { get; }
        //        public ReadOnlyCollection<NineSetEntity> Columns { get; } 
        //        public ReadOnlyCollection<NineSetEntity> Rows { get; }
        //        public ReadOnlyCollection<NineSetEntity> Squares { get; } = new ReadOnlyCollection<NineSetEntity>(
        //            new List<NineSetEntity>() {
        //                new NineSetEntity(), new NineSetEntity(), new NineSetEntity(),
        //                new NineSetEntity(), new NineSetEntity(), new NineSetEntity(),
        //                new NineSetEntity(), new NineSetEntity(), new NineSetEntity() });
    }
}
