using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class Document
    {
        public string filename;
        public string text;
        
        public Document(string _filename, string _text)
        {
            filename = _filename;
            text = _text;
        }
    }
}
