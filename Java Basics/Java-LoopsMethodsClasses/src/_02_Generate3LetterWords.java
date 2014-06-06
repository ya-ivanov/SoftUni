import java.util.Scanner;


public class _02_Generate3LetterWords {
    public static void main(String... d){
        Scanner input = new Scanner(System.in);
        
        System.out.print("Write letter sequence: ");
        
        char[] chars = input.nextLine().toCharArray();
        
        for(int i = 0; i < chars.length; i++){
            for (int j = 0; j < chars.length; j++) {
                for (int k = 0; k < chars.length; k++) {
                    if (chars.length == 3)
                        System.out.print("" + chars[i] + chars[j] + chars[k] + " ");
                    else
                        System.out.print("" + chars[i] + chars[j] + chars[k] + " ");
                }
            }
        }
    }
}

