using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao.Classes
{
    public class PrimeiraClasse
    {
        //O que é uma classe?
        //é um conjunto de propriedades e metodos que você pode extrair do mundo real para o mundo imaginario

        //O que é uma propriedade?
        //é uma variavel declarada com um tipo de dado, um modificador de acesso e com get/set

        //Ctrl + . -> importar namespace automaticamente

        // Modificadores de acessos
        // Private -> que você só pode visualizar a sua classe dentro dela mesma
        // Public -> você pode disponibilizar sua classe para outras acessarem

        //getters e setters
        //get -> extrair informação
        //set -> setar informação

        //Propriedades
        public string NomeDoUsuario { get; set; }

        public int Idade { get; set; }

        public int AnoNascimento { get; set; }


        //Construtores
        public PrimeiraClasse()
        {
            //Idade = 26;
            NomeDoUsuario = "Matheus";
            AnoNascimento = 1995;
        }

        public PrimeiraClasse(int idade)
        {
            Idade = idade;
        }

        public void CalcularIdadeAtual()
        {
            int anoAtual = 2021;

            Idade = anoAtual - AnoNascimento;
        }

        public static int Chamada()
        {
            int anoAtual = 2021;
            int anoNascimento = 1995;

            return anoAtual - anoNascimento;
        }
    }
}
