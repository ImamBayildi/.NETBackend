using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
usşng MyProject;

namespace Another
{
    public class CustomerManager
    {
         //encapsulation.
        public string AddCustomer(Musteri musteri){
            //Define a Musteri obect and set on this method
            return "Musteri added";
        }

        public string AddCustomer(string customerName, string customerBirthday, bool isDeleted=false){
            //Define a Musteri variables and set on this method
            Musteri Customer = new Musteri();
            return (customerName+"customer added");
        }

        public string Update(string id, Musteri musteri){
            //Define a Musteri obect and set on this method
            foreach (Object item in Musteri)
            {
                if (Musteri.Id == item.Id)
                {
                    item.Name = Musteri.Name;
                    item.Birthday = Musteri.Birthday;
                    item.isDeleted = Musteri.isDeleted;
                }
            }
            return "Musteri updated";
        }

        public void GetCustomer(string id){
            bool isFound = 0;
            foreach (Object item in Musteri)
            {
                if (Musteri.Id == item.Id)
                {
                    idFound = 1;
                    Console.WriteLine(Musteri.Name);
                    Console.WriteLine(Musteri.Birthday);
                    Console.WriteLine(Musteri.isDeleted);
                }
            }
            isFound? null : Console.WriteLine("Musteri bulunamadı");
        }
    }
}