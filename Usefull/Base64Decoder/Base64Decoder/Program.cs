using System;
using System.IO;
using System.Text;

namespace Base64Decoder
{
    /// <summary>
    /// Takes a base 64 encoded PDF and turns it into a PDF file again
    /// </summary>
    class Program
    {
        static void Main()
        {
            string base64String;

            try
            {
                var inFile = new StreamReader(@".\test.txt",Encoding.UTF8);
                var base64CharArray = new char[inFile.BaseStream.Length];
                inFile.Read(base64CharArray, 0, (int)inFile.BaseStream.Length);
                base64String = new string(base64CharArray);
            }
            catch (Exception exp)
            {
                // Error creating stream or reading from it.
                Console.WriteLine("{0}", exp.Message);
                return;
            }

            // Convert the Base64 UUEncoded input into binary output. 
            byte[] binaryData;
            try
            {
                binaryData =
                   Convert.FromBase64String(base64String);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Base 64 string is null.");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Base 64 string length is not " +
                   "4 or is not an even multiple of 4.");
                return;
            }

            // Write out the decoded data.
            try
            {
                var outFile = new FileStream(@".\test.pdf",
                                                    FileMode.Create,
                                                    FileAccess.Write);
                outFile.Write(binaryData, 0, binaryData.Length);
                outFile.Close();
            }
            catch (Exception exp)
            {
                // Error creating stream or writing to it.
                Console.WriteLine("{0}", exp.Message);
            }
        }
    }
}
