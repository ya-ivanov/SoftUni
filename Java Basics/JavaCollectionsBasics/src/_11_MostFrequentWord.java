import java.util.*;

public class _11_MostFrequentWord {
    static String[] wordsRepeat;
    static  Set<String> words;
    static List<String> wordsWithCount  = new ArrayList<>();
    static int maxOccur = 0;

    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        wordsRepeat = scan.nextLine().toLowerCase().split("\\W+");
        words = new HashSet<>();

        for (String str : wordsRepeat)
            wordsWithCount.add(str + " -> " + countOccurrences(str) + " times");

        for (String str : wordsWithCount)
            words.add(str);

        maxOccur = getMostFrequentWord();
        words.forEach(word -> {
            if (Integer.parseInt(String.valueOf(word.charAt(word.indexOf("-> ")+3))) == maxOccur)
                System.out.println(word);
        });
    }

    public static int getMostFrequentWord(){
        int maxOccur = Integer.MIN_VALUE;
        for (int i = 0; i < wordsRepeat.length; i++) {
            if (Integer.parseInt(String.valueOf(wordsWithCount.get(i).charAt(wordsWithCount.get(i).indexOf("-> ")+3))) > maxOccur)
                maxOccur = Integer.parseInt(String.valueOf(wordsWithCount.get(i).charAt(wordsWithCount.get(i).indexOf("-> ")+3)));
        }
        return maxOccur;
    }

    public static int countOccurrences(String word){
        int counter = 0;
        for (int i = 0; i < wordsRepeat.length; i++)
            if (wordsRepeat[i].equals(word))
                counter++;
        return counter;
    }
}
