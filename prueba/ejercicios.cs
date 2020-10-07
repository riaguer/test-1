
namespace prueba
{
    class ejercicios
    {//Ejercicio:Hacer una funcion que imprima por pantalla los numeros de 0 al 99;
        public static void Ejercicio1()
        {
            int contador;
            contador = 0;
            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                contador++;
            }  
        }
        //Ejercicio:Hacer una funcio que imprima todos los numeros pares desde 0 hasta n;
        public static void Ejercicio2(int n)
        {
            int contador = 0;
            while (contador < n)
            {
                if (Misc.IsEven(contador))
                    System.Console.WriteLine(contador);
                contador = contador + 2;
            }
        }
        //Ejercicio:Hacer un programa que imprima si un numero es primo o no

        public static void Ejercicio3(int number)
        {
            bool is_prime;
            is_prime = Misc.IsPrime(number);
            if (is_prime == true)
                System.Console.WriteLine("Es primo");
            else
                System.Console.WriteLine("No es primo");
        }
        //Ejercicio 4 hacer un bucle que imprima 5,4,3,2,1,0,-1,-2
        public static void Ejercicio4(int number)
        {
            for(int i = 0; i < 90; i++)
            {
                System.Console.WriteLine(5-i);
            }
                
            int contador = 0;
            while (contador < 90)
            {
                contador++;
            }
        }
        //Ejercicio que imprime -0,1,-2,3,-4,5,-6,7,-8,9,-10;
        public static void Ejercicio5()
        {
            for(int i = 0; i < 90; i++)
            {
                if ((i % 2) == 0)
                    System.Console.WriteLine(-i);
                else
                    System.Console.WriteLine(i);
            }
        }
        //Ejercicio que imprime 0,1,1,2,3,5,8,13,34(Fibonacci)
        public static void Ejercicio6()
        {
            int i = 0;
            int n1 = 0;
            int n2 = 1;
            System.Console.WriteLine(n1);
            System.Console.WriteLine(n2);
            while (i < 90) 
            { 
                n2 = n1 + n2;
                n1 = n2 - n1;
                i++;
                System.Console.WriteLine(n2);
            }
        }
    }
}//int solo guarda hasta dosmil millones si quieres mas que esos pones long y solucionado;
//while(condition)(tiene que ser un bool)
//No te olvides de llamarlo en Program.cs (ejercicios.Ejercicio6(); por ejemplo) 