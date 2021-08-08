using System;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVM_ExtremelySimpleMemoApp {
    public class MainViewModel : INotifyPropertyChanged {
        // 입력받은 값을 저장할 변수(_name, _info)에 대한 Property 
        private string _name;

        public string Name {
            get { return _name; }
            set {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _info;

        public string Info {
            get { return _info; }
            set {
                _info = value;
                OnPropertyChanged("Info");
            }
        }

        private string _output;

        public string Output {
            get { return _output; }
            set {
                _output = value;
                OnPropertyChanged("Output");
            }
        }

        private ICommand information;

        // 클릭 이벤트 발생
        public ICommand Information {
            get { return (this.information) ?? (this.information = new DelegateCommand(OutputInfo)); }
        }

        // Action 함수 정의
        // 입력받은 두 값을 가공하여 Output에 저장
        private void OutputInfo() {
            Output = _name + "\n\n" + _info;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) {
            if (propertyName != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    #region DelegateCommand Class

    public class DelegateCommand : ICommand {
        private readonly Func<bool> canExecute;
        private readonly Action execute;

        /// <summary>
        /// Initializes a new instance of the DelegateCommand class.
        /// </summary>
        /// <param name="execute">indicate an execute function</param>
        public DelegateCommand(Action execute) : this(execute, null) {
        }

        /// <summary>
        /// Initializes a new instance of the DelegateCommand class.
        /// </summary>
        /// <param name="execute">execute function </param>
        /// <param name="canExecute">can execute function</param>
        public DelegateCommand(Action execute, Func<bool> canExecute) {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// can executes event handler
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// implement of icommand can execute method
        /// </summary>
        /// <param name="o">parameter by default of icomand interface</param>
        /// <returns>can execute or not</returns>
        public bool CanExecute(object o) {
            if (this.canExecute == null) {
                return true;
            }

            return this.canExecute();
        }

        /// <summary>
        /// implement of icommand interface execute method
        /// </summary>
        /// <param name="o">parameter by default of icomand interface</param>
        public void Execute(object o) {
            this.execute();
        }

        /// <summary>
        /// raise ca excute changed when property changed
        /// </summary>
        public void RaiseCanExecuteChanged() {
            if (this.CanExecuteChanged != null) {
                this.CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }

    #endregion
}