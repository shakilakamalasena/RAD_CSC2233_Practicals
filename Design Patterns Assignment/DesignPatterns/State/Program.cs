using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        // STATE INTERFACE
        public interface IAlertState
        {
            void Alert();
        }

        // CONTEXT CLASS
        public class MobilePhone
        {
            private IAlertState alertState;

            public MobilePhone(IAlertState alertState)
            {
                this.alertState = alertState;
            }

            public void SetState(IAlertState state)
            {
                alertState = state;
            }

            public void Alert()
            {
                alertState.Alert();
            }
        }

        // CONCRETE STATE CLASS
        public class VibrationState : IAlertState
        {
            public void Alert()
            {
                Console.WriteLine("Phone is vibrating...");
            }
        }

        public class SilentState : IAlertState
        {
            public void Alert()
            {
                Console.WriteLine("Phone is Silent. No alerts will be heard.");
            }
        }

        static void Main(string[] args)
        {
            MobilePhone phone = new MobilePhone(new VibrationState());

            phone.Alert();

            phone.SetState(new SilentState());

            phone.Alert();

            Console.ReadKey();
        }
    }
}
