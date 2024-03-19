namespace Listov.Services
{
    internal class ReadOnlyDocument : Document
    {
        private string data;
        private string path;

        public ReadOnlyDocument(string path) : base(path)
        {
        }
    }
}
