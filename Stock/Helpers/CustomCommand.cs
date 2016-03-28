using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Stock.Helpers
{
    public class CustomCommand:ICommand
    {
        Action<object> execute;
        Func<object, bool> canExecute;

        public CustomCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public CustomCommand(Action<object> execute)
          : this(execute, null)
        {

        }

        public bool CanExecute(object parameter)
        {
            if (this.canExecute != null)
                return this.canExecute(parameter);
            else
                return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
