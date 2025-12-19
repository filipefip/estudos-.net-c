/************************************* EXERCICIO 1 ************************************/

/*
 
 Você está desenvolvendo um sistema para um clube, onde a experiência do cliente é prioridade. 
Os membros comuns têm acesso básico, mas os clientes VIP possuem benefícios exclusivos, como níveis de fidelidade e identificadores personalizados. 
Seu desafio é criar uma estrutura que diferencie esses perfis.

Crie um programa que:

Defina uma classe Pessoa com os atributos Nome e Idade.
Crie uma classe ClienteVIP que herde de Pessoa, adicionando:
Um atributo nível de fidelidade (ex: Ouro, Diamante).
Um atributo código VIP (ex: VIP123A).
Instancie dois clientes VIP com dados fictícios.
Exiba no console uma mensagem formatada para cada cliente, incluindo:
Uma saudação personalizada (ex: "Bem-vindo, cliente VIP: [Nome]").
Idade, nível de fidelidade e código VIP em linhas separadas.
 
 */

//using PraticandoHeranca.Exercicio1;

//ClienteVIP cliente1 = new ClienteVIP("Renata", 32, "Ouro", "VIP123A");
//ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "Diamante", "VIP789X");

//Console.WriteLine($"Bem-vindo, cliente VIP: {cliente1.Nome}");
//Console.WriteLine($"Idade: {cliente1.Idade}");
//Console.WriteLine($"Nível de Fidelidade: {cliente1.NivelFidelidade}");
//Console.WriteLine($"Código VIP: {cliente1.CodigoVIP}\n");

//Console.WriteLine($"Bem-vindo, cliente VIP: {cliente2.Nome}");
//Console.WriteLine($"Idade: {cliente2.Idade}");
//Console.WriteLine($"Nível de Fidelidade: {cliente2.NivelFidelidade}");
//Console.WriteLine($"Código VIP: {cliente2.CodigoVIP}\n");



/************************************* EXERCICIO 2 ************************************/

/*
 
Você está desenvolvendo um sistema interno para uma empresa que deseja organizar as informações de seus colaboradores. 
A empresa possui funcionários fixos, que recebem salário mensal, e freelancers, que trabalham por projetos com valores específicos. 
Seu desafio é criar uma estrutura que represente esses dois tipos de colaboradores, aproveitando os conceitos de herança para evitar repetição de código.

Crie um programa que:

Defina uma classe base Funcionario com os atributos Nome e Cargo.
Crie uma classe filha Freelancer que herde de Funcionario e adicione o atributo ValorProjeto.
Crie uma classe filha Interno que herde de Funcionario e adicione o atributo Salario.
Instancie pelo menos um objeto de cada classe filha, atribuindo valores a cada atributo.
Exiba as informações no terminal.
 
 */

//using PraticandoHeranca.Exercicio2;

//Interno f1 = new Interno("Luciana", "Desenvolvedora", 7000.00m);
//Freelancer f2 = new Freelancer("Carlos", "Designer", 3500.00m);

//Console.WriteLine(f1);
//Console.WriteLine(f2);



/************************************* EXERCICIO 3 ************************************/

/*
 
Imagine que você está desenvolvendo um sistema para uma empresa de transporte que precisa gerenciar informações sobre seus passageiros. 
Cada pessoa cadastrada possui dados básicos, como nome e idade, mas os passageiros também podem informar quantos bilhetes já adquiriram. 
Seu objetivo é criar uma estrutura que organize essas informações de forma clara e eficiente.

Crie um programa que:

Defina uma classe Pessoa com os atributos Nome e Idade.
Crie a classe Passageiro, herdando de Pessoa, e adicione o atributo QuantidadeBilhetes.
Implemente um método dentro de Passageiro para exibir os dados formatados no console.
Cadastre dois passageiros com dados fictícios e exiba suas informações.
 
 */

using PraticandoHeranca.Exercicio3;
Passageiro p1 = new Passageiro("Lúcia", 45, 3);
Passageiro p2 = new Passageiro("Rodrigo", 30, 1);

Console.WriteLine(p1);
Console.WriteLine(p2);