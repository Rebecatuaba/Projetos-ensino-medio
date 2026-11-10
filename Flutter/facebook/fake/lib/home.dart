// ignore_for_file: prefer_const_constructors

import 'package:flutter/material.dart';


class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text(
          "fakebook",
          style: TextStyle(
            fontWeight: FontWeight.bold,
            color: Color.fromARGB(255, 28, 107, 197),
          ),
        ),
        backgroundColor: const Color.fromARGB(255, 255, 255, 255),
        shadowColor: const Color.fromARGB(0, 196, 39, 39),
      ),
      body: SingleChildScrollView(
        child: Column(
          children: [
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                ElevatedButton.icon(
                  style: ElevatedButton.styleFrom(
                    elevation: 0,
                    backgroundColor: Colors.transparent,
                    shadowColor: Colors.transparent,
                  ),
                  onPressed: () {},
                  icon: const Icon(
                    size: 30,
                    color: Color.fromARGB(255, 141, 141, 141),
                    Icons.home,
                  ),
                  label: const Text(""),
                ),
                ElevatedButton.icon(
                  style: ElevatedButton.styleFrom(
                    elevation: 0,
                    backgroundColor: Colors.transparent,
                    shadowColor: Colors.transparent,
                  ),
                  onPressed: () {},
                  icon: const Icon(
                    size: 30,
                    color: Color.fromARGB(255, 141, 141, 141),
                    Icons.add_to_queue,
                  ),
                  label: const Text(""),
                ),
                ElevatedButton.icon(
                  style: ElevatedButton.styleFrom(
                    elevation: 0,
                    backgroundColor: Colors.transparent,
                    shadowColor: Colors.transparent,
                  ),
                  onPressed: () {},
                  icon: const Icon(
                    size: 30,
                    color: Color.fromARGB(255, 141, 141, 141),
                    Icons.add_business_outlined,
                  ),
                  label: const Text(""),
                ),
                ElevatedButton.icon(
                  style: ElevatedButton.styleFrom(
                    elevation: 0,
                    backgroundColor: Colors.transparent,
                    shadowColor: Colors.transparent,
                  ),
                  onPressed: () {},
                  icon: const Icon(
                    size: 30,
                    color: Color.fromARGB(255, 141, 141, 141),
                    Icons.account_circle_outlined,
                  ),
                  label: const Text(""),
                ),
                ElevatedButton.icon(
                  style: ElevatedButton.styleFrom(
                    elevation: 0,
                    backgroundColor: Colors.transparent,
                    shadowColor: Colors.transparent,
                  ),
                  onPressed: () {},
                  icon: const Icon(
                    size: 30,
                    color: Color.fromARGB(255, 141, 141, 141),
                    Icons.doorbell_outlined,
                  ),
                  label: const Text(""),
                ),
                ElevatedButton.icon(
                  style: ElevatedButton.styleFrom(
                    elevation: 0,
                    backgroundColor: Colors.transparent,
                    shadowColor: Colors.transparent,
                  ),
                  onPressed: () {},
                  icon: const Icon(
                    size: 30,
                    color: Color.fromARGB(255, 141, 141, 141),
                    Icons.menu,
                  ),
                  label: const Text(""),
                ),
              ],
            ),
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
