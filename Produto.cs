 public abstract class Produto
    {
        public string nome { get; set; }
        public string desc { get; set; }
        public double preco { get; set; }
        public string nomeProduto {get; set;}

        public string desc2 { get; set; }
        public double preco2 { get; set; }
        public string nomeProduto2 {get; set;}
        
        public void descreverProduto() {
            Console.WriteLine("Nome do produto: " + this.nome );
            Console.WriteLine();
            Console.WriteLine("Descrição: " + this.desc);
            Console.WriteLine();
            Console.WriteLine("Preço: R$" + this.preco);

            
        }

        public Produto()
        {
            this.nomeProduto = "Samsung A14";
            this.desc= "128GB, 4gb Ram, 5000Mah";
            this.preco = 799;

            this.nomeProduto2 = "Bicicleta";
            this.desc2 = "Bicicleta semi-nova, Cor preta";
            this.preco2 = 600;

        }
    }