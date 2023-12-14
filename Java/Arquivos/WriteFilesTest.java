import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.OutputStreamWriter;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.Random;

public class WriteFilesTest {
    private static final String FILE = "writeFile.txt";

    public static void main(String[] args) {
        Path file = Path.of(FILE);

        try (BufferedWriter writer = Files.newBufferedWriter(file)) {
            writer.write("Escolha um cavalo para apostar");
            writer.newLine();

            for (int i = 0; i < 10; i++) {
                Random random = new Random();
                writer.append("Cavalo n" + random.nextInt(0, 100));
                writer.newLine();
            }
        } catch (IOException error) {
            error.getMessage();
        }

        try (OutputStreamWriter osw = new OutputStreamWriter(System.out);) {
            osw.write("Hello World");
            osw.write(111);
        } catch (Exception error) {
            error.getMessage();
        }

        try (FileWriter fl = new FileWriter(FILE, true)) {
            fl.write("Same thing, but different");
            fl.write(111);
            fl.append("Isso esta appendando");
        } catch (Exception error) {
            System.out.println(error.getMessage());
        }

        try {
            File files = new File("caralho.txt");
            while (files.canWrite()) {
                System.out.println("Do something!");
            }
        } catch (Exception error) {
            System.out.println(error.getMessage());
        }
    }
}
