import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _03_LargestSeqOfEqualStrings {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] strings = scan.nextLine().split(" ");
        int max = Integer.MIN_VALUE;
        int maxCurrent = Integer.MIN_VALUE;
        String seq = strings[0], seqCurrent=strings[0];

        for (int i = 0; i < strings.length-1; i++) {
            if (strings[i].equals(strings[i+1])){
                maxCurrent++;
                seqCurrent+=strings[i] + " ";
            } else {
                maxCurrent = 0;
                seqCurrent = "";
            }
            if (maxCurrent > max){
                seq = seqCurrent;
                max = maxCurrent;
            }
        }

        System.out.println(seq + (seq.split(" ").length > 1 ? seq.split(" ")[0] : " "));
    }
}
