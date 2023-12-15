import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class HttpURLConnectionExample {
	private static final String POST_URL = "https://reqres.in/api/register";

	private static final String POST_PARAMS = "email=eve.holt@reqres.in&password=pistol";

	public static void main(String[] args) throws IOException {
		sendPOST();
	}

	private static void sendPOST() throws IOException {
		URL url = new URL(POST_URL);
		HttpURLConnection connnection = (HttpURLConnection) url.openConnection();

		connnection.setDoOutput(true);
		OutputStream outputStream = connnection.getOutputStream();
		outputStream.write(POST_PARAMS.getBytes());
		outputStream.close();

		if (connnection.getResponseCode() == HttpURLConnection.HTTP_OK) {
			String aux;
			StringBuffer response = new StringBuffer();

			BufferedReader reader = new BufferedReader(new InputStreamReader(connnection.getInputStream()));
			while ((aux = reader.readLine()) != null) {
				response.append(aux);
			}
			reader.close();

			System.out.println(response.toString());
		}
	}
}