print("********************************")
print("Bem vindo ao jogo de Adivinhação")
print("********************************")

numero_secreto = 42
total_de_tentativas = 3
rodada = 1

'''
while rodada <= total_de_tentativas:
    print("\nTentativa {} de {}".format(rodada, total_de_tentativas))

    chute_str = input("Digite o seu numero: ")
    print("Você digitiou ", chute_str)
    chute = int(chute_str)

    acertou = chute == numero_secreto
    maior = chute > numero_secreto
    menor = chute < numero_secreto

    if acertou:
        print("Você acertou!")
        break
    else:
        if maior:
            print("Você errou! O seu chute foi maior do que o número secreto")
        elif menor:
            print("Você errou! O seu chute foi menor do que o número secreto")

    rodada += 1

print("Fim do jogo")
'''

'''
for rodadas in range(1, total_de_tentativas + 1):
    print("\nTentativa {} de {}".format(rodadas, total_de_tentativas))

    chute_str = input("Digite o seu numero: ")
    print("Você digitiou ", chute_str)
    chute = int(chute_str)

    acertou = chute == numero_secreto
    maior = chute > numero_secreto
    menor = chute < numero_secreto

    if acertou:
        print("Você acertou!")
        break
    else:
        if maior:
            print("Você errou! O seu chute foi maior do que o número secreto")
        elif menor:
            print("Você errou! O seu chute foi menor do que o número secreto")


print("Fim do jogo")
'''

for rodadas in range(1, total_de_tentativas + 1):
    print("\nTentativa {} de {}".format(rodadas, total_de_tentativas))

    chute_str = input("Digite um número entre 1 e 100: ")
    print("Você digitiou ", chute_str)
    chute = int(chute_str)

    if chute < 1 or chute > 100:
        print("Você deve digitar um número entre 1 e 100")
        continue

    acertou = chute == numero_secreto
    maior = chute > numero_secreto
    menor = chute < numero_secreto

    if acertou:
        print("Você acertou!")
        break
    else:
        if maior:
            print("Você errou! O seu chute foi maior do que o número secreto")
        elif menor:
            print("Você errou! O seu chute foi menor do que o número secreto")


print("Fim do jogo")