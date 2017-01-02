//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.ObjectModel;

//namespace SudokuSolver.SudokuBoard {
//    class NineSetEntity {
//        public ReadOnlyCollection<FieldEntity> Fields { get; } = new ReadOnlyCollection<FieldEntity>(
//            new List<FieldEntity>() {
//                new FieldEntity(), new FieldEntity(), new FieldEntity(),
//                new FieldEntity(), new FieldEntity(), new FieldEntity(),
//                new FieldEntity(), new FieldEntity(), new FieldEntity() });

//        public IEnumerable<int> PossibleNumbers {
//            get {
//                List<int> allNumbers = new List<int>();
//                allNumbers.AddRange(Fields[0].PossibleNumbers);
//                allNumbers.AddRange(Fields[1].PossibleNumbers);
//                allNumbers.AddRange(Fields[2].PossibleNumbers);
//                allNumbers.AddRange(Fields[3].PossibleNumbers);
//                allNumbers.AddRange(Fields[4].PossibleNumbers);
//                allNumbers.AddRange(Fields[5].PossibleNumbers);
//                allNumbers.AddRange(Fields[6].PossibleNumbers);
//                allNumbers.AddRange(Fields[7].PossibleNumbers);
//                allNumbers.AddRange(Fields[8].PossibleNumbers);
//                HashSet<int> uniqueNumbers = new HashSet<int>(allNumbers);
//                return uniqueNumbers.AsEnumerable<int>();
//            }
//        }
//    }
//}
