/*using System;

namespace Ex1
{
    class ExerciosURI
    {
        static void Main(string[] args)
        {
            // URI 1002
            /*double A = double.Parse(Console.ReadLine());
            double n = 3.14159;

            double area = n * Math.Pow(A, 2);

            Console.WriteLine("A=" + area.ToString("F4"));*/



            // URI 1003
            /*int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);*/



            // URI 1004
            /*int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine("PROD = " + PROD);*/



            // URI 1005
            /*double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            double media = (A*3.5 + B*7.5)/11;

            Console.WriteLine("MEDIA = " + media.ToString("F5"));*/



            // URI 1006
            /*double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double media = (A * 2 + B * 3 + C * 5) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1"));*/



            // URI 1007
            /*int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);*/



            // URI 1008
            /*int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine());

            double sal = horas * valor;

            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$ " + sal.ToString("F2"));*/



            // URI 1009
            /* string nome = Console.ReadLine();
            double sal = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());

            double total = sal + vendas * 0.15;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));*/



            // URI 1010
            /*string[] v1 = Console.ReadLine().Split(' ');
            int A = int.Parse(v1[0]);
            int B = int.Parse(v1[1]);
            double C = double.Parse(v1[2]);

            string[] v2 = Console.ReadLine().Split(' ');
            int D = int.Parse(v2[0]);
            int E = int.Parse(v2[1]);
            double F = double.Parse(v2[2]);

            double valor = B * C + E * F;

            Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2"));*/



            // URI 1011
            /*double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            double volume = (4.0/ 3) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3"));*/



            // URI 1012
            /*string[] v = Console.ReadLine().Split(' ');
            double A = double.Parse(v[0]);
            double B = double.Parse(v[1]);
            double C = double.Parse(v[2]);
            double pi = 3.14159;

            double tri = (A * C / 2);
            double circ = pi * Math.Pow(C, 2);
            double trap = ((A + B) * C) / 2;
            double quad = Math.Pow(B, 2);
            double ret = (A * B);

            Console.WriteLine("TRIANGULO: " + tri.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circ.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trap.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quad.ToString("F3"));
            Console.WriteLine("RETANGULO: " + ret.ToString("F3"));*/



            // URI 1013
            /*string[] v = Console.ReadLine().Split(' ');
            int A = int.Parse(v[0]);
            int B = int.Parse(v[1]);
            int C = int.Parse(v[2]);

            double MaiorAB = (A + B + Math.Abs(A - B)) / 2;
            double MaiorBC = (C + B + Math.Abs(C - B)) / 2;
            double Maior = (MaiorAB + MaiorBC + Math.Abs(MaiorAB - MaiorBC)) / 2;

            Console.WriteLine(Maior + " eh o maior");*/



            // URI 1014
            /*int x = int.Parse(Console.ReadLine());
            double y= double.Parse(Console.ReadLine());

            double consumo = x / y;

            Console.WriteLine(consumo.ToString("F3") + " km/l");*/




            // URI 1015
            /*string[] x = Console.ReadLine().Split(' ');
            double x1 = double.Parse(x[0]);
            double y1 = double.Parse(x[1]);

            string[] y = Console.ReadLine().Split(' ');
            double x2 = double.Parse(y[0]);
            double y2 = double.Parse(y[1]);

            double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(dist.ToString("F4"));*/




            // URI 1016
            /*int dist = int.Parse(Console.ReadLine());
            int tempo = 2 * dist;

            Console.WriteLine(tempo + " minutos");*/




            // URI 1017
            /*int tempo = int.Parse(Console.ReadLine());
            int vel = int.Parse(Console.ReadLine());

            double qtd = vel * tempo / 12.0;

            Console.WriteLine(qtd.ToString("F3"));*/




            // URI 1018
            /*int Total = int.Parse(Console.ReadLine());

            Console.WriteLine(Total);
            int valor100 = Total / 100;
            Console.WriteLine(valor100 + " nota(s) de R$ 100,00");
            int valor50 = (Total - 100 *valor100) / 50;
            Console.WriteLine(valor50 + " nota(s) de R$ 50,00");
            int valor20 = (Total - 100 * valor100 - 50 * valor50) / 20;
            Console.WriteLine(valor20 + " nota(s) de R$ 20,00");
            int valor10 = (Total - 100 * valor100 - 50 * valor50 - 20 *valor20) / 10;
            Console.WriteLine(valor10 + " nota(s) de R$ 10,00");
            int valor5 = (Total - 100 * valor100 - 50 * valor50 - 20 * valor20 - 10 * valor10) / 5;
            Console.WriteLine(valor5 + " nota(s) de R$ 5,00");
            int valor2 = (Total - 100 * valor100 - 50 * valor50 - 20 * valor20 - 10 * valor10 - 5 *valor5) / 2;
            Console.WriteLine(valor2 + " nota(s) de R$ 2,00");
            int valor1 = (Total - 100 * valor100 - 50 * valor50 - 20 * valor20 - 10 * valor10 - 5 * valor5 - 2*valor2) / 1;
            Console.WriteLine(valor1 + " nota(s) de R$ 1,00");*/




            // URI 1019
            /*int N = int.Parse(Console.ReadLine());
            int horas = N / 3600;
            int min = (N - horas * 3600)/ 60;
            int sec = (N - horas *3600 - 60 * min);

            Console.WriteLine(horas + ":" + min + ":" + sec);*/




            // URI 1020
            /*int idade = int.Parse(Console.ReadLine());
            int ano = idade / 365;
            int mes = (idade - ano * 365) / 30;
            int dias = (idade - ano * 365 - mes * 30);

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dias + " dia(s)");*/




            // URI 1021
            /*double N, resto;
            int n100, n50, n20, n10, n5, n2, m100, m50, m25, m10, m5, m1;


            N = float.Parse(Console.ReadLine());
            N = N * 100 + 0.5;

            n100 = (int)N / 10000;
            resto = N % 10000;
            n50 = (int)resto / 5000;
            resto %= 5000;
            n20 = (int)resto / 2000;
            resto %= 2000;
            n10 = (int)resto / 1000;
            resto %= 1000;
            n5 = (int)resto / 500;
            resto %= 500;
            n2 = (int)resto / 200;
            resto %= 200;
            m100 = (int)resto / 100;
            resto %= 100;
            m50 = (int)resto / 50;
            resto %= 50;
            m25 = (int)resto / 25;
            resto %= 25;
            m10 = (int)resto / 10;
            resto %= 10;
            m5 = (int)resto / 5;
            resto %= 5;
            m1 = (int)resto / 1;


            Console.WriteLine("NOTAS:");
            Console.WriteLine("" + n100 + " nota(s) de R$ 100.00");
            Console.WriteLine("" + n50 + " nota(s) de R$ 50.00");
            Console.WriteLine("" + n20 + " nota(s) de R$ 20.00");
            Console.WriteLine("" + n10 + " nota(s) de R$ 10.00");
            Console.WriteLine("" + n5 + " nota(s) de R$ 5.00");
            Console.WriteLine("" + n2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine("" + m100 + " moeda(s) de R$ 1.00");
            Console.WriteLine("" + m50 + " moeda(s) de R$ 0.50");
            Console.WriteLine("" + m25 + " moeda(s) de R$ 0.25");
            Console.WriteLine("" + m10 + " moeda(s) de R$ 0.10");
            Console.WriteLine("" + m5 + " moeda(s) de R$ 0.05");
            Console.WriteLine("" + m1 + " moeda(s) de R$ 0.01");*/



            // URI 1035
            /*string[] v = Console.ReadLine().Split(' ');
            int a = int.Parse(v[0]);
            int b = int.Parse(v[1]);
            int c = int.Parse(v[2]);
            int d = int.Parse(v[3]);

            if(b > c && d > a && ((c+d) > (a+b)) && c > 0 && d > 0 && a%2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }*/



            // URI 1036
            /*string[] v = Console.ReadLine().Split(' ');
            double A = double.Parse(v[0]);
            double B = double.Parse(v[1]);
            double C = double.Parse(v[2]);

            double delta = Math.Pow(B,2) - (4 * A * C);

            if(delta < 0 || A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double R1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine("R1 = " + R1.ToString("F5"));

                double R2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine("R2 = " + R2.ToString("F5"));
            }*/



            // URI 1037
            /*float valor = float.Parse(Console.ReadLine());

            if(0.0 <= valor && valor <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(25.0 < valor && valor <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if(50.0 < valor && valor <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if(75.0 < valor && valor <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }*/



            // URI 1038
            /*string[] item = Console.ReadLine().Split(' ');
            int cod = int.Parse(item[0]);
            int qtd = int.Parse(item[1]);
            double total = 0;

            switch (cod)
            {
                case 1:
                    total = 4.00 * qtd;
                    break;

                case 2:
                    total = 4.50 * qtd;
                    break;

                case 3:
                    total = 5.00 * qtd;
                    break;

                case 4:
                    total = 2.00 * qtd;
                    break;

                case 5:
                    total = 1.50 * qtd;
                    break;
            }
            Console.WriteLine("Total: R$ " + total.ToString("F2"));*/



            // URI 1040
            /*string[] v = Console.ReadLine().Split(' ');
            double n1 = double.Parse(v[0]);
            double n2 = double.Parse(v[1]);
            double n3 = double.Parse(v[2]);
            double n4 = double.Parse(v[3]);

            double media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10.0;

            Console.WriteLine("Media: " + media.ToString("F1"));

            if (media >= 7.0)
                Console.WriteLine("Aluno aprovado.");
            else if (5.0 <= media && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double exame = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + exame.ToString("F1"));
                media = (exame + media) / 2.0;
                if (media >= 5.0)
                    Console.WriteLine("Aluno aprovado.");
                else
                    Console.WriteLine("Aluno reporvado.");
                Console.WriteLine("Media final: " + media.ToString("F1"));
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }*/



            // URI 1041
            /*string[] v = Console.ReadLine().Split(' ');
            double x = double.Parse(v[0]);
            double y = double.Parse(v[1]);

            if (x > 0.0 && y > 0.0)
                Console.WriteLine("Q1");
            else if (x < 0.0 && y > 0.0)
                Console.WriteLine("Q2");
            else if (x < 0.0 && y < 0.0)
                Console.WriteLine("Q3");
            else if (x > 0.0 && y < 0.0)
                Console.WriteLine("Q4");
            else if (x == 0 && y != 0)
                Console.WriteLine("Eixo Y");
            else if (y == 0 && x != 0)
                Console.WriteLine("Eixo X");
            else
                Console.WriteLine("Origem");*/



            // URI 1042
            /*string[] v = Console.ReadLine().Split(' ');
            int x = int.Parse(v[0]);
            int y = int.Parse(v[1]);
            int z = int.Parse(v[2]);

            int[] vec = new int[3] { x, y, z };

            Array.Sort(vec);
            foreach (int i in vec) Console.WriteLine(i);
            Console.WriteLine("");
            foreach (string str in v) Console.WriteLine(str);

        }
    }
}*/
