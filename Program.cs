using LogicaProgramacao.Classes;
using LogicaProgramacao.Classes.Assembly;
using LogicaProgramacao.Classes.Assembly.Enum;
using LogicaProgramacao.Classes.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao
{
    class Program
    {
        // Console application = Script executado no prompt de comando
        // Quando houver necessidade de fazer alguma execução que não precise de interface gráfica

        //APP01 -> Enviam email de relatório -> Mac Control(Consumo de MAC, )

        // Task Schedule(APP01) -> 3 itens (Console application)

        //Parser Samsung ARD3 -> Console Application

        //Forms ou Console - Onde está o executavel? Bin/Debug || Release -> 

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

            #region Chamadas de classes

            //PrimeiraClasse primeiraClasse = new PrimeiraClasse();
            ////primeiraClasse.NomeDoUsuario = "Matheus feitoza";
            ////primeiraClasse.Idade = 10;

            ////primeiraClasse = new PrimeiraClasse(27);

            //primeiraClasse.CalcularIdadeAtual();

            //PrimeiraClasse.Chamada();

            //Console.WriteLine("Sua idade é: " + primeiraClasse.Idade);
            //Console.ReadLine();

            #endregion

            #region Chamadas de Classes PT 2

            //List<Customer> customers = new List<Customer>();

            //Customer customerPositivo = new Customer();
            //customerPositivo.Id = 54;
            //customerPositivo.CustomerName = "POSITIVO";
            //customerPositivo.Active = true;

            //Customer customerSamsung = new Customer();
            //customerSamsung.Id = 42;
            //customerSamsung.CustomerName = "SAMSUNG";
            //customerSamsung.Active = true;

            //customers.Add(customerPositivo);
            //customers.Add(customerSamsung);

            //foreach(var item in customers)
            //{
            //    string texto = "";

            //    texto += "Id: " + item.Id;
            //    texto += "\nCustomer Name: " + item.CustomerName;
            //    texto += "\nActive: " + item.Active;

            //    Console.WriteLine(texto);
            //    Console.WriteLine("______________________________");
            //}

            //List<Property> itensProperies = new List<Property>();

            //Customer customer = new Customer();
            //customer.Id = 54;
            //customer.CustomerName = "POSITIVO";
            //customer.Active = true;

            //Factory factory = new Factory();
            //factory.Id = 1;
            //factory.Name = "Jabil MTX";
            //factory.Active = true;

            //Property propriedade1 = new Property();
            //propriedade1.Id = 1;
            //propriedade1.PropertyName = "ISBIRTH";
            //propriedade1.PropertyValue = "TRUE";
            //propriedade1.Active = true;

            //Property propriedade2 = new Property();
            //propriedade2.Id = 1;
            //propriedade2.PropertyName = "BOARDLABEL";
            //propriedade2.PropertyValue = @"\\brmanm0loft01\Labels\teste.lwl";
            //propriedade2.Active = true;

            ////itensProperies.Add(propriedade1);
            ////itensProperies.Add(propriedade2);

            //Assembly assembly = new Assembly();
            //assembly.Id = 1;
            //assembly.AssemblyName = "POS1212A";
            //assembly.Customer = customer;
            //assembly.Factory = factory;
            ////assembly.Properties = itensProperies;
            //assembly.Properties = new List<Property>() { propriedade1, propriedade2 };
            //assembly.Active = true;

            ////Exibindo informações
            //string conteudo = "";

            //conteudo += string.Format("Assembly Name: {0}\n", assembly.AssemblyName);
            //conteudo += string.Format("Factory: {0} \n", assembly.Factory.Name);
            //conteudo += string.Format("Customer Name: {0} \n", assembly.Customer.CustomerName);

            //foreach(var item in assembly.Properties)
            //{
            //    conteudo += string.Format("Property: {0}, Value: {1} \n", item.PropertyName, item.PropertyValue);
            //}

            //Console.WriteLine(conteudo);





            #endregion

            #region Enum
            //Boxe boxe1 = new Boxe("POSBOX123", (int)StatusPalletEnum.Packed);

            //Boxe boxe2 = new Boxe("POSBOX123", (int)StatusPalletEnum.OnHold);

            //Boxe boxe3 = new Boxe("POSBOX123", (int)StatusPalletEnum.Partial);

            //Boxe boxe4 = new Boxe("POSBOX123", (int)StatusPalletEnum.Used);

            //Console.WriteLine((int)StatusPalletEnum.Packed);
            #endregion

            #region Files
            string path = @"C:\AiOLog.txt";

            var fileExists = File.Exists(path);

            File.Delete(path);
            File.Copy(path, @"D:\novo.txt", true);

            File.WriteAllText(path, "Teste Matheus");

            if (fileExists)
            {
                Console.WriteLine("Arquivo existe!");
            }
            else
            {
                Console.WriteLine("Arquivo não existe!");
            }

            #endregion

            #region Directory
            string dir = @"C:\Projetos\";

            var dirExists = Directory.Exists(dir);

            if(!dirExists)
            {
                Directory.CreateDirectory(dir);
            }

            //Directory.Delete(dir);

            var files = Directory.GetFiles(dir);

            foreach(var item in files)
            {
                try
                {
                    string serial = "";
                    string conteudo = "";

                    var strReadAllText = File.ReadAllText(item);
                    var strReadAllLines = File.ReadAllLines(item);

                    FileInfo fileInfo = new FileInfo(item);

                    //Char e String
                    // 'C' "C"

                    serial = fileInfo.Name.Split('.')[3];

                    conteudo += "C" + Constant.Customer + Environment.NewLine;
                    conteudo += "I" + Constant.Division + Environment.NewLine;
                    conteudo += "S" + serial + Environment.NewLine;
                    conteudo += "P" + Constant.Equipment + Environment.NewLine;
                    conteudo += "F" + Constant.Test + Environment.NewLine;
                    conteudo += "TP" + Environment.NewLine;

                    File.WriteAllText(dir + "parser01.txt", conteudo);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               

                Console.WriteLine(item);
            }

           

            //S - Serial
            //C - Customer
            //I - Divison
            //P - Equipement
            //F - Test
            //TP(Pass) ou TF(Fail)     

            

            #endregion


            Console.ReadLine();
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
