namespace Listov.Services
{
    internal class Project
    {
        private List<Document> documents;
        private List<WritableDocument> writableDocuments;
        public Project()
        {
            documents = new List<Document>();
            writableDocuments = new List<WritableDocument>();
        }
        public void OpenAll()
        {
            foreach (var document in documents)
            {
                document.Open();
            }
        }
        public void SaveAll() 
        {
            foreach(var document in writableDocuments)
            {
                    document.Save();
            }
        }
        public void AddDocument(Document document)
        {
            this.documents.Add(document);
        }
        public void AddDocument(WritableDocument document)
        {
            this.writableDocuments.Add(document);
        }
    }
}
