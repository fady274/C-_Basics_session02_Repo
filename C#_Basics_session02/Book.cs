using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basics_session02
{
    internal class Book
    {
        #region Fields
        static int counter = 0;
        public int id;
        public string Title;
        public int pages;
        #endregion

        #region Constructor

        public Book(string title, int pages)
        {
            counter++;
            this.id = counter;
            this.Title = title;
            this.pages = pages;
        }

        #endregion

        #region Functions

        public override string ToString()
        {
            return $"ID : {this.id} \nTitle : {this.Title} \nPages : {this.pages}";
        }

        #endregion

    }
}
