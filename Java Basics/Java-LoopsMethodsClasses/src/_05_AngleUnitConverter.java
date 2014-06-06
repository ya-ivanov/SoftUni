import java.util.Scanner;

public class _05_AngleUnitConverter {
    public static void main(String[] main){
        Scanner scan = new Scanner(System.in);
        System.out.println("How many querys?");
        int times = Integer.parseInt(scan.nextLine());
        String[] input = new String[times];

        System.out.println("Enter them:");
        for (int i = 0; i< times; i++) input[i] = scan.nextLine();

        for (int i = 0; i < times; i++){
            String[] details = input[i].split(" ");
            if (details[1].equals("rad")){System.out.printf("%.6f deg\n",  toDegrees(Double.parseDouble(details[0])));}
            else if (details[1].equals("deg")){System.out.printf("%.6f rad\n",  toRadians(Double.parseDouble(details[0])));}
            else {System.out.println("Wrong input");}
        }
    }

    public static double toDegrees(double radians){
        return radians*(180/Math.PI);
    }

    public static double toRadians(double degrees){
        return degrees* (Math.PI/180);
    }
}
