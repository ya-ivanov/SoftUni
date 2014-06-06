import java.util.*;

public class _04_LongestIncreasingSequence {
    public static void main(String[] args){
        System.out.println("Enter sequence");
        Scanner scan = new Scanner(System.in);
        String[] numbersStr = scan.nextLine().split(" ");
        List<Integer> nums = new ArrayList<>();
        List<String> seqs = new ArrayList<>();
        String temp = "";

        for (String num : numbersStr)
            nums.add(Integer.parseInt(num));

        for (int i = 1; i < nums.size(); i++){
            if (nums.get(i-1) < nums.get(i))
                temp+=(nums.get(i - 1) + " ");
             else {
                temp += (nums.get(i - 1) + " ");
                seqs.add(temp);
                temp = "";
            }
        }

        temp+=(nums.get(nums.size()-1));
        seqs.add(temp);
        seqs.forEach(x -> System.out.println(x));

        int longestElement = 0;

        for (int i = 1; i < seqs.size(); i++)
            if (seqs.get(i).length() > seqs.get(longestElement).length())
                longestElement = i;

        System.out.print("Longest: " + seqs.get(longestElement));
    }
}
