bool voltarMenu1;



         do {
        
              voltarMenu1 = false;
            Cliente Cliente01 = new Cliente();
            
            int menu;
            double valor;
          

    Console.Clear();
    
    {
        Console.WriteLine("Opção inválida, selecione uma das opções válidas [1-6]");
        Console.WriteLine();
    }
    Console.WriteLine("Selecione uma das opções abaixo:");
    Console.WriteLine();
    Console.WriteLine("1 - Adicionar um produto");
    Console.WriteLine("2 - Ver lista de produtos");
    Console.WriteLine("3 - Cadastrar Cliente");
    Console.WriteLine("4 - Depositar saldo");
    Console.WriteLine("5 - Ve o saldo depositado");
    Console.WriteLine("6 - Encerrar o codigo");
    Console.WriteLine();
    Console.Write("Selecione uma opção -> ");
    menu  = Int32.Parse(Console.ReadLine());
   
     Adc_Produto produto01 = new Adc_Produto();
     List<Adc_Produto> listaProdutos = new List<Adc_Produto>();


    //produto01.nome = "kaua";

           string produto = "";

     switch (menu)
     {
        case 1:


            //Cadastrar os produtos //
            

            Console.Clear();
            Console.WriteLine("Digite o nome do produto: ");
            produto01.nomeProduto = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite uma breve descrição do produto: ");
            produto01.desc = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            produto01.preco = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            produto01.descreverProduto();
            Console.WriteLine();
            produto = produto01.nome;
            Console.WriteLine("Cadastro concluído, digite alguma coisa pra continuar...");
            Console.ReadLine();
            voltarMenu1 = true;

            listaProdutos.Add(produto01);

            
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadLine();

              break;
            
        case 2:
            Console.Clear();
           Console.WriteLine("Nome do produto: " + produto01.nomeProduto);
           Console.WriteLine();
           Console.WriteLine("Descrição do produto: " + produto01.desc);
           Console.WriteLine();
           Console.WriteLine("Preço do produto: R$" + produto01.preco);
           Console.WriteLine("----------------------------");
            Console.WriteLine("Nome do produto: " + produto01.nomeProduto2);
           Console.WriteLine();
           Console.WriteLine("Descrição do produto: " + produto01.desc2);
           Console.WriteLine();
           Console.WriteLine("Preço do produto: R$" + produto01.preco2);
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadLine();
            voltarMenu1 = true;
            break;

        case 3:
        
            Console.Clear();
            Console.WriteLine("Cadastro do cliente");
            Console.WriteLine("---------------------");
            Console.Write("Digite seu nome: ");
            Cliente01.nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Digite seu endereço: ");
            Cliente01.endereco = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Cadastro concluído, digite qualquer tecla para continuar...");
            Console.ReadLine();
            voltarMenu1 = true;
            break;

        case 4:
          
          Console.Clear();
            Console.WriteLine("Depósito de valor em conta");
            Console.WriteLine("---------------------");
            Console.Write("Digite o valor a ser depositado: ");
            valor = Double.Parse(Console.ReadLine());
            Cliente01.Depositar(valor);
            Console.WriteLine("Depósito concluído, digite qualquer tecla para continuar...");
            Console.ReadLine();
            voltarMenu1 = true;
          break;

          case 5:
          Console.Clear();
          
          Console.WriteLine(Cliente01.saldo);
          Console.WriteLine("Digite qualquer tecla para continuar...");
          Console.ReadLine();
          voltarMenu1 = true;
          break;

          case 6:
          Console.WriteLine("encerrando...");
          
          break;

        default:
           voltarMenu1 = true;
            break;
    }
             } while (voltarMenu1);



    