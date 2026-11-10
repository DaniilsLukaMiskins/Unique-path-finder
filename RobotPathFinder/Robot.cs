namespace RobotPathFinder



//Created on 11 November 2026 by Daniils Luka Mishkins

//TASK: Find unique path numbers for robot to achieve coordinate (rows, colums)
//Robot starts at (0,0) and can only go right or down in one move. 
{
    public class Robot
    {
        private int rows { get ; set; }
        private int columns { get ; set; }

        private int uniquepaths;

        private int[,] cords; // board

        public Robot(int M, int N)
        {
            rows = M;
            columns = N;
            cords= new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    cords[i, j] = 1;
                }
            }
        }

        public int FindUniquePaths() //method for finding unique paths
        {
            for (int i = rows - 1 - 1; i >= 0; i--)
            {
                for (int j = columns - 1 - 1; j >= 0; j--)
                {
                    cords[i, j] = cords[i + 1, j] + cords[i, j + 1];
                }
            }

            uniquepaths = cords[0,0];
            return uniquepaths;
        }


    }
}
