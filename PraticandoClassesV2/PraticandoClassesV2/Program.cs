/********************* EXERCICIO 1 *********************/

/*

Imagine que você está desenvolvendo uma aplicação para uma biblioteca que precisa cadastrar livros. Cada livro deve ter um título e um autor.
Crie uma classe chamada Livro que possua duas propriedades públicas: Titulo e Autor. Depois, crie um objeto dessa classe e preencha os dados com um título e autor de sua escolha e 
exiba a saída. 

 */

//Livro livro1 = new(
//    titulo: "1984",
//    autor: "George Orwell"
//);

//Console.WriteLine($"Título: {livro1.Titulo}, Autor: {livro1.Autor}");





/********************* EXERCICIO 2 *********************/

/*
 
Você está criando um sistema de emissão de passagens para uma agência de viagens. 
Cada passagem precisa obrigatoriamente conter o nome do passageiro e o destino, definidos no momento da criação.

Crie uma classe chamada Passagem que tenha:

Uma propriedade pública Passageiro.
Uma propriedade pública Destino.
Um construtor que obrigue o preenchimento dessas informações na criação do objeto.
Depois, crie uma instância da classe e exiba os dados da passagem.

 */

//Passagem passagem1 = new(
//    passageiro: "João Silva",
//    destino: "Rio de Janeiro"
//);

//Console.WriteLine($"Passageiro: {passagem1.Passageiro}, Destino: {passagem1.Destino}");





/********************* EXERCICIO 3 *********************/

/*
 
Você foi contratado(a) para desenvolver um sistema de operações bancárias. 
Cada conta precisa ter um número e um saldo inicial. E, deve existir um método para realizar depósitos, recebendo o valor a ser depositado como parâmetro.

Crie uma classe chamada ContaBancaria que tenha:

Uma propriedade pública NumeroConta.
Uma propriedade pública Saldo.
Um método Depositar(double valor) que adicione o valor ao saldo existente.
Depois, crie uma instância da classe, realize um depósito e exiba o saldo atualizado.
 
 */

//ContaBancaria conta1 = new(
//    numeroConta: "123456-7",
//    saldoInicial: 1000.00
//);

//conta1.Depositar(500.00);

//Console.WriteLine($"Número da Conta: {conta1.NumeroConta}, Saldo Atualizado: {conta1.Saldo}");




/********************* EXERCICIO 4 *********************/

/*
 
Você está desenvolvendo um sistema de gestão de pessoas para uma empresa. 
O sistema precisa cadastrar funcionários informando o nome e o cargo no momento da criação. 
E, ele deve permitir que um funcionário seja promovido para um novo cargo, mas apenas se o novo cargo for diferente do atual — não faria sentido uma promoção que não 
mudasse o cargo da pessoa, concorda?!

Crie uma classe chamada Funcionario que tenha:

Uma propriedade pública Nome.
Uma propriedade pública Cargo.
Um construtor que receba nome e cargo como parâmetros obrigatórios.
Um método chamado Promover(string novoCargo) que atualize o cargo do funcionário, somente se o novo cargo for diferente do atual. Se for o mesmo, exiba uma mensagem de erro informando 
que a promoção não pode ocorrer.
Depois, crie uma instância da classe, exiba os dados iniciais, promova o funcionário e exiba os dados atualizados.
 
*/

//Funcionario funcionario1 = new(
//    nome: "Maria Oliveira",
//    cargo: "Analista Júnior"
//);

//Console.WriteLine($"Nome: {funcionario1.Nome}, Cargo: {funcionario1.Cargo}");

//funcionario1.Promover("Analista Pleno");

//Console.WriteLine($"Nome: {funcionario1.Nome}, Cargo: {funcionario1.Cargo}");

//funcionario1.Promover("Analista Pleno");



/********************* EXERCICIO 5 *********************/

/*
 
Você está desenvolvendo uma ferramenta de cálculo geométrico para auxiliar estudantes de um curso de matemática. 
Uma das funcionalidades é representar um retângulo, permitindo calcular sua área de acordo com a altura e a largura fornecidas.

Crie uma classe chamada Retangulo que tenha:

Duas propriedades públicas: Altura e Largura.
Um método chamado CalcularArea() que retorne a área do retângulo (altura × largura).
Depois, crie um objeto da classe, atribua os valores e mostre o resultado da área na tela.

*/

//Retangulo retangulo1 = new(
//    altura: 5,
//    largura: 8
//);

//retangulo1.CalcularArea();




/********************* EXERCICIO 6 *********************/

