using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ControlExercicios
    {
        //Ligar as duas classes
        ModelExercicios model;
        private int opcao;
        public double bas;
        public double altura;
        public int dias;
        public int ano;
        public int meses;
        public double TotEleitor;
        public double VB;
        public double VN;
        public double VV;
        public double PorcBrancos;
        public double PorcNulos;
        public double PorcValidos;
        public double salarioatual;
        public double percreajuste;
        public double novosalario;
        public double custoFabrica;
        public double percentImposto;
        public double percentDistribuidora;
        public double primeiraNota;
        public double segundaNota;
        public double terceiraNota;
        public double media;
        public int quant;
        public int quant2;
        public double salario;
        public double vendas;
        public double a;
        public double b;
        public double c;







        public ControlExercicios()
        {
            model = new ModelExercicios();//Chamando o construtor da classe Model Exercicios
        }//fim do construtor

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }
        public void Menu()
        {
            Console.WriteLine("---- Menu ----" +
                             "\n1. Exercício 01" +
                             "\n2. Exercício 02" +
                             "\n3. Exercício 03" +
                             "\n4. Exercício 04" +
                             "\n5. Exercício 05" +
                             "\n6. Exercício 06" +
                             "\n7. Exercício 07" +
                             "\n8. Exercício 08" +
                             "\n9. Exercício 09" +
                             "\n10. Exercício 10" +
                             "\n11. Exercício 11" +
                             "\n12. Exercício 12" +
                             "\n13. Exercício 13");
            Console.WriteLine("Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Executar()
        {
            Menu();
            //Executar a ação
            switch (ConsultarOpcao)
            {
                case 1:
                    Console.WriteLine(model.Exercicio01());
                    break;







                case 2:
                    Console.WriteLine("Informe um numero");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("O antecessor de " + num + " é: " + model.Exercicio02(num));
                    break;








                case 3:
                    do
                    {
                        Console.WriteLine("Digite a base do triangulo");
                        bas = Convert.ToDouble(Console.ReadLine());
                        if (bas <= 0)
                        {
                            Console.WriteLine("Essa base digitada não é valida, digite novamente");
                        }
                    } while (bas <= 0);

                    do
                    {
                        Console.WriteLine("Digite a altura do triangulo");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        if (altura <= 0)
                        {
                            Console.WriteLine("Essa altura digitada não é valida, digite novamente");
                        }
                    } while (altura <= 0);

                    Console.WriteLine("A area do triangulo é: " + model.Exercicio03(bas, altura));
                    break;








                case 4:
                    do
                    {
                        Console.WriteLine("Dias");
                        dias = Convert.ToInt32(Console.ReadLine());
                        if (dias < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (dias < 0);


                    do
                    {
                        Console.WriteLine("Meses");
                        meses = Convert.ToInt32(Console.ReadLine());
                        if (meses < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (meses < 0);

                    do
                    {
                        Console.WriteLine("Anos");
                        ano = Convert.ToInt32(Console.ReadLine());
                        if (ano < 0)
                        {
                            Console.Write("Valor invalido, tente novamente");
                        }
                    } while (ano < 0);

                    Console.WriteLine("A sua idade em dias é de " + model.Exercicio04(ano, meses, dias));
                    break;









                case 5:
                    do
                    {
                        Console.WriteLine("Digite o número total de eleitores do município: ");
                        TotEleitor = Convert.ToDouble(Console.ReadLine());
                        if (TotEleitor < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (TotEleitor < 0);



                    do
                    {
                        Console.WriteLine("Digite o número de votos brancos:");
                        VB = Convert.ToDouble(Console.ReadLine());
                        if (VB < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (VB < 0);


                    do
                    {
                        Console.WriteLine("Digite o número de votos nulos:");
                        VN = Convert.ToDouble(Console.ReadLine());
                        if (VN < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (VN < 0);

                    do
                    {
                        Console.WriteLine("Digite o número de votos validos:");
                        VV = Convert.ToDouble(Console.ReadLine());
                        if (VV < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (VV < 0);


                    Console.WriteLine("Votos brancos: " + VB + "|" + " Porcentagem de votos brancos: " + model.PorcBranco(TotEleitor, VB) + "%");
                    Console.WriteLine("Votos nulos: " + VN + "|" + " Porcentagem de votos nulos: " + model.PorcNulo(TotEleitor, VN) + "%");
                    Console.WriteLine("Votos validos: " + VV + "|" + " Porcentagem de votos validos: " + model.PorcValidos(TotEleitor, VB) + "%");
                    break;


                case 6:
                    do
                    {
                        Console.WriteLine("Digite o sálario atual: ");
                        salarioatual = Convert.ToDouble(Console.ReadLine());
                        if (salarioatual < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (salarioatual < 0);

                    do
                    {
                        Console.WriteLine("Digite o Reajuste: ");
                        percreajuste = Convert.ToDouble(Console.ReadLine());
                        if (percreajuste < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (percreajuste < 0);
                    Console.WriteLine("O novo salario é: " + model.Exercicio06(salarioatual, percreajuste, novosalario) + " % ");
                    break;



                case 7:
                    Console.WriteLine("Informe o custo de Fabricação: ");
                    double custoFabrica = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o percentual do distribuidor: ");
                    double percentDistribuidora = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o percentual do imposto: ");
                    double percentImposto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O custo final do consumidor é: " + model.totValor(custoFabrica, percentImposto, percentDistribuidora));
                    break;




                case 8:
                    do
                    {
                        Console.WriteLine("Digite a primeira nota: ");
                        primeiraNota = Convert.ToDouble(Console.ReadLine());
                        if (primeiraNota < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (primeiraNota < 0);



                    do
                    {
                        Console.WriteLine("Digite a segunda nota:");
                        segundaNota = Convert.ToDouble(Console.ReadLine());
                        if (segundaNota < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (segundaNota < 0);


                    do
                    {
                        Console.WriteLine("Digite a terceira nota:");
                        terceiraNota = Convert.ToDouble(Console.ReadLine());
                        if (terceiraNota < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (terceiraNota < 0);
                    Console.WriteLine("A sua média é: " + model.Nota(primeiraNota, segundaNota, terceiraNota, media));
                    break;





                case 9:
                    do
                    {
                        Console.WriteLine("Quantas maças foram compradas? ");
                        quant = Convert.ToInt32(Console.ReadLine());
                        if (quant < 0)
                        {
                            Console.WriteLine("Valor invalido, digite outro!");
                        }
                    } while (quant < 0);

                    Console.WriteLine("O valor a ser pago é de: " + model.Macas(quant));
                    break;



                case 11:
                    do
                    {
                        Console.WriteLine("Digite seu salario: ");
                        salario = Convert.ToDouble(Console.ReadLine());
                        if (salario < 0)
                        {
                            Console.WriteLine("Valor invalido, digite outro!");
                        }
                    } while (salario < 0);


                    do
                    {
                        Console.WriteLine("Digite o total de vendas: ");
                        vendas = Convert.ToDouble(Console.ReadLine());
                        if (vendas < 0)
                        {
                            Console.WriteLine("Valor invalido, digite outro!");
                        }
                    } while (vendas < 0);

                    Console.WriteLine("O salario total é: " + model.salarioTotal(salario, a, b, c, vendas));
                    break;







                default:
                    Console.WriteLine("Código digitado não é valido!");
                    break;
            }//fim do switch
        }//fim do executar
    }//fim da classe
}//fim do projeto
