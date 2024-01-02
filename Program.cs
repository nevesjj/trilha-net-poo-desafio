using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "5918258", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone (numero: "7328452", modelo: "Modelo 3", imei: "88888888", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");