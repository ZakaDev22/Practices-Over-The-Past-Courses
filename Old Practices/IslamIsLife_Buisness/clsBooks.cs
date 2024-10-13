using IslamIsLife_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IslamIsLife_Buisness
{
    public class clsBooks
    {
        // Make Data Buisness And Access For Books Class

        enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;

        // make all the members Nullabel.

        public int? BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public DateTime? PublicationDate { get; set; }
        public string Publisher { get; set; }

        public string Genre { get; set; }

        // Allows Null
        public string Description { get; set; }
        // Allows Null
        public int? Pages { get; set; }
        // Allows Null
        public string ImagePath { get; set; }





        public clsBooks()
        {
            this.BookID = null;
            this.Title = null;
            this.Author = null;
            this.ISBN = null;
            this.PublicationDate = null;
            this.Publisher = null;
            this.Genre = null;
            this.Description = null;
            this.Pages = null;
            this.ImagePath = null;

            this._Mode = enMode.AddNew;
        }

        private clsBooks(int? bookID, string title, string author, string iSBN, DateTime? publicationDate,
                                      string publisher, string genre, string description, int? pages, string imagePath)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            ISBN = iSBN;
            PublicationDate = publicationDate;
            Publisher = publisher;
            Genre = genre;
            Description = description;
            Pages = pages;
            ImagePath = imagePath;
            _Mode = enMode.Update;
        }

        private bool _AddNewBook()
        {
            this.BookID = clsBooksDataAccess.AddNewBook(this.Title , this.Author,this.ISBN, this.PublicationDate,
                                                        this.Publisher, this.Genre, this.Description, this.Pages, this.ImagePath);

            return (this.BookID != -1);
        }

        private bool _UpdateBook()
        {

            return clsBooksDataAccess.UpdateBook(this.BookID,this.Title, this.Author, this.ISBN, this.PublicationDate,
                                                        this.Publisher, this.Genre, this.Description, this.Pages, this.ImagePath);
        }

        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBook())
                        return true;
                    else
                        return false;

                case enMode.Update:
                    return _UpdateBook();

            }

            return false;
        }

        public static clsBooks FindBookWithID(int? BookID)
        {
            string    Title = null;
            string      Author = null;
            DateTime? PublicationDate  = null;
            string  ISBN = null;
            string    Publisher = null;
            string    Genre = null;
            string    Description = null;
            int?    Pages = null;
            string    ImagePath = null;

           
            bool IsFind = clsBooksDataAccess.FindBookByID(BookID, ref Title, ref Author, ref ISBN,
                                                                  ref PublicationDate, ref Publisher,ref Genre, ref Description,ref Pages, ref ImagePath);

            if (IsFind)
            {
                return new clsBooks(BookID, Title, Author, ISBN,  PublicationDate,  Publisher, Genre, Description,Pages,ImagePath);
            }
            else
                return null;
        }

        public static bool DeletePerson(int BookID)
        {
            return clsBooksDataAccess.DeleteBookWithID(BookID);
        }

        public static DataTable GetAllBooks()
        {
            return clsBooksDataAccess.GetAllBooks();
        }

        public static int GetAllBooksCount()
        {
            return clsBooksDataAccess.GetAllBooksCount();
        }
    }
}
