using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScoolBook.Interfaces
{
    public interface IBook
    {
        IBook Open();
        void Close();
        byte[] GetData();
    }
}
