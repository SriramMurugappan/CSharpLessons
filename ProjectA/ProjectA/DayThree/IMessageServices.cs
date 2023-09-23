/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.DayThree
{
    internal interface IMessageServices
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceivedMessage();
        void DeleteMessage();

    }
    public interface IPayments
    {
        void MakePayment(FlagsAttribute amount);
    }
    internal class WhatsApp : IMessageServices,IPayments 
    {
        public void DeleteMessage() 
        {
            Console.WriteLine("Method not implemented");
        }
        public void ReceiveMessage() 
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendAudioMessage() 
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendMessage()
        {
            Console.WriteLine("Method not implemented");
        }
        public void SendVideoMessage(string message) 
        {
            Console.WriteLine("Method not implemented");
        }
    }
    public class MessageTester
    {
        public static void TestOne()
        {
            IMessageServices messageServices = new WhatsApp();
            messageServices.SendMessage("hello");
            messageServices.ReceivedMessage();
        }
        
    }
}
*/