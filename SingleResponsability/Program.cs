using SingleResponsability;

try
{
    Console.Write("Please specify the file to convert to HTML: ");
    var fullFilePath = Console.ReadLine();
    FileProcessor fileProcessor = new FileProcessor(fullFilePath);
    TextProcessor textProcessor = new TextProcessor(fileProcessor);
    textProcessor.ConvertText();    
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.Write("Press any key to exit. ");
Console.ReadKey();

