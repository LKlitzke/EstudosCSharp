using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;

//using Ex1.Entities;
//using Ex1.Services;
//using Ex1.Entities.Enums;

namespace Ex1
{
    // Criado para Delegate
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {

        // Criado para Linq
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            #region Exemplos iniciais
            // Objeto {var} = new Objeto();

            // Exemplo 1: Triângulo
            /*Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2;
            double j = (y.A + y.B + y.C) / 2;

            Console.WriteLine(p + " : " + j);*/



            // Exemplo 2: Pessoas
            /*Pessoa a = new Pessoa(), b = new Pessoa();

            Console.Write("Dados da primeira pessoa:\nNome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.Write("Dados da segunda pessoa:\nNome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Pessoa mais velha: " + (a.Idade > b.Idade ? a.Nome : b.Nome));*/



            // Exemplo 3: Funcionários
            /*Funcionario a = new Funcionario(), b = new Funcionario();

            Console.Write("Dados do primeiro funcionário:\nNome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            a.Salario = double.Parse(Console.ReadLine());

            Console.Write("Dados do segundo funcionário:\nNome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            b.Salario = double.Parse(Console.ReadLine());

            double media = (a.Salario + b.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("F2"));*/



            // Exercício 4: Triângulo com método
            /*Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine(areaX + " : " + areaY);*/
            #endregion

            #region Exemplos com objetos
            // Exercício 5: Dados do produto
            /*Produto x = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            x.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto: " + x);

            Console.Write("Digite o número de produtos a serem adicionados: ");
            x.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados do produto: " + x);
            
            Console.Write("Digite o número de produtos a serem removidos: ");
            x.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados do produto: " + x);*/



            // Exercício 6: Medidas de um retângulo
            /*Retangulo x = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            x.Largura = double.Parse(Console.ReadLine());
            x.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + x.Area().ToString("F2"));
            Console.WriteLine("PERÍMETRO = " + x.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2"));*/



            // Exercício 7: Funcionário
            /*FuncionarioEX7 f = new FuncionarioEX7();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine(f);

            Console.Write("Digite a porcentagem a aumentar: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine(f);*/



            // Exercício 8: Alunos e notas
            /*Aluno a = new Aluno();

            Console.Write("Digite o nome: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as notas:");
            a.nota1 = double.Parse(Console.ReadLine());
            a.nota2 = double.Parse(Console.ReadLine());
            a.nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2"));

            if (a.NotaFinal() < 60.0)
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60 - a.NotaFinal() + " PONTOS"));
            }
            else
            {
                Console.WriteLine("APROVADO");
            }*/


            #endregion

            #region Objeto com Static
            // Exercício 9: Cotação do dólar -- MEMBRO ESTÁTICOS
            /*Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double compra = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Converter(cotacao, compra).ToString("F2"));*/
            #endregion

            #region Construtor
            // CONSTRUTOR: Cria um objeto a partir da entrada de variáveis
            // Ex.: public {NomeClasse}(tipo {var1}, tipo {var2}, [...]){  }

            // Exercício 10: Produto com CONSTRUTO
            /*Console.Write("Digite o nome do produto: ");
            string prod = Console.ReadLine();
            Console.Write("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Digete a quantidade: ");
            double qtd = double.Parse(Console.ReadLine());

            ProdutoEX10 p = new ProdutoEX10(prod, preco, qtd);

            Console.WriteLine(p);

            Console.Write("Digite o número de produtos a serem adicionados: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine(p);

            Console.Write("Digite o número de produtos a serem removidos: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine(p);*/
            #endregion

            #region Get e Set
            // ENCAPSULAMENTO: Modifica o acesso de um atributo/método 

            // Exercício 11:  Get e Set
            /*ProdutoEX11 p = new ProdutoEX11("TV", 500.00, 10);

            Console.WriteLine(p.getNome());
            //p.SetNome(Console.ReadLine());
            p.SetNome("ks3");
            Console.WriteLine(p.getNome());
            Console.WriteLine(p.getPreco());
            Console.WriteLine(p.getQuant());*/
            #endregion

            #region Properties e Auto Properties
            // PROPERTIES: Simplifica o get/set para objetos
            // Ex.: prop tab 2x -----> public tipo {var} {get; set;}

            // Exercício 12: Properties
            /*ProdutoEX12 p = new ProdutoEX12("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco.ToString("F2"));
            Console.WriteLine(p.Quant);*/



            // Exercício 13: Auto Properties
            /*ProdutoEX12 p = new ProdutoEX12("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco.ToString("F2"));
            Console.WriteLine(p.Quant);*/



            // Exercício 14: Conta Bancária
            /*Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            double valor;
            if (Console.ReadLine() == "s")
            {
                Console.Write("Entre o valor do depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
            }
            else
                valor = 0;

            ContaBancaria c = new ContaBancaria(num, nome, valor);


            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(c);

            Console.Write("\nEntre um valor para depósito: ");
            c.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(c);

            Console.Write("\nEntre um valor para saque: ");
            c.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(c);*/
            #endregion

            #region Nullable
            // NULLABLE: Permite que variáveis sejam do tipo nulo (usa-se os métodos .GetValueOrDefault() e .HasValue())
            // tipo? var == null;

            // Exercício 15: Nullable
            /*(double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault() + " " + y.GetValueOrDefault());
            Console.WriteLine(x.HasValue + " " + y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("O valor é nulo");

            double? z = null;
            double? zz = 10.0;
            double a = z ?? 5.0;
            double b = zz ?? 5.0;

            Console.WriteLine(a + " " + b);*/
            #endregion

            #region Vetores, Params e Foreach
            // VETORES: Unidimensional. Ex.: int[] vet = new int[tam];
            // PARAMS: Permite que métodos recebam valores nos argumentos. Ex.: int s1 = Calculadora.Soma(2, 3);
            // FOREACH: Loop alternativo ao for. Ex.: foreach(Pessoa p in PessoaList) { Console.WriteLine(p.Nome) }

            // Revisão: Vetores I
            /*int num = int.Parse(Console.ReadLine());
            double[] vet = new double[num];
            double media = 0;

            for(int i=0; i<num; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
                media += vet[i];
            }
            Console.WriteLine("Média: " + (media/num).ToString("F2"));*/



            // Revisão: Vetores II + Classe
            /*int num = int.Parse(Console.ReadLine());
            ProdutoVetor[] vet = new ProdutoVetor[num];

            double media = 0;


            for(int i = 0; i < num; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                vet[i] = new ProdutoVetor(nome, preco);
                media += vet[i].Preco;
            }

            Console.WriteLine("Preço médio: " + (media / num).ToString("F2"));*/



            // Revisão: Vetores III + Classe
            /*Quarto[] quarto = new Quarto[10];

            Console.Write("Quantos quartos serão alugados? ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("\nAluguel #"+(i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int qV = int.Parse(Console.ReadLine());

                quarto[qV] = new Quarto(nome, email);
            }

            Console.WriteLine("\nQuartos ocupados:");
            for(int i=0; i < quarto.Length; i++)
            {
                if (quarto[i] != null)
                    Console.WriteLine((i) + ": " + quarto[i].Nome + ", " + quarto[i].Email);
            }*/



            // Exercício 16: Params
            /*Console.Write("Quantos números a somar? ");
            //int s1 = Calculadora.Soma(new int[] { 2, 3 });
            int s1 = Calculadora.Soma(2, 3); // Com Params
            int s2 = Calculadora.Soma(new int[] { 2, 3,4,5 });

            Console.WriteLine("Soma total: " + s1 + " : " + s2);*/



            // Exercício 17: Foreach
            /*string[] vet = new string[] { "Lucas", "Klitzke", "Silva" };

            for(int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }
            foreach(string obj in vet)
            {
                Console.WriteLine(obj);
            }*/
            #endregion

            #region Listas (e métodos)
            // LISTAS: Associação de múltiplos objetos, como um vetor
            // Ex.: List<string> list = new List<string>();

            //--------------- --------------- --------------- ---------------
            // LISTAS
            //List<string> list2 = new List<string> { "Maria", "João" };
            /*
            List<string> list = new List<string>();

            //list.Add(new Produto(x,y,z));
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco");

            Console.WriteLine("Tamanho: " + list.Count);

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            // Find
            string s1 = list.Find(x => x[0] == 'A');                    /// LAMBDA: "Encontre uma string X tal que X[0] seja igual a 'A';
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Primeiro: " + s1 + " " + s2);

            // FindIndex
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("\nPrimeira pos: " + pos1);


            // FindLastIndex
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima pos: " + pos2);


            // FindAll
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // Remove
            list.Remove("Alex");
            Console.WriteLine("----------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------");

            // RemoveAll
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------");

            // RemovetAt
            list.RemoveAt(0);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Annaaaa");
            Console.WriteLine("----------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------");

            // RemoreRange
            list.RemoveRange(2, 3); // Remove 3 elementos da lista A PARTIR do index 2
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------");*/



            // Exercício Listas
            /*List<Empregado> lista = new List<Empregado>();

            Console.Write("Quantos empregados serão registrados? ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Empregado #" + (i+1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                lista.Add(new Empregado(id, nome, salario));
                Console.WriteLine("");
            }

            Console.Write("Qual ID receberá aumento? ");
            int idselect = int.Parse(Console.ReadLine());

            Empregado idAumento = lista.Find(x => x.Id == idselect);

            if(idAumento == null)
            {
                Console.WriteLine("Este usuário não existe.\n");
            }
            else
            {
                Console.Write("Entre com a porcentagem: ");
                double pct = double.Parse(Console.ReadLine());
                // Selecionar método de um objeto dentro de uma lista
                idAumento.AumentarSalario(pct);
            }

            Console.WriteLine("\nLista de empregados:");
            foreach(Empregado obj in lista)
            {
                Console.WriteLine(obj);
            }*/
            #endregion

            #region Matrizes
            // VETORES: Bidimensional (ou mais). Ex.: int[,] mat = new int[tam1,tam2];

            // Revisão Matrizes I
            /*double[,] mat = new double[2, 3];

            // Length
            Console.WriteLine(mat.Length);

            // Rank (Quantidade de linhas)
            Console.WriteLine(mat.Rank);

            // GetLength (Contagem da 1º Dimensão (index 0)
            Console.WriteLine(mat.GetLength(0));

            // GetLength (contagem da 2º Dimensão (index 1)
            Console.WriteLine(mat.GetLength(1));*/



            // Revisão Matrizes II
            /*int num = int.Parse(Console.ReadLine());
            int[,] mat = new int[num, num];

            for(int i=0; i < num; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                for (int j = 0; j < num; j++)
                {
                    mat[i, j] = int.Parse(v[j]);
                }
            }
            int quantNeg = 0;

            Console.WriteLine("\nDiagonal principal:");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == j)
                        Console.Write(mat[i, j] + " ");
                    if (mat[i, j] < 0)
                        quantNeg++;
                }
            }
            Console.WriteLine("\nNúmeros negativos: " + quantNeg);*/



            // Revsião Matrizes III
            /*int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];
            for(int i = 0; i < M; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                for(int j=0;j< N; j++)
                {
                    mat[i, j] = int.Parse(v[j]); 
                }
            }
            Console.Write("Qual número procurar? ");
            int proc = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(mat[i,j] == proc)
                    {
                        Console.WriteLine("Posição: " + i + ", " + j);
                        if (j > 0) Console.WriteLine("\nEsq: " + mat[i, j - 1]);
                        if (j < N - 1) Console.WriteLine("Dir: " + mat[i, j + 1]);
                        if (i > 0 ) Console.WriteLine("Acima: " + mat[i - 1, j]);
                        if (i < M - 1) Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                    }
                }
            }*/
            #endregion

            #region Operações com String
            // STRING
            /* string str = "testestetest";
            bool b1 = String.IsNullOrEmpty(str);

            Console.WriteLine(b1);*/
            #endregion

            #region Enumerable e Composição
            // ENUMERABLE: Enumerar algum atributo de objeto. Deve-se usar Enum na classe.
            // Ex.: WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            // COMPOSIÇÃO: Classes que derivam de outra.

            // Enum
            /*Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);*/



            // Exercício Composição e Enum
            /*Console.Write("Digite o nome do departamento: ");
            string deptName = Console.ReadLine();
            Console.Write("Digite os dados:\n");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Nível: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: ");
            double salary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, salary, dept);

            Console.Write("Quantos contratos? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nDados do contrato #" + (i + 1) + ":");
                Console.Write("Data (yy/mm/yyyy): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duração (horas): ");
                double hours = double.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("Mês e ano para calcular ganho (mm/yyyy): ");
            string[] date1 = Console.ReadLine().Split('/');
            int month = int.Parse(date1[0]);
            int year = int.Parse(date1[1]);

            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Department.Name);
            Console.WriteLine("Ganho em " +  month + "/" + year + " = " + worker.Income(year, month).ToString("F2"));*/
            #endregion

            #region Algoritmos aleatórios
            /*int x = 36;
            int y = 7;
            while(x != y){
                if (x > y) x -= y;
                else
                {
                    y -= x;
                    Console.WriteLine(y);
                }
               
            }*/


            /*try
            {
                throw new ArithmeticException("B");
                Console.WriteLine("A");
            }
            catch (Exception e)
            {
                Console.WriteLine("C");
            }*/
            #endregion

            #region Composição e Enum com StringBuilder
            // STRINGBUILDER: Mutável, pode-se adicionar ou remover substrings em sua formação (serve no .ToString())

            // Composição c/ StringBuilder
            /*Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow, that's awesome");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travelling to New Zealand",
                "I'm going to visit this wordeful conutry",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/09/2018 13:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);
            p2.AddComment(c1);
            p2.AddComment(c2);

            Console.WriteLine(p1);
            Console.WriteLine(p2);*/



            // Desafio de Composição e Enum
            /*Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birthdate (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client cli = new Client(name, email, birth);
            Order2 order = new Order2(DateTime.Now, status, cli);

            Console.Write("\n How many items to this order? ");
            int items = int.Parse(Console.ReadLine());

            for(int i = 0; i < items; i++)
            {
                Console.WriteLine($"Enter {i+1} item data:");
                Console.Write("Product name: ");
                string nameItem = Console.ReadLine();
                Console.Write("Product Price: ");
                double priceItem = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantItem = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Product prod = new Product(nameItem, priceItem);
                OrderItem orderItem = new OrderItem(quantItem, priceItem, prod);
                order.AddItem(orderItem);
            }

            Console.WriteLine("SUMMARY: ");
            Console.WriteLine(order);*/
            #endregion

            #region Herança, DownCasting e Upcasting
            // HERANÇA: Subclasses que derivam de uma superclasse.
            // UPCASTING: Uma subclasse torna-se uma superclasse. Ex.: Account acc2 = new BusinessAccount(1003, "BOB", 0.0, 200.0);
            // DOWNCASTING: Uma superclasse torna-se uma subclasse. Ex.: BusinessAccount acc5 = acc3 as BusinessAccount;
            // Obs.: Usa-se "as" e "is" como forma alternativa de casting

            /*BusinessAccount account = new BusinessAccount(8080, "Lucas", 9000.00, 200.00);
            Console.WriteLine(account.Balance);*/



            /*Account acc = new Account(1001, "Alex", 1000.00);
            BusinessAccount Bacc = new BusinessAccount(1002, "Maria", 500.00, 1000.00);

            // UPCASTING
            Account acc1 = Bacc;
            Account acc2 = new BusinessAccount(1003, "BOB", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Lucass", 0.0, 500.00);


            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            // FALHA: BusinessAccount acc5 = (BusinessAccount)acc3;
            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // Forma alternativa de casting
                acc5.Loan(200.00);
                Console.WriteLine(("Loan"));
            }
            if(acc3 is SavingsAccount)
            {
                //avingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }*/

            #endregion

            #region Sobreposição, Virtual, Override e Base
            // VIRTUAL -> Presente na superclasse para permitir que sobreponha e seja sobreposto
            // OVERRIDE -> Garante que a subclasse herde um método porém tenha as próprias regras
            // BASE -> Chama o método da superclasse e depois executa o método da subclasse
            // SEALED -> Impede que uma classe seja herdada // Impede que um método seja novamente sobreposto

            /*Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Bob", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);*/
            #endregion

            #region Polimorfismo
            // POLIMORFISMO -> Permite instanciar um objeto de tipo diferente a partir do Upcasting e Downcasting
            // Ex.: Account acc = new BusinessAccount(x,y,z);

            // Exercício 1
            /*List<Employee> employeesList = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced (y/n)? ");
                string outSourced = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());
                if(outSourced == "y" || outSourced == "Y")
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine());
                    Employee outEmployee = new OutsourcedEmployee(name, hours, value, addCharge);
                    employeesList.Add(outEmployee);
                    Console.WriteLine("\n");
                    continue;
                }
                Console.WriteLine("\n");
                Employee employee = new Employee(name, hours, value);
                employeesList.Add(employee);
            }

            Console.WriteLine("PAYMENTS:");
            foreach(Employee emp in employeesList)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"));
            }*/



            // Exercício 2
            /*List<Product2> prodList = new List<Product2>();
            Console.Write("Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string Prodtype = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(Prodtype == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    prodList.Add(new UsedProduct(name, price, manufDate));
                    continue;
                }
                else if(Prodtype == "i")
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    prodList.Add(new ImportedProduct(name, price, fee));
                    continue;
                }
                else
                {
                    prodList.Add(new Product2(name, price));
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach(Product prod in prodList)
            {
                Console.WriteLine(prod.priceTag());
            }*/
            #endregion

            #region Classes e Objetos Abstratos
            // -> CLASS ABSTRATA: Só é possível instanciar subclasses, impedindo a criação de uma classe genérica e garantindo a herança TOTAL
            // Usa-se "abstract" como modificador de classe
            // Ex.: É possível criar BusinessAccount e SavingsAccount, mas não Account

            /*List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine($"Shape {i+1} data:");
                Console.Write("Rectangle or Circle (r/c)?: ");
                string shape = Console.ReadLine();
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(shape == "r")
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }
                Console.WriteLine("");
            }
            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape sh in shapes)
            {
                Console.WriteLine(sh.Area().ToString("F2"));
            }*/



            // Desafio
            /*List<TaxPayer> taxesList = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or company (i/c)? ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());
                if(type == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine());
                    taxesList.Add(new Individual(healthExp, name, income));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numEmp = int.Parse(Console.ReadLine());
                    taxesList.Add(new Company(numEmp, name, income));
                }
                Console.WriteLine("");
            }
            Console.WriteLine("TAXES PAID:");
            double aux = 0.0;
            foreach(TaxPayer tx in taxesList)
            {
                Console.WriteLine(tx.Name + ": $ " + tx.Taxes().ToString("F2"));
                aux += tx.Taxes();
            }

            Console.WriteLine("TOTAL TAXES: $ " + aux.ToString("F2"));*/
            #endregion

            #region Tratamento de Exceções
            // TRY -> Bloco de comandos do código que pode causar a exceção
            // CATCH -> Bloco de códigos para agir na exceção
            // FINALLY -> Bloco de código a ser executado INDEPENDENTEMENTE de ter ocorrido erro ou não.
            // Obs.: É importante especificar qual tipo de exception pode ser lançada, ao invés de um tipo genérico
            // Para personalizar um Exception, deve-se criar uma classe específica cuja herança é de uma superclasse de exception
            /* Ex.:
            class DomainException : ApplicationException 
            {
               public DomainException(string message) : base(message) { }
            }*/


            /*try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("FORMAT ERROR!" + e.Message);
            }*/


            // Exercício com Finally
            /*try
            {
                Console.Write("Room Number: ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Check-in Date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation resv = new Reservation(room, checkIn, checkOut);
                Console.WriteLine("Reservation: " + resv);

                Console.WriteLine("\n\nEnter data to update the reservation:");
                Console.Write("Check-in Date (dd/MM/yyyy): ");
                DateTime UPDcheckIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date (dd/MM/yyyy): ");
                DateTime UPDcheckOut = DateTime.Parse(Console.ReadLine());

                resv.UpdateDates(UPDcheckIn, UPDcheckOut);
                Console.WriteLine("Reservation: " + resv);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }*/



            // Desafio de Exceções
            /*try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine());

                AccountExc acc = new AccountExc(num, name, balance, limit);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                acc.Withdraw(amount);

                Console.WriteLine("New Balance: " + acc.Balance.ToString("F2"));
            }
            catch(DomainException e)
            {
               Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }*/
            #endregion

            #region Arquivos
            // FILE -> Membros estáticos, é mais simples porém executa uma verificação de segurança
            // FILEINFO -> Membros instanciados, é mais rápido e aplicável apenas quando o desempenho importa
            // DIRECTORY -> Operações com pastas, como o File;
            // DIRECTORYINFO -> Operações com pastas, como o Fileinfo;
            // PATH -> Operações sobre string de paths de arquivos
            // Precisa do System.IO;
            // File/Fileinfo ---> FileStream ---> FileReader

            // File e Fileinfo
            /*string sourcePath = @"C:\Users\lucas\source\repos\Estudos\Ex1\Ex1\file1.txt";
            string targetPath = @"C:\Users\lucas\source\repos\Estudos\Ex1\Ex1\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }*/



            // Utilizando o FileStream e FileReader
            /*string path = @"C:\Users\lucas\source\repos\Estudos\Ex1\Ex1\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);
                sr = File.OpenText(path); // Cria implicitamente o StreamReader no FileStream

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }catch(IOException e)
            {
                Console.WriteLine("An error occured! " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }*/



            // Aplicando o "using"
            /*string path = @"C:\Users\lucas\source\repos\Estudos\Ex1\Ex1\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred! " + e.Message);
            }*/



            // StreamWriter
            /*string sourcePath = @"C:\Users\lucas\source\repos\Estudos\Ex1\Ex1\file1.txt";
            string targetPath = @"C:\Users\lucas\source\repos\Estudos\Ex1\Ex1\file3.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred! " + e.Message);
            }*/



            // Directory e DirectoryInfo
            /*string sourcePath = @"C:\Users\lucas\source\repos\Estudos\Ex1\Ex1\myfolder";
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFiles:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(sourcePath + "\\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred! " + e.Message);
            }*/



            // Path
            /*string path = @"C:\Users\lucas\source\repos\Estudos\Ex1\Ex1\file1.txt";

            Console.WriteLine("GetSeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("File path: " + Path.GetFileName(path));
            Console.WriteLine("File extension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Full path: " + Path.GetFullPath(path));
            Console.WriteLine("Temp path: " + Path.GetTempPath());*/



            // Exercício
            /*Console.Write("Enter file path: ");
            string sourcePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourcePath + "\\file.csv");
                string outputPath = sourcePath + "\\out";
                string outputFile = outputPath + "\\summary.csv";

                Directory.CreateDirectory(outputPath);

                using (StreamWriter sw = File.AppendText(outputFile))
                {
                    foreach(string line in lines)
                    {
                        string[] items = line.Split(',');
                        string name = items[0];
                        double value = double.Parse(items[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(items[2]);

                        sw.WriteLine(name + ", " + (value * quantity).ToString("F2"));
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred! " + e.Message);
            }
            finally
            {
               // piu piu 
            }*/
            #endregion

            #region Interfaces
            // INTERFACE -> Constitui operações que devem ser realizadas por classes

            // Exemplo sem/com Interface
            /*Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime carPickup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime carReturn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine());
            CarRental rental = new CarRental(carPickup, carReturn, new Vehicle(model));

            RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService()); // Com interfaces: Adiciona o 3º parâmetro
            rentalService.processInvoice(rental);

            Console.WriteLine("\nINVOICE:");
            Console.WriteLine(rental.Invoice);*/



            // Exercício
            /*Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract Value: ");
            double value = double.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            Console.Write("Enter number of installments: ");
            int numInstallments = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalService());
            contractService.processContract(contract, numInstallments);

            Console.WriteLine("INSTALLMENTS:");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment.ToString());
            }*/



            // Aplicação de Interface + Herança
            // Troca Shape s1 por IShape s1 
            /*IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);*/



            // Problema do diamante (Quando uma subclasses herda de duas superclasses, tal qual essas são interfaces de uma outra classe.
            /*Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dessertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());*/



            // IComparable
            /*string path = @"C:\Users\lucas\source\repos\Estudos\Ex1\Ex1\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario3> list = new List<Funcionario3>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario3(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Funcionario3 func in list)
                    {
                        Console.WriteLine(func);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(e.Message);
            }*/
            #endregion

            #region Generics
            // Trocando tudo de int para OBJECT para testar
            // GENERICS -> Parametriza métodos, classes e interfaces. Conhecido como tipo T (PODE SER QUALQUER LETRA)
            // A lógica é determinar um tipo genérico para o Service, e então no programa principal eu defino qual o tipo (int aqui)

            /*try
            {
                PrintService<int> printService = new PrintService<int>();
                Console.Write("How many values? ");
                int num = int.Parse(Console.ReadLine());

                for (int i = 0; i < num; i++)
                {
                    printService.addValue(int.Parse(Console.ReadLine()));
                }

                int a = printService.first();
                int b = a + 2;

                printService.print();
                Console.Write("\nFirst: " + printService.first());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/



            // Restrições do Generics (adicionar no service where T: IComparable
            /*List<Product3> list = new List<Product3>();

            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1]);

                Product3 product3 = new Product3(name, price);

                list.Add(product3);
            }

            CalculationService calculationService = new CalculationService();

            Product3 max = calculationService.max(list);

            Console.WriteLine("Max: " + max);*/
            #endregion

            #region GetHashCode e Equals
            // GETHASHCODE -> Gera um código para um objeto, é mais rápido que a.Equals(b) porém não é 100% funcional.

            /*ClientHash a = new ClientHash { Name = "Maria", Email = "maria@gmail.com" };
            ClientHash b = new ClientHash { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b)); // Retorna true pois o Equals está baseado somente no atributo EMAIL
            Console.WriteLine(a == b); // Retorna false pois a referência de memória é diferente*/
            #endregion

            #region HashSet e SortedSet
            // Não admite repetições, os elementos NÃO possuem posição, acesso, inserção e remoção são mais rápidos
            // Oferece operações como intereseção, união e diferença
            // HASHSET -> Armazenamento em uma tabela hash, RÁPIDO O(1), Ordem dos elementos não é garantida
            // SORTEDSET -> Armazenamento em árvore, RÁPIDO O(logN), Elementos ordenados no IComparer<T>
            // Métodos: Add, Clear, UnionWith(other), IntersectWith(other), ExceptWith(other), Remove(T), RemoveWhere(Predicate)

            /*HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Ndsadas"));

            foreach(string str in set)
            {
                Console.WriteLine(str);
            }*/



            // Operações do SortedSet
            /*SortedSet<int> a = new SortedSet<int>() { 10, 0, 2, 4, 5, 6, 8 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);

            // União
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // Interseção
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // Diferença
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);*/



            // Comparação de Tipo referência e Tipo Valor
            /*HashSet<Product4> a = new HashSet<Product4>();
            a.Add(new Product4("TV", 900.0));
            a.Add(new Product4("Notebook", 1700.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product4 prod = new Product4("Notebook", 1700.0);
            Console.WriteLine(a.Contains(prod)); // Sem implementar o GetHashCode/Equals o retorno é falso por causa da REFERÊNCIA

            Point point = new Point(5, 10);
            Console.WriteLine(b.Contains(point)); // Retorna verdadeiro por causa do VALOR*/



            // Exercício com leitura de arquivo
            /*Console.Write("Enter file path: ");
            string path = Console.ReadLine();

            HashSet<LogRecord> list = new HashSet<LogRecord>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        LogRecord logRecord = new LogRecord(name, instant);
                        list.Add(logRecord);

                        Console.WriteLine(line[0] + " " + line[1]);
                    }
                }

                Console.WriteLine("Count: " + list.Count);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }*/



            // Desafio
            /*HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int num = int.Parse(Console.ReadLine());

            for (int j = 0; j < num; j++)
            {
                int id = int.Parse(Console.ReadLine());
                courseA.Add(id);
            }

            Console.Write("How many students for course B? ");
            num = int.Parse(Console.ReadLine());

            for (int j = 0; j < num; j++)
            {
                int id = int.Parse(Console.ReadLine());
                courseA.Add(id);
            }

            Console.Write("How many students for course C? ");
            num = int.Parse(Console.ReadLine());

            for (int j = 0; j < num; j++)
            {
                int id = int.Parse(Console.ReadLine());
                courseA.Add(id);
            }
            courseA.UnionWith(courseB);
            courseA.UnionWith(courseC);
            Console.WriteLine("Total Students: " + courseA.Count);*/
            #endregion

            #region Dictonary e SortedDictionary
            // HASH -> Par chave/valor
            // Não admite repetições do objeto chave, a indexação é sua chave, é RÁPIDÃO
            // a diferença com o SortedDictionary é como no HashSet/SortedSet
            // Métodos: dictionary[key], Add(key, value), Clear(), Count, ContainsKey(key), ContainsValue(value), Remove(key)

            /*Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "Maria";
            cookies["email"] = "Maria@gmail.com";
            cookies["phone"] = "99223111";
            cookies["phone"] = "12345670"; // Subscreve o valor para a chave "phone"

            Console.WriteLine(cookies["email"]);

            // Remove
            cookies.Remove("email");
            //Console.WriteLine(cookies["email"]);

            foreach(KeyValuePair<string,string> item in cookies) // Pode substituir KeyValuePair por "var"
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }*/



            // Desafio Dictionary
            /*Console.Write("Enter file path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> map = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int count = int.Parse(line[1]);
                        if (map.ContainsKey(name))
                        {
                            map[name] += count;
                        }
                        else
                        {
                            map.Add(name, count);
                        }

                        Console.WriteLine(line[0] + " " + line[1]);
                    }
                }
                Console.WriteLine("\n\n");
                foreach(KeyValuePair<string, int> item in map)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }*/
            #endregion

            #region Extension Methods
            // Cria um método de extensão ESTÁTICO, devendo adicionar "static" no arquivo de extensão e a referência do objeto "this <type> thisObj"

            // Exemplo 1 - Novo Método para DateTime
            /*DateTime dt = new DateTime(2021, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());



            // Exemplo 2 - Novo método para int
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));*/
            #endregion

            #region Expressões Lambda
            // Expressão Lambda -> Realiza uma função anônima, sem precisar especificar o tipo e nem declarar variáveis
            // PADRÃO ----> (variavel1, variavel2) => (expressão resultante)
            // Cálculo Lambda -> Formalismo matemático base da programação funcional

            /*List<Product5> list = new List<Product5>();

            list.Add(new Product5("TV", 900.00));
            list.Add(new Product5("Notebook", 1200.00));
            list.Add(new Product5("Tablet", 450.00));

            //Comparison<Product5> comp = CompareProducts;
            //Comparison<Product5> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); // Função lambda com delegate

            //list.Sort(comp); // Ao invés de utilizar IComparable, usa-se Comparison<T>
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // Expressão (inline) diretamente na chamada do sort

            foreach(Product5 p in list)
            {
                Console.WriteLine(p);
            }*/
            #endregion

            #region Delegates
            // DELEGATE -> Referência para métodos com Type Safety
            // Pré-definidos: Action, Func, Predicate
            // MULTICAST DELEGATES -> Adiciona referências de mais de um método, utilizando o +=
            /*double A = 10;
            double B = 12;

            BinaryNumericOperation op = CalculationService.Sum; // Referencia a função criada ANTES da função Main()
            BinaryNumericOperation op2 = CalculationService.Max;
            //BinaryNumericOperation op3 = CalculationService.Square; // Dá erro pois a assinatura requer 2 argumentos doubles

            BinaryNumericOperation op4 = CalculationService.Sum;
            op4 += CalculationService.Max; // MULTICAST DELEGATE

            double result = CalculationService.Sum(A, B);
            double result2 = CalculationService.Square(A);
            double result3 = op.Invoke(A, B);
            double result4 = op2(A, B);
            double result5 = op4(A, B); // Utilizando Multicast delegate

            Console.WriteLine(
                result + " "
                + result2 + " "
                + result3 + " "
                + result4 + " "
                + result5);*/



            // PREDICATE -> Recebe um objeto T e retorna booleano
            /*List<Product5> list = new List<Product5>();
            list.Add(new Product5("Tv", 900.00));
            list.Add(new Product5("Mouse", 50.00));
            list.Add(new Product5("Tablet", 350.50));
            list.Add(new Product5("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.00); // Por Lambda
            //list.RemoveAll(ProductTest); // Por chamada de delegate

            // ACTION -> Representa um método void que recebe zero ou mais argumentos (até 16 sobrecargas)
            //list.ForEach(UpdatePrice);

            Action<Product5> act = UpdatePrice;
            list.ForEach(act); // Chamada através de delegate

            Action<Product5> act2 = p => { p.Price += p.Price * 0.1; }; // COM CHAVES INDICA Q A EXPRESSÃO LAMBDA NÃO RETORNA NADA!!
            list.ForEach(act2); // Chamada através de lambda

            foreach (Product5 p in list)
            {
                Console.WriteLine(p);
            }

            // FUNC -> Representa um método que recebe zero ou mais argumentos, e retorna um valor (Exatamente como o Action, mas com return)
            // Possui até 16 sobrecargas. Precisa declarar o System.Linq

            // Método normal
            //List<string> result = list.Select(NameUpper).ToList();

            // Através do delegate
            //Func<Product5, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();

            // Através do Lambda
            //Func<Product5, string> func = p => p.Name.ToUpper();
            //List<string> result = list.Select(func).ToList();

            // Lambda Inline
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }*/
            #endregion

            #region LINQ (Language Integrated Query)
            // Conjunto de tecnologias para integrar consultas diretamente no C#
            // Operações chamadas de coleções, consultas e IntelliSense da IDE. UTILIZA O SYSTEM.LINQ
            // Passos: Especificar datasource --> elaborar expressão de query --> Executar query
            /* Operações:
                FILTRO: Where, OfType
                SORTING: OrderBy, Reverse, OrderByDescending
                SET: Distinct, Except, Intersect, Union
                QUANTIFICATION: All, Any, Contains (Se contém algum elemento em condição)
                PROJECTION: Select, SelectMany
                PARTITION: Skip, Take
                JOIN: Join, GroupJoin
                GROUPING: GroupBy
                GENERATIONAL: Empty (Gera fonte de dados)
                EQUALITY: SequenceEquals
                ELEMENT: ElementAt, First, FirstOrDefault, Last, Single
                CONVERSIONS: AsEnumerable, AsQuaeryable
                CONCATENATION: Concat
                AGGREGATION: Aggregate, Average, Count, Max, Min, Sum
            */


            // Especificar datasource
            /*int[] numbers = new int[] { 2, 3, 4, 5 };

            // Definir expressão de consulta
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Executar consulta
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }*/



            // Exercício 1
            /*Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product6> products = new List<Product6>() {
                new Product6() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product6() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product6() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product6() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product6() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product6() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product6() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product6() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product6() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product6() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product6() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            //var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900.00);
            var r1 =
                from x in products
                where x.Category.Tier == 1 && x.Price == 900.0
                select x;
            Print("Tier 1 and Price < 900:", r1);

            //var r2 = products.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            var r2 =
                from x in products
                where x.Category.Name == "Tools"
                select x.Name;
            Print("Names of products from Tools:", r2);

            //var r3 = products.Where(x => x.Name.StartsWith('C')).Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name }); // OBJETO ANÔNIMO
            var r3 =
                from x in products
                where x.Name.StartsWith('C')
                select new { x.Name, x.Price, CategoryName = x.Category.Name };
            Print("Products that start with C:", r3);

            //var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            var r4 =
                from x in products
                where x.Category.Tier == 1
                orderby x.Name
                orderby x.Price // AQUI É INVERTIDO
                select x;
            Print("Products with Tier 1:", r4);

            //var r5 = r4.Skip(2).Take(4); // PULA 2 ELEMENTOS E PEGA 4
            var r5 =
                (from x in r4
                 select x).Skip(2).Take(4);
             Print("Skip 2 take 4", r5);

            //var r6 = products.First();
            var r6 = (from x in products select x).First();
            Console.WriteLine("\nFirst test1: " + r6);

            //var r7 = products.Where(x => x.Price > 3000.00).FirstOrDefault();
            var r7 = (from x in products select x).FirstOrDefault();
            Console.WriteLine("FirstOrDefault test2: " + r7);

            var r8 = products.Where(x => x.Id == 3).SingleOrDefault();
            Console.WriteLine("\nSingle or Default test1: " + r8);

            var r9 = products.Where(x => x.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or Default test2: " + r9);

            var r10 = products.Max(x => x.Price);
            Console.WriteLine("\nMax price: " + r10);

            var r11 = products.Min(x => x.Price);
            Console.WriteLine("Min price: " + r11);

            var r12 = products.Where(x => x.Category.Id == 1).Sum(x => x.Price);
            Console.WriteLine("Sum price: " + r12);

            var r13 = products.Where(x => x.Category.Id == 1).Average(x => x.Price);
            Console.WriteLine("Average price: " + r13);

            var r14 = products.Where(x => x.Category.Id == 5).Select(x => x.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Empty sequence: " + r14);

            var r15 = products.Where(x => x.Category.Id == 1).Select(x => x.Price).Aggregate(0.0,(x, y) => x + y);
            Console.WriteLine("Aggregate Sum: " + r15);

            //var r16 = products.GroupBy(x => x.Category);
            var r16 =
                from x in products
                group x by x.Category;
            foreach (IGrouping<Category, Product6> group in r16) // USA O IGROUPING, QUE É PARECIDO COM O MAP
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach(Product6 p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }*/



            // Exercício 2
            /*Console.Write("Enter file path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Product7> list = new List<Product7>();
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(',');
                        list.Add(new Product7(vect[0], double.Parse(vect[1], CultureInfo.InvariantCulture)));
                    }

                    var avg = list.Select(x => x.Price).DefaultIfEmpty(0.0).Average();
                    Console.WriteLine("Average Price: " + avg.ToString("F2"));

                    var prods = list.Where(x => x.Price < avg).OrderByDescending(x => x.Name).Select(x => x.Name);

                    foreach(string p in prods)
                    {
                        Console.WriteLine(p);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(e.Message);
            }*/



            // Exercício 3
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee2> list = new List<Employee2>();
                    while (!sr.EndOfStream)
                    {
                        string[] vet = sr.ReadLine().Split(',');
                        list.Add(new Employee2(vet[0], vet[1], double.Parse(vet[2], CultureInfo.InvariantCulture)));
                    }
                    Console.Write("Enter a salary value: ");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    var emails = list.Where(x => x.Salary > value).OrderBy(x => x.Email).Select(x => x.Email);
                    foreach(string e in emails)
                    {
                        Console.WriteLine(e);
                    }

                    Console.WriteLine("Sum of salaries in which the name starts with M: " + list.Where(x => x.Name.StartsWith('M')).Sum(x => x.Salary).ToString("F2"));
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }

            #endregion

        }

        #region Funções extras para capítulos
        /*
        #region NameUpper (Delegate Func)
        static string NameUpper(Product5 p)
        {
            return p.Name.ToUpper();
        }
        #endregion

        #region UpdatePrice (Delegate Action)
        static void UpdatePrice(Product5 p)
        {
            p.Price += p.Price * 0.1;
        }
        #endregion

        #region ProductTest (Delegate Predicate)
        public static bool ProductTest(Product5 p)
        {
            return p.Price >= 100.0;
        }
        #endregion

        #region CompareProducts (Delegate)
        // Delegate para comparar produtos (sem necessidade de ())
        static int CompareProducts(Product5 p1, Product5 p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
        #endregion

        #region PrintCollection (Generics)
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine("\n");
        }
        #endregion
        */
        #endregion
    }
}