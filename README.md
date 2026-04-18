# MathCalcsC#

Uma aplicação console em **C# .NET 6.0** para cálculos matemáticos e gestão de estoque de produtos.

## 🎯 Funcionalidades

### 📐 Cálculos de Geometria

#### **CircleCalculator** - Calculadora de Círculo
- Calcula a **circunferência** baseado no raio
- Calcula o **volume** da esfera
- Calcula a **área** do círculo
- Exibe o valor de π (PI)

#### **TriangleCalculator** - Calculadora de Triângulo
- Calcula a **área de dois triângulos** inseridos pelo usuário
- Compara e identifica qual triângulo possui a **maior área**
- Entrada de dados via terminal

### 📦 Gestão de Inventário

#### **InventoryManager** - Gerenciador de Estoque
- Criação e gerenciamento de produtos
- Controle de **quantidade em estoque**
- **Adicionar e remover** produtos do inventário
- Cálculo automático do **valor total** em estoque
- Exibição de informações detalhadas dos produtos

## 🛠️ Tecnologia

- **Linguagem**: C#
- **Plataforma**: .NET 6.0
- **Tipo**: Aplicação Console
- **Estrutura**: Projetos organizados por funcionalidade

## 📁 Estrutura do Projeto

```
MathCalcs/
├── Geometry/
│   ├── CircleCalculator.cs
│   └── Circle.cs
├── Geometry/TriangleCalculator/
│   ├── TriangleCalculator.cs
│   └── Triangle.cs
├── Inventory/
│   ├── InventoryManager.cs
│   └── Product.cs
└── Program.cs
```

## 🚀 Como Usar

1. Clone o repositório
2. Abra a solução em Visual Studio ou VS Code
3. Compile o projeto: `dotnet build`
4. Execute: `dotnet run`
5. Escolha a funcionalidade desejada no menu

## 💡 Exemplo de Uso

### Calcular Círculo
```
Entre o valor do raio: 5
Circunferencia: 31.42
Volume: 523.60
Valor de PI: 3.14
```

### Gerenciar Estoque
```
Nome do Produto: Notebook
Preço: 2500.00
Quantidade: 10
Total em Estoque: $25000.00
```

## 📝 Notas

- A aplicação foi desenvolvida como projeto de estudo em C#
- Segue boas práticas de organização e nomenclatura
- Utiliza tratamento de erros e validação de entrada
- Implementa cálculos com precisão de ponto flutuante

## 📄 Licença

Este projeto é fornecido como material educacional.


