using System;

namespace Lista_exercicios_Rached
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // ex.1: Ler uma temperatura em graus Celsius e transformá-la em graus Fahrenheit 

            double celsius, fahrenheit;

            Console.WriteLine("Digite a temperatura na escala Celsius: ");
            celsius = Double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine("A temperatura é: " + fahrenheit + "F");
           

            // ex.2:Cálculo de um salário líquido de um professor. Serão fornecidos valor da hora aula, número de aulas dadas e o % de desconto do INSS. 

            double haula, naula, dinss, sliq, sbrut;

            Console.WriteLine("Informe o valor da hora-aula: ");
            haula = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe cargo-horária semanal de aula: ");
            naula = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a alicota do INSS: ");
            dinss = Double.Parse(Console.ReadLine());

            sbrut = (naula * 4.5 * haula);

            sliq = sbrut - ((sbrut * dinss) / 100);

            Console.WriteLine("O salário líquido é R$" + sliq);



            // ex.3: Ler  1  número.  Se  positivo,  imprimir  raiz  quadrada,  senão  o quadrado. 

            double num;

            Console.WriteLine("Escolha um número e digite aqui: ");
            num = Double.Parse(Console.ReadLine());

            if (num >= 0)
            { 
                Console.WriteLine("O número é positivo e sua raiz quadrada é: " + Math.Sqrt(num));
            } else
            {
                Console.WriteLine("Você escolheu um número que não é positivo, logo seu quadrado é: " + Math.Pow(num, 2));
            }

            // ex.4: Faça um programa que calcule e mostre a área de um círculo.: Obs.: Crie uma constante para π, sabendo que ele vale 3.1415.

            const double pi = 3.1415;
            double raio, area;

            Console.WriteLine("Para conhecer a área da circunferência, digite o valor do raio: ");
            raio = Double.Parse(Console.ReadLine());

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("O valor da área é: " + area);

            // ex.5: Faça  um  programa  que  receba  o  ano  de  nascimento  de uma pessoa  e  o  ano  atual,  calcule  e  mostre:  a.  A  idade  dessa  pessoa;  b.  Quantos anos essa pessoa terá em 2022.

            int anoAtual, anoNascimento, idadeAtual, idade2022;

            anoAtual = DateTime.Now.Year;

            Console.WriteLine("Digite o ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            idadeAtual = anoAtual - anoNascimento;
            Console.WriteLine("Sua idade atual é: " + idadeAtual);

            idade2022 = 2022 - anoNascimento;
            Console.WriteLine("Sua idade em 2022 é: " + idade2022);

            // ex.6: O custo ao consumidor de um carro novo é a soma do preço de fábrica  com  o  percentual  de  lucro  do  distribuidor  e  dos  impostos  aplicados  ao preço  de  fábrica.  Faça  um  programa  que  receba  o  preço  de  fábrica  de  um veículo, o percentual de lucro do distribuidor e o percentual de imposto. Calcule e  mostre:  a.  O  valor  correspondente  ao  lucro  do  distribuidor;  b.  O  valor correspondente aos impostos; c. O preço final do veículo.
           
            double precoFabrica, precoFinal, lucro, imposto;
            
            Console.WriteLine("Digite o valor de fábrica do veículo: ");
            precoFabrica = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o percentual de lucro incidente no produto: ");
            lucro = Double.Parse(Console.ReadLine());
            lucro = (precoFabrica * lucro) / 100;

            Console.WriteLine("Digite a aliquota de imposto do produto (%): ");
            imposto = Double.Parse(Console.ReadLine());
            imposto = (precoFabrica * imposto) / 100;

            precoFinal = lucro + precoFabrica + imposto;

            Console.WriteLine($"O  valor  correspondente  ao  lucro  do  distribuidor é: R${lucro}");
            Console.WriteLine("O  valor  correspondente  aos impostos são: R$" + imposto);
            Console.WriteLine("O preço final do veículo é: R$" + precoFinal);

            // ex.7: Cada degrau de uma escada tem X de altura. Faça um programa que  receba  essa  altura  e  a  altura  que  o  usuário  deseja  alcançar  subindo  a escada.  Calcule  e  mostre  quantos degraus o  usuário deverá  subir  para  atingir seu objetivo, sem se preocupar com a altura do usuário. 
            //REVISAR DAQUI Esse!:

            const double pisoDegrau = 0.28;
            double  hPavimento, eDegraus, nDegraus, ebalanciado, comprimentoEsc;


            Console.WriteLine("Digite a altura a ser vencida entre pavimentos, em metros: ");
            hPavimento = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do espelho do degrau entre 0.17m e 0.18m:");
            eDegraus = Double.Parse(Console.ReadLine());

            if (eDegraus >= 0.17 && eDegraus <= 0.18)
            {
                nDegraus = Math.Ceiling(hPavimento / eDegraus);
                ebalanciado = hPavimento / nDegraus;
                comprimentoEsc = pisoDegrau * (nDegraus - 1);
                Console.WriteLine("A escada terá " + nDegraus + " degraus.");
                Console.WriteLine("E para escada ser balanciada, o espelho terá " + ebalanciado + "m de altura.");
                Console.WriteLine("Por fim, a escada terá " + comprimentoEsc + "m de comprimento, sem patamar.");
             }

            else
            {
                    Console.WriteLine("A dimensão do espelho não é válida. Tente novamente!");
            }
            

            //ex.8: Faça um programa que receba o número de horas trabalhadas e o  valor  do  salário  mínimo.  Calcule  e  mostre  o  salário  a  receber  seguindo  as regras abaixo: a. a hora trabalhada valea metade do salário mínimo; b. o salário bruto equivale ao número de horas trabalhadas multiplicado pelo valor da hora trabalhada; c. o imposto equivale a 3% do salário bruto; d. o salário a receber equivale ao salário bruto menos o imposto.

            const double salarioMinimo = 1192.40, impst = 3;
            double horaTrabalhada, qtdHorasTrab, salarioBruto, impostoFinal;
            
            horaTrabalhada = salarioMinimo / 2;
           
            Console.WriteLine("Digite o numero de horas trabalhadas: ");
            qtdHorasTrab = double.Parse(Console.ReadLine());
            
            salarioBruto = qtdHorasTrab * horaTrabalhada;
            
            impostoFinal = (salarioBruto * impst) / 100;
           
            Console.WriteLine("O valor da hora trabalhada é: R${0}", horaTrabalhada);
            Console.WriteLine("O valor do salário bruto é: R${0}", salarioBruto);
            Console.WriteLine("O valor do imposto é: R${0}", impostoFinal);
            Console.WriteLine("O salário a receber é: R${0}", (salarioBruto - impostoFinal));

            //ex.9: Inicialize  uma  variável  do  tipo  inteiro  com  um  valor  aleatório. Escreva  um comando "switch" com quatro cases. Um case deve corresponder ao valor  que você atribuiu à variável de teste. Em cada "case" você irá criar um  comando  para  imprimir  na  tela  um  presente  diferente.  Para  o  case  que  corresponde ao valor da variável de teste, você irá mandar imprimir PS4  como um presente. 

            int opcao = 1;
            Console.WriteLine("Digite um numero de 1 a 4");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("O presente é PS4");
                    break;
                case 2:
                    Console.WriteLine("o presente é uma boneca LOL");
                    break;
                case 3:
                    Console.WriteLine("O presente é uma bola furada");
                    break;
                case 4:
                    Console.WriteLine("O presente é uma pião");
                    break;
                default:
                    Console.WriteLine("Opção não identificada, Tente novamente!");
                    break;
            }

            //ex.10: (QUESTÃO  DESAFIO):Receber  um  valor  inteiro  entre 0  e 999  e  imprimir este valor por extenso
  
    }
}
}