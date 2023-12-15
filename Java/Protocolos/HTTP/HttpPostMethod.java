import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class HttpPostMethod {

    private static final String PATH_URL = "https://reqres.in/api/register";
    private static final String PARAMS = "email=eve.holt@reqres.in&password=pistol";

    public static void main(String[] args) {
        postMethod(PATH_URL, PARAMS);
    }

    private static void postMethod(String pathURL, String params) {
        try {
            URL url = new URL(pathURL);

            HttpURLConnection connection = (HttpURLConnection) url.openConnection();

            connection.setDoOutput(true);
            OutputStream output = connection.getOutputStream();
            output.write(params.getBytes());
            output.flush();
            output.close();

            if (connection.getResponseCode() == HttpURLConnection.HTTP_OK) {
                StringBuffer result = new StringBuffer();
                String aux;

                BufferedReader reader = new BufferedReader(new InputStreamReader(connection.getInputStream()));
                while ((aux = reader.readLine()) != null) {
                    result.append(aux);
                }
                reader.close();
                connection.disconnect();

                System.out.println(result);
            }
        } catch (IOException error) {
            System.out.println(error.getMessage());
        }
    }
}
