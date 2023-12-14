import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.StandardCopyOption;
import java.util.Random;
import java.util.Scanner;

public class MoveFilesTest {
    private static final String FILE = "C:\\Users\\Gui\\OneDrive\\Anexos\\Área de Trabalho\\";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Deseja criar quantos arquivos aleatórios?");
        int quantidade = scanner.nextInt();

        Random random = new Random();
        for (int i = 0; i < quantidade; i++) {
            int numberNameFile = random.nextInt(1, 100);
            String nameFile = String.valueOf(numberNameFile) + ".txt";

            Path file = Path.of(nameFile);
            if (!Files.exists(file)) {
                try {
                    Files.createFile(file);
                } catch (Exception error) {
                    error.getMessage();
                }
            }

            try {
                String movePath = FILE;
                String fileName = file.getFileName().toString();
                String destiny = movePath + fileName;
                Files.move(file, Path.of(destiny), StandardCopyOption.REPLACE_EXISTING);

            } catch (Exception error) {
                error.getMessage();
            }
        }

        scanner.close();
    }
}
