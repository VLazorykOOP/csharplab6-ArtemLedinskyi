using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.task1
{
    internal class DocumentCollection : IEnumerable<Document>
    {
        private List <Document> documents= new List<Document>();

        public void Add(Document document)
        {
            documents.Add(document);
        }
        public IEnumerator<Document> GetEnumerator()
        {
            return documents.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
