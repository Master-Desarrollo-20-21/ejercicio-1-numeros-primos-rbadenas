using System;

namespace ejercicio_1_numeros_primos_rbadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            var eratosthenesSieve = new EratosthenesSieve();

            Console.WriteLine("Sum of 50 first prime numbers is " + eratosthenesSieve.SumOf50firstPrimes());
            Console.WriteLine("Sum of primes on the 50 first numbers is " + eratosthenesSieve.SumOfPrimesIn50firstNumbers());
        }
    }
}
