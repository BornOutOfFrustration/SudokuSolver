using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1 {
    [TestClass]
    public class PossibleNumbersEntityUnitTests {
        [TestMethod]
        public void Test_Create_Sudoku_Board() {
            SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
            SudokuSolver.SudokuBoard.NineSetEntity row1 = board.Rows[0];
            SudokuSolver.SudokuBoard.NineSetEntity row2 = board.Rows[1];
            SudokuSolver.SudokuBoard.NineSetEntity row3 = board.Rows[2];
            SudokuSolver.SudokuBoard.NineSetEntity row4 = board.Rows[3];
            SudokuSolver.SudokuBoard.NineSetEntity row5 = board.Rows[4];
            SudokuSolver.SudokuBoard.NineSetEntity row6 = board.Rows[5];
            SudokuSolver.SudokuBoard.NineSetEntity row7 = board.Rows[6];
            SudokuSolver.SudokuBoard.NineSetEntity row8 = board.Rows[7];
            SudokuSolver.SudokuBoard.NineSetEntity row9 = board.Rows[8];

            SudokuSolver.SudokuBoard.NineSetEntity column1 = board.Columns[0];
            SudokuSolver.SudokuBoard.NineSetEntity column2 = board.Columns[1];
            SudokuSolver.SudokuBoard.NineSetEntity column3 = board.Columns[2];
            SudokuSolver.SudokuBoard.NineSetEntity column4 = board.Columns[3];
            SudokuSolver.SudokuBoard.NineSetEntity column5 = board.Columns[4];
            SudokuSolver.SudokuBoard.NineSetEntity column6 = board.Columns[5];
            SudokuSolver.SudokuBoard.NineSetEntity column7 = board.Columns[6];
            SudokuSolver.SudokuBoard.NineSetEntity column8 = board.Columns[7];
            SudokuSolver.SudokuBoard.NineSetEntity column9 = board.Columns[8];

            SudokuSolver.SudokuBoard.NineSetEntity region1 = board.Region[1];
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

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void Test_SudokuBoardRows_SwitchRowsInBoard_ShouldThrowError() {
        //    SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
        //    board.Rows[6] = board.Rows[0];
        //}

    }
}
