
# 🚀 KafkaDotnetConsoleApplication - Produtor e Consumidor em .NET Core

Este projeto é uma aplicação **.NET Core** que demonstra como utilizar o **Apache Kafka** para comunicação assíncrona entre um **produtor** e um **consumidor** de mensagens.

----------

## 📌 O que é o Apache Kafka?

O **Apache Kafka** é uma plataforma distribuída de mensagens baseada no modelo **pub/sub** (publicação/assinatura). Ele permite a comunicação assíncrona entre aplicações, sendo altamente escalável e utilizado em sistemas de processamento de dados em tempo real.

----------

## 🛠️ Ferramentas Utilizadas

-   **.NET Core** 8+
-   **Apache Kafka**
-   **Docker & Docker Compose**
-   **Confluent.Kafka** (biblioteca oficial para .NET)
-   **Zookeeper** (necessário para o Kafka)

----------

## 📦 Pacotes Utilizados

Para rodar o Kafka com **.NET**, utilizamos a biblioteca **Confluent.Kafka**:

```sh
dotnet add package Confluent.Kafka

```

----------

## 🚀 Passo a Passo para Rodar o Projeto

Siga os passos abaixo para rodar os serviços Kafka e testar o produtor e consumidor.

### 1️⃣ Clonar o Repositório

```sh
git clone https://github.com/GabrielSantosLemos/kafka-dotnet-console-application.git
cd kafka-dotnet-console-application

```

### 2️⃣ Criar um Ambiente Kafka com Docker

Se você não tem o Kafka instalado, podemos rodá-lo com Docker.
Na raiz do projeto que esta o arquivo `docker-compose.yml`


Subir os serviços do Kafka:

```sh
docker-compose up -d

```

Verificar se os containers estão rodando:

```sh
docker ps

```

### 3️⃣ Criar um Tópico no Kafka

Acesse o terminal do Kafka:

```sh
docker exec -it kafka bash

```

Crie o tópico:

```sh
kafka-topics --create --topic meu-topico --bootstrap-server localhost:9092 --partitions 1 --replication-factor 1

```

Verifique se o tópico foi criado corretamente:

```sh
kafka-topics --list --bootstrap-server localhost:9092

```

### 8️⃣ Rodar a Aplicação .NET

Compilar o projeto:

```sh
dotnet build

```

Rodar a aplicação:

```sh
dotnet run

```

### 🛑 Parando os Serviços

Para parar o Kafka:

```sh
docker-compose down

```

Para remover completamente os containers e volumes:

```sh
docker-compose down -v

```
## 🤝 Contribuição:

Contribuições são bem-vindas! Se você encontrar bugs ou desejar propor melhorias, sinta-se à vontade para abrir uma issue ou enviar um pull request.

## 📜 Licença:

Este projeto é licenciado sob a Licença MIT.