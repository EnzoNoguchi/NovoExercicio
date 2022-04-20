using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ModelExercicios
    {



        //--------------------------------------------------------EXERCICIOS VARIAVEIS---------------------------------------------------------------------  


        //Declaração de variáveis
        private int A;
        private int B;
        private int C;
        private double tres2;
        public double resultado;


        //---------------------------------------------------------------------------------------------------------------------------------------



        //Declarar o construtor
        public ModelExercicios()
        {
            ConsultarA = 10;
            ConsultarB = 20;
            ConsultarC = 0;
        }//fim do construtor

        public int ConsultarA
        {
            get
            {
                return A;
            }
            set
            {
                this.A = value;
            }
        }//fim do consultarA

        public int ConsultarB
        {
            get
            {
                return B;
            }
            set
            {
                this.B = value;
            }
        }//fim do consultarB

        public int ConsultarC
        {
            get
            {
                return C;
            }
            set
            {
                this.C = value;
            }
        }//fim do consultarC




        //-------------------------------------------------------------EXERCICIOS------------------------------------------------------------------------






        //Método Exercício01
        public string Exercicio01()
        {
            ConsultarC = ConsultarA;
            ConsultarA = ConsultarB;
            ConsultarB = ConsultarC;
            return "A: " + ConsultarA + "\nB: " + ConsultarB;
        }//fim do métodoExercicio01








        //Método Exercicio02
        public int Exercicio02(int num)
        {
            return num - 1;
        }//fim do métodoExercicio02








        //Método Exercicio03
        public double Exercicio03(double bas, double altura)
        {
            return bas * altura;
        }//fim do métodoExercicio03








        //Método Exercicio04
        public int Exercicio04(int ano, int meses, int dias)
        {
            return (ano * 365) + (meses * 30) + dias;
        }//fim do métodoExercicio04







        //Método Exercicio05

        public double PorcBranco(double TotEleitor, double VB)
        {
            return (100 * VB) / TotEleitor;
        }
        public double PorcNulo(double TotEleitor, double VN)
        {
            return (100 * VN) / TotEleitor;
        }

        public double PorcValidos(double TotEleitor, double VV)
        {
            return (100 * VV) / TotEleitor;
        }// fim do metodoExercicio05







        //Método Exercicio06
        public double Exercicio06(double salarioatual, double percreajuste, double novosalario)
        {
            return salarioatual * (percreajuste / 100);
        }//fim do métodoExercicio06







        //Método Exercicio07
        public double totValor(double custoFabrica, double percentImposto, double percentDistribuidora)
        {
            return (custoFabrica * percentImposto) + (custoFabrica * percentDistribuidora) + custoFabrica;
        }
        //fim do métodoExercicio07






        //Método Exercicio08
        public double Nota(double primeiraNota, double segundaNota, double terceiraNota, double media)
        {
            return media = (primeiraNota + segundaNota + terceiraNota) / 3;
        }
        //fim do métodoExercicio07




        //Metodo EX09
        public double Macas(int quant)
        {
            if(quant < 12)
            {
                resultado = quant * 1.30;
            }
            else
            {
                resultado = quant * 1.00;
            }
            return resultado;
        }
        //fim do métodoExercicio09




        //Método Exercicio11
        public double salarioTotal(double salario, double vendas, double a, double b, double c)
        {
            if (vendas > 1500)
            {
                a = vendas * 0.05;
                b = salario + a;
            }
            else
            {
                a = vendas * 0.03;
                b = salario + a;
            }
            return b;
        }
        //fim Metodo ex11




    }//fim da classe
}//fim do projeto

