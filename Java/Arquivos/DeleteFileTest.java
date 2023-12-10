import java.nio.file.Files;
import java.nio.file.Path;

public class DeleteFileTest {
    public static void main(String[] args) {
        Path file = Path.of("deleteFile.txt");

        boolean exist = Files.exists(file);
        if (!exist) {
            try {
                Files.createFile(file);
                System.out.println("Arquivo criado!");
            } catch (Exception error) {
                error.getMessage();
            }
        }

        try {
            Files.delete(file);
            System.out.println("Arquivo excluido!");
        } catch (Exception e) {
            e.getMessage();
        }

    }
}
