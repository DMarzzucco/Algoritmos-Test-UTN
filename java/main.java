// Fibonacci
public class FibonacciSequence {
    public static void main(String[] args) {
        int limit = 20;
        int n1 = 0;
        int n2 = 1;

        System.out.println(n1); 
        System.out.println(n2); 

        while (n2 < limit) {
            int nextNumber = n1 + n2;
            System.out.println(nextNumber); 
            n1 = n2;
            n2 = nextNumber;
        }
    }
}

