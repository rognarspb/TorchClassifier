
using TorchClassifier;
using TorchClassifier.NamesDatabase;

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Names classifier");


var classifier = new NamesClassifier();
classifier.Run();