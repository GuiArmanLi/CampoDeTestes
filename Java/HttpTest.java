import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Scanner;

public class HttpTest {
    public static String GET_URL;

    public static void main(String[] args) {
        System.out.println("Primeiro GET nativo");
        getUrl();
        try {

            getName();
        } catch (Exception e) {
            e.getMessage();
        }
    }

    private static void getName() throws Exception {
        URL url = new URL(GET_URL);
        HttpURLConnection connection = (HttpURLConnection) url.openConnection();

        connection.setRequestMethod("GET");
        connection.setRequestProperty("User-Agent", "Chorme");

        int responseCode = connection.getResponseCode();
        System.out.println(responseCode);

        if (responseCode == HttpURLConnection.HTTP_OK) { // success
            BufferedReader in = new BufferedReader(new InputStreamReader(connection.getInputStream()));
            String inputLine;
            StringBuffer response = new StringBuffer();

            while ((inputLine = in.readLine()) != null) {
                response.append(inputLine);
            }
            in.close();

            System.out.println(response.toString());
        } else {
            System.out.println("GET request did not work.");
        }
    }

    private static void getUrl() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Entre com uma URL e os parametros");
        GET_URL = scanner.nextLine();
    }
}
