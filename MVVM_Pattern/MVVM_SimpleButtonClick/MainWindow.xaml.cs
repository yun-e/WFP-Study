namespace MVVM_SimpleButtonClick {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
            
            // 현재 페이지 UI에 사용할 DataContext가 ViewModel.MainViewModel 에 있음
            // ViewModel과 UI가 연결됨
            this.DataContext = new MainViewModel();
        }
    }
}