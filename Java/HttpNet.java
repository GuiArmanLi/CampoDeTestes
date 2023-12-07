import java.net.MalformedURLException;
import java.net.URL;

public class HttpNet {
    private static String GET_URL = "http://127.0.0.1:5500/index.html";

    public static void main(String[] args) {
        try {
            URL url = new URL(GET_URL);
            String receive = url.getHost();
            System.out.println(receive);

        } catch (MalformedURLException error) {
            System.out.println(error.getMessage());
        }
    }

}
