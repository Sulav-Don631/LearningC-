using System;
using System.IO;
public class FileIO
{

    public void LearnFileReading()
    {
        string filePath = "/Users/sudinshrestha/Documents/personal/dotnet/LearningC-/README.md";
        string fileInProject = "Inheritance.cs";
        bool isFileThere = File.Exists(fileInProject);
        if(isFileThere)
        {
        var fileContent = File.ReadAllText(fileInProject);
       Console.WriteLine(fileContent);
        }

    }

    public void LearnFileWriting()
    {
        string filePath = "Abc.txt";
        File.WriteAllText(filePath, "Hello this is file handeling course");
    }

    public void LearnFileInfo()
    {
        string filePath = "Abc.txt";
        FileInfo fileInfo = new FileInfo(filePath);
        
        var size = fileInfo.Length;
        var createDate = fileInfo.CreationTime;

        Console.WriteLine(filePath);
        Console.WriteLine($"Size: {size}");
        Console.WriteLine($"Created Date {createDate}");
    }

    public void LearnDirectory()
    {
        string folderPath = "Abc";
        Directory.CreateDirectory(folderPath);

        Console.WriteLine("Do you want to dele the folder just created?");
        var ask = 'y';
        

        var t = Console.Read();

        if (t == ask )
        {
            Directory.Delete(folderPath);
        }

        
    }

}