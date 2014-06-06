import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _08_ExtractEmails {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        String words = scan.nextLine().toLowerCase();
        Set<String> emails = new HashSet<String>();

        Pattern p = Pattern.compile("\\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,4}\\b", Pattern.CASE_INSENSITIVE);
        Matcher matcher = p.matcher(words);

        while(matcher.find())   emails.add(matcher.group());

        emails.forEach(x -> System.out.println(x));
    }
}
