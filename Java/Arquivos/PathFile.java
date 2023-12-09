import java.io.File;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.attribute.FileTime;
import java.nio.file.attribute.UserPrincipal;

public class PathFile {
    public static void main(String[] args) {
        System.out.println("------------------------------------------------");
        Path file = Path.of("text.txt");

        if (!Files.exists(file)) {
            try {
                File newFile = new File("text.txt");
                newFile.createNewFile();

            } catch (Exception e) {
                e.getMessage();
            }
        }
        System.out.println("Name = " + file.getFileName());
        System.out.println("Existe = " + Files.exists(file));

        try {
            UserPrincipal user = Files.getOwner(file);
            System.out.println("Patrao = " + user);

            FileTime fileTime = Files.getLastModifiedTime(file);
            System.out.println("Ultima modificacao = " + fileTime);

            // Como escolher onde o arquivo sera gerado
            Path tempFile = Files.createTempFile("cavalo", ".png");
            System.out.println("Arquivo temporario = " + tempFile);

            // Nao cria um novo diretorio
            // Path path = Path.of("cavalo.txt");
            // Path newDirectory =
            // Files.createDirectories(path.getParent().resolve("some/new/dir"));
            // System.out.println("newDirectory = " + newDirectory);

            Files.writeString(file, "cavalo bombado!");

        } catch (Exception error) {
            error.getMessage();
        }
    }
}
