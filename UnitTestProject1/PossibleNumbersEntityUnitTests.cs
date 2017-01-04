using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1 {
    [TestClass]
    public class PossibleNumbersEntityUnitTests {
        [TestMethod]
        public void Test_Create_Sudoku_Board() {
            SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
        }

        [TestMethod]
        public void Test_SudokuBoard_Check_Sets() {
            // Arrange
            var board = new SudokuSolver.SudokuBoard.BoardEntity();

            for (int i = 0; i < 9; i++) {
                // Act (Assert is an exception if not created.
                var row = board.Rows[i];
                var col = board.Columns[i];
                var reg = board.Regions[i];

                // Assert
                Assert.IsInstanceOfType(row, typeof(SudokuSolver.SudokuBoard.NineSetEntity));
                Assert.IsInstanceOfType(col, typeof(SudokuSolver.SudokuBoard.NineSetEntity));
                Assert.IsInstanceOfType(reg, typeof(SudokuSolver.SudokuBoard.NineSetEntity));
            }
        }

        [TestMethod]
        public void Test_SudokuBoard_AllFields_AreUnique() {
            var board = new SudokuSolver.SudokuBoard.BoardEntity();

            // Fields [0..9] in row 0 must be the same as fields[0] in col [0..9]
            // Fields [0..9] in row 1 must be the same as fields[1] in col [0..9]
            // ...
            // Fields [0..9] in row 8 must be the same as fields[8] in col [0..9]

            for (int rowIndex1 = 0; rowIndex1 < 9; rowIndex1++) {
                for (int fieldIndex1 = 0; fieldIndex1 < 9; fieldIndex1++) {
                    var field1 = board.Rows[rowIndex1].Fields[fieldIndex1];
                    for (int rowIndex2 = 0; rowIndex2 < 9; rowIndex2++) {
                        for (int fieldIndex2 = 0; fieldIndex2 < 9; fieldIndex2++) {
                            if (rowIndex1 == rowIndex2 && fieldIndex1 == fieldIndex2) {
                                continue;
                            }
                            var field2 = board.Rows[rowIndex2].Fields[fieldIndex2];
                            Assert.AreNotSame(field1, field2);
                        }
                    }
                }
            }
        }

        [TestMethod]
        public void Test_SudokuBoard_FieldsInRowsCols_AreSame() {
            var board = new SudokuSolver.SudokuBoard.BoardEntity();

            // Fields [0..9] in row 0 must be the same as fields[0] in col [0..9]
            // Fields [0..9] in row 1 must be the same as fields[1] in col [0..9]
            // ...
            // Fields [0..9] in row 8 must be the same as fields[8] in col [0..9]

            for (int index1 = 0; index1 < 9; index1++) {
                for (int index2 = 0; index2 < 9; index2++) {
                    var fieldA = board.Rows[index1].Fields[index2];
                    var fieldB = board.Columns[index2].Fields[index1];
                    Assert.AreSame(fieldA, fieldB);
                }
            }
        }
        [TestMethod]
        public void Test_SudokuBoard_FieldsInRowsRegions_AreSame() {
            var board = new SudokuSolver.SudokuBoard.BoardEntity();
            // Field 0, 1, 2 in region 0 must be the same as field 0, 1, 2 in row 0
            // Field 0, 1, 2 in region 1 must be the same as field 3, 4, 5 in row 0
            // Field 0, 1, 2 in region 2 must be the same as field 6, 7, 8 in row 0

            // Field 3, 4, 5 in region 0 must be the same as field 0, 1, 2 in row 1
            // Field 3, 4, 5 in region 1 must be the same as field 3, 4, 5 in row 1
            // Field 3, 4, 5 in region 2 must be the same as field 6, 7, 8 in row 1

            // Field 6, 7, 8 in region 0 must be the same as field 0, 1, 2 in row 2
            // Field 6, 7, 8 in region 1 must be the same as field 3, 4, 5 in row 2
            // Field 6, 7, 8 in region 2 must be the same as field 6, 7, 8 in row 2

            // Field 0, 1, 2 in region 3 must be the same as field 0, 1, 2 in row 3
            // Field 0, 1, 2 in region 4 must be the same as field 3, 4, 5 in row 3
            // Field 0, 1, 2 in region 5 must be the same as field 6, 7, 8 in row 3

            // Field 3, 4, 5 in region 3 must be the same as field 0, 1, 2 in row 4
            // Field 3, 4, 5 in region 4 must be the same as field 3, 4, 5 in row 4
            // Field 3, 4, 5 in region 5 must be the same as field 6, 7, 8 in row 4

            // Field 6, 7, 8 in region 3 must be the same as field 0, 1, 2 in row 5
            // Field 6, 7, 8 in region 4 must be the same as field 3, 4, 5 in row 5
            // Field 6, 7, 8 in region 5 must be the same as field 6, 7, 8 in row 5
            // etc.
            for (int rowIndex = 0; rowIndex < 9; rowIndex++) {
                int regionIndexBase = (rowIndex / 3) * 3; // 0, 0, 0, 3, 3, 3, 6, 6, 6

                for (int regionIndex = regionIndexBase; regionIndex < regionIndexBase + 3; regionIndex++) {
                    // region 0, 3, 6 : 0, 1, 2
                    // region 1, 4, 7 : 3, 4, 5
                    // region 2, 5, 8 : 6, 7, 8
                    int rowFieldIndex1;
                    int rowFieldIndex2;
                    int rowFieldIndex3;
                    if (regionIndex == 0 || regionIndex == 3 || regionIndex == 6) {
                        rowFieldIndex1 = 0;
                        rowFieldIndex2 = 1;
                        rowFieldIndex3 = 2;
                    } else if (regionIndex == 1 || regionIndex == 4 || regionIndex == 7) {
                        rowFieldIndex1 = 3;
                        rowFieldIndex2 = 4;
                        rowFieldIndex3 = 5;
                    } else {
                        rowFieldIndex1 = 6;
                        rowFieldIndex2 = 7;
                        rowFieldIndex3 = 8;
                    }

                    int regionFieldIndex1;
                    int regionFieldIndex2;
                    int regionFieldIndex3;
                    if (rowIndex == 0 || rowIndex == 3 || rowIndex == 6) {
                        regionFieldIndex1 = 0;
                        regionFieldIndex2 = 1;
                        regionFieldIndex3 = 2;
                    } else if (rowIndex == 1 || rowIndex == 4 || rowIndex == 7) {
                        regionFieldIndex1 = 3;
                        regionFieldIndex2 = 4;
                        regionFieldIndex3 = 5;
                    } else {
                        regionFieldIndex1 = 6;
                        regionFieldIndex2 = 7;
                        regionFieldIndex3 = 8;
                    }


                    Assert.AreSame(board.Rows[rowIndex].Fields[rowFieldIndex1], board.Regions[regionIndex].Fields[regionFieldIndex1]);
                    Assert.AreSame(board.Rows[rowIndex].Fields[rowFieldIndex2], board.Regions[regionIndex].Fields[regionFieldIndex2]);
                    Assert.AreSame(board.Rows[rowIndex].Fields[rowFieldIndex3], board.Regions[regionIndex].Fields[regionFieldIndex3]);
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Test_SudokuBoardRow_LowerBoundaries_ShouldThrowError() {
            SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
            SudokuSolver.SudokuBoard.NineSetEntity row = board.Rows[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Test_SudokuBoardRow_UpperBoundaries_ShouldThrowError() {
            SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
            SudokuSolver.SudokuBoard.NineSetEntity row = board.Rows[9];
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Test_SudokuBoardColumn_LowerBoundaries_ShouldThrowError() {
            SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
            SudokuSolver.SudokuBoard.NineSetEntity column = board.Columns[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Test_SudokuBoardColumn_UpperBoundaries_ShouldThrowError() {
            SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
            SudokuSolver.SudokuBoard.NineSetEntity row = board.Columns[9];
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Test_SudokuBoardRegion_LowerBoundaries_ShouldThrowError() {
            SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
            SudokuSolver.SudokuBoard.NineSetEntity region = board.Regions[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Test_SudokuBoardRegion_UpperBoundaries_ShouldThrowError() {
            SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
            SudokuSolver.SudokuBoard.NineSetEntity region = board.Regions[9];
        }
        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void Test_SudokuBoardRows_SwitchRowsInBoard_ShouldThrowError() {
        //    SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
        //    board.Rows[6] = board.Rows[0];
        //}

    }
}
