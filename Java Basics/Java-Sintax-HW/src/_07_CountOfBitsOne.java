import java.util.Scanner;

public class _07_CountOfBitsOne {
    public static void main(String args[]){
        System.out.println("Enter a number:");
        Scanner input = new Scanner(System.in);
        String binRep = Long.toBinaryString(input.nextInt());

        System.out.println( countBits(binRep));
    }

    private static int countBits(String binRep) {
        int times = 0;
        for (int i = 0; i < binRep.length(); i++) {
            if (binRep.charAt(i) == '1') times++;
        }
        return times;
    }
}
