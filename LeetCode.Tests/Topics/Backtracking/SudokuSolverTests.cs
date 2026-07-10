namespace LeetCode.Tests;

[TestFixture]
[Category("Backtracking")]
public class SudokuSolverTests
{
    [Test]
    public void SolveSudoku_ClassicPuzzle()
    {
        char[][] board = [
            ['5', '3', '.', '.', '7', '.', '.', '.', '.'],
            ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
            ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
            ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
            ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
            ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
            ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
            ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9']
        ];
        SudokuSolver.SolveSudoku(board);
        Assert.That(board[0][2], Is.EqualTo('4'));
        Assert.That(board[8][8], Is.EqualTo('9'));
    }
}
