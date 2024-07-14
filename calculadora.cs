using System;
class Calculadora{
    static void Main(){
        int op;
        float a,b,res;

        Console.WriteLine("Bem vindo");

        while(true){

            Console.WriteLine("Digite o numero para selecionar a operação desejada");
            Console.WriteLine("---------------");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            op=int.Parse(Console.ReadLine());

            if(op == 5)
            {

                Console.WriteLine("Obrigado por acessar");
                break;
            }

            Console.WriteLine("---------------");

            Console.WriteLine("Digite o primeiro número: ");
            a=float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            b=float.Parse(Console.ReadLine());
        
            if(op == 1)
            {
                res=a+b;

                Console.WriteLine("O resultado da Adição foi de {0}", res);
            }

            else if(op == 2)
            {
                res=a-b;

                Console.WriteLine("O resultado da Subtração foi de {0}", res);
            }

            else if(op == 3)
            {
                res=a*b;

                Console.WriteLine("O resultado da Multiplicação foi de {0}", res);
            }

            else if(op == 4)
            {
                if(b != 0)
                {
                res=a/b;

                Console.WriteLine("O resultado da Divisão foi de {0}", res);
                }
                else
                {
                    Console.WriteLine("Erro: não é possível dividir por zero");
                }
            }

            else
            {
                Console.WriteLine("Operação inválida");
            }

            Console.WriteLine("---------------");

        }
            
        
    }
}