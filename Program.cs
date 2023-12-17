using DesafioPOO.Models;

using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de Nokia
            Nokia nokia = new Nokia("123456789", "Nokia 8", "IMEI123", 64);

            // Testando métodos da classe abstrata Smartphone
            Console.WriteLine($"Número: {nokia.Numero}");
            Console.WriteLine($"Modelo: {nokia.Modelo}");
            Console.WriteLine($"IMEI: {nokia.IMEI}");
            Console.WriteLine($"Memória: {nokia.Memoria} GB");

            // Testando o método específico de Nokia
            nokia.InstalarAplicativo("WhatsApp");

            // Criando uma instância de Iphone
            Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 128);

            // Testando métodos da classe abstrata Smartphone
            Console.WriteLine($"Número: {iphone.Numero}");
            Console.WriteLine($"Modelo: {iphone.Modelo}");
            Console.WriteLine($"IMEI: {iphone.IMEI}");
            Console.WriteLine($"Memória: {iphone.Memoria} GB");

            // Testando o método específico de Iphone
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
