public class Solution 
{
    public bool IsValidSudoku(char[][] board) 
    {
        // HashSets declared and initialized.
        HashSet<int>[] hashRows     = new HashSet<int>[9];
        HashSet<int>[] hashCols     = new HashSet<int>[9];
        HashSet<int>[] hashBoxes    = new HashSet<int>[9];

        for(int i = 0; i < 9; i++)
        {
            hashRows[i]     = new HashSet<int>();
            hashCols[i]     = new HashSet<int>();
            hashBoxes[i]    = new HashSet<int>();
        }

        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[i].Length; j++)
            {
                if(board[i][j] == '.')
                    continue;
                int n = (int) char.GetNumericValue(board[i][j]);
                
                // Calculate which hashBox number should go into
                int hBox = 0;
                if(3 <= i && i < 6)
                    hBox += 3;
                else if(6 <= i && i < 9)
                    hBox += 6;
                if(3 <= j && j < 6)
                    hBox += 1;
                else if(6 <= j && j < 9)
                    hBox += 2;
                
                // Check if number has already appeared in this row/col/box
                if(hashRows[i].Contains(n))
                    return false;
                else if(hashCols[j].Contains(n))
                    return false;
                else if(hashBoxes[hBox].Contains(n))
                    return false;

                // Add ints to corresponding HashSet
                hashRows[i].Add(n);
                hashCols[j].Add(n);
                hashBoxes[hBox].Add(n);
            }
        }
        
        return true;
    }
}
