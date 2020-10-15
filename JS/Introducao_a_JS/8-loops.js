console.log('\nTrabalhando com loops\n');

const listaDeDestinos = new Array(
    'Salvador',
    'São Paulo',
    'Rio de Janeiro',
);

//console.log(listaDeDestinos);

const idadeComprador = 15;
const estaAcompanhada = true;
let temPassagemComprada = false;
const destino = 'Salvador';


const podeComprar = (idadeComprador >= 18 || estaAcompanhada);

let contador = 0;
let destinoExiste = false;

while(contador<3){
    if(listaDeDestinos[contador] == destino){
        destinoExiste = true;
        break;
    }
    contador += 1;
}

console.log('Destino Existe: ', destino);

if(podeComprar && destinoExiste) {
    console.log('Boa viagem');
} else {
    console.log('Desculpe tivemos um erro!');
}

for(let cont = 0; cont < 3; cont++){
    if(listaDeDestinos[contador] == destino){
        destinoExiste = true;
        break;
    }
}