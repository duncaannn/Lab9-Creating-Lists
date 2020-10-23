using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesOfLeaders = new List<string> { "1. Napoleon Bonaparte", "2. Julius Caesar", "3. Mikhail Gorbachev", "4. Constantine The Great", "5. Attila The Hun", "6. Xerxes I", "7. John F. Kennedy", "8. Agamemnon", "9. Hannibal", "10. King David", "11. Charlemagne", "12. Trent Reznor", "13. Ian MacKaye", "14. Sir William Wallace" };
            List<string> locations = new List<string> { "Ajaccio, France", "Rome, Italy", "Privolnoye, Russia", "Naissus, Dacia Mediterranea (now Niš, Serbia)", "Pannonia, Hungary", "Persia", "Brookline, Massachussetts", "Mykene - Hellas, Greece", "Carthage, Tunisia", "Bethlehem, Israel", "Aachen, Germany", "New Castle, Pennsylvania", "Washington D.C.", "Eldersie, Scotland" };
            List<string> knownFor = new List<string> { "Emperor of France", "Emperor of Rome", "President of the Soviet Union", "Holy Roman Emperor", "Flagellum Dei", "Emperor of Persia", "35th President of the USA", "King of Mycenae", "General of Carthage", "King of Israel", "Holy Roman Emperor", "Nine Inch Nails", "Fugazi", "Knight of Scotland" };

            foreach (string s in namesOfLeaders)
            {
                Console.WriteLine(s);
            }
            bool isValid = false;
            while (true)
            {
                while (true)
                {
                    int index = 0;

                    while (isValid == false)
                    {
                        try
                        {

                            index = int.Parse(GetUserInput("Which leader would you like to learn about today? Enter their requisite number."));

                            Console.WriteLine($"Thank you. {index} is {namesOfLeaders[index - 1]}");

                            isValid = true;
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid Number. Try again!");
                            isValid = false;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Not in the range. Please select a number between 1-14");
                            isValid = false;
                        }

                    }

                   

                    string yesNo = GetUserInput("Would you like to know their birthplace? y/n");
                    if (yesNo == "y")
                    {
                        Console.WriteLine($"Thank you. {index} is {locations[index - 1]}");
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }

                    string yesNo1 = GetUserInput("Would you like to know what they are known for? y/n");
                    if (yesNo1 == "y")
                    {
                        Console.WriteLine($"Thank you. {index} is {knownFor[index - 1]}");
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                    string addUser = GetUserInput("Would you like to add someone to the list? y/n");
                    if(addUser=="y")
                    {
                        namesOfLeaders.Add(GetUserInput("Enter someone's name you would like to add."));
                        locations.Add(GetUserInput("How about their birthplace?"));
                        knownFor.Add(GetUserInput("What is their title, or what are they known for?"));
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                    //  }
                    //else
                    //{
                    //    Console.WriteLine("Please enter a valid number.");
                    //}
                }



            }



        }



        public static bool ValidateIndex(string index)
        {
            Regex d = new Regex(@"([1-9]{1,2})$");
            if (d.IsMatch(index))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();
            return response;
        }
    }
}


