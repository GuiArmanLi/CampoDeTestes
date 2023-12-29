import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class IteratorTest {
    public static void main(String[] args) {
        List<String> nomes = new ArrayList<>();

        nomes.add("Maria");
        nomes.add("Guilherme");
        nomes.add("Paulo");
        nomes.add("Kauan");

        Iterator<String> i = nomes.iterator();

        while (i.hasNext()) {
            System.out.println(i.next());

        }
    }
}
