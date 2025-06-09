namespace OnlineShopping
{
    class UserProfile
    {
        // Private Properties
        private static int userCount = 0;
        private string userId = "";
        private string password = "";
        private string email = "";
        private double accountBalance = 0;


        // Public Properties
        public string UserId
        {
            get { return userId; }
        }
        public string Email
        {
            get
            {
                if (!string.IsNullOrEmpty(email))
                {
                    return email;
                }
                else
                {
                    throw new Exception("Email is not set.");
                }
            }
            set
            {
                if (!value.Contains('@'))
                {
                    throw new Exception("Invalid email.");
                }
                else
                {
                    email = value;
                }
            }
        }

        public string Password
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Password not set");
                }
                else
                {
                    password = value;
                }
            }
        }

        public double AccountBalance
        {
            get
            {
                return accountBalance;
            }
        }

        public double AddBalance(double amount)
        {
            accountBalance += amount;
            Console.WriteLine($"{amount} added to balance");
            return accountBalance;
        }

        public double MakePurchase(double price)
        {
            if (accountBalance - price >= 0)
            {
                accountBalance -= price;
                Console.WriteLine($"{price} deducted from balance");

                return accountBalance;
            }
            else
            {
                throw new Exception("Insufficient balance for purchase.");
            }
        }

        public void ChangeEmail(string newEmail)
        {
            if (newEmail.Contains('@'))
            {
                email = newEmail;
            }
            else
            {
                throw new Exception("Invalid email format.");
            }
        }

        public bool Authenticate(string pass)
        {
            if (pass.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public UserProfile(string email, string password, double accountBalance)
        {
            userCount++;
            userId = $"USR{userCount:D3}";
            Email = email;
            Password = password;
            this.accountBalance = accountBalance;
        }


    }

    public class Program
    {
        static void Main(string[] args)
        {
            UserProfile user = new UserProfile("john.doe@gmail.com", "12345", 1000.0);
            Console.WriteLine("ID: {0}", user.UserId);
            Console.WriteLine("Email: {0}", user.Email);
            Console.WriteLine("Account Balance: {0}", user.AccountBalance);

            user.AddBalance(500);
            user.MakePurchase(200);
            user.ChangeEmail("john@newmail.com");
            bool isValid = user.Authenticate("12345");


            // Some Extra code to verify

            Console.WriteLine($"Current Account Balance is {user.AccountBalance}");
            Console.WriteLine($"Email is updated to {user.Email}");
            Console.WriteLine($"Validity of the entered password is: {isValid}");


            Console.WriteLine("----------------------------------------------------");

            UserProfile admin = new UserProfile("admin@gmail.com", "00000000", 2000);
            Console.WriteLine("ID: {0}", admin.UserId);
            Console.WriteLine("Email: {0}", admin.Email);
            Console.WriteLine("Account Balance: {0}", admin.AccountBalance);

            admin.AddBalance(5000);
            admin.MakePurchase(2000);
            Console.WriteLine("Account Balance: {0}", admin.AccountBalance);
            admin.ChangeEmail("newadmin@gmail.com");
            Console.WriteLine($"Email is updated to {admin.Email}");

            isValid = admin.Authenticate("0000");
            Console.WriteLine($"Validity of the entered password is: {isValid}");


        }
    }



}