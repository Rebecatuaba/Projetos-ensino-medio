/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package projeto;

/**
 *
 * @author Anchieta
 */
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import javax.swing.JOptionPane;
public class Conexão {
   public static Connection con = null;   
 
 public static void Conectar(){
     System.out.println("Conectando...");
     try{
         Class.forName("com.mysql.jdbc.Driver");
         con = DriverManager.getConnection("jdbc:mysql://127.0.0.1/aula2a", "root", "");
         System.out.println("Conectado");
         
     }
     catch (ClassNotFoundException ex){
         System.out.println("Classe não encontrada");
     }
     catch (SQLException e){
        System.out.println(e);
            JOptionPane.showMessageDialog(null, "Erro ao Conectar" + e,"ERRO",JOptionPane.INFORMATION_MESSAGE);
       
     }
 } 
}
