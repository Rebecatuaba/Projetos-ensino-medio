// ignore_for_file: prefer_const_constructors, prefer_const_literals_to_create_immutables

import 'package:flutter/material.dart';

import 'tela4.dart';
import 'tela5.dart';

void main() {
  runApp(const MainApp());
}

class MainApp extends StatefulWidget {
  const MainApp({super.key});

  @override
  State<MainApp> createState() => _MainAppState();
}

class _MainAppState extends State<MainApp> {
  int indice=3;

  @override
  Widget build(BuildContext context) {
    return  MaterialApp(
      home: Scaffold(
        body: [
          Center(
            child: 
            Text('tela 1'),
            ),
            Center(
            child: 
            Text('tela 2'),
            ),
            Center(
            child: 
            Text('tela 3'),
            ),
            Tela4(),
            Tela5(),
        ][indice],
        bottomNavigationBar: 
          NavigationBar(
            selectedIndex: indice,
            onDestinationSelected: (int index){
              setState(() {
                indice = index;
              });
            },
            destinations: <NavigationDestination>[
              NavigationDestination(
                icon: Icon(Icons.abc_outlined), 
                label: 'Tela 1'),
               NavigationDestination(
                icon: Icon(Icons.abc_outlined), 
                label: 'Tela 2'),
                NavigationDestination(
                icon: Icon(Icons.abc_outlined), 
                label: 'Tela 3'),
                NavigationDestination(
                icon: Icon(Icons.abc_outlined), 
                label: 'Tela 4'),
                NavigationDestination(
                selectedIcon: Icon(Icons.ac_unit_sharp),
                icon: Icon(Icons.abc_outlined),
                tooltip: 'aqui vai a tela 5', 
                label: 'Tela 5'), 
            ],
             ),
      ),
    );
  }
}