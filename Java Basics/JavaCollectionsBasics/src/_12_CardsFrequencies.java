import java.text.DecimalFormat;
import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;

public class _12_CardsFrequencies {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        String[] cards = scan.nextLine().toUpperCase().split(" ");
        Set<String> cardsNoRepeat = new HashSet<>();

        for (String card : cards)
            cardsNoRepeat.add(card.split("\\W+")[0]);

        cardsNoRepeat.forEach(card -> {
            if (card.charAt(0) != '1')
                System.out.println(card.charAt(0) + " -> " + countFrequency(card, cards) + "%");
            else
                System.out.println(card.charAt(0) + "0 -> " + countFrequency(card, cards) + "%");
        });
    }

    public static double countFrequency(String word, String[] hand){
        double counter = 0;
        for (int i = 0; i < hand.length; i++)
            if (hand[i].contains(word))
                counter++;
        return Double.valueOf(new DecimalFormat("#.##").format((100*counter)/hand.length ));
    }
}
