using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document");
            Console.WriteLine();
          
            Console.WriteLine("Please input your documents name: ");
            String documentname = Console.ReadLine();
            Console.WriteLine("Please input your documents content: ");
            String documentcontent = Console.ReadLine();
            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Document\\" + documentname + ".txt");

                //Write a line of text
                sw.WriteLine(documentcontent);

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error:");
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                int count = 0;
                string[] Text = File.ReadAllLines("C:\\Document\\" + documentname + ".txt");
                for (int i = 0; i < Text.Count(); i++)
                {
                    count += Text[i].Length;
                }
                Console.WriteLine(documentname + " was succesfully saved. The document contains {0} characters.", count);
                
            }
            Console.ReadKey();

        }

        }
    }

