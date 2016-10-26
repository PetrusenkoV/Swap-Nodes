using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\v.petrusenko\\WorkingFolder\\TrainingTasks\\temp files\\case4.txt");

            StreamReader sr1 = new StreamReader("C:\\Users\\v.petrusenko\\WorkingFolder\\TrainingTasks\\temp files\\myOutput.txt");
            StreamReader sr2 = new StreamReader("C:\\Users\\v.petrusenko\\WorkingFolder\\TrainingTasks\\temp files\\ExpectedOutput.txt");


            string myOutput = null;
            string expectedOutput = null;
            string line;

            while ((line = sr1.ReadLine()) != null)
            {
                myOutput += line;
                Console.WriteLine(line);
            }
            Console.WriteLine("2nd file starts");
            //while ((line = sr2.ReadLine()) != null)
            //{
            //    myOutput += line;
            //    Console.WriteLine(line);
            //}




            List<string> data = new List<string>();


            //while ((line = sr.ReadLine()) != null)
            //{
            //    data.Add(line);
            //    Console.WriteLine(line);
            //}



            int n = Int32.Parse(sr.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = sr.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int T = Convert.ToInt32(sr.ReadLine());

            int[] levelOfSwaps = new int[T];
            for (int i = 0; i < T; i++)
            {
                levelOfSwaps[i] = Convert.ToInt32(sr.ReadLine());
            }

            BinaryTree tree = new BinaryTree();

            for (int i = 0; i < n; i++)
            {
                tree.AddChildrenToNode(i + 1, a[i][0], a[i][1]);
            }

            for (int i = 0; i < T; i++)
            {
                int k = 1;


                while (levelOfSwaps[i] * k <= tree.TreeLevel)
                {
                    tree.SwapAtLevel(tree.Root, levelOfSwaps[i] * k);

                    k++;
                }
                tree.InorderTraversal(tree.Root);
                Console.WriteLine();

            }
            Console.WriteLine(myOutput.Equals(expectedOutput));
            Console.WriteLine(tree.TreeLevel);
            Console.ReadLine();
        }
    }
}
