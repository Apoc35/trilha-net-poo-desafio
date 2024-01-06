using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphoneusing DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone cel = new Iphone("123456","N2530","11111979111", 64);
cel.Ligar();
cel.ReceberLigacao();
cel.InstalarAplicativo("whatsup");

Console.WriteLine("\n");

Nokia cel2 = new Nokia("123456","N2530","11111979111", 64);
cel2.Ligar();
cel2.ReceberLigacao();
cel2.InstalarAplicativo("whatsup");