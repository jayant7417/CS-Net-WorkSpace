﻿using System;
using System.IO;

namespace FileExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\abhad\Desktop\Practice\India.txt", filePath2 = @"C:\Users\abhad\Desktop\Practice\India2.txt", filePath3 = @"C:\Users\abhad\Desktop\Practice\another.txt";

            File.Create(filePath).Close();
            Console.WriteLine("India.txt created");

            bool exists = File.Exists(filePath);
            if (exists)
            {
                File.Copy(filePath, filePath2);
                Console.WriteLine("Copied India.txt to India2.txt");

                File.Move(filePath2, filePath3);
                Console.WriteLine("Moved India2.txt to another.txt");

                File.Delete(filePath3);
                Console.WriteLine("another.txt deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }
            Console.ReadKey();
        }
    }
}