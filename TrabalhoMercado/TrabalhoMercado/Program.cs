using TrabalhoMercado;
Mercado mercado = new Mercado();
Random random = new Random();

string[] paymentChoice = new string[3];
string[] workers = new string[2];
string[] produtos = new string[5];
int[] despesa = new int[3];
int boughtProducts = 0;
int userInputQtdReturned = 0;
int outputQtd = 0;
int billing = 0;
int caixa = 50;
int MinimalQtd = 100;

produtos[0] = "Maça";
produtos[1] = "Picanha";
produtos[2] = "Detergente";
produtos[3] = "Ração";
produtos[4] = "Fini";
workers[0] = "João";
workers[1] = "Carina";
paymentChoice[0] = "Crédito";
paymentChoice[1] = "Débito";
paymentChoice[2] = "Dinheiro";

Console.WriteLine("Supermercado HM\n");
bool userUsing = true;
while (userUsing)
{
    int randomReturned = random.Next(20, 40);
    Console.WriteLine("1 - Comprar\n2- Checar o caixa\n3 - Encerrar\n");
    var userInputChoice = Console.ReadLine();
    if (userInputChoice == "1")
    {
        userInputQtdReturned = mercado.Buying(produtos, MinimalQtd, boughtProducts, workers, paymentChoice, billing, randomReturned, outputQtd);
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            int billingUser = 0;
            int PaymentReturned = mercado.Payment(paymentChoice);
            boughtProducts = boughtProducts + userInputQtdReturned;
            billing = billing + userInputQtdReturned * randomReturned;
            billingUser = billingUser + userInputQtdReturned * randomReturned;
            Console.WriteLine($"{workers[0]} efetuou sua compra no valor de R${billingUser} no {paymentChoice[--PaymentReturned]} com sucesso, {workers[1]} empacotou sua compra. Aproveite!");
        }
    }
    if (userInputChoice == "2")
    {
        mercado.Fechamento(caixa, billing, boughtProducts, userInputQtdReturned, randomReturned);
    }
    if (userInputChoice == "3")
    {
        Console.Clear();
        Console.WriteLine("Até a proxima!");
        userUsing = false;
    }
}