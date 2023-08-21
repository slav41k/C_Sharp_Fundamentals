using System;
using System.Collections.Generic;
using System.IO;
using System.Security;

namespace HW7
{
    internal class Program
    {
        static void Main()
        {
            //Task 1
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string path = "/Users/cyanide/phone.txt";
            string line;

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(" : ");
                        if (parts.Length == 2)
                        {
                            string phoneName = parts[0];
                            string phoneNumber = parts[1];
                            phoneBook[phoneNumber] = phoneName;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            string outPath = "/Users/cyanide/numbers.txt";

                using (StreamWriter writer = new StreamWriter(outPath))
                {
                    foreach (var kvp in phoneBook)
                    {
                        writer.WriteLine(kvp.Key);
                    }
                }
                
                //Task 3
                Dictionary<string, string> newPhoneBook = new Dictionary<string, string>();

                using (StreamReader read = new StreamReader(path))
                {
                    while ((line = read.ReadLine()) != null)
                    {
                        string[] parts = line.Split(" : ");
                        if (parts.Length == 2)
                        {
                            string newPhoneName = parts[0];
                            string newPhoneNumber = parts[1];
                            if (newPhoneNumber.Length == 11)
                                newPhoneNumber = "+3" + newPhoneNumber;
                            newPhoneBook[newPhoneNumber] = newPhoneName;
                        }
                    }
                }

                //Task 2
                Console.Write("Enter a name to find the phone number: ");
                string searchName = Console.ReadLine();
                bool isThereName = true;
                foreach (var kvp in newPhoneBook)
                {
                    if (searchName.ToLower() == kvp.Value.ToLower())
                    {
                        Console.WriteLine($"{kvp.Value} : {kvp.Key}");
                        isThereName = false;
                    }
                }
                if(isThereName)
                    Console.WriteLine("Invalid name");
                
                //Task 3
                string newOutPath = "/Users/cyanide/new.txt";

                using (StreamWriter writ = new StreamWriter(newOutPath))
                {
                    foreach (var kvp in newPhoneBook)
                    {
                        writ.WriteLine($"{kvp.Value} : {kvp.Key}");
                    }
                }
            }
        }

    }