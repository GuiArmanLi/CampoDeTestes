import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Logger;

public class JDBCMain {
    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        JdbcConnection jdcb = new JdbcConnection();

        Connection connection = jdcb.getConnection();

        try {
            String insert = "insert into pokemon (nome, tipo, nivel) values (?, ?, ?)";
            String delete = "delete * from pokemon";
            String query = "select * from pokemon";

            PreparedStatement statement = connection.prepareStatement(insert);

            statement.setString(1, "Charmander");
            statement.setString(2, "Fogo");
            statement.setInt(3, 14);
            statement.execute();
            statement.close();

            ResultSet result = statement.executeQuery(query);

            System.out.println(result);// usa while se n for como um array

            // String uptade = "update pokemon set nome = 'Charizard'";
            // connection.createStatement().executeUpdate(uptade);

        } catch (SQLException error) {
            Logger.getLogger("Erro").warning(error.getMessage());
        }

    }
}