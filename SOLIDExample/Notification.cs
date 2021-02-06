using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    public class Email
    {
        public void SendEmail()
        {
            Console.WriteLine("Email sent.....");
        }
    }

    public class Notification
    {
        private Email _email;
        public Notification()
        {
            _email = new Email();
        }

        public void PromotionalNotification()
        {
            _email.SendEmail();
        }
    }

    public interface IMessenger
    {
        void SendMessage();
    }
    public class EmailV2 : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("Email sent....");
        }
    }

    public class SMSV2 : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("SMS sent....");
        }
    }
    public class MethodNotification
    {

        #region Method dependency injection
        /// <summary>
        /// Method dependency injection.
        /// </summary>
        /// <param name="_IMessengerV2"></param>
        public void DoNotify(IMessenger _IMessengerV2)
        {
            _IMessengerV2.SendMessage();
        }
        #endregion
    }

    public class ConstructorNotification
    {
        #region constructor injection
        private IMessenger _iMessenger;
        public ConstructorNotification(IMessenger _iMessenger2)
        {
            _iMessenger = _iMessenger2;
        }

        public void DoNotify()
        {
            _iMessenger.SendMessage();
        }
        #endregion

    }

    public class PropertyNotification
    {
        #region Property injection
        private IMessenger _iMessenger;

        public IMessenger MessageService
        {
            set
            {
                _iMessenger = value;
            }
        }

        public void DoNotify()
        {
            _iMessenger.SendMessage();
        }
        #endregion

    }
}
