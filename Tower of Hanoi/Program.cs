﻿namespace Tower_of_Hanoi
{
    internal class Program
    {
        static void towerOfHanoi(int n, char from_rod,
                             char to_rod, char aux_rod)
        {
            if (n == 0)
            {
                return;
            }
            towerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
            Console.WriteLine("Move disk " + n + " from rod "
                              + from_rod + " to rod " + to_rod);
            towerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
        }

        //  Driver method 
        public static void Main(String[] args)
        {
            int N = 3;

            // A, B and C are names of rods 
            towerOfHanoi(N, 'A', 'C', 'B');
        }
    }
}

