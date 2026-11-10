// ignore_for_file: prefer_const_literals_to_create_immutables, prefer_const_constructors

import 'package:flutter/material.dart';

class Tela1 extends StatefulWidget {
  const Tela1({super.key});

  @override
  State<Tela1> createState() => _Tela1State();
}

class _Tela1State extends State<Tela1> {
  @override
  Widget build(BuildContext context) {
    return  Scaffold(
        body: SingleChildScrollView(
        child: Column(
          children: [
           Container(
              width: double.infinity,
              height: 300,
              child: Image.asset(
                "assets/img/tutu.jpg",
                fit: BoxFit.cover,
              ),
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              children: [
                ElevatedButton.icon(
                  style: ElevatedButton.styleFrom(
                    elevation: 0,
                    backgroundColor: Colors.transparent,
                    shadowColor: Colors.transparent,
                  ),
                  onPressed: () {},
                  icon: const Icon(
                    Icons.thumb_up,
                    size: 22,
                    color: Color.fromARGB(255, 141, 141, 141),
                  ),
                  label: const Text("Curtir"),
                ),
                ElevatedButton.icon(
                  style: ElevatedButton.styleFrom(
                    elevation: 0,
                    backgroundColor: Colors.transparent,
                    shadowColor: Colors.transparent,
                  ),
                  onPressed: () {},
                  icon: const Icon(
                    Icons.comment_bank_outlined,
                    size: 22,
                    color: Color.fromARGB(255, 141, 141, 141),
                  ),
                  label: const Text("Comentar"),
                ),
                ElevatedButton.icon(
                  style: ElevatedButton.styleFrom(
                    elevation: 0,
                    backgroundColor: Colors.transparent,
                    shadowColor: Colors.transparent,
                  ),
                  onPressed: () {},
                  icon: const Icon(
                    Icons.send,
                    size: 22,
                    color: Color.fromARGB(255, 141, 141, 141),
                  ),
                  label: const Text("Enviar"),
                ),
              ],
            ),
            SizedBox(height: 20),
            Row(
              mainAxisAlignment: MainAxisAlignment.start,
              children: [
                CircleAvatar(
                  radius: 25,
                  backgroundImage: AssetImage('assets/img/coquette.jpeg'),
                ),
                const SizedBox(width: 20),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text("Mr. Clant"),
                    const SizedBox(height: 2),
                    Text("há muito tempo atrás", style: TextStyle(fontSize: 12)),
                  ],
                ),
              ],
            ),
            Container(
              width: double.infinity, 
              height: 300,
              child: Image.asset(
                "assets/img/pink.jpg",
                fit: BoxFit.cover,
              ),
          ),
        ],
      ),
    ),
    );
  }
}
