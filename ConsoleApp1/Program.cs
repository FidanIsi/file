namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test 1
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            File.Create(path);*/

            // Test 2
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("The file mytest.txt deleted successfully.");
            }
            else { Console.WriteLine("File does not exist"); }*/

            // Test 3
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            if (!File.Exists(path))
            {
                File.Create(path);
                Console.WriteLine("A file created with name mytest.txt");
            }
            else { Console.WriteLine("File already exists"); }*/

            // Test 4
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string data = "Hello";
            File.WriteAllText(path, data);
            Console.WriteLine("A file created with content name mytest.txt");*/

            // Test 5
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string data = "Hello and Welcome";
            File.WriteAllText(path, data);
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);*/

            // Test 6
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string[] data = { "this is 1st line", "this is 2nd line" };
            File.WriteAllLines(path, data);
            Console.WriteLine("The content of the file is  :");
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);*/

            // Test 7
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string ignoredWord = "fox";
            string[] arr = { "the quick brown fox jumps", "over the lazy dog." };

            if (!File.Exists(path))
            {
                Console.WriteLine("The specified file does not exist.");
            }

            List<string> list = new List<string>();

            foreach (string element in arr)
            {
                if (!element.Contains(ignoredWord))
                {
                    list.Add(element);
                }
            }

            File.WriteAllLines(path, list);
            
            Console.WriteLine("Lines containing the word '" + ignoredWord + "' have been removed from the file.");*/

            // Test 8
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string data = "This is the line appended at last line.";

            File.AppendAllText(path, data);
            var contents = File.ReadAllText(path);
            Console.WriteLine(contents);*/

            // Test 9
            /*string path1 = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string path2 = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mynewtest";
            
            string[] data = { "Hello and Welcome", "It is the first content ", "of the text file mytest.txt" };
            if(!File.Exists(path1))
            {
                File.Create(path1);
            }

            File.WriteAllLines(path1, data);
            File.Copy(path1, path2, true);
            File.Delete(path1);
            Console.WriteLine("The file mytest.txt successfully copied to the name mynewtest.txt in the same directory.");*/

            // Test 10
            /*string path1 = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string path2 = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mynewtest";
            string[] data = { "Hello and Welcome", "It is the first content ", "of the text file mytest.txt" };
            if (!File.Exists(path1))
            {
                File.Create(path1);
            }

            File.WriteAllLines(path1, data);

            File.Move(path1, path2);
            Console.WriteLine("The file mytest.txt successfully copied to the name mynewtest.txt in the same directory.");*/

            // Test 11
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string[] data = { "test line 1 ", "test line 2 ", "test line 3 " };
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            File.WriteAllLines(path, data);

            var lines = File.ReadAllLines(path).Take(1);
            Console.WriteLine("The content of the first line of the file is :" );
            foreach ( var line in lines )
            {
                Console.WriteLine(line);
            }*/

            // Test 12
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string[] data = { "line1", "line2 ", "line3 " };
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            File.WriteAllLines(path, data);

            var lines = File.ReadAllLines(path).TakeLast(1);
            Console.WriteLine("The content of the last line of the file mytest.txt is  :");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }*/

            // Test 13
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string[] data = { "line1", "line2 ", "line3 " };
            int lineNumber;

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            Console.Write("Enter the line number to read: ");
            lineNumber = Convert.ToInt32(Console.ReadLine());
            if (lineNumber > 0)
            {
                string[] lines = File.ReadAllLines(path);
                if (lineNumber <= lines.Length)
                {
                    string lineToRead = lines[lineNumber - 1];
                    Console.WriteLine(lineToRead);
                }
                else
                {
                    Console.WriteLine("Line number exceeds the total number of lines in the file.");
                }

            }
            else
            {
                Console.WriteLine("Invalid number");
            }*/

            // Test 14
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string[] data = { "line1", "line2 ", "line3 ", "line4 " };
            File.WriteAllLines(path, data);
            var lines = File.ReadAllLines(path).TakeLast(2);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }*/


            // Test 15
            /*string path = "C:\\Users\\Adeliya\\OneDrive\\İş masası\\filleio\\mytext";
            string[] data = { "line1", "line2 ", "line3 ", "line4 " };
            File.WriteAllLines(path, data);
            int num = File.ReadAllLines(path).Length;
            Console.WriteLine(num);*/

        }
    }
}