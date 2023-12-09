import java.util.Scanner;

public class Primo {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numero = scanner.nextInt();

        int point = 0;
        for (int i = 1; i <= numero; i++) {
            if (numero % i == 0) {
                point++;
            }
        }

        if (point == 2) {
            System.out.println("Primo");
        } else {
            System.out.println("Nao primo");
        }

        scanner.close();
    }

}
