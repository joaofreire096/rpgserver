# Sistema de RPG - Servidor
[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

# New Features

  - Gerador de aventuras
  
### Tecnologias

* Instale o donetcore [Dotnet Core 3.1]!

#### Compilar sistema

```sh
dotnet build
```
### Executar sistema
```sh
dotnet run
```
Endereço de desenvolvimento
```sh
https://localhost:5001
```

### APIs

Gerador de Aventuras

```sh
GET gerador/aventura
```

Gerador de Cidades

```sh
GET gerador/cidade
```

### Exemplos de consumo de API

```sh
https://localhost:5001/gerador/aventura
```

License
----

MIT

[//]: # (Links)

[Dotnet Core 3.1]: <https://dotnet.microsoft.com/download/dotnet-core/3.1>
