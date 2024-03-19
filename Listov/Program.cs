using Listov.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Document document = new Document("../../../Assets/data2.txt");
        Document readOnlyDocument = new ReadOnlyDocument("../../../Assets/data.txt");
        Project project = new Project();
        project.AddDocument(document);
        project.AddDocument(readOnlyDocument);
        project.SaveAll();
    }
}