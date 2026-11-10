// ignore_for_file: prefer_const_constructors

import 'package:flutter/material.dart';
import 'package:pulsator/pulsator.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        body: Center(
          child: PulseIcon(
            icon: Icons.add,
            pulseColor: Colors.blue,
            iconSize: 44.0,
            innerSize: 54.0,
            pulseSize: 116.0,
          ),
        ),
      ),
    );
  }
}

