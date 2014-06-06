import java.util.Scanner;

public class _05_CountAllWords {
    public static void main(String[] args){
        System.out.println("Enter sentence:");
        Scanner scan = new Scanner(System.in);
        String text = scan.nextLine();
        System.out.println(text.split("\\W+").length);
    }
}

