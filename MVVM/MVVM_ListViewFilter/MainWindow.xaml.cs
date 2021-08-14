namespace MVVM_ListViewFilter {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();

            // DataContext 객체를 이용하여 느슨한 결합으로 참조
            this.DataContext = new ViewModels.MainViewModel();
        }
    }
}