using System;
using System.IO;
using System.IO.Compression;

namespace ScoolBook.Services
{
    /// <summary>
    /// Класс для архивирования книг.
    /// </summary>
    public class ArchiveBooks
    {
        /// <summary>
        /// Архивирует PDF, PNG и JSON файлы по указанному пути и удаляет оригиналы.
        /// </summary>
        /// <param name="filePath">Путь к файлу (включая имя файла) для архивации.</param>
        public void Archive(string filePath)
        {
            string outputDirectory = Path.GetDirectoryName(filePath);
            if (outputDirectory == null)
                throw new ArgumentException("Путь к директории не может быть null", nameof(filePath));

            // Имя архивного файла с использованием имени директории
            string archiveFilePath = Path.Combine(outputDirectory, Path.GetFileName(outputDirectory) + ".gfavaz");

            // Создаем архивный файл
            using (FileStream fs = new FileStream(archiveFilePath, FileMode.Create))
            using (var archive = new ZipArchive(fs, ZipArchiveMode.Create, true))
            {
                // Архивируем PDF, PNG и JSON файлы
                ArchiveFiles(archive, outputDirectory, "*.pdf");
                ArchiveFiles(archive, outputDirectory, "*.png");
                ArchiveFiles(archive, outputDirectory, "*.json");
            }

            // Удаляем оригинальные файлы после архивирования
            DeleteOriginalFiles(outputDirectory, "*.pdf");
            DeleteOriginalFiles(outputDirectory, "*.png");
            DeleteOriginalFiles(outputDirectory, "*.json");
        }

        /// <summary>
        /// Добавляет файлы с указанным шаблоном в архив.
        /// </summary>
        /// <param name="archive">Архив, в который будут добавляться файлы.</param>
        /// <param name="directory">Директория для поиска файлов.</param>
        /// <param name="filePattern">Шаблон для поиска файлов.</param>
        private void ArchiveFiles(ZipArchive archive, string directory, string filePattern)
        {
            // Получаем файлы по заданному шаблону
            var files = Directory.GetFiles(directory, filePattern);
            foreach (var file in files)
            {
                // Добавляем файл в архив
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }
        }

        /// <summary>
        /// Удаляет оригинальные файлы с указанным шаблоном.
        /// </summary>
        /// <param name="directory">Директория для поиска файлов.</param>
        /// <param name="filePattern">Шаблон для поиска файлов.</param>
        private void DeleteOriginalFiles(string directory, string filePattern)
        {
            var files = Directory.GetFiles(directory, filePattern);
            foreach (var file in files)
            {
                File.Delete(file);
            }
        }
    }
}
