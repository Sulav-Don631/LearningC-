using System;
using System.IO;
public class FileIO
{

    public void LearnFileHandling()
    {
        string filePath = "/Users/sudinshrestha/Documents/personal/dotnet/LearningC-/README.md";
        bool isFileThere = File.Exists(filePath);
        if(isFileThere)
        {
        var fileContent = File.ReadAllText(filePath);
       Console.WriteLine(fileContent);
        }

    }

}