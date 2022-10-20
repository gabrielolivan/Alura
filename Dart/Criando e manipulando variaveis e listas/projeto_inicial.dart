void main() {

    int idade = 25;
    double altura = 1.86;
    double alto = 780e6;
    bool geek = (idade == altura);
    const String nome = "Gabriel"; 
    final String sobrenome = "Olivan";
    bool maiorDeIdade;

    String nome1 = 'Ricardo';
    String nome2 = 'Claudia';
    String nome3 = 'Tianta';
    String nome4 = 'Flatelo';
    List<String> listanomes = [nome1, nome2, nome3, nome4];
    List<dynamic> gabriel = [idade, altura, geek, nome, sobrenome];

    String frase = 'Eu sou ${gabriel[3]} ${gabriel[4]}\n'
    'Tenho ${gabriel[0]} anos.\n'
    'Tenho ${gabriel[1]}m de altura.';

    print(idade);
    print(altura);
    print(alto);
    print(geek);
    print(frase);
    print(listanomes);
    print(gabriel);

    if(idade>=18) {
        maiorDeIdade = true;
    } else {
        maiorDeIdade = false;
    }

    print(maiorDeIdade);

    for(int i = 0; i < 5; i++){
        print(i);
    }

    while (maiorDeIdade) {
        print(maiorDeIdade);
        maiorDeIdade = false;
    }

    int energia = 10;
    do {
      print("mais uma repeticao");
      energia -= 6;
    } while (energia>0);


    // comentarios
    /*
    comentarios em varias linhas
    batata
    */ 
}