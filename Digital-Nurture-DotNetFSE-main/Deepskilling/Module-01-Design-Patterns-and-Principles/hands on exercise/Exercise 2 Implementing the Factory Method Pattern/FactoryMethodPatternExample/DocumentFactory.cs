namespace FactoryMethodPatternExample;

public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

public class WordFactory:DocumentFactory
{
    public override IDocument CreateDocument()=>new WordDocument();
}

public class PdfFactory:DocumentFactory
{
    public override IDocument CreateDocument()=>new PdfDocument();
}

public class ExcelFactory:DocumentFactory
{
    public override IDocument CreateDocument()=>new ExcelDocument();
}
