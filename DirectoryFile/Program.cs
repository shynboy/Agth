using System;
using System.IO;
namespace DirectoryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // D:\Project\MyShopProject\MyShop\Abc.txt
            Console.WriteLine("Nhap ten file");
            string path = Console.ReadLine();
            char slat = '\\';
            string[] splited = path.Split(slat);
            //foreach(var item in splited)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("----------------------");
            string[] myDirectory = (string[])splited.Clone();
            for(int i = 1; i < myDirectory.Length; i++)
            {
                Console.WriteLine($"Directory {i} : {myDirectory[i]}");
            }
            string[] Disk = splited[0].Split(':');
            string Diskname = Disk[0];
            string fileName = splited[splited.Length - 1];
            Console.WriteLine($"Disk {Diskname}");
            Console.WriteLine($"Filename {fileName}");

            Console.ReadLine();
        }
    }



    class FileDirectory
    {

    }
}
