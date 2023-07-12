<img src="https://raw.githubusercontent.com/MicaelliMedeiros/micaellimedeiros/master/image/computer-illustration.png" min-width="400px" max-width="400px" width="400px" align="right" alt="Computador iuriCode">

## Documentação da API

<p align="left"> 
  Consulta Informações por Placa do Carro - API / ASP.NET / WebApi.<br>
  Gratuita para o Uso (em processo de publicação!).
</p>


### Atualizações: Valor IPVA, TABELA FIPE

#### Documentação swagger

```https
  https://localhost:{0000}/swagger/index.html
```

#### Valor
```https
  https://localhost:{0000}/{NumeroPlaca}
```

| string placa   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| IZO1880 | `string` | Coloque uma placa valida |

#### Sucesso
```json
  {
  "data": {
    "marca": "RENAULT",
    "modelo": "MEGANEGT DYN 16",
    "importado": "Não",
    "ano": "2011",
    "anoModelo": "2011",
    "cor": "Prata",
    "cilindrada": "1598 cc",
    "potencia": "115 cv",
    "combustivel": "Álcool / Gasolina",
    "chassi": "*****J762015",
    "motor": "*****Q031861",
    "passageiros": "5",
    "uf": "RS",
    "municipio": "SARANDI"
  },
  "erros": []
}
```
#### Falha
```json
  {
  "data": null,
  "erros": [
    "Carro Não Encontrado, Verifica o Numero da Placa"
  ]
}
```
