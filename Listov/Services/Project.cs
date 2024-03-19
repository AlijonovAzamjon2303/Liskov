namespace Listov.Services
{
    internal class Project
    {
        private List<Document> documents;
        public Project()
        {
            documents = new List<Document>();
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
            foreach(var document in documents)
            {
                if (document is not ReadOnlyDocument)
                {
                    document.Save();
                }
            }
        }
        public void AddDocument(Document document)
        {
            this.documents.Add(document);
        }
    }
}
