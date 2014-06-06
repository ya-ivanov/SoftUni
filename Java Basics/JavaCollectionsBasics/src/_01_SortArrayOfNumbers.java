import java.util.Arrays;
import java.util.Scanner;

public class _01_SortArrayOfNumbers {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        int numsCount = scan.nextInt();
        scan.nextLine();
        int[] numbers = new int[numsCount];

        for (int i = 0; i < numsCount; i++) {
            numbers[i] = Integer.parseInt(scan.next());
        }

        Arrays.sort(numbers);

        for(int num : numbers){
            System.out.print(num + " ");
        }

    }
}
