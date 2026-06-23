namespace FactoryMethodPatternExample
{
    interface IDocument
    {
        void Open();
    }

    class WordDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening Word Document");
    }

    class PdfDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening PDF Document");
    }

    class ExcelDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening Excel Document");
    }
}
