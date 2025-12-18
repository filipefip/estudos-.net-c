/********************************** Aula 1 e 2 **********************************/
//Conta conta1 = new()
//{
//    NumeroIndicador = 1,
//    Titular = "Alice",
//    Saldo = 500.0,
//    Senha = "senha123"
//};

//conta1.ExibirInformacoesConta();


//Carro carro1 = new()
//{
//    Marca = "Toyota",
//    Modelo = "Corolla",
//    Ano = 1980,
//    VelocidadeAtual = 0
//};


//Console.WriteLine(carro1.DescricaoDetalhada);
//carro1.Acelerar();
//carro1.Acelerar();
//carro1.ExibirVelocidadeAtual();
//carro1.Frear();
//carro1.Buzinar();
//carro1.ExibirVelocidadeAtual();


//Produto produto1 = new("Notebook", "Samsung", 3400, 20);
//produto1.ExibirDetalhes();


//Produto produto2 = new(
//    nome: "Smartphone",
//    marca: "Apple",
//    preco: 7200,
//    estoque: 15
//);

//produto2.ExibirDetalhes();

/***************************** Aula 3, Exercicios 1 e 2 ******************************/
//Holder filipe = new(
//    name: "Filipe",
//    document: "52663996866"
//);

//Account account = new(
//    holder: filipe,
//    agency: "0001",
//    balance: 1500,
//    limit: 5000
//);

//Console.WriteLine(account.DisplayAccountInfo);
//Console.WriteLine(account.DisplayHolderInfo);

/***************************** Aula 3, Exercicios 3 ******************************/

//Stock stock = new(
//    stockId: "STK001",
//    stockName: "Estoque Principal"
//);

//Product product1 = new(
//    id: 101,
//    name: "Cadeira Gamer",
//    price: 1200.50,
//    quantity: 10
//);

//Product product2 = new(
//    id: 102,
//    name: "Mesa de Escritório",
//    price: 850.75,
//    quantity: 5
//);

//Product product3 = new(
//    id: 103,
//    name: "Monitor 27 Polegadas",
//    price: 1500.00,
//    quantity: 7
//);

//stock.AddProduct(product1);
//stock.AddProduct(product2);

//stock.DisplayStockProducts();

//stock.AddProduct(product3);

//stock.DisplayStockProducts();


/***************************** Aula 3, Exercicios 4 ******************************/

//Student student1 = new()
//{
//    Name = "Carlos",
//    Age = 20
//};

//Student student2 = new()
//{
//    Name = "Ana",
//    Age = 22
//};

//Subject subject1 = new("Matemática");
//Subject subject2 = new("História");

//student1.EnrollSubject(subject1, 85.5);
//student1.EnrollSubject(subject2, 90.0);

//student2.EnrollSubject(subject1, 78.0);
//student2.EnrollSubject(subject2, 88.5);

//Teacher teacher = new("Prof. Silva");
//teacher.AddSubject(subject1);
//teacher.AddSubject(subject2);

//teacher.DisplaySubjects();

//subject1.DisplayEnrolledStudents();

//subject2.DisplayEnrolledStudents();

//student1.DisplayGrades();

//student2.DisplayGrades();

// teacher.StudentsHasSubject();

/***************************** Aula 3, Exercicios 5 ******************************/

//Restaurant restaurant = new("Gourmet Paradise");
//restaurant.Menu = new Menu();
//restaurant.Menu.AddItem("Spaghetti Carbonara");
//restaurant.Menu.AddItem("Margherita Pizza");
//restaurant.Menu.AddItem("Caesar Salad");

//Table table1 = new(1, 2);
//Table table2 = new(2, 4);
//Table table3 = new(3, 6);

//restaurant.AddTable(table1);
//restaurant.AddTable(table2);
//restaurant.AddTable(table3);

//restaurant.DisplayMenu();
//restaurant.ReserveTable();
//restaurant.DisplayReservedTables();

//Order order1 = new(101);
//order1.AddItem("Spaghetti Carbonara", restaurant.Menu);
//order1.AddItem("Tiramisu", restaurant.Menu); // Item not in menu
//order1.AddItem("Caesar Salad", restaurant.Menu);

//Order order2 = new(102);
//order2.AddItem("Margherita Pizza", restaurant.Menu);

//table1.Order = order1;
//table2.Order = order2;

//restaurant.DisplayOrders();

//restaurant.ReserveTable();
//restaurant.DisplayReservedTables();