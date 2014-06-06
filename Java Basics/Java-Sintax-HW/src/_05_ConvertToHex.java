import java.util.Scanner;

public class _05_ConvertToHex {
    public static void main(String args[]){
        System.out.println("Enter a number:");
        Scanner input = new Scanner(System.in);
        System.out.println(Integer.toHexString(input.nextInt()).toUpperCase());
    }
}
