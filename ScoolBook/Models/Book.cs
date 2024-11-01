using ScoolBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoolBook.Models
{
    public abstract class Book : IBook
    {

        #region Properties
        // Приватные поля
        private string title;
        private string author;
        private string description;
        private string coverImagePath;
        private string filePath;

        // Публичные свойства с доступом к приватным полям
        public string Title
        {
            get => title;
            set => title = value; // Здесь можно добавить валидацию, если нужно
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Description
        {
            get => description;
            set => description = value; // Здесь можно добавить валидацию, если нужно
        }

        public string CoverImagePath
        {
            get => coverImagePath;
            set => coverImagePath = value; // Здесь можно добавить валидацию, если нужно
        }

        public string FilePath
        {
            get => filePath;
            set => filePath = value; // Здесь можно добавить валидацию, если нужно
        }

        #endregion
        public abstract void Close();
        public abstract byte[] GetData();
        public abstract IBook Open();
    }
}
