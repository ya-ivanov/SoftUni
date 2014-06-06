import java.util.Scanner;

public class _02_TriangleArea {
    public static void main(String[] args){
        double[] a = new double[2];
        double[] b = new double[2];
        double[] c = new double[2];

        Scanner scan = new Scanner(System.in);

        System.out.println("Enter coordinates (x and y) for point 'A':");
        a[0] = scan.nextDouble();
        a[1] = scan.nextDouble();

        System.out.println("Enter coordinates (x and y) for point 'B':");
        b[0] = scan.nextDouble();
        b[1] = scan.nextDouble();

        System.out.println("Enter coordinates (x and y) for point 'C':");
        c[0] = scan.nextDouble();
        c[1] = scan.nextDouble();

        double area = ((a[0]*(b[1]-c[1]) + (b[0]*(c[1]-a[1]) + (c[0]*(a[1]-b[1])))))/2;

        if (area > 0)
            System.out.println("Area: " + area);
        else
            System.out.println("Area: " + (area*(-1)));

    }
}
