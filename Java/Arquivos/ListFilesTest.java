import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;

public class ListFilesTest {
    public static void main(String[] args) {
        Path dir = Path.of("C:\\Users\\Gui\\OneDrive\\Anexos\\Área de Trabalho\\Gabriel_PenDive");

        try (var files = Files.walk(dir)) {
            files.forEach((iterator) -> {
                System.out.println(iterator.toString());
            }

            );
        } catch (IOException error) {
            error.printStackTrace();
        }
    }
}
