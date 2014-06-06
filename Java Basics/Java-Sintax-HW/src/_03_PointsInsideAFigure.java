import java.util.Scanner;

public class _03_PointsInsideAFigure {
    public static void main(String args[]){
        System.out.println("Enter x and y :");
        Scanner input = new Scanner(System.in);
        double[] point = new double[2];
        point[1] = input.nextDouble();
        point[0] = input.nextDouble();
        System.out.println(isInsideFigure(point) ? "Inside" : "Outside");
    }

    private static boolean isInsideFigure(double[] point) {
        if (point[0] >= 6 && point[0] <= 13.5){
            if (point[1] >= 12.5 && point[1] <= 22.5){
                if (point[1] > 17.5 && point[1] < 20 && point[0] > 8.5){
                    return false;
                }
                else return true;
            } else return false;
        } else return false;
    }
}
