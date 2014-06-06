import java.time.ZonedDateTime;
import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;
import java.util.Date;
import org.joda.time.DateTime;
import org.joda.time.Days;

public class _07_DaysBetweenTwoDates {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter two dates: Format: 11-09-2001");
        String dateStrOne = scan.nextLine();
        String dateStrTwo = scan.nextLine();
        Date past = new Date(Integer.parseInt(dateStrOne.split("-")[2]), Integer.parseInt(dateStrOne.split("-")[1]), Integer.parseInt(dateStrOne.split("-")[0])); // June 20th, 2010
        Date today = new Date(Integer.parseInt(dateStrTwo.split("-")[2]), Integer.parseInt(dateStrTwo.split("-")[1]), Integer.parseInt(dateStrTwo.split("-")[0])); // June 20th, 2010
        System.out.println(Days.daysBetween(new DateTime(past), new DateTime(today)).getDays());
    }
}
