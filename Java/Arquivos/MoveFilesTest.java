import java.nio.file.Files;
import java.nio.file.Path;

public class MoveFilesTest {
    public static void main(String[] args) {
        Path file = Path.of("moveFile.txt");

        System.out.println("=========================================");

        boolean existFile = Files.exists(file);
        if (!existFile) {
            try {
                Files.createFile(file);
            } catch (Exception error) {
                error.getMessage();
            }
        }

        try {
            String fileName = file.getFileName().toString();
            Files.move(file, Path.of("C:\\Users\\Gui\\OneDrive\\Anexos\\Área de Trabalho\\" + fileName));

        } catch (Exception error) {
            error.getMessage();
        }
        System.out.println("=========================================");
    }
}
