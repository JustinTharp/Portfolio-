// Program 0
// Justin Tharp
// CIS 200-01
//Due Date: 2/3/16

// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook
{
    public const int DEFAULT_YEAR = 2015; // Default copyright year

    private String _title;      // The book's title
    private String _author;     // The book's author
    private String _publisher;  // The book's publisher
    private int _copyrightYear; // The book's year of copyright
    private String _callNumber; // The book's call number in the library
    private bool _checkedOut;   // The book's checked out status

    // Precondition:  None
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(String theTitle, String theAuthor, String thePublisher,
        int theCopyrightYear, String theCallNumber)
    {
        // Establish default first in case invalid
        CopyrightYear = DEFAULT_YEAR;

        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        CallNumber = theCallNumber;

        ReturnToShelf(); // Make sure book is not checked out
    }

    public String Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }

        // Precondition:  None
        // Postcondition: The title has been set to the specified value
        set
        {
            _title = value;
        }
    }

    public String Author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return _author;
        }

        // Precondition:  None
        // Postcondition: The author has been set to the specified value
        set
        {
            _author = value;
        }
    }

    public String Publisher
    {
        // Precondition:  None
        // Postcondition: The publisher has been returned
        get
        {
            return _publisher;
        }

        // Precondition:  None
        // Postcondition: The publisher has been set to the specified value
        set
        {
            _publisher = value;
        }
    }

    public int CopyrightYear
    {
        // Precondition:  None
        // Postcondition: The copyright year has been returned
        get
        {
            return _copyrightYear;
        }

        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        set
        {
            if (value >= 0)
                _copyrightYear = value;
        }
    }

    public String CallNumber
    {
        // Precondition:  None
        // Postcondition: The call number has been returned
        get
        {
            return _callNumber;
        }

        // Precondition:  None
        // Postcondition: The call number has been set to the specified value
        set
        {
            _callNumber = value;
        }
    }

    // Precondition:  None
    // Postcondition: The book is checked out
    public void CheckOut(LibraryPatron patronDetails)
    {
        _checkedOut = true;
        Patron = patronDetails;
    }

    // Precondition:  None
    // Postcondition: The book is not checked out
    public void ReturnToShelf()
    {
        _checkedOut = false;
        Patron = null;
    }

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        return _checkedOut;
    }

    // Read-only property named Patron that returns a LibraryPatron reference
    public LibraryPatron Patron { get; private set; }


    // Precondition:  None
    // Postcondition: A string is returned presenting the libary book's data on separate lines
    public override string ToString()
    {
        return String.Format("Title: {0}{6}Author: {1}{6}Publisher: {2}{6}" +
            "Copyright: {3:D4}{6}Call Number: {4}{6}{5}",
            Title, Author, Publisher, CopyrightYear, CallNumber, patronstring(),
            System.Environment.NewLine);
    }
    // Precondition: None
    // Postcondition: A conditional determines what will be returned based on if a book is checked
    // out or not. 
    public string patronstring()
    {
        return String.Format("{0}", _checkedOut == true ? "Checked out by: " + Patron : "Not checked out");
    }
}
