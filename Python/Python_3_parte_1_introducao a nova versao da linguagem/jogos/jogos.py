import forca
import adivinhacao

def escolhe_jogo():
    print("********************************")
    print("Escolha seu jogo!")
    print("********************************")

    print("(1) Jogo da Forca, (2) jogo da Adivinhação")

    jogo = int(input(("Qual jogo? ")))

    if jogo == 1:
        print("Jogando Forca")
        forca.jogar()
    elif jogo == 2:
        print("jogando Adivinhação")
        adivinhacao.jogar()

    print("----------------------------")

if __name__ == "__main__":
    escolhe_jogo()