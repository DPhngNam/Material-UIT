
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter folder path: ");
        string folderPath = Console.ReadLine();

        if (Directory.Exists(folderPath))
        {
            Explore(folderPath, 0);
        }
        else
        {
            Console.WriteLine("The folder path does not exist.");
        }
    }

    static void Explore(string path, int level)
    {
        try
        {
            // Indentation
            Console.Write(new string(' ', level * 2));

            if (File.Exists(path))
            {
                Console.WriteLine("File: " + path);
            }
            else if (Directory.Exists(path))
            {
                Console.WriteLine("Dir: " + path);
                string[] files = Directory.GetFiles(path);
                string[] dirs = Directory.GetDirectories(path);

                // Process and explore
                
                
                foreach (string dir in dirs)
                {
                    Explore(dir, level + 1);
                }
               
                foreach (string file in files)
                {
                    Explore(file, level + 1);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error exploring {path}: {ex.Message}");
        }
    }
}
