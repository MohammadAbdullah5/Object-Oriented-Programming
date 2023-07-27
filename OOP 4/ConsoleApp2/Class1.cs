using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        public int price;
        public int bookmark;
        public bool isBorrowed;
        List<string> chapters;

        public Book(string title, string author, int pages, int price)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.price = price;
            this.bookmark = 0;
            this.isBorrowed = false;
            chapters[0] = "Intro";
            chapters[1] = "Chapter 1";
            chapters[2] = "Chapter 2";
            chapters[3] = "Chapter 3";
        }

        public string getChapter(int chapterNumber)
        {
            return chapters[chapterNumber - 1];
        }

        public int getBookMark()
        {
            return bookmark;
        }

        public void setBookMark(int pageNumber)
        {
            bookmark = pageNumber;
        }

        public int getBookPrice()
        {
            return price;
        }

        public void setBookPrice(int newPrice)
        {
            price = newPrice;
        }

        public bool isBorrowedOrNot()
        {
            return isBorrowed;
        }
    }
}
