import java.io.BufferedWriter;
import java.io.IOException;
import java.io.OutputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.Random;

public class WriteFilesTest {
    public static void main(String[] args) {
        Path file = Path.of("cavalo.txt");

        try (BufferedWriter writer = Files.newBufferedWriter(file);
                OutputStream outputStream = Files.newOutputStream(file)) {

            if (!Files.exists(file)) {
                file = Files.createFile(file);
            }

            // FileWriter fileWriter = new FileWriter(file);
            // fileWriter.write(file.getAbsolutePath());
            // fileWriter.close();

            for (int i = 0; i < 10; i++) {
                Random random = new Random();
                writer.write("Cavalo n" + random.nextInt(0, 100));
                writer.newLine();
            }

            String text = Files.readString(file).toUpperCase();
            System.out.println(text);

        } catch (IOException error) {
            error.getMessage();
        }
    }
}
