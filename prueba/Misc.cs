﻿

namespace prueba
{
    class Misc
    {
        public static int GetMinValue(int a , int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int GetMaxValue(int a,int b)
        {
            if (a > b)
                return (a);
            else
                return (b);
        }
        //This function return true is the number
        //is even(par) and false otherwise
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsPositive(int value)
        {
            if (value >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double Pi(int value)
        {
            double a;
            return  a = System.Math.PI;
        }
        public static bool IsPrime(int number)
        {
            int i = 2;
            while (i > number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }
        //tienes que hacer una funcion que diga si dos circulos se chocan es decir la suma de los radios Ej:- 5 + 5 = 10 
        //es mayor que la suma de la distancia de punto central a punto central de cada uno de los circulos entonces 
        //los circulos se chocan
    }
}
