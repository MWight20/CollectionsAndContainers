using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// About:
//
//  This is an App used to practice Collections and containers in conjuction with static/nonstatic classes implementation.
//
//  Containers/collections used:
//
//      Arrays,
//      Multidimensional Arrays(2D and 3D),
//      Jagged Arrays,
//      List, 
//      Dictionary,
//      HashSet,
//      sortedSet,
//     
//


namespace collectionsContainersAndClasses
{
    public static class StaticClass
    {
        //variables used to test
        public static string[] StaticNamesArray = new string[] {"James", "Michael", "Jayce", "Hayley", "Stella"};
        public static int[] StaticIntArray = new int[] { 20, 14, 12, 11, 2006 };
        
        //Collection variables
        public static List<string> StaticNamesList = new List<string>();
        public static Dictionary<int, string> StaticNamesDictionary = new Dictionary<int, string>();
        public static HashSet<string> StaticHashSet = new HashSet<string>();
        public static SortedSet<string> StaticSortedSet = new SortedSet<string>();
        
        //MD Arrays
        public static int [ , ] StaticArr1 = new int[ 2, 3];
        public static int [ , , ] StaticArr2 = new int[2, 3, 4];


        public static void PrintMe<T>(IEnumerable<T> col)
        {
            foreach(var item in col)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class NonStaticClass
    {
        //variables used to test
        public string[] NamesArray = new string[] { "James", "Michael", "Michael", "Jayce", "Hayley", "Jayce", "Stella" };
        public int[] IntArray = new int[] { 20, 14, 12, 11, 2006 };
        
        //Collection variables
        public List<int> nonStaticList = new List<int>();
        public Dictionary<int, string> nonStaticDictionary = new Dictionary<int, string>();
        public HashSet<string> HashSet = new HashSet<string>();
        public SortedSet<string> SortedSet = new SortedSet<string>();
        
        public int[,] Arr1 = new int[2, 3];
        public int[,,] Arr2 = new int[2, 3, 4];

        //this allows both arrays and generic lists to be passed in as parameters
        public void printMe<T>(IEnumerable<T> col)
        {
            foreach (var item in col)
            {
                Console.WriteLine(item);
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n**********************************************");
            Console.WriteLine("Now testing Non-Static and static printMe() methods");
            Console.WriteLine("**********************************************");

            // NonStaticClass
            NonStaticClass azure = new NonStaticClass();
            Console.WriteLine("Now printing nonstatic class variables: ");
            Console.WriteLine();
            azure.printMe(azure.NamesArray);
            azure.printMe(azure.IntArray);

            Console.WriteLine();

            //StaticClass
            Console.WriteLine("Now printing static class variables: ");
            Console.WriteLine();
            StaticClass.PrintMe(StaticClass.StaticNamesArray);
            StaticClass.PrintMe(StaticClass.StaticIntArray);


            Console.WriteLine("\n**********************************************");
            Console.WriteLine("Now testing Jagged arrays");
            Console.WriteLine("**********************************************");

            // This arrray is initialized with 3 int arrays of undetermined length
            int[][] Jag = new int[3][];

            // Jag[][] will consist of 3 int arrays, with initlized array length of 5, 4, and 2, respectively.
            Jag[0] = new int[5];
            Jag[1] = new int[4];
            Jag[2] = new int[2];

            Jag[0][0] = 1;
            Jag[0][1] = 3;
            Jag[0][2] = 5;
            Jag[0][3] = 7;
            Jag[0][4] = 9;

            Jag[1][0] = 0;
            Jag[1][1] = 2;
            Jag[1][2] = 4;
            Jag[1][3] = 6;

            Jag[2][0] = 11;
            Jag[2][1] = 22;

            //initializing jag2 all at once
            string[][] Jag2 = new string[][]
            {
                new string[] {"this", "is", "the","first","string","array"},
                new string[] {"Now", "this", "is","the","second"},
            };

            //output jag
            for (int i = 0; i < Jag.Length; i++)
            {
                for (int j = 0; j < Jag[i].Length; j++)
                {
                    Console.WriteLine("Value for [" + i + "][" + j + "] :  " + Jag[i][j]);
                }
            }

            //output jag2
            for (int i = 0; i < Jag2.Length; i++)
            {
                for (int j = 0; j < Jag2[i].Length; j++)
                {
                    Console.WriteLine("Value for [" + i + "][" + j + "] :  " + Jag2[i][j]);
                }
            }



            Console.WriteLine("\n**********************************************");
            Console.WriteLine("Now testing Multidimensional arrays");
            Console.WriteLine("**********************************************");
            
            // static
            // public int[,] Arr1 = new int[2, 3];
            // Arr1 contains 2 arrays of 3 indices
            
            //assign values to Arr1
            StaticClass.StaticArr1[0, 0] = 20;
            StaticClass.StaticArr1[0, 1] = 14;
            StaticClass.StaticArr1[0, 2] = 23;
            StaticClass.StaticArr1[1, 0] = 13;
            StaticClass.StaticArr1[1, 1] = 12;
            StaticClass.StaticArr1[1, 2] = 11;

            Console.WriteLine("\n\n Displaying values for StaticClass Arr1[,]");
            //output values of Arr1
            foreach (int i in StaticClass.StaticArr1)
            {
                Console.WriteLine("Value at this index is: " + i + ".");
            }


            // nonstatic
            // public int[,,] Arr2 = new int[2, 3, 4];
            // Arr2 contains 2 arrays of 3 indices with 4 subindices  

            //assign values to Arr2
            //0
            azure.Arr2[0, 0, 0] = 1;
            azure.Arr2[0, 0, 1] = 1;
            azure.Arr2[0, 0, 2] = 1;
            azure.Arr2[0, 0, 3] = 1;

            azure.Arr2[0, 1, 0] = 2;
            azure.Arr2[0, 1, 1] = 2;
            azure.Arr2[0, 1, 2] = 2;
            azure.Arr2[0, 1, 3] = 2;

            azure.Arr2[0, 2, 0] = 3;
            azure.Arr2[0, 2, 1] = 3;
            azure.Arr2[0, 2, 2] = 3;
            azure.Arr2[0, 2, 3] = 3;

            //1
            azure.Arr2[1, 0, 0] = 11;
            azure.Arr2[1, 0, 1] = 11;
            azure.Arr2[1, 0, 2] = 11;
            azure.Arr2[1, 0, 3] = 11;

            azure.Arr2[1, 1, 0] = 12;
            azure.Arr2[1, 1, 1] = 12;
            azure.Arr2[1, 1, 2] = 12;
            azure.Arr2[1, 1, 3] = 12;

            azure.Arr2[1, 2, 0] = 13;
            azure.Arr2[1, 2, 1] = 13;
            azure.Arr2[1, 2, 2] = 13;
            azure.Arr2[1, 2, 3] = 13;

            Console.WriteLine("\n\n Displaying values for nonstatic Arr2[,,]");
            foreach (int i in azure.Arr2)
            {
                Console.WriteLine("Value at this index is: " + i + ".");
            }
            

            Console.WriteLine("\n**********************************************");
            Console.WriteLine("Now testing Lists");
            Console.WriteLine("**********************************************");

            //static values
            Console.WriteLine("\n Displaying values for static List");
            foreach (string value in StaticClass.StaticNamesArray)
            {
                StaticClass.StaticNamesList.Add(value);
            }

            foreach(string value in StaticClass.StaticNamesList)
            {
                Console.WriteLine(value);
            }

            //nonstatic values
            Console.WriteLine("\n Displaying values for nonstatic List");
            foreach (int value in azure.IntArray)
            {
                azure.nonStaticList.Add(value);
            }

            foreach(int value in azure.nonStaticList)
            {
                Console.WriteLine(value);
            }
           

            Console.WriteLine("\n**********************************************");
            Console.WriteLine("Now testing Dictionaries");
            Console.WriteLine("**********************************************");


            //nonstatic values
            for(int i = 0; i < azure.NamesArray.Length; i++)
            {
                azure.nonStaticDictionary.Add(i, azure.NamesArray[i]);
            }

            foreach(KeyValuePair<int, string> item in azure.nonStaticDictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }


            Console.WriteLine("\n**********************************************");
            Console.WriteLine("Now testing HashSets");
            Console.WriteLine("**********************************************");

            //nonstatic
            foreach (string value in azure.NamesArray)
            {
                azure.HashSet.Add(value);
            }

            //using toArrayjoin
            Console.WriteLine(string.Join(",", azure.HashSet.ToArray()));
            Console.WriteLine();

            //using foreach
            foreach(string value in azure.HashSet)
            {
                Console.WriteLine(value);
            }
            


            Console.WriteLine("**********************************************");
            Console.WriteLine("Now testing SortedSets");
            Console.WriteLine("**********************************************");

            //nonstatic
            foreach (string value in azure.NamesArray)
            {
                azure.SortedSet.Add(value);
            }

            //using toArrayjoin
            Console.WriteLine(string.Join(",", azure.SortedSet.ToArray()));
            Console.WriteLine();

            //using foreach
            foreach (string value in azure.SortedSet)
            {
                Console.WriteLine(value);
            }



        }
    }
}
