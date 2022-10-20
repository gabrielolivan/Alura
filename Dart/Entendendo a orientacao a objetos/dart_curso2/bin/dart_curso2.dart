void main() {
  String nome = "Laranja";
  double peso = 100.2;
  String cor = "Verde e Amarela";
  String sabor = "Doce e cítrica";
  int diasDesdeColheita = 20;
  bool isMadura = funcEstaMadura(diasDesdeColheita);

  mostrarMadura("Uva", 40, cor: "roxa");

  int quantosDias = funcQuantosDiasMadura(diasDesdeColheita);
  print(quantosDias);


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