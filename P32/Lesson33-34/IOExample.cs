using System;

namespace P32.Lesson33_34;

using System.IO;

public class IOExample
{
    //FileStream, MemoryStream, байт (images, .bat, .zip)
    //StreamReader, StreamWriter, chars 
    //BinaryReader, BinaryWriter, binary 

    /*public static void Main(string[] args)
    {
        string path = "C:\\Users\\Home\\RiderProjects\\P32\\P32\\input.bin";

        
        Console.WriteLine("============= Bite ==============");
        using ( FileStream streamWriter = new FileStream(path, FileMode.Create))
        {
             byte[] buffer = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    streamWriter.Write(buffer, 0, buffer.Length);
        }
        
        using (FileStream streamReader = new FileStream(path, FileMode.Open))
        {
            byte[] buffer2 = new byte[streamReader.Length];
            streamReader.Read(buffer2, 0, buffer2.Length);
            foreach (var item in buffer2)
            {
                Console.WriteLine(item);
            }
        }
        
        
        Console.WriteLine("============= Text ==============");

        string pathText = "C:\\Users\\Home\\RiderProjects\\P32\\P32\\index.txt";

        using (StreamWriter writer = new StreamWriter(pathText))
        {
            writer.WriteLine("Привіт, як справи!?");
        }

        using (StreamReader reader = new StreamReader(pathText))
        {
           string str = reader.ReadLine();
           Console.WriteLine("File data:" + str);
        }
        
        
        Console.WriteLine("============= Binary ==============");
        string pathBin = "C:\\Users\\Home\\RiderProjects\\P32\\P32\\bin.bin";
        using (BinaryWriter writer = new BinaryWriter(File.Open(pathBin, FileMode.Create)))
        {
            writer.Write(52);
            writer.Write(88.44);
            writer.Write("Hello World!");
        }


        using (BinaryReader reader = new BinaryReader(File.Open(pathBin, FileMode.Open)))
        {
           int int32 = reader.ReadInt32();
           double readDouble  = reader.ReadDouble();
           string s = reader.ReadString();
           
           Console.WriteLine("Binary data int:" + int32);
           Console.WriteLine("Binary data double:" + readDouble);
           Console.WriteLine("Binary data string:" + s);
           
        }
        
        Console.WriteLine("============= Directory ==============");
        
        
        
        string pathDir = "C:\\Users\\Home\\RiderProjects\\P32\\P32\\LessonDir";
        if (!Directory.Exists(pathDir))
        {
            //Directory.CreateDirectory(pathDir);
        }

        string[] files = Directory.GetFiles(pathDir);
        string[] directories = Directory.GetDirectories(pathDir);
        
        
        Console.WriteLine("============= DirectoryInfo ==============");
        
        pathDir = "C:\\Users\\Home\\RiderProjects\\P32\\P32\\LessonDirInfo";
        
        DirectoryInfo directoryInfo = new DirectoryInfo(pathDir);
        
        if (!directoryInfo.Exists)
        {
           //directoryInfo.Create();
        }

        Console.WriteLine($"FullName: {directoryInfo.FullName}");
        Console.WriteLine($"Time: {directoryInfo.CreationTime}");
        Console.WriteLine($"Root: {directoryInfo.Root}");

        Console.WriteLine("============= FileInfo ==============");

        FileInfo fileInfo = new FileInfo(pathBin);
        
        if (!fileInfo.Exists)
        {
        }
        
        Console.WriteLine($"FileName: {fileInfo.Name}");
        Console.WriteLine($"Length: {fileInfo.Length}");
        Console.WriteLine($"Time: {fileInfo.CreationTime}");

        //fileInfo.CopyTo("", true);


    }*/
}