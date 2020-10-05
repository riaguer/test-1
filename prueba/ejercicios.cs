
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
        public static bool IsPrime(int number)
        {
            int i = 2;
            while (i > number)
            {
                if((number%i)==0)
                    return false;
                i++;
            }
            return true;
        }
    }
}
//while(condition)(tiene que ser un bool)