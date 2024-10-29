using DesafioPOO.Models;

Iphone iphone = new Iphone("123456789", "Iphone 13", "123456789", 128);
Console.WriteLine("Iphone");
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Nokia nokia = new Nokia("987654321", "Nokia 1100", "987654321", 16);
Console.WriteLine("Nokia");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Jogo da Cobrinha");