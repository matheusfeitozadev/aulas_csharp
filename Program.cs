using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao
{
    class Program
    {
        

        static void Main(string[] args)
        {
            #region Prologo
            int idade = 0;
            //string nome = "";

            // = -> Operador de atribuição
            // + -> Soma de valores
            // ++ -> Incrementa o valor da variavel atual -> 1 -> ++ -> 2
            // -- -> Decrementa o valor da variavel atual -> 1 -> -- -> 0

            //idade++;
            //idade += 2;

            //idade--;
            //idade -= 2;

            #endregion

            #region Parte 1

            //executeVerification();

            #endregion

            #region Parte 2
            //int idade = 0;

            //Console.WriteLine("Digite sua idade:");
            //idade = Console.ReadLine();

            #endregion

            #region Parte 3 (Ciclo de repetição)
            // 0, 1

            #region Ciclo for
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Quantidade de execução: " + i.ToString() + "\n");

            //    executeVerification();
            //}
            #endregion

            #region Ciclo for (3 tentativas)

            //int tentativas = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Quantidade de execução: " + i.ToString() + "\n");

            //    var isAuthenticated = executeVerification();

            //    if(!isAuthenticated)
            //    {
            //        tentativas++;
            //    }

            //    if(tentativas == 3)
            //    {
            //        Console.WriteLine("Você atingiu o número de tentativas!");
            //        Console.ReadLine();
            //        break;
            //    }
            //}
            #endregion

            #region Ciclo While

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Quantidade de execução: " + i.ToString() + "\n");

            //    executeVerification();
            //}

            //int i = 0;

            //while (i < 2)
            //{
            //    Console.WriteLine("Quantidade de execução: " + i.ToString() + "\n");

            //    executeVerification();

            //    i++;
            //}

            //bool isAuthencated = true;

            //while (isAuthencated)
            //{
            //    //Console.WriteLine("Quantidade de execução: " + i.ToString() + "\n");

            //    isAuthencated = executeVerification();
            //}

            #endregion

            #region Do While

            //bool isAuthencated = true;

            //while (isAuthencated)
            //{
            //    //Console.WriteLine("Quantidade de execução: " + i.ToString() + "\n");

            //    isAuthencated = executeVerification();
            //}


            //do
            //{
            //    isAuthencated = executeVerification();
            //} while (isAuthencated);

            #endregion

            #region colecoes de dados List e Foreach

            //string texto = "";
            //int idade_number = 0;
            //bool verdadeiro = false;

            //float flt = 0;
            //double dbl = 0;
            //decimal dcm = 0;

            //List<string> nomes = new List<string>();
            //List<int> indexs = new List<int>();
            ////List<int> idades = new List<int>();

            ////int[] idades_array = new int[10];
            ////idades_array[0] = 26;

            //foreach(var index in indexs)
            //{
            //    nomes.RemoveAt(index);
            //}

            //nomes.Add("Sergio");
            //nomes.Add("Kevin");
            //nomes.Add("Wesley 1");
            //nomes.Add("Wesley 2");
            //nomes.Add("Joao");
            //nomes.Add("Elizandro");

            ////nomes.Remove("Kevin");
            //nomes.RemoveAt(1);
            //nomes.RemoveRange(1, 4);

            //foreach (var nome in nomes)
            //{
            //    Console.WriteLine("Nome: " + nome);
            //}


            #endregion

            #region Switch Case

            //bool isAuthenticated = false;

            //if (isAuthenticated == true)
            //{
            //    Console.WriteLine("Você está logado!");
            //}
            //else
            //{
            //    Console.WriteLine("Você NAO está logado!");
            //}

            //switch(isAuthenticated)
            //{
            //    case true:
            //        Console.WriteLine("Você está logado!");

            //        break;

            //    case false:
            //        Console.WriteLine("Você NAO está logado!");

            //        break;

            //   default:
            //        Console.WriteLine("Valor inválido!");
            //        break;
            //}

            #endregion

            #region Conversão de valores

            //string idadeStr = "true";
            //int number = 0;
            //bool isOK = false;
            //float real = 10.100f;

            //number = int.Parse(idadeStr);

            //if (number <= 18)
            //{
            //    Console.WriteLine("Menor de idade!");
            //}
            //else
            //{
            //    Console.WriteLine("Maior de idade!");
            //}

            //number.ToString();
            //isOK.ToString();

            //isOK = bool.Parse(idadeStr);

            //Cast
            //isOK = (bool)idadeStr;

            //var dec_float = float.Parse(real.ToString("00.00"));

            //var numero_sem_decimal = (int)real;

            //Console.ReadLine();

            #endregion

            #region Operadores matematicos

            //++ -- += -= *= /=

            int number1 = 10;
            int number2 = 20;
            int total = 0;

            total += number1 + number2;
            total *= number1 * number2;
            //total /= number1 / number2;
            total += number1 % number2;


            #endregion

            #endregion
        }

        static bool executeVerification()
        {
            string username = "";
            string password = "";

            Console.WriteLine("Username:");
            username = Console.ReadLine();

            Console.WriteLine("Password:");
            password = Console.ReadLine();

            getLoginAndPassword(username, password);

            var isAuthenticated = verificationUsername(username, password);

            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Seu usuário está vazio!");

                isAuthenticated = false;
            }
            else
            {
                if (isAuthenticated == true)
                {
                    Console.WriteLine("Você está logado!");
                }
                else
                {
                    Console.WriteLine("Você NAO está logado!");
                }
            }

            Console.ReadLine();
            Console.Clear();

            return isAuthenticated;
        }

        static void getLoginAndPassword(string username, string password)
        {
            string informacao = "";

            informacao = printInformation(username, password, informacao);

            Console.WriteLine(informacao);
        }

        static string printInformation(string username, string password, string informacao)
        {
            informacao = "Seu usuário é: " + username + "\n";
            informacao += "Sua senha é: " + password;

            return informacao;
        }

        static bool verificationUsername(string username, string password)
        {
            bool isAuthenticated = false;
            //string isAuthenticatedStr = "";

            // AND -> &&
            // OR -> ||
            // Equal -> ==
            // Not equal -> !=
            // Atrabuicao -> =
            // Negação -> !
            // Menor que -> <
            // Maior que -> >
            // Menor igual que -> <=
            // Maior igual que -> >=

            //isAuthenticated = username == "matheus" && password == "123";

            //isAuthenticatedStr = username == "matheus" && password == "123" ? "OK" : "NOK";

            //username = username.ToUpper();

            if (username.ToUpper() == "MATHEUS" && password == "123")
            {
                isAuthenticated = true;
            }

            return isAuthenticated;
        }

        static void stringPart()
        {
            string nome = "J  ";

            nome = nome.ToUpper();
            nome = nome.ToLower();

            nome.Replace("M", "Z");
            nome.Trim();

            string.Concat("", "", "", "");
            string.Concat("Seu usuário é: ", nome, "\n");

            //matheus
        }
    }
}
