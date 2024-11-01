using ScoolBook.Interfaces;
using System;
using System.IO;

namespace ScoolBook.Models
{
    public class PdfBook : Book
    {
        public override void Close()
        {
            Console.WriteLine("Closing PDF book");
        }

        public override byte[] GetData()
        {
            return File.Exists(FilePath) ? File.ReadAllBytes(FilePath) : null;
        }

        public override IBook Open()
        {
            throw new NotImplementedException();
        }
    }
}
