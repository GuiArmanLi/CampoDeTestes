import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class JdbcConnection {
    private String driver = "com.mysql.jdbc.Driver";
    private String url = "jdbc:mysql://localhost:3306/";
    private String user = "root";
    private String passwrod = "root";

    public Connection getConnection() throws SQLException, ClassNotFoundException {
        Class.forName(this.driver);
        return DriverManager.getConnection(this.url, this.user, this.passwrod);
    }
}
