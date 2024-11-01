using ScoolBook.Models;
using System;
using System.IO; // Для работы с файлами
using Newtonsoft.Json;

namespace ScoolBook.Services
{
    public class JsonBook
    {
        // Метод для создания JSON-файла
        public void CreateJsonFile(string filePath, Book book)
        {
            string outputDirectory = Path.GetDirectoryName(filePath);
            string outputJsonPath = Path.Combine(outputDirectory, "MetaData.JSON");
            // Заполняем объект для сериализации
            var bookData = new BookData
            {
                Title = book?.Title ?? "",  // Если book null, то пустая строка
                Author = book?.Author ?? "",  // Если book null, то пустая строка
                Description = book?.Description ?? "",  // Если book null, то пустая строка
                CoverImagePath = book?.CoverImagePath ?? "",  // Если book null, то пустая строка
                FilePath = book?.FilePath ?? ""  // Если book null, то пустая строка
            };

            // Сериализуем объект в JSON
            string json = JsonConvert.SerializeObject(bookData, Formatting.Indented);

            // Сохраняем JSON в файл
            File.WriteAllText(outputJsonPath, json);
        }


        // Метод для заполнения объекта Book данными из JSON
        public Book LoadBookFromJson(string filePath)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(filePath))
                throw new FileNotFoundException("JSON файл не найден.", filePath);

            // Читаем содержимое JSON файла
            string json = File.ReadAllText(filePath);

            // Десериализуем JSON в объект BookData
            var bookData = JsonConvert.DeserializeObject<BookData>(json);

            // Создаем объект Book из данных
            return new PdfBook
            {
                Title = bookData.Title,
                Author = bookData.Author,
                Description = bookData.Description,
                CoverImagePath = bookData.CoverImagePath,
                FilePath = bookData.FilePath
            };
        }

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

