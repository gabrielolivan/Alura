console.log('Trabalhando com condicionais');

const listaDeDestinos = new Array(
    'Salvador',
    'São Paulo',
    'Rio de Janeiro',
);

//console.log(listaDeDestinos);

const idadeComprador = 15;
const estaAcompanhada = true;
const temPassagemComprada = true;

if(idadeComprador >= 18 || estaAcompanhada) {
    console.log('Boa compra');
    console.log(listaDeDestinos);
} else {
    console.log('Comprador é menor de idade');
}

console.log('Embarque: \n\n');
if((idadeComprador >= 18 || estaAcompanhada) && temPassagemComprada){
    console.log('Boa viagem');
} else {
    console.log('Não pode viajar');
}