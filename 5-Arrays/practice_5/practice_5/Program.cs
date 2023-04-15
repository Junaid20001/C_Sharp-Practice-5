using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array method 1 with value declear:
            /*
            string[] ali = new string[2];
            ali[0] = "Junaid";
            ali[1] = "Khalid";
            Console.WriteLine(ali[1]);
            Console.WriteLine(ali[0]);
            */

            /*
            //Array method 2 with value declear:
            string[] khan = new string[] { "Junaid", "Khalid", "Faiz" };

            Console.WriteLine(khan[1]);
            Console.WriteLine(khan[0]);
            Console.WriteLine(khan[2]);
            Console.WriteLine(" \r");
            */

            /*
            //Array method 3 with value declear:
            string[] jawan = { "Maiz", "Talha", "KhanBaba", "Sohail"};

            Console.WriteLine(jawan[1]);
            Console.WriteLine(jawan[3]);
            Console.WriteLine(jawan[0]);
            Console.WriteLine(jawan[2]);
            */

            /*
            //Array with for loop
            string[] kasim = new string[4];

            kasim[3] = "Junaid";
            kasim[1] = "Faiz";
            kasim[2] = "Maiz";
            kasim[0] = "Khalid";

            for (int i = 0; i < kasim.Length ; i++)
            {
                Console.WriteLine(kasim[i]);
            }
            */

            /*
            //foreach loop with array

            string[] kasim = new string[4];

            kasim[3] = "Junaid";
            kasim[1] = "Faiz";
            kasim[2] = "Maiz";
            kasim[0] = "Khalid";

            foreach (string item in kasim)
            {
                Console.WriteLine(item);
            }
            */

            /*
            int[] number = new int[4];

            number[3] = 5;
            number[1] = 8;
            number[2] = 2;
            number[0] = 9;        //always print by the first index number

            foreach (int item in number)
            {
                Console.WriteLine(item);
            }
            */
            /*
            //Two Diminsional Array
            int[,] twoD_array = new int[3, 4]
            {
                {12,44,65,23 },       //both row & column start from 0 index.. like 2 index row index is 6 & 3 index of column is 23,35,74
                {55,98,100,35 },
                {6, 37, 48, 74 }
            };
            Console.WriteLine(twoD_array[2,1]);
            ///

            int[,] twoD_array = new int[3, 4]
            {
                {12,44,65,23 },       //for dimension 0 represent row and 1 represent column with .GETLength
                {55,98,100,35 },
                {6, 37, 48, 74 }
            };
            Console.WriteLine(twoD_array.GetLength(1));   
            
            //
            int[,] twoD_array = new int[3, 4]
            {
                {12,44,65,23 },       //check how many diminsions
                {55,98,100,35 },
                {6, 37, 48, 74 }
            };
            Console.WriteLine(twoD_array.Rank);
            */
            /*
            //All matrix value
            int[,] twoD_array = new int[3, 4]
            {
                {12,44,65,23 },       
                {55,98,100,35 },
                {6, 37, 48, 74 }
            };

            for (int i = 0; i < twoD_array.GetLength(0); i++)
            {
                for (int j = 0; j < twoD_array.GetLength(1); j++)
                {

                    Console.WriteLine(twoD_array[i,j]+ " ");
                }
            }
            */
            /*
            //data in matrix form
            int[,] twoD_array = new int[3, 4]
            {
                {12,44,65,23 },
                {55,98,100,35 },
                {6, 37, 48, 74 }
            };

            for (int i = 0; i < twoD_array.GetLength(0); i++)
            {
                for (int j = 0; j < twoD_array.GetLength(1); j++)
                {

                    Console.Write(twoD_array[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
            /* //Multi-Meminsional Array with for_each_loop
            int[,] twoD_array = new int[3, 4]
            {
                {12,44,65,23 },
                {55,98,100,35 },
                {6, 37, 48, 74 }
            };
             
            foreach (int item in twoD_array) 
                { 
                Console.WriteLine(item);   
            }
            */

            //forloop jagged array all value print
            /*
            int[][] junaid_array = new int[3][];
            junaid_array[0] = new[] { 11, 23, 25, 34, 50, 60, 100 };
            junaid_array[1] = new[] { 12, 25, 30, 94, 88 };
            junaid_array[2] = new[] { 9, 56, 33};

            for (int i = 0; i < junaid_array.GetLength(0); i++)
            {
                for (int j = 0; j < junaid_array[i].Length; j++)
                {
                    Console.Write(junaid_array[i][j] + " "); 
                }
                Console.WriteLine(); 
            }
            */

            //foreach loop jagged array all value print
            /*
            int[][] junaid_array = new int[3][];
            junaid_array[0] = new int[] { 11, 23, 25, 34, 50, 60, 100 };
            junaid_array[1] = new int[] { 12, 25, 30, 94, 88 };
            junaid_array[2] = new int[] { 9, 56, 33 };

            foreach (int[] row in junaid_array)
            {
                foreach (int element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            */

            //Initilizing Array(Single Diminisional) by User Input in Int datatype
            /*
            Console.WriteLine("How many Number of Items you wan't to store in Array : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[num];
            for (int i = 0;i < num; i++)
            {
                Console.WriteLine("Enter Data : ");
                int data = Convert.ToInt32(Console.ReadLine());
                numbers[i] = data;
            }
            Console.WriteLine("----Your Data is----");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            */

            //Initilizing Array(Single Diminisional) by User Input in string datatype
            /*
            //Console.WriteLine("How many Number of Items you wan't to store in Array : ");
            //int num = Convert.ToInt32(Console.ReadLine());    //how many array wan't

            //string[] numbers = new string[num];
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine("Enter Data : " + (i+1));   //array value
            //    string data = Console.ReadLine();
            //    numbers[i] = data;
            //}
            //Console.WriteLine("----Your Data is----");    
            //foreach (string item in numbers)
            //{
            //    Console.WriteLine(item);         //value result show's
            //}
            */

            //IndexOf Array
            /*
            string str = "GeeksForGeeks";
            int index1 = str.IndexOf('e', 3); //ater 3 index check the index of G
            Console.WriteLine("The Index Value of character 'e' is " + index1);
            */

            //Sub-String
            /*
            string message = "Hello World";

            string newMessage = message.Substring(1, 4);
            Console.WriteLine(newMessage);
            */

            //Equals() string
            /*
            string firstString = "This is Jamie";
            string secondString = "Hello";
            Console.WriteLine(firstString.Equals(secondString));
            */

            Console.ReadLine();
            

        }
    }
}
