using LendoArquivoJsonCSharp.Serialization;
using System;
using System.Runtime.Serialization.Json;
using System.Text;

namespace LendoArquivoJsonCSharp
{
    public class Program
    {

        static void Main(string[] args)
        {
            //var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\pessoa.json");
            var json = File.ReadAllText(@"D:\Estudo de Desenvolvimento\CSharp\TrabalhandoComArquivos\LendoArquivoJsonCSharp\pessoa.json");


            //Utilizando o System.Runtime.Serialization 

            var js = new DataContractJsonSerializer(typeof(List<Pessoa>));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));

            var pessoa = (List<Pessoa>)js.ReadObject(ms);


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Nome:" + pessoa[i].Nome);
                Console.WriteLine("Idade:" + pessoa[i].Idade);
                Console.WriteLine("Empresa:" + pessoa[i].Empresa);

                Console.WriteLine("----------------------");

            }

            Console.ReadKey();
        }
    }
}

