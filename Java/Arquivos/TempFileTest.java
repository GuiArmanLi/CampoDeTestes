import java.nio.file.Files;
import java.nio.file.Path;

public class TempFileTest {
    public static void main(String[] args) {
        try {
            Path tempFile = Files.createTempFile("Cavalo", ".png");
            System.out.println("Arquivo temporario = " + tempFile.toAbsolutePath());
        } catch (Exception error) {
            error.printStackTrace();
        }
    }
}
