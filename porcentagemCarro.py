def carro():
    custo = float(input('Custo R$: '))

    distribuidor = custo * (28/100)
    imposto = custo *(45/100)

    valorFinal = custo + distribuidor + imposto

    print(f'Valor Final R$: {valorFinal}')

carro()