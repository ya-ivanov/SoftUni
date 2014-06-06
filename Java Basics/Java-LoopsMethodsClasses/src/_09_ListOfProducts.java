import java.io.BufferedReader;
import java.io.FileReader;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

public class _09_ListOfProducts {
    public static void main(String[] args){

        List<Product> products = new ArrayList<>();
        try{
            BufferedReader reader = new BufferedReader(new FileReader("src\\input.txt"));
            String line = "";
            while ((line = reader.readLine()) != null)
                products.add(new Product(Double.parseDouble(line.split(" ")[1]), line.split(" ")[0]));
            reader.close();
        }catch (Exception e){
            System.out.printf(e.getMessage() + e.getCause() + e.toString());
        }

        products.sort(new PriceComparator());

        try{
            PrintWriter writer = new PrintWriter("src\\output.txt", "UTF-8");
            products.forEach(product -> {
                System.out.println(product.getName() + " " + product.getPrice());
                writer.println(product.getName() + " " + product.getPrice());
            });
            writer.close();
        }catch (Exception e){
            System.out.printf(e.getMessage() + e.getCause() + e.toString());
        }
    }
}

class Product{
    private double price;
    private String name;

    Product(double price, String name) {
        this.price = price;
        this.name = name;
    }

    public double getPrice() {
        return price;
    }

    public String getName() {
        return name;
    }
}

class PriceComparator implements Comparator<Product> {
    @Override
    public int compare(Product a, Product b) {
        return a.getPrice() < b.getPrice()  ? -1 : a.getPrice()  == b.getPrice()  ? 0 : 1;
    }
}