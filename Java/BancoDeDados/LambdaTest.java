import java.util.HashMap;
import java.util.Map;

public class LambdaTest {
    public static void main(String[] args) {
        Map<String, Integer> nomes = new HashMap<>();

        nomes.put("Kauan", 1);
        nomes.put("Lucas", 2);
        nomes.put("Paulo", 3);
        nomes.put("Guilherme", 4);
        nomes.put("Gabriel", 5);

        nomes.forEach((name, key) -> System.out.println("Nome: " + name + ". Key: " + key));

    }
}
