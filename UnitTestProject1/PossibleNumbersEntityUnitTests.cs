using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1 {
    [TestClass]
    public class PossibleNumbersEntityUnitTests {
        [TestMethod]
        public void Test_Create_Sudoku_Board() {
            SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
            SudokuSolver.SudokuBoard.RowEntity row1 = board.Rows[0];
            SudokuSolver.SudokuBoard.RowEntity row2 = board.Rows[1];
            SudokuSolver.SudokuBoard.RowEntity row3 = board.Rows[2];
            SudokuSolver.SudokuBoard.RowEntity row4 = board.Rows[3];
            SudokuSolver.SudokuBoard.RowEntity row5 = board.Rows[4];
            SudokuSolver.SudokuBoard.RowEntity row6 = board.Rows[5];
            SudokuSolver.SudokuBoard.RowEntity row7 = board.Rows[6];
            SudokuSolver.SudokuBoard.RowEntity row8 = board.Rows[7];
            SudokuSolver.SudokuBoard.RowEntity row9 = board.Rows[8];
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Test_SudokuBoardRow_LowerBoundaries_ShouldThrowError() {
            SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
            SudokuSolver.SudokuBoard.RowEntity row = board.Rows[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Test_SudokuBoardRow_UpperBoundaries_ShouldThrowError() {
            SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
            SudokuSolver.SudokuBoard.RowEntity row = board.Rows[9];
        }

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void Test_SudokuBoardRows_SwitchRowsInBoard_ShouldThrowError() {
        //    SudokuSolver.SudokuBoard.BoardEntity board = new SudokuSolver.SudokuBoard.BoardEntity();
        //    board.Rows[6] = board.Rows[0];
        //}

    }
}
