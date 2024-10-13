using System;
using System.Data;
using ContactsBusinnesLayer;

using CountriesBusinessLayer;

namespace ContactsPresentaionLayer
{
    internal class Program
    {
        //============================================== Contacts Test Functions ===============================//
        static void TestFindContacts(int ID)
        {
            clsContacts contacts = clsContacts.Find(ID);

            if (contacts != null)
            {
                Console.WriteLine(contacts.FirstName + " " + contacts.LastName);
                Console.WriteLine(contacts.Email);
                Console.WriteLine(contacts.Phone);
                Console.WriteLine(contacts.Address);
                Console.WriteLine(contacts.DateOfBirth);
                Console.WriteLine(contacts.CountryID);
                Console.WriteLine(contacts.ImagePath);
            }
            else
            {
                Console.WriteLine(" Contact Not Found");
            }
        }

         static void TestAddNewContact()
        {
            clsContacts contacts = new clsContacts();

            contacts.FirstName = "Zaka";
            contacts.LastName = "King";
            contacts.Email = "Zaka@.net";
            contacts.Phone = "89350289320";
            contacts.Address = "kslnklkzm";
            contacts.DateOfBirth = new DateTime(2002, 2, 11);
            contacts.CountryID = 1;
            contacts.ImagePath = string.Empty;

            if(contacts.Save())
            {
                Console.WriteLine("Adding New Contact Done Successfully:-)");
            }
            else
            {
                Console.WriteLine("Adding Contatc Is Fealed :-(");
            }
        }

         static void TestUpdateContact(int ID)
        {
            clsContacts contact = clsContacts.Find( ID);

            if(contact != null)
            {
                contact.FirstName = "SSiya";
                contact.LastName = "Caty";
                contact.Email = "FF.com";
                contact.Address = "SSSTTTFFF";
                contact.Phone = "902430932402";
                contact.DateOfBirth = DateTime.Now;
                contact.CountryID = 2;
                contact.ImagePath = string.Empty;

                if(contact.Save())
                {
                    Console.WriteLine("Update Contact Done Successfully. :-)");
                }
                else
                {
                    Console.WriteLine("Updateing Contact Is Failed :-(");
                }
            }
        }

         static void TestDeleteContact(int ID)
        {

            if (clsContacts.IsContactExist(ID))
            {
                if (clsContacts.Delete(ID))
                {
                    Console.WriteLine("Delete Contact done Successfully. :-)");
                }
                else
                {
                    Console.WriteLine("Deleting Contact Is Failed :-(");
                }
            }
            else
                Console.WriteLine($"Contact With ID : {ID} Was Not Found :-(");

           
            
        }

        static void ListContacts()
        {
            DataTable dt = clsContacts.GetAllContacts();

            foreach(DataRow Row in dt.Rows)
            {
                Console.WriteLine($"{Row["ContactID"]} - {Row["FirstName"]} - {Row["LastName"]}");
            }
        }

        static void IsContactExist(int ID)
        {
            if(clsContacts.IsContactExist(ID))
            {
                Console.WriteLine($"Contact With ID : {ID} Was Found :-)");
            }
            else
             Console.WriteLine($"Contact With ID : {ID} Was Not Found :-(");

        }


        //============================================== countries Test Functions ===============================//

        static void FindCountriesByID(int ID)
        {
            clsCountries Country = clsCountries.Find(ID);

            if (Country != null)
            {
                Console.WriteLine(" Country Was Found Successfully.");
                Console.WriteLine($"Country ID   : {Country.ID}");
                Console.WriteLine($"Country Name : {Country.CountryName}");
                Console.WriteLine($"Code         : {Country.Code}");
                Console.WriteLine($"Phone Code   : {Country.PhoneCode}");
            }
            else
            {
                Console.WriteLine("Country Was Not Found");
            }
        }

        static void FindCountryByName(string CountryName)
        {
            clsCountries Country = clsCountries.Find(CountryName);

            if (Country != null)
            {
                Console.WriteLine(" Country Was Found Successfully.");
                Console.WriteLine($"Country ID    : {Country.ID}");
                Console.WriteLine($"Country Name : {Country.CountryName}");
                Console.WriteLine($"Code         : {Country.Code}");
                Console.WriteLine($"Phone Code   : {Country.PhoneCode}");
            }
            else
            {
                Console.WriteLine("Country Was Not Found");
            }
        }

        static void AddNewCountry()
        {
            clsCountries Country = new clsCountries();

            Country.CountryName = "SSiyaHeart";
            Country.Code = "ZAS";
            Country.PhoneCode = "123";

            if (Country.Save())
            {
                Console.WriteLine($"Adding New Country with ID : {Country.ID} Done Successfully. ");
            }
            else
            {
                Console.WriteLine("Failed :-(");
            }
        }

        static void UpdateCountry(int ID)
        {
            clsCountries Country = clsCountries.Find(ID);

            if (Country != null)
            {
                Country.CountryName = "Algria";
                Country.Code = "ZAS";
                Country.PhoneCode = "123";

                if (Country.Save())
                {
                    Console.WriteLine($"Updating Country with ID : {Country.ID} Done Successfully. ");
                }
                else
                {
                    Console.WriteLine("Failed :-(");
                }
            }
        }

        static void DeleteCountry(int ID)
        {

            if (clsCountries.IsCountryExist(ID))
            {
                if (clsCountries.Delete(ID))
                {
                    Console.WriteLine("Success :-)");
                }
                else
                {
                    Console.WriteLine("Failed :-(");
                }
            }
            else
            {
                Console.WriteLine($"Country With ID : {ID} Was Not Found  :-(");
            }
           
        }

        static void ListCountries()
        {
            DataTable dt = clsCountries.ListCountries();

            foreach (DataRow Row in dt.Rows)
            {
                Console.WriteLine($"{Row["CountryID"]} - {Row["CountryNAme"]} - {Row["Code"]} - {Row["PhoneCOde"]}");
            }
        }

        static void IsCountryExistByID(int ID)
        {
            if(clsCountries.IsCountryExist(ID))
            {
                Console.WriteLine($"Country With ID : {ID} Was Found Successfully. :-)");
            }
            else
            { 
                Console.WriteLine($"Country With ID : {ID} Was Not Found  :-(");
            }
        }

        static void IsCountryExistByName(string Name)
        {
            if (clsCountries.IsCountryExistByName(Name))
            {
                Console.WriteLine($"Country With Name : {Name} Was Found Successfully. :-)");
            }
            else
            {
                Console.WriteLine($"Country With ID : {Name} Was Not Found  :-(");
            }
        }

    //-----------------------------------------------------------------------------------------------------//

        static void Main(string[] args)
        {
            // TestFindContacts(1);

            // TestAddNewContact();

            //TestUpdateContact(9);

            // TestDeleteContact(6);

            // ListContacts();

            //IsContactExist(100);

            //---------------------------------------------------//

            // FindCountriesByID(1);

              FindCountryByName("Morroco");

            // AddNewCountry();

            //   UpdateCountry(6);

           //  DeleteCountry(5);

           //  ListCountries();

            // IsCountryExistByID(6);

            // IsCountryExistByName("Spain");
            

            Console.ReadKey();

        }
    }
}
