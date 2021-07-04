from datetime import datetime,timedelta


class Datasbr:
    def __init__(self):
        self.momento_cadastro = datetime.today()

    def __str__(self):
        return self.format()

    def mes_cadastro(self):
        meses_do_ano = ['janeiro', 'fevereiro', 'março', 'abril', 'maior', 'junho',
                        'julho', 'agosto', 'setembro', 'outubro', 'novembro', 'dezembro']
        mes_cadastro = self.momento_cadastro.month - 1
        return meses_do_ano[mes_cadastro]

    def dia_semana(self):
        dias_semana = ['segunda', 'terça', 'quarta', 'quinta', 'sexta', 'sabado', 'domingo']
        dia_semana = self.momento_cadastro.weekday()
        return dias_semana[dia_semana]

    def format(self):
        return self.momento_cadastro.strftime('%d/%m/%Y %H:%M')

    def tempo_cadastro(self):
        return datetime.today() - self.momento_cadastro
