import java.util.Scanner;


public class _01_SymmetricNumbers {
    public static void main(String... d){
        Scanner input = new Scanner(System.in);
        
        int start = input.nextInt();
        int end = input.nextInt();
        
        for (int i = start; i < end+1; i++){
           if (String.valueOf(i).charAt(0) == String.valueOf(i).charAt(String.valueOf(i).length()-1)){
               System.out.print(i + " ");
           }
        }
    }
}
