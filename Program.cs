using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone



Console.WriteLine("Smartphone Iphone");
Smartphone iphone1 = new Iphone("15", "Pro", "98745654", 256);
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia1 = new Nokia("Pé de boi", "Velho", "9884854", 16);
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Youtube");




