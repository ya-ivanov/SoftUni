import java.util.Arrays;
import java.util.Scanner;

public class _04_SmallestOfThreeNumbers {
    public static void main(String args[]){
        int arr[] = new int[3];

        System.out.println("Enter 3 numbers:");
        Scanner input = new Scanner(System.in);

        arr[0] = input.nextInt();
        arr[1] = input.nextInt();
        arr[2] = input.nextInt();
        Arrays.sort(arr);

        for (int n : arr)
            System.out.print(n + " ");
    }
}

