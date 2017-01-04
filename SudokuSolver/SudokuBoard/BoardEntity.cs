using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SudokuSolver.SudokuBoard {
    public class BoardEntity {
        public BoardEntity() {
            // Create all fields for this board (81 fields)
            var fieldList = new List<FieldEntity>();
            int fieldIndex = 0;
            while(fieldIndex < 81) {
                FieldEntity field = new FieldEntity();
                fieldList.Add(field);
                fieldIndex++;
            }

            var listRows = new List<NineSetEntity>();
            int rowIndex = 0;
            while(rowIndex < 9) {
                FieldEntity[] fieldsForRow = new FieldEntity[9];
                Array.Copy(fieldList.ToArray(), rowIndex * 9, fieldsForRow, 0, 9);
                var row = new NineSetEntity(fieldsForRow);
                listRows.Add(row);
                rowIndex++;
            }

            Rows = new ReadOnlyCollection<NineSetEntity>(listRows);

            var listColumns = new List<NineSetEntity>();
            int columnIndex = 0;
            while (columnIndex < 9) {
                FieldEntity[] fieldsForColumn = new FieldEntity[9];

                int columnFieldIndex = 0;
                while (columnFieldIndex < 9) {
                    fieldsForColumn[columnFieldIndex] = fieldList[columnIndex + (columnFieldIndex * 9)];
                    columnFieldIndex++;
                }
                
                var column = new NineSetEntity(fieldsForColumn);
                listColumns.Add(column);
                columnIndex++;
            }

            Columns = new ReadOnlyCollection<NineSetEntity>(listColumns);

            var listRegions = new List<NineSetEntity>();

            // region 1..3
            for (int x = 0; x < 3; x++) {
                var listRegion = new List<FieldEntity>();
                for (int y = 0; y < 3; y++) {
                    for (int z = 0; z < 3; z++) {
                        FieldEntity fe = fieldList[y * 9 + (x * 3 + z)];
                        listRegion.Add(fe);
                    }
                }
                listRegions.Add(new NineSetEntity(listRegion.ToArray()));
            }

            // region 4..6
            for (int xx = 0; xx < 3; xx++) {
                var listRegion = new List<FieldEntity>();
                for (int yy = 0; yy < 3; yy++) {
                    for (int zz = 0; zz < 3; zz++) {
                        FieldEntity fe = fieldList[(yy + 3) * 9 + (xx * 3 + zz)];
                        listRegion.Add(fe);
                    }
                }
                listRegions.Add(new NineSetEntity(listRegion.ToArray()));
            }

            // region 7..9
            for (int xxx = 0; xxx < 3; xxx++) {
                var listRegion = new List<FieldEntity>();
                for (int yyy = 0; yyy < 3; yyy++) {
                    for (int zzz = 0; zzz < 3; zzz++) {
                        FieldEntity fe = fieldList[(yyy + 6) * 9 + (xxx * 3 + zzz)];
                        listRegion.Add(fe);
                    }
                }
                listRegions.Add(new NineSetEntity(listRegion.ToArray()));
            }
            Regions = new ReadOnlyCollection<NineSetEntity>(listRegions);
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
