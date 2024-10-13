using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Change_Event_Example
{

    public class TemperatureChangeEventArg : EventArgs
    {
        public double OldTemperature { get; }
        public double NewTemperature { get; }

        public double Diferrent { get; }

        public TemperatureChangeEventArg(double oldTemperature, double newTemperature)
        {
            this.OldTemperature = oldTemperature;
            this.NewTemperature = newTemperature;
            this.Diferrent = this.NewTemperature - this.OldTemperature;
        }
    }

    internal class clsTermostat
    {
        public event EventHandler<TemperatureChangeEventArg> OnTemperatureChangeEvent;

        private double OldTemperature , CurrentTemperature;

        public void SetTemperature(double NewTemperature)
        {
            if(CurrentTemperature != NewTemperature)
            {
                OldTemperature = CurrentTemperature;
                CurrentTemperature = NewTemperature;
                OnTemperatureChange(OldTemperature, CurrentTemperature);
            }
        }

        private void OnTemperatureChange(double OldTemperature , double CurrentTemperature)
        {
            OnTemperatureChange(new TemperatureChangeEventArg(OldTemperature, CurrentTemperature));
        }

        private void OnTemperatureChange(TemperatureChangeEventArg e)
        {
            OnTemperatureChangeEvent?.Invoke(this, e);
        }

    }
}
