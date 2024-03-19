namespace Listov.Services
{
    internal class ReadOnlyDocument : Document
    {
        private string data;
        private string path;

        public ReadOnlyDocument(string path) : base(path)
        {
        }

        public override void Save()
        {
            throw new Exception("This file is read-only");
        }
    }
}
