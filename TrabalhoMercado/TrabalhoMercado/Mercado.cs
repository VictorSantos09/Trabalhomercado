namespace TrabalhoMercado
{
    public class Mercado
    {
        public int Buying(string[] produtos, int MinimalQtd, int boughtProducts, string[] workers, string[] paymentChoice, int billing, int random, int outputQtd)
        {
            Console.Clear();
            Console.WriteLine("ESCOLHA SUA OPÇÂO:\n");
            int contador = 1;
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine($"{contador} - {produtos[i]}");
                contador++;
            }
            string userChoiceProduct = Console.ReadLine();
            while (userChoiceProduct.Length > 5)
            {
                Console.WriteLine("Tente novamente");
                userChoiceProduct = Console.ReadLine();
            }
            if (userChoiceProduct == "1")
            {
                outputQtd = BuyPattern(0, MinimalQtd, boughtProducts, produtos, workers, paymentChoice, billing, random);
            }
            if (userChoiceProduct == "2")
            {
                outputQtd = BuyPattern(1, MinimalQtd, boughtProducts, produtos, workers, paymentChoice, billing, random);
            }
            if (userChoiceProduct == "3")
            {
                outputQtd = BuyPattern(2, MinimalQtd, boughtProducts, produtos, workers, paymentChoice, billing, random);
            }
            if (userChoiceProduct == "4")
            {
                outputQtd = BuyPattern(3, MinimalQtd, boughtProducts, produtos, workers, paymentChoice, billing, random);
            }
            if (userChoiceProduct == "5")
            {
                outputQtd = BuyPattern(4, MinimalQtd, boughtProducts, produtos, workers, paymentChoice, billing, random);
            }
            return outputQtd;
        }
        public int BuyPattern(int item, int MinimalQtd, int boughtProducts, string[] produtos, string[] workers, string[] paymentChoice, int billing, int random)
        {
            int userInputQtd = 0;
            Console.WriteLine($"Escolhido: {produtos[item]} | Valor unidades: R${random} \n");
            Console.WriteLine($"Quantia Minima {MinimalQtd}\nDigite a quantidade:");
            string userInputQtdST = Console.ReadLine();
            userInputQtd = Convert.ToInt32(userInputQtdST);
            if (userInputQtd < MinimalQtd)
            {
                Console.WriteLine("Quantia invalida");
            }
            else
            {
                Console.WriteLine("Digite 1 para finalizar sua compra ou 2 para trocar a compra:"); //SOMENTE IMPRIMI NA TELA (CONT. NA PROGRAM)
            }
            return userInputQtd;
        }
        public int Payment(string[] paymentChoice)
        {
            int contador = 1;
            Console.WriteLine($"Escolha sua forma de pagamento: ");
            for (int i = 0; i < paymentChoice.Length; i++)
            {
                Console.WriteLine($"{contador} - {paymentChoice[i]}");
                contador++;
            }
            string userInputPaymentST = Console.ReadLine();
            int userInputPayment = Convert.ToInt32(userInputPaymentST);
            return userInputPayment;
        }
        public void Fechamento(int caixa, int billing, int boughtProducts, int userInputQtd, int random)
        {
            // NECESSARIO userInputQtd PARA PODER SOMAR O PRODUTOS COMPRADOS
            caixa = caixa + billing;
            Console.WriteLine($"Quantia atual no caixa: {caixa}");
            Console.WriteLine($"Quantidade produtos comprados: {boughtProducts} | Valor total R${billing}");
            Console.WriteLine("Clique ENTER para fechar o caixa");
            Console.ReadKey();
            Console.WriteLine("Caixa fechado com sucesso!");
        }
    }
}