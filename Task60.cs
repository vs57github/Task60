using System;

namespace ThreeDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[2, 2, 2];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)  // Заполняем массив рандомными двузначными числами.
            {
                for (int j = 0; j < array.GetLength(1); j++)  // Для того, чтобы не было повторений, используем do-while.
                {
                    for (int k = 0; k < array.GetLength(2); k++)   // Выходим из цикла, когда элементу присвоено уникальное число.
                    {                        
                        do   // do-while - цикл, который выполняется хотя-бы 1 раз.                        
                        {                            
                            array[i, j, k] = random.Next(10, 100);                            
                        } 
                        while (IsNumberUnique(array[i, j, k], array));   // IsNumberUnique - bool-метод, который проверяет, уникальное-ли число.                        

                    }                    

                }                

            }

            Console.WriteLine("3D Array:");

            for (int i = 0; i < array.GetLength(0); i++)   // 3D Array: - 3-мерный массив.             
            {                                              // [i][j][k] - [0][0][0], [0][0][1], [0][1][0], [0][1][1], [1][0][0], [1][0][1], [1][1][0], [1][1][1].              

                for (int j = 0; j < array.GetLength(1); j++)   // Elements: - 8-кратный foreach-цикл:              

                    for (int k = 0; k < array.GetLength(2); k++)   // foreach ([i],[j],[k]) in ([2],[2],[2])                  

                        Console.WriteLine($"Element with index ({i},{j},{k}) is {array[i,j,k]}");                 

            }            

        }        

        static bool IsNumberUnique(int numberToCheck , int[,,] array)   // bool-метод IsNumberUnique() - true/false:         
        {            

            foreach (var item in array)             // foreach ([item]) in ([array])             

                if (item == numberToCheck)           // if ([item] == numberToCheck)                 

                    return false;                   // return false                 

            return true;                           // else return true             

        }        

    }    
}