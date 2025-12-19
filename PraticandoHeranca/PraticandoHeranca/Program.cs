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

using PraticandoHeranca.Exercicio1;

ClienteVIP cliente1 = new ClienteVIP("Renata", 32, "Ouro", "VIP123A");
ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "Diamante", "VIP789X");

Console.WriteLine($"Bem-vindo, cliente VIP: {cliente1.Nome}");
Console.WriteLine($"Idade: {cliente1.Idade}");
Console.WriteLine($"Nível de Fidelidade: {cliente1.NivelFidelidade}");
Console.WriteLine($"Código VIP: {cliente1.CodigoVIP}\n");

Console.WriteLine($"Bem-vindo, cliente VIP: {cliente2.Nome}");
Console.WriteLine($"Idade: {cliente2.Idade}");
Console.WriteLine($"Nível de Fidelidade: {cliente2.NivelFidelidade}");
Console.WriteLine($"Código VIP: {cliente2.CodigoVIP}\n");