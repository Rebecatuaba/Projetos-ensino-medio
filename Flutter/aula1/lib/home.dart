//não acredite no Tutu de Canabis

 // ignore_for_file: prefer_const_constructors

 import 'package:flutter/material.dart';

class Home extends StatefulWidget { //Stateful = consegue mudar coisas na pagina      Stateless =  não muda
  Home({super.key});

  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home> {

  String titulo = "Pipoca com sal", image = 'img/Fino.jpg';

  @override
  Widget build(BuildContext context) {

    return Scaffold(
      appBar: AppBar(
        title: Text(titulo),
      ),

      body: Column(
        children: [

        ElevatedButton.icon(
          onPressed: (){},
          icon: Icon(Icons.access_alarm),
          label: Text('algo'),
          ),

        ElevatedButton(
            onPressed: () {
              setState(() { //Verifica um estado / Tem que colocar algo que ira mudar algo

                // if(titulo == "Peida quadrada"){
                //   titulo = "Pipoca com sal";
                // }else{
                //   titulo = "Peida quadrada";
                // }

                titulo = (titulo == "Pipoca com sal")/*Teste*/  ? titulo = 'Peida quadrada' /* Caso verdadeiro */ : titulo = 'Pipoca com sal' /*caso falso*/;
                //Operador ternário (if de uma linha)
                image = (image == 'img/Fino.jpg') ? image = 'img/img1.jpg' : image = 'img/Fino.jpg';

              });
            }, 
            child: Column(
              children: [
                Text("Menu")
              ],
            ),
          ),

          SizedBox( //Cria um espaço vazio
            height: 100,
          ),

        Center(
          child: Image.asset(
            image,
            width: 500,
            height: 500,
          ),
        ),
      ], 
    ),
  );
  }
}