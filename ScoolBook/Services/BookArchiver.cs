using System;
using System.IO;
using ScoolBook.Handlers;
using Newtonsoft.Json;

namespace ScoolBook.Services
{
    public class BookArchiver
    {
        private readonly ImageHandler imageHandler;
        private readonly JsonBook JsonBook;

        public BookArchiver()
        {
            imageHandler = new ImageHandler();
            JsonBook = new JsonBook();
        }

        public void CreateBookArchive(string bookFolder, string bookName)
        {
            
        }

        // Метод для извлечения архива книги
        public void ExtractBookArchive(string archivePath, string extractPath)
        {
           
        }

        // Метод для удаления архива
        public void DeleteBookArchive(string archivePath)
        {
            if (File.Exists(archivePath))
            {
                File.Delete(archivePath);
            }
        }
    }
}
