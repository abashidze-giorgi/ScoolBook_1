using ScoolBook.Handlers;
using ScoolBook.Repositories;
using ScoolBook.Services;
using System;
using System.Windows.Forms;

namespace ScoolBook.forms
{
    public partial class MainPage : Form
    {
        private readonly BookService _bookService = new BookService();
        private readonly ImageHandler _imageHandler = new ImageHandler();
        private JsonBook _book = new JsonBook();
        private ArchiveBooks _archiveBooks = new ArchiveBooks();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_book_Click(object sender, EventArgs e)
        {
            string filePath = _bookService.CopyBook(sender, e);
            _imageHandler.CreateImageFromBook(filePath);
            _book.CreateJsonFile(filePath, null);
            _archiveBooks.Archive(filePath);
        }
    }
}
