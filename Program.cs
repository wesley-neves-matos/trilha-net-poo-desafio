using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("11975853654", "Modelo1", "111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("11988522953", "Modelo3", "444444", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
