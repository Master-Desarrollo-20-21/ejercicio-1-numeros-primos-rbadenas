namespace ejercicio_1_numeros_primos_rbadenas
{
 public class EratosthenesNumber{

        private readonly int number;

        public EratosthenesNumber(int number)
        {
            this.number = number;
        }

        public int value(){ return number; }
        public bool isPrime(){

            if(number <2) return false;

            int divisor = 1;
            do
            {
                divisor++;
            } while (!isDivisibleBy(divisor) && divisor < number);

            return number == divisor;
        }
        private bool isDivisibleBy(int divisor){
            return number % divisor == 0;
        }
    
    }
}