namespace Listov.Services
{
    internal class Document
    {
        protected string data = "";
        protected readonly string path;
        public Document(string path)
        {
            this.path = path;
            this.CheckExists();
        }
        public void Open()
        {
            this.data = File.ReadAllText(path);
        }
        public virtual void Save()
        {
            this.data += DateTime.Now.ToString();
            File.WriteAllText(path, data);
        }
        private void CheckExists()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
    }
}
