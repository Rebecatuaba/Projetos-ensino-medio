// ignore_for_file: prefer_const_constructors

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home> {
  final _form = GlobalKey<FormState>();
  final _valor = TextEditingController();
  final _nome = TextEditingController();

  enviar() {
    if (_form.currentState!.validate()) {
      // salvar
      _nome.clear();
      _valor.clear();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          content: Text('Operação realizada!'),
        ),
      );

    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Formulários'),
      ),
      body: Padding(
        padding: const EdgeInsets.all(10),
        child: ListView(children: [
          Column(
            children: [
              Form(
                key: _form,
                child: Column(
                  children: [
                    TextFormField(
                      controller: _nome,
                      style: TextStyle(fontSize: 22),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(),
                        labelText: 'Nome',
                        prefixIcon: Icon(Icons.abc),
                      ),
                      keyboardType: TextInputType.name,
                      //keyboardType: TextInputType.emailAddress,

                      validator: (value) {
                        if (value!.isEmpty) {
                          return 'Informe o nome';
                        }
                        return null;
                      },
                    ),
                    SizedBox(
                      height: 10,
                    ),
                    TextFormField(
                      controller: _valor,
                      style: TextStyle(fontSize: 22),
                      decoration: InputDecoration(
                        border: OutlineInputBorder(),
                        labelText: 'Valor',
                        prefixIcon: Icon(Icons.monetization_on_sharp),
                        suffix: Text(
                          'reais',
                          style: TextStyle(fontSize: 14),
                        ),
                      ),
                      keyboardType: TextInputType.number,
                      //keyboardType: TextInputType.emailAddress,
                      inputFormatters: [
                        FilteringTextInputFormatter.digitsOnly,
                      ],
                      validator: (value) {
                        if (value!.isEmpty) {
                          return 'Informe o valor da compra';
                        } else if (double.parse(value) <= 50) {
                          return 'Valor inferior a R\$ 50,00';
                        }
                        return null;
                      },
                    ),
                  ],
                ),
              ),
              Container(
                alignment: Alignment.bottomCenter,
                margin: EdgeInsets.only(top: 24),
                child: ElevatedButton(
                  onPressed: enviar,
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: const [
                      Icon(Icons.check),
                      Padding(
                        padding: EdgeInsets.all(16),
                        child: Text(
                          'Comprar',
                          style: TextStyle(fontSize: 20),
                        ),
                      )
                    ],
                  ),
                ),
              )
            ],
          ),
        ]),
      ),
    );
  }
}
