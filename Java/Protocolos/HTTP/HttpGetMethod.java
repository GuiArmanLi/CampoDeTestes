import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

public class HttpGetMethod {
    private static final String GET_URL = "https://www.paixaocontabil.com.br/";

    public static void main(String[] args) {
        getMethod();
    }

    private static void getMethod() {
        try {
            URL url = new URL(GET_URL);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();

            int status = connection.getResponseCode();
            if (status == HttpURLConnection.HTTP_OK) {
                StringBuffer response = new StringBuffer();
                String aux;

                BufferedReader reader = new BufferedReader(new InputStreamReader(connection.getInputStream()));
                while ((aux = reader.readLine()) != null) {
                    response.append(aux);
                }
                reader.close();

                System.out.println(response);
            }

            connection.disconnect();
        } catch (IOException error) {
            System.out.println(error.getMessage());
        }
    }
}
