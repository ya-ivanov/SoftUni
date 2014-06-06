import java.util.*;

public class _10_ExtractUniqueWords {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        String[] text = scan.nextLine().toLowerCase().split("\\W+");
        Set<String> words = new HashSet<>();

        for (String s : text)
            words.add(s);
        List<String> list = new ArrayList<String>();

        for (String s : words)
            list.add(s);

        Collections.sort(list);
        list.forEach(x -> System.out.println(x));
    }
}
