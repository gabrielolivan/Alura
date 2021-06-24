from flask import Flask, render_template

app = Flask(__name__)


class Jogo:
    def __init__(self, nome, categoria, console):
        self.nome = nome
        self.categoria = categoria
        self.console = console


@app.route('/inicio')
def ola():
    jogo1 = Jogo('Super Mario', 'Ação', 'SNES')
    jogo2 = Jogo('Pokemon Gold', 'RPG', 'GBA')
    jogo3 = Jogo('Mortal Kombat', 'Luta', 'SNES')
    lista = [jogo1, jogo2, jogo3]
    return render_template('lista.html', titulo='jogos', jogos=lista)


# app.run(host='0.0.0.0', port=8080)
app.run()
