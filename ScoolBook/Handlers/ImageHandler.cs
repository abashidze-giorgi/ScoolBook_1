using Ghostscript.NET.Rasterizer;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ScoolBook.Handlers
{
    public class ImageHandler
    {
        public void CreateImageFromBook(string pdfFilePath)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(pdfFilePath))
            {
                throw new FileNotFoundException("PDF file not found.", pdfFilePath);
            }

            // Папка для сохранения изображения
            string outputDirectory = Path.GetDirectoryName(pdfFilePath);
            string outputImagePath = Path.Combine(outputDirectory, $"{Path.GetFileNameWithoutExtension(pdfFilePath)}_Page1.png");

            using (var rasterizer = new GhostscriptRasterizer())
            {
                // Открываем PDF-документ
                rasterizer.Open(pdfFilePath);

                int pageNumber = 1; // Первая страница
                int dpi = 300; // Разрешение в dpi

                // Получаем изображение первой страницы
                using (var image = rasterizer.GetPage(dpi, pageNumber))
                {
                    // Получаем размеры страницы
                    int width = image.Width;
                    int height = image.Height;

                    // Создаем новое изображение для сохранения с увеличенным размером
                    using (var resizedImage = new Bitmap(image, new Size(width * 2, height * 2)))
                    {
                        // Сохраняем изображение
                        resizedImage.Save(outputImagePath, ImageFormat.Png);
                    }
                }
            }
        }
    }
}
