using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo.Service
{
    public class Command<T> : ICommand
    {
        readonly Func<T, bool> canExecute;
        readonly Action<T> execute;
        bool canExecuteCache;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            var temp = canExecute?.Invoke((T)parameter) ?? true;

            if (canExecuteCache != temp)
            {
                canExecuteCache = temp;
                OnChanged();
            }

            return canExecuteCache;
        }

        public void Execute(object parameter)
        {
            execute?.Invoke((T)parameter);
        }

        public void OnChanged()
        {
            CanExecuteChanged?.Invoke(this, null);
        }

        public Command(Action action)
        {
            execute = obj => action?.Invoke();
        }

        public Command(Action<T> action)
        {
            execute = action;
        }

        public Command(Action action, Func<bool> canAction)
        {
            execute = obj => action?.Invoke();
            canExecute = obj => canAction?.Invoke() ?? true;
        }

        public Command(Action<T> action, Func<T, bool> canAction)
        {
            execute = action;
            canExecute = canAction;
        }
    }

    public class Command : Command<object>
    {
        public Command(Action action) : base(action)
        {
        }

        public Command(Action<object> action) : base(action)
        {
        }

        public Command(Action action, Func<bool> canAction) : base(action, canAction)
        {
        }

        public Command(Action<object> action, Func<object, bool> canAction) : base(action, canAction)
        {
        }
    }
}