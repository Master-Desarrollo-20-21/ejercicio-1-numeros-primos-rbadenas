namespace ejercicio_1_numeros_primos_rbadenas
{
public class EratosthenesSieve{

        public EratosthenesSieve()
        {

        }

        public int sumOf50firstPrimes(){
            var candidate = 0;
            var primesCount = 0;
            var primesAcumulatedSum = 0;
            do
            {
                candidate++;
                var eratosthenesNumber = new EratosthenesNumber(candidate);
                if(eratosthenesNumber.isPrime()){
                    primesAcumulatedSum += eratosthenesNumber.value();
                    primesCount++;
                }
                
            } while (primesCount < 50);

            return primesAcumulatedSum;
        }

        public int sumOfPrimesIn50firstNumbers(){
            var candidate = 0;
            var primesAcumulatedSum = 0;
            do
            {
                candidate++;
                var eratosthenesNumber = new EratosthenesNumber(candidate);
                if(eratosthenesNumber.isPrime()){
                    primesAcumulatedSum += eratosthenesNumber.value();
                }
                
            } while (candidate < 50);

            return primesAcumulatedSum;
        }

    }
}