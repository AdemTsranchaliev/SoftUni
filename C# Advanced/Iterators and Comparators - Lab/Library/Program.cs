﻿using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    class Program
    {
        public static void Main()
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library library = new Library(bookOne, bookTwo, bookThree);
            library.ToString();
        }


    }
}
