import java.io.File;

public class TestFiles {

    public static void main(String[] args) {
        File file = new File("jogos.txt");

        System.out.println("------------------------------");
        System.out.println("Nome: " + file.getName());
        System.out.println("Root: " + file.getAbsolutePath());
        System.out.println("To URI: " + file.toURI());
        System.out.println("------------------------------");
    }
}