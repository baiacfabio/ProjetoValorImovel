[![Build](https://github.com/baiacfabio/ProjetoValorImovel/actions/workflows/main.yml/badge.svg)](https://github.com/baiacfabio/ProjetoValorImovel/actions/workflows/main.yml)

# Projeto

Esse é um simples projeto de APIs para calcular o valor de um imovel com base em sua metragem.

O projeto consiste de duas APIs, a primeira, API-1, é responsavel por retornar o valor do metro quadrado.
A segunda, API-2, recebe como parametro a metragem que deve ser calculada, consome o valor disponibilizado pela API-1 e retorna o valor calculado.

# ✨ Tecnologias
Esse projeto foi desenvolvido utilizando as seguintes tecnologias:

- AspNet Core
- Docker
- Swagger


# 🚀 Como executar

- Clone o repositório
- API-1
    - Abra um terminal
    - Navegue até o diretorio da API-1: `cd api-1`
    - Execute os comandos: 
        - `dotnet restore`
        - `dotnet build`
        - `dotnet run --project WebApi`
    - A API-1 estará disponível no endereço `https://localhost:4001/swagger/index.html`
- API-2
    - Abra outro terminal
    - Navegue até o diretorio da API-2: `cd api-2`
    - Execute os comandos: 
        - `dotnet restore`
        - `dotnet build`
        - `dotnet run --project WebApi`
    - A API-2 estará disponível no endereço `https://localhost:5001/swagger/index.html`

As aplicações estão publicadas no Heroku e podem ser acessadas pelos links abaixo:

API-1 -> https://fabio-webapi-1.herokuapp.com/swagger/index.html

API-2 -> https://fabio-webapi-2.herokuapp.com/swagger/index.html



