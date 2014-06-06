import java.util.Scanner;

public class _08_CountOfEqualBitPairs {

    public static void main(String args[]){
        System.out.println("Enter a number:");
        Scanner input = new Scanner(System.in);
        String binRep = Long.toBinaryString(input.nextInt());
        System.out.println(countPairs(binRep));
    }

    private static int countPairs(String bit){
        int times = 0;

        for (int i = 1; i < bit.length(); i++){
            if (bit.charAt(i) == bit.charAt(i-1)) times++;
        }
        return times;
    }
}
