using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateNow = DateTime.Now.ToString();

            Console.WriteLine("Fruit, vegetable or delete?");
            string userInput = Console.ReadLine().ToLower();

             if (userInput == "fruit")
            {
                Fruit(dateNow);
            }
            else if (userInput == "vegetable")
            {
                Vegetable(dateNow);
            }
            else if (userInput == "delete")
            {
                FileDeleter();
            }
        }
        public static void Fruit(string dateString)
        {           
            Console.WriteLine("What files would you like to move into the fruit folder?");
            string sourceFile = Console.ReadLine();
            string fullSourceFile = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\" + sourceFile + ".txt";
            File.WriteAllText(fullSourceFile, dateString);
            string fullDestinationFile = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit\" + sourceFile + ".txt";

            File.Move(fullSourceFile, fullDestinationFile);
        }
        public static void Vegetable(string dateString)
        {
            Console.WriteLine("What files would you like to move into the vegetable folder?");
            string sourceFile = Console.ReadLine();
            string fullSourceFile = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\" + sourceFile + ".txt";
            File.WriteAllText(fullSourceFile, dateString);
            string fullDestinationFile = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables\" + sourceFile + ".txt";

            File.Move(fullSourceFile, fullDestinationFile);
        }
        public static void FileDeleter()
        {
            Console.WriteLine("Folder? (leave empty for root)");
            string sourceFolder = @"\" + Console.ReadLine() + @"\";

            Console.WriteLine("File?");
            string sourceFile = Console.ReadLine();
            string fullFile = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task" + sourceFolder + sourceFile + ".txt";

            //Console.WriteLine(fullFile);
            File.Delete(fullFile);
        }
    }
}
