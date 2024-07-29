using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThree
{
     class Propert
    {
        /* properties : way to encapsulate fields and provide controlled
         * special members of class that provide a flexible mechanism of class that
         * provide a flexible mechanism to read, write or compute the values of private fields
         * Properties can be used as if they are public data members but they include 
         * special methods called accessors to access and modify thier values
         * Get Accessor
         * Set Accessor
         */
        public string name;
        private int age;
        private string address;
        public string Address { get; set; }
        public void setAddress(string value) { address = value; }
        public string getAddress() => address;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Age cannot be negative");
                age = value;
            }
        }

    }
    class Properties
    {
        static void Main(string[] args)
        {
            Propert obj = new Propert { Address = "patan"};
            obj.name = "md";
            try
            {
                Console.WriteLine(obj.Age = -1);
            }
            catch (Exception ex) { 
                Console.WriteLine("Error : Age cannot be negative "+ ex.Message);
            }
           
         
            obj.setAddress("Dhobighat");
            string address=obj.getAddress();
            Console.WriteLine(obj.Address);
            Console.WriteLine(address);
        }
        /* indexers                     Properties
           Indexers are created using   Doesnot require this keyword
           this keyboard.

           indexers are identified by   Properties are identified by thier names
           signature

           indexer are accessed using   properties are accessed using thier name
           index 

           Are instance member so       Can be static as well as instance member
           cannot be static

           A get accessor of an indexer A get accessor of a property has no parameter
           has the same formal paramter
           list as the indexer          

           A set accessor of an indexer A set accessor of a property 
           in addition to the value     contains the implicit value paramter
           parameter
        */
    
    }
}


