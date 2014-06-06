import java.util.Scanner;

public class _01_CalculateArea {
    public static void main(String args[]){
        System.out.println("Enter 'a' and 'b':");
        Scanner input = new Scanner(System.in);

        int a = input.nextInt(), b = input.nextInt();
        System.out.println(a * b);
    }
}
