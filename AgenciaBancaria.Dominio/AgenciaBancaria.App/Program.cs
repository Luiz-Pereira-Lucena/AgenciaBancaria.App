using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Estanciando a class Endereco do Dominio > Endereco
                Endereco endereco = new Endereco("Rua test", "8666688", "Recife", "PE");

                //Estanciando a class Cliente do Dominio > Cliente
                Cliente cliente = new Cliente("Carla", "123456", "456789", endereco);

                //Estanciando a class ContaCorrente do Dominio > ContaCorrente
                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                string senha = "abc123456789";
                conta.Abrir(senha);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Sacar(10, senha);

                Console.WriteLine("Saldo: " + conta.Saldo);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
