using DesafioPOO.Models;

Nokia nokia = new Nokia("12456789", "Note30", "111111111111", 64);
Console.WriteLine("Nokia:");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Iphone iphone = new Iphone("987654321", "iPhone 14", "222222222222", 128);
Console.WriteLine("Iphone:");
iphone.Ligar();
iphone.InstalarAplicativo("Apple Music");
