using System.IO;
/// <summary>
/// This is a program for sorting my dowloads folder into folders for each file extention type
/// this is also my first c# progject 
/// </summary>


class SortDownloadfolder
{
    
    private const string downPath = @"C:\Users\Bruger\Downloads\"; //Download path 

    static void Main(string[] args)
        {
        string path = downPath;
        string[] dirOfDown = Directory.GetFiles(path);

        foreach(string i in dirOfDown)
        {
            if (i != path + "desktop.ini" && i != path + "print.pdf") // Files i know wont be moved / would maybe crash the program
            {
                string normFilN = Path.GetFileName(i); //get's the file name whit extentions
                if (Directory.Exists(path + Path.GetExtension(i)[1..])){//checks wheter the directory exist 
                    File.Move(i, path + Path.GetExtension(i)[1..] + "\\" + normFilN); //moves the files to there correct place
                }
                else
                {
                    Directory.CreateDirectory(path + Path.GetExtension(i)[1..]); //makes the directory if it doesn't exist
                    File.Move(i, path + Path.GetExtension(i)[1..] + "\\" + normFilN); //moves the files to there correct place
                }
                
            }
        }
    }
}