using System.Diagnostics;

namespace ClassLibrary2
{
    public class PhoneBook
    {
        public string[] Names;
        public string[] Numbers;
        private int counter;
        public static int created;
        public PhoneBook()
        {
            Names = new string[100];
            Numbers = new string[100];
            counter = 0;
            created++;
        }
        static PhoneBook()
        {
            created = 0;
        }
        public string this[string name]
        {
            set
            {
                int index = Array.IndexOf(Names, name);
                if (index == -1)
                {
                    Names[counter] = name;
                    Numbers[counter] = value;
                    counter++;
                }
                else
                {
                    Numbers[index] = value;
                }
            }
            get
            {
                for (int i = 0; i < counter; i++)
                
                    if (name==Names[i])
                        return Numbers[i];
            
                return "not found";
            }
        }
        
        public static int operator +(PhoneBook phoneBook1,PhoneBook phoneBook2)
        {
            return phoneBook1.counter + phoneBook2.counter;
        }
        public static void print()
        {
            Console.WriteLine("this is static methode");
        }
        
        /*
        public void addPhone(string name,string number)
        {
            Names[counter] = name;
            Numbers[counter] = number;
            counter++;
        }

       public string Search(string name)
        {
            for(int i = 0; i < counter; i++)
            {
                if (Names[i] == name)
                    return Numbers[i];

            }
            return "not found";
        }
        */
    }
}
