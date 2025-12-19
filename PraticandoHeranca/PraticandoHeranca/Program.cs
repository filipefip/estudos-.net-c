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

//using PraticandoHeranca.Exercicio3;
//Passageiro p1 = new Passageiro("Lúcia", 45, 3);
//Passageiro p2 = new Passageiro("Rodrigo", 30, 1);

//Console.WriteLine(p1);
//Console.WriteLine(p2);



/************************************* EXERCICIO 4 ************************************/

/*
 
Você está desenvolvendo um sistema para uma instituição que emite certificados de validação profissional. 
Cada profissão cadastrada precisa ser reconhecida como um tipo válido, mas a entidade base (Profissão) não deve ser instanciada diretamente, pois representa apenas um conceito abstrato.

Crie um programa que:

Defina uma classe abstrata Profissao com um atributo titulo.
Crie duas classes que herdem de Profissao:
Analista: deve receber o título via construtor.
Docente: deve receber o título via construtor.
Implemente uma classe Certificado que:
Aceite qualquer objeto do tipo Profissao em seu construtor.
Exiba a mensagem formatada: "Certificado emitido para: <titulo>".
 
 */

//using PraticandoHeranca.Exercicio4;

//Analista analista = new Analista("Analista de Sistemas");
//Docente docente = new Docente("Docente de Matemática");
//Certificado cerf1 = new Certificado(analista);
//Certificado certf2 = new Certificado(docente);

//Console.WriteLine(cerf1);
//Console.WriteLine(certf2);


/************************************* EXERCICIO 5 ************************************/

/*
 
Imagine que você está desenvolvendo um sistema de gerenciamento para uma biblioteca digital. 
Esse sistema precisa organizar diferentes tipos de mídias, como documentos de texto e imagens, cada um com suas próprias características, mas compartilhando propriedades básicas.

Sua tarefa é criar uma estrutura que permita catalogar esses itens, garantindo que cada tipo de mídia possa exibir suas informações específicas.

Crie um programa que:

Defina uma classe base chamada ItemDigital com um atributo para armazenar o título do item.
Crie uma classe Pergaminho que herde de ItemDigital, adicionando um atributo para armazenar o conteúdo textual.
Implemente o método MostrarDetalhes() para exibir o título e o conteúdo no console.
Instancie um objeto da classe Pergaminho, atribuindo um título e um conteúdo.
Chame o método MostrarDetalhes()
 
 */

//using PraticandoHeranca.Exercicio5;

//Pergaminho pergaminhoAntigo = new Pergaminho("Segredos_Antigos.txt", "A chave para a sabedoria reside na observação...");
//pergaminhoAntigo.MostrarDetalhes();



/************************************* EXERCICIO 6 ************************************/

/*
 
Você está desenvolvendo um sistema para monitoramento de sensores inteligentes em diferentes dispositivos eletrônicos. 
Cada dispositivo pode ativar ou desativar sensores, mas os tipos de sensores variam conforme o modelo.

Seu desafio é criar uma estrutura que garanta que todos os dispositivos implementem um comportamento padrão. Para isso, vamos usar interfaces.

Crie um programa que:

Defina uma interface ISensor com os métodos Ativar() e Desativar().
Crie uma classe SensorTemperatura que implemente a interface ISensor.
Crie uma classe SensorPresenca que também implemente a interface ISensor.
Para cada tipo de sensor, exiba no console uma mensagem personalizada ao ativar e desativar.
No Program.cs, instancie cada sensor e chame os métodos Ativar() e Desativar().
 
 */

//using PraticandoHeranca.Exercicio6;

//SensorTemperatura temp = new SensorTemperatura();
//SensorPresenca presenca = new SensorPresenca();

//temp.Ativar();
//temp.Desativar();

//presenca.Ativar();
//presenca.Desativar();



/************************************* EXERCICIO 7 ************************************/

/*
 
Você está desenvolvendo um sistema para um centro técnico especializado na montagem de computadores personalizados. 
Cada computador é composto por diferentes peças, e cada peça possui características próprias. 
Ao invés de herdar, faz mais sentido compor um computador com essas peças, já que um computador tem uma placa-mãe, tem um processador, e assim por diante.

Seu desafio é criar uma estrutura que represente essa montagem usando composição.

Crie um programa que:

Defina a classe Processador, com os atributos Marca e Modelo.
Defina a classe PlacaMae, com os atributos Fabricante e Socket.
Crie a classe Computador, que possua como atributos um Processador e uma PlacaMae.
Instancie objetos das peças com dados fictícios e associe a um objeto da classe Computador.
Crie um método ExibirConfiguracao() na classe Computador que exiba no console os dados completos do computador.
 
 */

using PraticandoHeranca.Exercicio7;

Processador cpu = new Processador("Intel", "i7-12700K");
PlacaMae mobo = new PlacaMae("ASUS", "LGA1700");
Computador pc = new Computador(cpu, mobo);

pc.ExibirConfiguracao();