from cpf_cnpj import Documento

cnpj = '35379838000112'
cpf = '05363439930'
objeto_cpf = Documento.cria_documento(cpf)

print(objeto_cpf)