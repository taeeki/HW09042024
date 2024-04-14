CreditCard card1 = new CreditCard("487457ifi", 20000);
CreditCard card2 = new CreditCard("74536333", 569000000);
CreditCard card3 = new CreditCard("84565447y", 65984);

//Вывод информации о карточке 
card1.PrintInfoCard();
card2.PrintInfoCard();
card3.PrintInfoCard();

card1.AddMoney(5000);
card2.AddMoney(1);
card3.WithdrawMoney(984);

Console.WriteLine("Состояние карточек послы выполнения транзакций: ");
//Вывод информации о карточке 
card1.PrintInfoCard();
card2.PrintInfoCard();
card3.PrintInfoCard();

public class CreditCard
{
    public string AccountNum;
    public decimal BalanceNow;

    public void AddMoney(decimal cash)
    {
        this.BalanceNow += cash;
    }

    public CreditCard(string _numb, decimal _bal)
    {
        this.AccountNum = _numb;
        this.BalanceNow += _bal;
    }
    public void WithdrawMoney(decimal cash)
    {
        this.BalanceNow -= cash;
    }
    public void PrintInfoCard()
    {
        Console.WriteLine($"Номер счета: {AccountNum}" +
            $" Сумма на счете: {BalanceNow}");
    }
}