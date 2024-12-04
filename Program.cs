/*
You have a long flowerbed in which some of the plots are planted
and some are not. However, flowers cannot be planted in adjacent
plots. 
Given an integer array flowerbed containing 0j's and 1's, where 0
is empty and 1 is not empty, and the integer n, return true if n new flowers
can be planted in the flowerbed without violating the no adjacent flowersr
rule and false otherwise.
*/

//arrray.compare?
//bool
//i++
//count - two seperate loops w/ || to seperate compares
//loop1 to count spots
//loop 2 to plant and verify if true

namespace Assignment_5._3_Question_1
{
    public class Garden
    {
        public bool Flowers(int[] Bed, int n)
        {
            int count = 0;
            int length = Bed.Length;

            for (int i = 0; i < length; i++)
            {
                if (Bed[i] == 0)
                {
                    //check bedspace
                    bool prevEmpty = (i == 0 || Bed[i - 1] == 0); 
                    bool nextEmpty = (i == length - 1 || Bed[i + 1] == 0);
                    //make stack and peek somehow?

                    if (prevEmpty && nextEmpty)
                    {
                        Bed[i] = 1;  
                        count++;

                        if (count >= n)
                        {
                            return true;
                        }
                        //if
                    }
                }
            }
            return count >= n;
        }
    }

    class Program
    {
        static void Main()
        {
            //input, hardcode?
            //Console.WriteLine("Please enter the size of the flowerbed: ");
            //string input = Console.ReadLine();
            //int[] flowerbed = input.Split(' ').Select(int.Parse).ToArray();
            //space out user input?

            int[] flowerbed = { 1, 0, 0, 0, 1, 0, 1, 0 };
            Console.WriteLine($"Given the example array of {flowerbed}. ");
            Console.WriteLine("");

            //convoluted
            Console.WriteLine("Please enter how many flowers to plant: ");
            int n = int.Parse(Console.ReadLine());

            Garden garden = new Garden();

            bool result = garden.Flowers(flowerbed, n);

            if (result)
            {
                Console.WriteLine($"Yup, you've got the space for {n} flowers.");
            }
            else
            {
                Console.WriteLine($"Nope, not enough space for {n} more flowers.");
            }
        }
    }
}