/*
 
Imagine que você está criando um sistema de recomendação para uma plataforma de filmes. 
Cada filme tem um título e uma classificação indicativa. 
Para garantir que as pessoas vejam apenas conteúdos apropriados para sua idade, o sistema deve verificar se a pessoa pode assistir ao filme com base na idade informada.

Crie uma classe chamada Filme que tenha:

Propriedades públicas Titulo e ClassificacaoEtaria (int).
Um método chamado PodeAssistir(int idadeUsuario) que retorna true se a idade for maior ou igual à classificação etária, e false caso contrário.
Um método ExibirResultado(int idadeUsuario) que exiba uma mensagem amigável informando se o usuário pode ou não assistir ao filme.
 
 */

//Filme filme = new Filme("Matrix", 16);
//filme.ExibirResultado(14);
//filme.ExibirResultado(20);




/********************* EXERCICIO 7 *********************/

/*
 
Você recebeu a missão de automatizar o sistema de estoque de uma papelaria. 
Cada item precisa registrar seu nome e a quantidade atual em estoque. O sistema deve permitir retirar itens, mas somente se houver quantidade suficiente disponível. 
Caso contrário, deve exibir uma mensagem informando a falha.

Crie uma classe chamada Produto com:

Propriedade pública Nome.
Campo privado quantidadeEstoque.
Um construtor que receba o nome e a quantidade inicial.
Um método público Retirar(int quantidade) que:
Reduz a quantidade apenas se houver estoque suficiente.
Exiba uma mensagem indicando o sucesso ou a falha da operação.
Um método ExibirEstoque() para mostrar a quantidade atual.
 
 */

//Produto produto = new Produto("Caneta Azul", 20);
//produto.Retirar(5);
//produto.ExibirEstoque();
//produto.Retirar(30);



/********************* EXERCICIO 8 *********************/

/*
 
Imagine que você está desenvolvendo um sistema de pedidos para uma loja virtual. 
Toda vez que alguém faz uma compra, o sistema precisa registrar o número do pedido, o nome do cliente e o status atual (por exemplo: "Pendente", "Enviado", "Entregue").

Seu papel é representar esse pedido como uma classe, com os principais atributos e um comportamento: permitir que o status seja atualizado conforme o pedido avança.

Crie uma classe chamada Pedido com:

Propriedade pública NumeroPedido (string).
Propriedade pública NomeCliente (string).
Propriedade pública Status (string).
Um método chamado AtualizarStatus(string novoStatus) para alterar o status.
Um método chamado ExibirPedido() que mostre os dados na tela.
 
 */

//Pedido pedido = new Pedido("001", "Ana Silva", "Pendente");
//pedido.ExibirPedido();
//pedido.AtualizarStatus("Enviado");
//pedido.ExibirPedido();



/********************* EXERCICIO 9 *********************/

/*
 
Você está criando um sistema para agendamento de consultas em uma clínica. 
Toda consulta envolve o nome do paciente, o nome do médico e a data marcada. 
É comum que consultas sejam reagendadas — e seu sistema precisa permitir isso.

Você deve criar uma classe que represente uma consulta com os dados essenciais e um método para reagendar, mantendo o controle da data atualizada.

Crie uma classe chamada Consulta com:

Propriedade pública NomePaciente.
Propriedade pública NomeMedico.
Propriedade pública DataConsulta (do tipo DateTime).
Método Reagendar(DateTime novaData) para atualizar a data.
Método ExibirResumo() que mostra as informações da consulta, usando "Data:" na primeira exibição e "Nova data:" se ela tiver sido reagendada.
 
 */

//Consulta consulta = new Consulta("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
//consulta.ExibirResumo();
//consulta.Reagendar(new DateTime(2025, 5, 25));
//consulta.ExibirResumo();



/********************* EXERCICIO 10 *********************/

/*
 
Você precisa criar um sistema para uma loja de software. 
Cada produto digital tem um nome, um preço e detalhes técnicos, como o tamanho do arquivo e o sistema operacional compatível. 
Esses detalhes técnicos podem variar bastante e, por isso, fazem mais sentido em uma estrutura separada — uma classe só para isso.

Crie:

Uma classe InformacaoTecnica com:
Propriedades TamanhoMB e SistemaOperacional.
Uma classe ProdutoDigital com:
Propriedades Nome, Preco e InfoTecnica (do tipo InformacaoTecnica).
Um método ExibirDetalhes() para mostrar tudo na tela.
 
 */

//InformacaoTecnica info = new InformacaoTecnica(1500, "Windows/Mac");
//ProdutoDigital produto = new ProdutoDigital("Photoshop", 89.99, info);
//produto.ExibirDetalhes();