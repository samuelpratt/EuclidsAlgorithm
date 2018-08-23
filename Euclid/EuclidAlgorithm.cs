namespace Euclid
{
    public class EuclidAlgorithm {

        public static int GreatestCommonDivisor(int a, int b) {
            while (a != b){
                if(a > b){
                    a = a - b;
                } 
                else {
                    b = b - a;
                } 
            }
            return a;
        }

    }
}

