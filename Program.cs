namespace c_sharp_pract_2
{//lab ex. 4
    using c_sharp_pract_2.Clases;
    internal class Program
    {
        static void Main()
        {
            var creditCard = new CreditCard(cardNumber: "1234567890123456",
                name: "John",
                surname: "Doe",
                patronymic: "Bob",
                cvc: "123",
                expiryDate: new Clases.ExpiryDate(12, 2024),
                moneyBalnce: 1000
            );
            Console.WriteLine(creditCard);

            var creditCard1 = new CreditCard(cardNumber: "1234567890123456",
                name: "Bob",
                surname: "Doe",
                patronymic: "Dan",
                cvc: "543",
                expiryDate: new Clases.ExpiryDate(12, 2024),
                moneyBalnce: 100
            );

            Console.WriteLine(creditCard1);

            Console.WriteLine($"Is CVC card 1 == CVC card 2: {creditCard == creditCard1}");

            Console.WriteLine("CVC card 1 + 100");
            creditCard += 100;
            Console.WriteLine(creditCard);

            Console.WriteLine("CVC card 2 - 50");
            creditCard1 -= 50;
            Console.WriteLine(creditCard1);
        }
    }
}
