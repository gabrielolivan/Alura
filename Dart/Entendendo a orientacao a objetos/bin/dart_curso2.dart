void main() {

  Legumes mandioca1 = Legumes('macaxeira', 1200, 'Marrom', true);
  Fruta banana1 = Fruta('Banana', 75.2, 'Amarela', 'Doce', 12);
  Nozes macadamia1 = Nozes('Macadamia', 2, 'Branco Amarelado', 'Doce', 20, 35);
  Citricas limao1 = Citricas('Limao', 100, 'verde', 'Azedo', 5, 9);

  macadamia1.printAlimento();
  banana1.printAlimento();
  mandioca1.printAlimento();
  limao1.printAlimento();

  mandioca1.cozinhar();
  limao1.fazerSuco();
  limao1.assar();
}


int funcQuantosDiasMadura(int dias) {
  int diasParaMadura = 30;
  int quantosDiasFaltam = diasParaMadura - dias;
  return quantosDiasFaltam;
}

void mostrarMadura(String nome, int dias, {required String? cor}) {
  if (dias >= 30) {
    print("A $nome está madura");
  } else {
    print("A $nome está madura");
  }
  if(cor != null){
    print("A cor da $nome é $cor");
  }
}

bool funcEstaMadura(int dias) {
  if (dias >= 30) {
    return true;
  } else {
    return false;
  }
}

class Alimento {
  String nome;
  double peso;
  String cor;

  Alimento(this.nome, this.peso, this.cor);

  void printAlimento() {
    print('Este(a) $nome pesa $peso gramas e é $cor.');
  }
}

class Fruta extends Alimento implements Bolo{

  String sabor;
  int diasDesdeColheita;
  bool? isMadura;

  Fruta(String nome, double peso, String cor, this.sabor, this.diasDesdeColheita, {this.isMadura}) 
    : super(nome, peso, cor);

  void estaMadura(int diasParaMadura) {
    isMadura = diasDesdeColheita >= diasParaMadura;
    print("A sua $nome foi colhida a $diasDesdeColheita dias, e precisa de $diasParaMadura para poder comer. Ela está madura? $isMadura");
  }

  void fazerSuco() {
    print('Você fez um ótimo suco de $nome');
  }
  
  @override
  void assar() {
    print('colocar no forno');
  }
  
  @override
  void fazerMassa() {
    print('Misturar a fruta');
  }
  
  @override
  void separarIngredientes() {
    print('catar a fruta');
  }

}

class Legumes extends Alimento implements Bolo{

  bool isPrecisaCozinhar;

  Legumes(String nome, double peso, String cor, this.isPrecisaCozinhar) : super(nome, peso, cor);

  void cozinhar() {
    if(isPrecisaCozinhar) {
      print('Pronto, o $nome está cozinhando!');
    } else {
      print('Nem precisa cozinhar.');
    }
  }
  
  @override
  void assar() {
    // TODO: implement assar
  }
  
  @override
  void fazerMassa() {
    // TODO: implement fazerMassa
  }
  
  @override
  void separarIngredientes() {
    // TODO: implement separarIngredientes
  }



}

class Citricas extends Fruta{
  double nivelAzedo;

  Citricas(String nome, double peso, String cor, String sabor, int diasDesdeColheita, this.nivelAzedo)
    : super(nome, peso, cor, sabor, diasDesdeColheita);
  
  void existeRefri(bool existe) {
    if(existe){
      print('Existe refrigerante de $nome');
    } else {
      print('Não existe refri de $nome');
    }
  }

  @override
  void assar() {
    print('descascar o(a) $nome');
    super.assar();
  }
}

class Nozes extends Fruta {
  double porcentagemOleoNatural;

  Nozes(String nome, double peso, String cor, String sabor, int diasDesdeColheita, this.porcentagemOleoNatural)
    : super(nome, peso, cor, sabor, diasDesdeColheita);

}

abstract class Bolo {
  
  void separarIngredientes();
  void fazerMassa();
  void assar();

}

