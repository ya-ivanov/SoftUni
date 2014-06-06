import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class _06_RandomHandsOf5Cards {

    static List<String> deck = getDeck();
    static int randomNum = 51;

    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        System.out.println("How many random hands do you want to draw?");
        int hands = scan.nextInt();

        Random rand = new Random();
        for(int a = 0; a < hands; a++){
            System.out.print(getCard(rand.nextInt(randomNum))  + getCard(rand.nextInt(randomNum)) + getCard(rand.nextInt(randomNum)) + getCard(rand.nextInt(randomNum)) + getCard(rand.nextInt(randomNum)));
            deck = getDeck();
            randomNum = 51;
            System.out.println("");
        }
    }

    public static String getCard(int num){
        String res = deck.get(num);
        deck.remove(num);
        randomNum--;
        return res;
    }

    private static List<String> getDeck() {
        String[] numbers = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        String[] color = {"\u2663", "\u2666", "\u2665", "\u2660"};
        List<String> thisDeck = new ArrayList<String>();

        for (int i = 0; i < numbers.length; i++) {
            for (int j = 0; j < color.length; j++) {
                thisDeck.add(numbers[i] + "" + color[j]);
            }
        }
        return thisDeck;
    }
}
