﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class FileOperations
    {
        public void CreateFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\User\\Desktop"+"\\Files\\Sample.txt");
            using StreamWriter str=fi.CreateText();
            Console.WriteLine("File has been created.");

            str.WriteLine("hello there");
            str.WriteLine("HI");
            Console.WriteLine("Written");

        }

        public void WriteData()
        {
            FileStream fs = new FileStream("C:\\Users\\User\\Desktop\\Files\\Sample2.txt",
            FileMode.CreateNew,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text:");
            string? str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            sw.Close();
        }

        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\User\\Desktop\\Files\\Sample.txt",
            FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str=sr.ReadLine();
            }
            
            sr.Close();
            fs.Close();
        }

        public void CopyMoveFile()
        {
            FileInfo fi1 = new FileInfo("C:\\Users\\User\\Desktop\\Files\\Sample.txt");
            FileInfo fi2 = new FileInfo("C:\\Users\\User\\Desktop\\Files\\Sample2.txt");

            fi1.CopyTo("C:\\Users\\User\\Desktop\\Files\\Temp1\\" + "Sample.txt");
            fi2.MoveTo("C:\\Users\\User\\Desktop\\Files\\Temp2\\" + "Sample2.txt");

            
        }

        public void DeleteFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\User\\Desktop\\Files\\Sample.txt");
            fi.Delete();


        }

        public void FileProperties()
        {
            FileInfo fi = new FileInfo("C:\\Users\\User\\Desktop\\Files\\Sample2.txt");
            fi.Delete();
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastWriteTime);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Exists);

        }
    }
}
