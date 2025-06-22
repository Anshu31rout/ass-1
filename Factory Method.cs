using System;

public interface IDocument
{
    void Open();
    void Close();
    void Save();
}

public class WordDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening Word document...");
    public void Close() => Console.WriteLine("Closing Word document...");
    public void Save() => Console.WriteLine("Saving Word document...");
}

public class PdfDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening PDF document...");
    public void Close() => Console.WriteLine("Closing PDF document...");
    public void Save() => Console.WriteLine("Saving PDF document...");
}

public class ExcelDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening Excel document...");
    public void Close() => Console.WriteLine("Closing Excel document...");
    public void Save() => Console.WriteLine("Saving Excel document...");
}

public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

public class WordDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new WordDocument();
}

public class PdfDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new PdfDocument();
}

public class ExcelDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new ExcelDocument();
}

public class FactoryMethodTest
{
    public static void Main(string[] args)
    {
        DocumentFactory wordFactory = new WordDocumentFactory();
        IDocument wordDoc = wordFactory.CreateDocument();
        wordDoc.Open();
        wordDoc.Save();
        wordDoc.Close();

        DocumentFactory pdfFactory = new PdfDocumentFactory();
        IDocument pdfDoc = pdfFactory.CreateDocument();
        pdfDoc.Open();
        pdfDoc.Save();
        pdfDoc.Close();

        DocumentFactory excelFactory = new ExcelDocumentFactory();
        IDocument excelDoc = excelFactory.CreateDocument();
        excelDoc.Open();
        excelDoc.Save();
        excelDoc.Close();
    }
}
