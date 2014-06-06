import java.util.Scanner;
public class _06_FormattingNumbers {

    public static void main(String args[]){

        System.out.println("Enter three numbers :");
        Scanner input = new Scanner(System.in);

        int intNum = input.nextInt();
        double doubleNum = input.nextDouble();
        double doubleNum2 = input.nextDouble();

        String hexStr = Integer.toHexString(intNum).toUpperCase();
        String binStr = String.format("%10s", Integer.toBinaryString(intNum)).replace(' ', '0');

        if (doubleNum2%1 == 0) {
            System.out.printf("|%-10s|%s|%10.2f|%-10.0f|",hexStr,binStr,doubleNum,doubleNum2);
        }
        else {
            System.out.printf("|%-10s|%s|%10.2f|%-10.3f|",hexStr,binStr,doubleNum,doubleNum2);
        }

    }
}
