using System.Linq;
using System.Collections.Generic;

namespace ejercicio_1_numeros_primos_rbadenas
{
    public class EratosthenesSieve
    {
        public EratosthenesSieve() { }

        public int SumOf50firstPrimes(){
            return TakePrimeNumbers(50).Sum();
        }

        public int SumOfPrimesIn50firstNumbers(){
            return TakePrimeNumbers(50, 50).Sum();
        }

        private List<int> TakePrimeNumbers(int askedPrimes, int? searchLimit = null)
        {
            var result = new List<int>();
            var candidate = 1;
            var primesCount = 0;

            do
            {
                candidate++;
                var eratosthenesNumber = new EratosthenesNumber(candidate);
                if(eratosthenesNumber.IsPrime()){
                    result.Add(eratosthenesNumber.Value());
                    primesCount++;
                }
                
            } while (primesCount < askedPrimes && searchLimit == null || candidate < searchLimit);

            return result;
        }

    }
}