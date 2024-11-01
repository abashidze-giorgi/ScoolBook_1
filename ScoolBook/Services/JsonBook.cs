using ScoolBook.Models;
using System;
using System.IO; // Для работы с файлами
using Newtonsoft.Json;
using System.Xml;

namespace ScoolBook.Services
{
    public class JsonBook
    {
        // Метод для создания JSON-файла
        public void CreateJsonFile(string filePath, Book book)
        {
            
        }

        // Метод для заполнения объекта Book данными из JSON
       

        // Внутренний класс для десериализации JSON
        private class BookData
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Description { get; set; }
            public string CoverImagePath { get; set; }
            public string FilePath { get; set; }
        }
    }
}
