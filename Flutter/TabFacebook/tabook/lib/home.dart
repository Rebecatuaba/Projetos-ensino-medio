// ignore_for_file: prefer_const_constructors, prefer_const_literals_to_create_immutables

import 'package:flutter/material.dart';

import 'tela1.dart';
import 'tela2.dart';
import 'tela3.dart';
import 'tela4.dart';
import 'tela5.dart';
import 'tela6.dart';

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: DefaultTabController(
        length: 6,
        child: Scaffold(
          appBar: AppBar(
            title: Text('Facebook', 
            style: TextStyle(color: Color.fromARGB(255, 28, 107, 197),
            fontWeight: FontWeight.bold,
            )),
            bottom: TabBar(
              indicatorColor: Color.fromARGB(255, 0, 170, 255),
              indicatorSize: TabBarIndicatorSize.label,
              tabs: [
                Tab(
                  icon: Icon(Icons.home, color: Color.fromARGB(255, 141, 141, 141),),
                ),
                Tab(
                  icon: Icon(Icons.add_to_queue, color: Color.fromARGB(255, 141, 141, 141),),
                ),
                Tab(
                  icon: Icon(Icons.add_business_outlined, color: Color.fromARGB(255, 141, 141, 141),),
                ),
                Tab(
                  icon: Icon(Icons.account_circle_outlined, color: Color.fromARGB(255, 141, 141, 141),),
                ),
                Tab(
                  icon: Icon(Icons.doorbell_rounded, color: Color.fromARGB(255, 141, 141, 141),),
                ),
                Tab(
                  icon: Icon(Icons.menu, color: Color.fromARGB(255, 141, 141, 141),),
                ),
              ]
              ),
          ),
          body: 
          TabBarView(
            children: [
              
              Tela1(),
              Tela2(),
              Tela3(),
              Tela4(),
              Tela5(),
              Tela6(),
             
            ],
            
            ),
        ),
      ),
    );
  }
}