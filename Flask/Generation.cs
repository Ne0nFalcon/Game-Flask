using System;

namespace Flask
{
    class Generation
    {
        public string[,,] GenerationShaffle(string [,,] LevelTaskMain, int difficultyLevel)
        {
            Random random = new Random();
            int check = 0;

            for (int i = difficultyLevel; i >= 1; i--)
            {
                for (int j = 3; j >= 1; j--)
                {
                    int x = random.Next(i + 1); 
                    int t = random.Next(j + 1);

                    var tempColor = LevelTaskMain[x, t, 0];
                    var tempImage = LevelTaskMain[x, t, 1];

                    LevelTaskMain[x, t, 0] = LevelTaskMain[i, j, 0];
                    LevelTaskMain[x, t, 1] = LevelTaskMain[i, j, 1];

                    LevelTaskMain[i, j, 0] = tempColor;
                    LevelTaskMain[i, j, 1] = tempImage;
                }
                check++;
            }
            for (int i = check + 1; i <= 10; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    LevelTaskMain[i, j, 0] = "Transparent";
                    LevelTaskMain[i, j, 1] = "";
                }
            }
            return LevelTaskMain;
        }
    }
}
