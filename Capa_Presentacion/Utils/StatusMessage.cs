using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Presentacion
{
    public class StatusUpdate : INotifyPropertyChanged
    {
        private string message;
        public event PropertyChangedEventHandler PropertyChanged;

        public StatusUpdate()
        {
        }

        public string Message
        {
            get { return this.message; }
            set
            {
                this.message = value;
                OnPropertyChanged("Message");
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}