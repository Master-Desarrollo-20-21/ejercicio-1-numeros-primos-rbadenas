namespace ejercicio_1_numeros_primos_rbadenas
{
 public class EratosthenesNumber{

        private readonly int value;

        public EratosthenesNumber(int value)
        {
            this.value = value;
        }

        public int Value(){ return value; }
        
        public bool IsPrime(){

            if(value <2) return false;

            int divisor = 1;
            do
            {
                divisor++;
            } while (!IsDivisibleBy(divisor) && divisor < value);

            return value == divisor;
        }
        
        private bool IsDivisibleBy(int divisor){
            return value % divisor == 0;
        }
    
    }
}