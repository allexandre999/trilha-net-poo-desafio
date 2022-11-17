using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "654321", modelo: "Modelo 0", imei: "001970010100000", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "6542", modelo: "Modelo 1", imei: "001970110103050", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("TikTok");