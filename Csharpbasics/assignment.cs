public class Assignment
{
    public void CreatingFile()
    {
        string filePath = "Nepal";
        Directory.CreateDirectory(filePath);

        for (int i = 1; i<=10; i++)
        {
            string subfolderName = $"Hero_{i}";
            string subfolderPath = Path.Combine(filePath, subfolderName);
            Directory.CreateDirectory(subfolderPath);

            File.WriteAllText(Path.Combine(subfolderPath,"Test.txt"),subfolderName);
        }
    }
}