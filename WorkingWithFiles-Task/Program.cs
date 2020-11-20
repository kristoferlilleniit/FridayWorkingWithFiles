using System;
using System.IO;

namespace WorkingWithFiles_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            moveToFruitFolder();
            moveToVegetablesFolder();
            DeleteFile();
        }


        public static void moveToFruitFolder()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            Console.WriteLine("What files do you want to move to the fruit folder?");
            string userInputF = Console.ReadLine();
            string sourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string fileName = $"{userInputF}.txt";

            if(File.Exists(Path.Combine(sourceDirectory, fileName)))
            {
                File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
            }else
            {
                Console.WriteLine("That file doesn't exist.");
            }
        }

        public static void moveToVegetablesFolder()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            Console.WriteLine("What files do you want to move to the vegetables folder?");
            string userInputV = Console.ReadLine();
            string sourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            string fileName = $"{userInputV}.txt";

            if (File.Exists(Path.Combine(sourceDirectory, fileName)))
            {
                File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
            }
            else
            {
                Console.WriteLine("That file doesn't exist.");
            }
        }

        public static void DeleteFile()
        {
            string rootPathFruits = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string rootPathVegetables = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            Console.WriteLine("What file do you want to delete in fruits folder?");
            string userInput = Console.ReadLine();
            string fileName = $"{userInput}.txt";


            if (File.Exists(Path.Combine(rootPathFruits, fileName)))
            {
                File.Delete(Path.Combine(rootPathFruits, fileName));
                Console.WriteLine("File deleted");
            }else
            {
                Console.WriteLine("File not found.");
            }

            Console.WriteLine("What file do you want to delete in vegetables folder?");
            string userInputV = Console.ReadLine();
            string fileNameV = $"{userInputV}.txt";

            if (File.Exists(Path.Combine(rootPathVegetables, fileNameV)))
            {
                File.Delete(Path.Combine(rootPathVegetables, fileNameV));
                Console.WriteLine("File deleted.");
            }else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
