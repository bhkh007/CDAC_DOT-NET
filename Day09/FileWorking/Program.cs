namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main()
        {
            WriteTextFile();
            ReadTextFile();
        }

        private static void WriteTextFile()
        {
            //string s = "Hello World";

            //byte[] arr = Encoding.Default.GetBytes(s);
            ////FileStream stream = File.Open("C:\\aaaa\\a.txt", FileMode.Create);
            //FileStream stream = File.Open(@"C:\aaaa\a.txt", FileMode.Create);
            //stream.Write(arr, 0, arr.Length);

            ////stream.Length
            ////stream.Read()

            //stream.Close();
            //-------------------------------




            StreamWriter writer = File.CreateText("C:\\aaaa\\a.txt");
            writer.WriteLine("Hello World");
            writer.WriteLine("Line 2");
            writer.WriteLine("230 pm onwards....");

            writer.Close();




        }

        private static void ReadTextFile()
        {
            string s;
            StreamReader reader = File.OpenText("C:\\aaaa\\a.txt");
            while ((s = reader.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            reader.Close();
        }

    }
}