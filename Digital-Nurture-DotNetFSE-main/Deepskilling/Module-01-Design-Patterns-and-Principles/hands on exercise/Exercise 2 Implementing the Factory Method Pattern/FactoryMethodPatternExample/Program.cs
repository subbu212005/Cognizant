using FactoryMethodPatternExample;

DocumentFactory wordFactory=new WordFactory();
DocumentFactory pdfFactory=new PdfFactory();
DocumentFactory excelFactory=new ExcelFactory();

IDocument word=wordFactory.CreateDocument();
IDocument pdf=pdfFactory.CreateDocument();
IDocument excel=excelFactory.CreateDocument();

word.Open();
pdf.Open();
excel.Open();
