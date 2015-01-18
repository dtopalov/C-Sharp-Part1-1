using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int currentBulls = 0;
        int currentCows = 0;
        int[] digits = new int[4];
        int[] guess = new int[4];

        string guessNumber = "";
        string guessNumber3 = "";
        string guessNumber2 = "";
        string guessNumber1 = "";
        bool output = false;

        for (int i = 1; i < 10; i++)
        {
            guessNumber1 += i;
            for (int j = 1; j < 10; j++)
            {
                guessNumber2 = guessNumber1 + j;
                for (int k = 1; k < 10; k++)
                {
                    guessNumber3 = guessNumber2 + k;
                    for (int l = 1; l < 10; l++)
                    {
                        guessNumber = guessNumber3 + l;
                        currentBulls = 0;
                        currentCows = 0;
                        for (int z = 0; z < 4; z++)
                        {
                            digits[z] = int.Parse(input[z].ToString());
                        }
                        for (int z = 0; z < 4; z++)
                        {
                            guess[z] = int.Parse(guessNumber[z].ToString());
                        }
                        for (int m = 0; m < 4; m++)
                        {
                            if (digits[m] == guess[m])
                            {
                                currentBulls++;
                                digits[m] = 0;
                                guess[m] = 0;
                            }
                        }

                        for (int m = 0; m < 4; m++)
                        {
                            for (int n = 0; n < 4; n++)
                            {
                                if (guess[n] == digits[m] && guess[n] != 0)
                                {
                                    currentCows++;
                                    digits[m] = 0;
                                    guess[n] = 0;
                                }
                            }                       
                        }
                        
                        if (currentBulls == b && currentCows == c)
                        {
                            output = true;
                            Console.Write(guessNumber + " ");
                        }
                        guessNumber = guessNumber3;
                    }
                    guessNumber3 = guessNumber2;
                }
                guessNumber2 = guessNumber1;
            }
            guessNumber1 = "";
        }
        if (output == false)
        {
            Console.WriteLine("No");
        }
    }
}
