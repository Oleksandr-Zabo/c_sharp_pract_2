using System;
using System.Text.RegularExpressions;

namespace c_sharp_pract_2.Clases
{
    internal class CreditCard
    {
        private string cardNumber;
        private string name;
        private string surname;
        private string patronymic;
        private string cvc;
        private ExpiryDate expiryDate;

        public string CardNumber
        {
            get => cardNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 16)
                {
                    throw new ArgumentException("Card number must be 16 digits.");
                }
                cardNumber = value;
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Name contains invalid characters.");
                }
                name = value;
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Username contains invalid characters.");
                }
                surname = value;
            }
        }

        public string Patronymic
        {
            get => patronymic;
            set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Patronymic contains invalid characters.");
                }
                patronymic = value;
            }
        }

        public string CVC
        {
            get => cvc;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 3)
                {
                    throw new ArgumentException("CVC must be 3 digits.");
                }
                cvc = value;
            }
        }

        public ExpiryDate ExpiryDate
        {
            get => expiryDate;
            set => expiryDate = value ?? throw new ArgumentException("Expiry date cannot be null.");
        }

        public double MoneyBalnce
        {
            get; set;
        }

        public CreditCard(string cardNumber, string name, string surname, string patronymic, string cvc, ExpiryDate expiryDate, double moneyBalnce)
        {
            CardNumber = cardNumber ?? throw new ArgumentNullException(nameof(cardNumber));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Patronymic = patronymic ?? throw new ArgumentNullException(nameof(patronymic));
            CVC = cvc ?? throw new ArgumentNullException(nameof(cvc));
            ExpiryDate = expiryDate ?? throw new ArgumentNullException(nameof(expiryDate));
            MoneyBalnce = moneyBalnce;
        }

        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

        public static CreditCard operator +(CreditCard card, double money)
        {
            card.MoneyBalnce += money;
            return card;
        }

        public static CreditCard operator -(CreditCard card, double money)
        {
            if (card.MoneyBalnce >= money)
            {
                card.MoneyBalnce -= money;
            }
            else
            {
                throw new ArgumentException("Not enough money.");
            }
            return card;
        }

        public override bool Equals(object obj)
        {
            if (obj is CreditCard card)
            {
                return card.CVC == CVC;
            }
            return false;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.Equals(card2);
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !card1.Equals(card2);
        }

        public override string ToString()
        {
            return $"Card: {CardNumber}, Name: {Name}, Username: {Surname}, Patronymic: {Patronymic}, CVC: {CVC}, Expiry: {ExpiryDate}, Money: {MoneyBalnce}";
        }
    }
}
