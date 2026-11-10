
package chat;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import javax.swing.JOptionPane;


public class ConexaoLogin {
    public static Connection con = null;
    
    public static void Conectar(){
    System.out.println("Conectando ao banco...");
    
    try {
        Class.forName("com.mysql.cj.jdbc.Driver");
        con = DriverManager.getConnection(
                "jdbc:mysql://127.0.0.1/Chat",
                "root","");
        System.out.println("Conectado. ");
        
    }catch(ClassNotFoundException ex) {
        System.out.println("Classe não encontrada, adicione o driver na bibliotecas.");
    } catch(SQLException e) {
        JOptionPane.showMessageDialog(null, "Erro ao conectar" + e,"ERRO", JOptionPane.INFORMATION_MESSAGE);
        throw new RuntimeException(e);
    
        
    }
    }
}
