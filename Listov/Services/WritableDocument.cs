
namespace Listov.Services
{
    internal class WritableDocument : Document
    {
        public WritableDocument(string path) : base(path)
        {}
        public  void Save()
        {
            this.data += DateTime.Now.ToString();
            File.WriteAllText(path, data);
        }
    
    }
}
