/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tela;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import javax.swing.JOptionPane;
/**
 *
 * @author Anchieta
 */
public class Conexao {
 public static Connection con = null;   
 
 public static void Conectar(){
     System.out.println("Conectando...");
     try{
         Class.forName("com.mysql.jdbc.Driver");
         con = DriverManager.getConnection("jdbc:mysql://127.0.0.1/solta", "root", "");
         System.out.println("Conectado com sucesso!!!");
         
     }
     catch (ClassNotFoundException eee){
         System.out.println("Classe não encontrada, adicione o driver nas bibliotecas.");
     }
     catch (SQLException erro){
        System.out.println(erro);
            JOptionPane.showMessageDialog(null, "Erro ao Conectar" + erro,"ERRO",JOptionPane.INFORMATION_MESSAGE);
        throw new RuntimeException(erro);
         
     }
 }
 
}
