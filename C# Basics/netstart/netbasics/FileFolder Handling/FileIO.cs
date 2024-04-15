using System;
using System.IO;

class FileIO
{
    private string folderPath = @"D:\SDK-and-C-Sharp\C# Basics\netstart\netbasics\FileFolder Handling";
    
    // Create a text file directly in the folderPath
    public void CreateFile()
    {
        string fileName = "student.txt";
        string filePath = Path.Combine(folderPath, fileName);

        // Write text content to the file
        File.WriteAllText(filePath, "this is the first line");
    }

    // Create a text file inside a new folder within folderPath
    public void CreateFileWithinFolder()
    {
        string newFolderName = "Student";
        string newFolderPath = Path.Combine(folderPath, newFolderName);

        // Create the new folder if it doesn't exist
        Directory.CreateDirectory(newFolderPath);

        string fileName = "Student1.txt";
        string filePath = Path.Combine(newFolderPath, fileName);

        // Write text content to the file
        File.WriteAllText(filePath, "this is the first line");
    }
}
