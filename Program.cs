 public abstract class Produto
    {
         public string nome { get; set; }
        public string desc { get; set; }
        public double preco { get; set; }
        
        public void descreverProduto() {
            Console.WriteLine("Nome do produto: " + this.nome );
            Console.WriteLine();
            Console.WriteLine("Descrição: " + this.desc);
            Console.WriteLine();
            Console.WriteLine("Preço: R$" + this.preco);
        }
    }

      public class adc_produto : Produto
    {
       
    }


      class Program
    {
        static void Main(string[] args)
        {
         int x = 0;

         do {
    int menu;

    Console.Clear();
    if (x > 0)
    {
        Console.WriteLine("Opção inválida, selecione uma das opções válidas [1-3]");
        Console.WriteLine();
    }
    Console.WriteLine("Selecione uma das opções abaixo:");
    Console.WriteLine();
    Console.WriteLine("1 - Adicionar um produto");
    Console.WriteLine("2 - Ver lista de produtos");
    Console.WriteLine("3 - Opção 3");
    Console.WriteLine();
    Console.Write("Selecione uma opção -> ");
    menu  = Int32.Parse(Console.ReadLine());

     switch (menu)
     {
        case 1:


            //Cadastrar os produtos //
            
            int quantidadeProdutos = 5;
            int i = 0;
            adc_produto[] produto01 = new adc_produto[quantidadeProdutos];
            produto01[i] = new adc_produto();
            

            Console.WriteLine("Digite o nome do produto: ");
            produto01[i].nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite uma breve descrição do produto: ");
            produto01[i].desc = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            produto01[i].preco = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            produto01[i].descreverProduto();
            Console.WriteLine();
            Console.WriteLine("Cadastro concluído, digite alguma coisa pra continuar...");
            Console.ReadLine();
            
            x = 1;

         break;
            
        case 2:
            if (x > 0)
            {
                x = 0;
            }
            Console.WriteLine(produto01[i]);
            break;

        case 3:
            Console.WriteLine("C");
            break;

        default:
            x = 1;
            break;
    }
             } while (x > 0);


        }
    }


    