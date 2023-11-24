﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             try
            {
                string path = @"C:\Users\rojar\OneDrive\Desktop\Simpli learn\OSL1\Project2\Project2\StudentData.txt";
                string[] lines2 = File.ReadAllLines(path);
                Console.WriteLine("The Students Data are \n");
                int index = 1;
                foreach (string line in lines2)
                {
                    Console.WriteLine($" {index++} : " + line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.Write("All the Students data in the files are displayed: ");
            }
            Console.ReadKey();
        }

        
    }

}
