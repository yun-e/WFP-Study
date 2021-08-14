using System;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVM_SimpleButtonClick {
    public class MainViewModel : INotifyPropertyChanged {
        private string _str;

        public string Str {
            get { return _str; }
            set {
                _str = value;
                // set 이 호출되어 Str의 값이 변경되면 UI에게 변경됨을 알림
                // 개발자가 특별한 코드를 추가하지 않아도 자동으로 변경된 값으로 수정
                OnPropertyChanged("Str");
            }
        }

        public MainViewModel() {
            Str = "Unclicked";
        }

        // OnPropertyChanged의 실제 구현
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        private ICommand _clickCommand;

        // get을 갖는 ClickCommand 속성 추가
        public ICommand ClickCommand {
            get { return (this._clickCommand) ?? (this._clickCommand = new DelegateCommand(Click)); }
        }

        // Click() 이라는 Action 함수 정의
        // Click 상태를 Str에 저장함
        private void Click() {
            if (_str == "Unclicked") {
                Str = "Clicked";
            }
            else {
                Str = "Unclicked";
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