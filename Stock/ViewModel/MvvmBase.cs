using log4net.Core;
using Stock.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.ViewModel
{
    public class MvvmBase : INotifyPropertyChanged,IDisposable 
    {        
        public event PropertyChangedEventHandler PropertyChanged;

        private OperationResult _result { get; set; }
        public OperationResult Result
        {
            get {
                if (_result!=null)
                {
                    return new OperationResult(!_result.IsSucess, _result.Message);
                }
                return _result; }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }        

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
