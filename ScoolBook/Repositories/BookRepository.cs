using ScoolBook.Interfaces;
using ScoolBook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoolBook.Repositories
{
    public class BookRepository
    {
        public PdfBook LoadBook(string filePath)
        {
            if (Path.GetExtension(filePath) == ".pdf")
            {
                return new PdfBook { FilePath = filePath }; // Загружаем PDF
            }

            throw new NotSupportedException("Неподдерживаемый формат файла.");
        }

        public void SaveBook(IBook book, string filePath)
        {
            File.WriteAllBytes(filePath, book.GetData());
        }

        public void DeleteBook(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

    }
}
