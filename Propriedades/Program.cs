using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Program
    {
        public class Pessoa
        {
            private string _nome;
            public string nome 
            {
                get => _nome.ToUpper();
               

                set
                {
                    if(value == "")
                    {
                        throw new ArgumentException("O valor nome nao pode ser vazio");
                    }
                    _nome = value;
                }
            }
            public string Sobrenome { get; set; }
            public string NomeCompleted => $"{nome} {Sobrenome}".ToUpper();
            
               
            
            private int _idade;
            public int idade
            {
                get => _idade;

                set
                {
                    if(value < 0)
                    {
                        throw new ArgumentException("A idade nao pode ser menor q zero");
                    }
                    _idade = value;
                }
            }
            
               
            

            public void apresentar()
            {
                Console.WriteLine($"Nome: {NomeCompleted}, Idade: {idade}");
            }
        }
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.nome = "giovanni";
            p1.idade = 1;
            p1.Sobrenome = "lucas";
            p1.apresentar();
            Console.ReadLine();
        }
    }
}
