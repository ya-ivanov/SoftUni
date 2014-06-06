
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class _03_FullHouse {

    public static void main(String[] args) {

        List<String> cards = getDeck();
        Set<String> setFullHouses = new HashSet<>();

        int num = 0;
        for (int i = 0; i < 52; i++) {
            for (int j = 0; j < 52; j++) {
                for (int k = 0; k < 52; k++) {
                    for (int l = 0; l < 52; l++) {
                        for (int m = 0; m < 52; m++) {
                            if (cards.get(i).charAt(0) == cards.get(j).charAt(0) && cards.get(j).charAt(0) == cards.get(k).charAt(0) && !cards.get(i).equals(cards.get(j)) && !cards.get(i).equals(cards.get(k)) && !cards.get(k).equals(cards.get(j))) {
                                if (cards.get(l).charAt(0) == cards.get(m).charAt(0) && cards.get(m).charAt(0) != cards.get(i).charAt(0) && !cards.get(l).equals(cards.get(m))) {
                                    num++;
                                    char[] chars = String.valueOf(cards.get(i) + cards.get(j) + cards.get(k) + cards.get(l) + cards.get(m)).toCharArray();
                                    Arrays.sort(chars);
                                    String sorted = new String(chars);
                                    System.out.print("(" + String.valueOf(cards.get(i) + cards.get(j) + cards.get(k) + cards.get(l) + cards.get(m)) +") ... ");
                                    setFullHouses.add(sorted);
                                }
                            }
                        }
                    }
                }
            }
        }

        System.out.println(setFullHouses.size());
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
