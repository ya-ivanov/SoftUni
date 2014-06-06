import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _02_SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] strings = scan.nextLine().split(" ");
        List<String> sequences = new ArrayList<>();
        List<String> sequencesDone = new ArrayList<>();

        for (String str : strings) {
            if (sequences.indexOf(str) == -1) {
                sequences.add(str);
                sequencesDone.add(str);
            } else {
                sequencesDone.set(sequences.indexOf(str), sequencesDone.get(sequences.indexOf(str)) +  " " + str);
            }
        }
        sequencesDone.forEach(str -> System.out.println(str));
    }
}
