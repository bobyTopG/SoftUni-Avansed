namespace CopyBinaryFile
{
    using System;
    using System.IO;
    using System.Text;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"../../../copyMe.jpg1";


            CopyFile(inputFilePath);

            void CopyFile(string inputFilePath)
            {
                int count = 1;
                using FileStream reader = new FileStream(inputFilePath, FileMode.Open);
                using FileStream writer = new FileStream(inputFilePath + count, FileMode.Create);
                count++;
                byte[] buffer = new byte[1024];
                int size = 0;
                while ((size = reader.Read(buffer, 0, buffer.Length)) != 0)
                {
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        buffer[i] ^= 157;
                    }
                    writer.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
