import java.io.BufferedReader;
import java.io.FileReader;

public class _08_SumNumbersFromTextFile {
    public static void main(String[] args){
        int sum = 0;
        try{
            BufferedReader reader = new BufferedReader(new FileReader("src\\numbers_to_sum.txt"));
            String line = "";
            while ((line = reader.readLine()) != null) {
                sum+=Integer.parseInt(line);
            }
            System.out.println(sum);
        }catch (Exception e){
            System.out.printf("Error: [Missing File]");
        }
    }
}
