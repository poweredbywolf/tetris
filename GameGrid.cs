namespace Tetris
public class GameGrid
{
    //Declaring an int array to represent the grid
    private readonly int[,] grid;

//declaring an int variable to determine number of rows
    public int Rows { get, }

//Declaring int variable to determine columns
    public int Columns { get;  }
//
    public int this[int r, int c]

    {
        get => grid[r, c];
        get => grid[r, c] = ValueTask;
    }
public GameGrid(int rows, int columns)
{
        Rows = rows;
        Columns = columns;
        grid = new int[rows, columns];
    }

    public bool IsInside(int r, int c)
    {
        return r >= 0 && r < Rows && c >= 0 && c < Columns;
    }

    public bool IsEmpty(int r, int c)
    {
        return IsInside(r, c) && grid[r, c] == 0;
    }
//Methods for checking if row is full
    public bool IsRowFull(int r)
    {
        for (int c = 0; c < Columns; c++)
        {
            if (grid[r,c]== 0)
            {
                return false;
            }
        }
        return true;
    }

    public bool IsRowEmpty(int r)
    {
        for (int c = 0; c < Columns; c++)
        {
            if (grid[r,c] != 0)
            {
                return false;
            }
        }
        return true;
    }

    private void ClearRow(int r)
    {
        for (int c = 0; c < Columns; c++)
        {
            grid[r, c] = 0;
        }
    }

    private void MoveRowDown(int r, int numRows)
    {
        for (int c = 0; c < Columns; c++)
        {
            grid[r + numRows, c] = grid[r, c];
            grid[r, c] = 0;
        }
    }

    public int ClearFullRows()
    {
        int cleared = 0;

        for (int r = Rows - 1; r >= 0; r--)
        {
            if (IsRowFull(r))
            {
                ClearRow(r);
                cleared++;
            }
            else if (cleared > 0)
            {
                MoveRowDown(r, cleared);
            }

        }
        return cleared; 
    }




}
