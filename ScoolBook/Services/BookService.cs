using ScoolBook.Models;
using ScoolBook.Repositories;
using System;
using System.IO;
using System.Windows.Forms;

namespace ScoolBook.Services
{
    public class BookService
    {
        private readonly BookRepository _bookRepository = new BookRepository();

        public Book OpenBook(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("PDF file not found.", filePath);
            }

            Console.WriteLine("Opening PDF book");
            return _bookRepository.LoadBook(filePath);
        }

        public void SaveBook(PdfBook book)
        {
            _bookRepository.SaveBook(book, book.FilePath);
            Console.WriteLine("PDF книга сохранена.");
        }

        public void CloseBook(PdfBook book)
        {
            book.Close();
            Console.WriteLine("PDF книга закрыта.");
        }

        public string CopyBook(object sender, EventArgs e)
        {
            // Путь к корневой директории приложения
            string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Папка для книг
            string booksDirectory = Path.Combine(rootDirectory, "books");

            string destinationFilePath = "";

            // Проверка существования папки books, если нет - создание
            if (!Directory.Exists(booksDirectory))
            {
                Directory.CreateDirectory(booksDirectory);
            }

            // Открытие диалога для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Выберите книгу",
                Filter = "All Files|*.*" // Замените на нужный фильтр, если необходимо
            };

            // Проверка результата выбора файла
            if (openFileDialog.ShowDialog() == DialogResult.OK) // Если файл выбран
            {
                // Получение названия книги из выбранного файла
                string bookName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                // Папка для книги внутри папки books
                string bookFolder = Path.Combine(booksDirectory, bookName);

                // Создание папки для книги, если она не существует
                if (!Directory.Exists(bookFolder))
                {
                    Directory.CreateDirectory(bookFolder);
                }

                // Копирование файла в новую папку книги
                destinationFilePath = Path.Combine(bookFolder, Path.GetFileName(openFileDialog.FileName));

                // Проверка, существует ли файл
                if (File.Exists(destinationFilePath))
                {
                    // Запрос на подтверждение замены файла
                    var result = MessageBox.Show("Файл уже существует. Хотите заменить его?", "Подтверждение замены", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return destinationFilePath; // Выход из метода, если замена не требуется
                    }
                }

                // Копирование файла с возможностью перезаписи
                File.Copy(openFileDialog.FileName, destinationFilePath, true); // true для перезаписи файла, если он уже существует

                MessageBox.Show("Книга успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return null;
            }

            return destinationFilePath;
        }
    }
}
