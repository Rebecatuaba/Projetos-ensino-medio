// ignore_for_file: override_on_non_overriding_member

import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  Home({super.key});

  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  
  String texto= "bolas";
  
  Widget build(BuildContext context) {
    return  Scaffold(
      appBar: AppBar(
        title: Text('Meu cù(app)'),
      ),
      body: Column(
        children: [
          ElevatedButton(
            onPressed: () {
              setState(() {
                texto= 'sorvete';
              });
            },
            child: Row(

            )
            ),
        ],
      )
    );
    return const Placeholder();
  }
}