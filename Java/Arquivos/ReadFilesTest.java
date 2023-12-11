import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.Scanner;

public class ReadFilesTest {
    private final static String FILE = "readFile.txt";

    public static void main(String[] args) {

        System.out.println("-------------------------------------------------------------------------------------");
        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in))) {
            System.out.println("Com InputStream");

            System.out.println(bufferedReader.readLine());
        } catch (Exception error) {
            error.getMessage();
        }

        System.out.println("-------------------------------------------------------------------------------------");
        try (BufferedReader bufferedReader = new BufferedReader(new FileReader(FILE))) {
            System.out.println("Com FileReader");

            while (bufferedReader.ready()) {
                System.out.println(bufferedReader.readLine());
            }
        } catch (Exception error) {
            error.getMessage();
        }

        System.out.println("-------------------------------------------------------------------------------------");
        try (Scanner scanner = new Scanner(Path.of(FILE))) {
            System.out.println("Com Scanner");

            while (scanner.hasNextLine()) {
                System.out.println(scanner.nextLine());
            }
        } catch (Exception error) {
            error.getMessage();
        }

        System.out.println("-------------------------------------------------------------------------------------");
        try {
            System.out.println("Com String + Files");

            String content = new String(Files.readAllBytes(Path.of(FILE)), StandardCharsets.UTF_8);
            System.out.println(content);
        } catch (Exception error) {
            error.getMessage();
        }

        System.out.println("-------------------------------------------------------------------------------------");
        try {
            Path file = Path.of(FILE);
            System.out.println("Com Files");
            System.out.println(Files.readString(file));
        } catch (IOException error) {
            error.getMessage();
        }
    }

}
