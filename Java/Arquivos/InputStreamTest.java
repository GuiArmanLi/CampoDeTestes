import java.io.IOException;
import java.io.InputStreamReader;

class InputStreamTest {
    public static void main(String[] args) {
        try (InputStreamReader fr = new InputStreamReader(System.in)) {
            int letters = fr.read();

            while (fr.ready()) {
                System.out.print((char) letters);
                letters = fr.read();
            }

            System.out.println();
        } catch (IOException error) {
            error.getMessage();
        }
    }
}