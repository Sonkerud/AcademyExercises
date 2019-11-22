using System;
using System.Collections.Generic;
using System.Text;

namespace PontusRep
{
    public class Book
    {


        public Book(int pageCount, string title)
        {
            Title = title;
            PageCount = pageCount;
        }

        private int pageCount;

        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }

            private set {
                if (value == null)
                {
                    throw new Exception("Hej hej");
                }
                title = value; }
        }


    }
}
