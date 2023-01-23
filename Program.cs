using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Tijolinho", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.ListarAplicativos();
nokia.InstalarAplicativo("WhatsApp");
nokia.ListarAplicativos();
nokia.InstalarAplicativo("WhatsApp");
nokia.DesinstalarAplicativo("Chrome Browser");
nokia.ListarAplicativos();
nokia.Informacoes();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "5 câmeras", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.Informacoes();
