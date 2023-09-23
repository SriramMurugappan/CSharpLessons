/*using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjectA.DaySeven
{
    internal class Bank
    {
        public int Id;
        public string Name;
        public string Address;
    }
    internal class Branch
    {
        public int bankId;
        public readonly int branchId;
        public string BranchName = string.Empty;
        public string BranchAddress = string.Empty;
        public string BranchCity = string.Empty;
        public string BranchZipCode;
        List<Customer> CustomerList = new List<Customer>();
        public Branch(int BankId, int BranchId)
        {
            BankId = bankId;
            BranchId = branchId;
        }
        public void AddnewCustomerToBranch(Customer customer)
        {
            CustomerList.Add(customer);
        }
        public void RemoveCustomerFromBranch(Customer customer)
        {
            Customer foundCustomer = CustomerList.FirstOrDefault(customer);
            if (foundCustomer == null)
            {
                Console.WriteLine("Customer Does not exist in this branch");
                return null;
            }
            return;
        }
    }
    class Customer
    {
        public readonly int CustomerID;
        public string CustomerName = String.Empty;
        public string CustomerAddress = String.Empty;
        public string CustomerCity = String.Empty;
        public string CustomerZipCode;
        public readonly DateTime DateOfBirth;
        public HashSet<Account> AccountList = ;//
    }
    public enum AccountType
    {
        SavingsAccount = 0, CurrentAccount = 1, FixedAccount = 2, LoanAccount = 3
    }
    class Account
    {
        public readonly long AccountNumber;
        public readonly int CustomerID;
        public AccountType TypeOfAccount;
        public const float MIN_Balance = 2000f;
        public const float MAX_Balance = 2000000f;
        private float currentBalance = 0;

        public float CurrentBalance
        {
            get => currentBalance;
            set
            {
                if ((currentBalance - value) < 1)
                    throw new Exception("Insufficient Balance");
                if ((currentBalance + value) > MAX_Balance)
                    throw new Exception("Very Large balance");
                currentBalance = value;
            }

        }
    }
    public enum MessagePriority
    {
        Normal = 0, Urgent = 1, Low = 2
    }
    class Message
    {
        public String To = String.Empty;
        public String From = String.Empty;
        public String Subject = String.Empty;
        public String Body = String.Empty;
        public String Attachment = String.Empty;
    }
    class AccountController
    {
        private Account account;
        public AccountController(Account account)
        {
            this.account = account;
        }
        public void DoWithdrawal(int accountNo, float amount)
        {
            if (accountNo == 0)
            {
                throw new Exception("Account Number must be > 0");
            }
            if (amount < 50)
            {
                throw new Exception("Amount to withdraw must be >50");
            }
            if (account != null)
            {
                throw new Exception("Account Not Found");
            }
            try
            {
                account.CurrentBalance -= amount;
                Console.WriteLine($"Withdraw Successfully your Balance{account.CurrentBalance}");
            }
            catch (Exception e)
            {

            }

            

    }
    }
    interface IMessageCreator
    {
        void SendSMS(long phoneNo, String msg);
        void SendEmail(String emailAddress, String msg);
        void ReceiveSMS(String msg);
        void ReceiveEmail(String msg);
        
    }
    class MessageController : IMessageCreator
    {
        public void ReceiveEmail(string msg)
        {
            try
            {
                Console.WriteLine("Not Implemented");
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }

}*/

