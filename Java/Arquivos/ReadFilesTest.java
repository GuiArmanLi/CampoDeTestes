import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;

public class ReadFilesTest {
    public static void main(String[] args) {
        Path file = Path.of("cavalo.txt");

        try {
            String text = Files.readString(file);
            System.out.println(text);

            // Scanner scanner = new Scanner(file);
            // while (scanner.hasNextLine()) {
            // System.out.println();
            // String output = scanner.nextLine();
            // System.out.println(output);
            // }
        } catch (IOException error) {
            error.printStackTrace();
        }
    }

}
