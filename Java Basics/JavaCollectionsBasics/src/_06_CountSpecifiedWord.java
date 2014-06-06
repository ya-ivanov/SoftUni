import java.util.Scanner;

public class _06_CountSpecifiedWord {
    public static void main(String[] args){
        System.out.println("Enter sentence, then enter word:");
        Scanner scan = new Scanner(System.in);
        String text = scan.nextLine().toLowerCase();
        String word = scan.next().toLowerCase();
        int times = 1;
        while(text.contains(word)){
            text = text.replace(word, "");
            times++;
        }
        System.out.println(times);
    }
}
