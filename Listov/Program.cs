using Listov.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Document document = new Document("../../../Assets/data.txt");
        WritableDocument writableDocument = new WritableDocument("../../../Assets/data2.txt");
        Project project = new Project();
        project.AddDocument(document);
        project.AddDocument(writableDocument);
        project.SaveAll();
    }
}