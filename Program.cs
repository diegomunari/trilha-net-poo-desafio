using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia celNokia = new Nokia("51 9 9999-9999", "Nokia 6120", "12345678", 128);
celNokia.Ligar();
celNokia.ReceberLigacao();
celNokia.InstalarAplicativo("Jogo da cobrinha");

Console.WriteLine("\n");

Iphone celIphone = new Iphone("51 9 8888-8888", "iPhone 14 Pro", "87654321", 256);
celIphone.Ligar();
celIphone.ReceberLigacao();
celIphone.InstalarAplicativo("Instagram");
