import java.util.Scanner;

public class _07_CountSubstringOccurrences {
    public static void main(String[] args){
        System.out.println("Enter sentence, then enter word:");
        Scanner scan = new Scanner(System.in);
        String text = scan.nextLine().toLowerCase();
        String word = scan.next().toLowerCase();
        System.out.println(text.split(word).length-1);
    }
}
