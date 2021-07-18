using System.Windows;
using System.Windows.Input;

namespace WPFRoutedEvents {
    /// <summary>
    /// WPF에서 Mouse Click Event의 발생 순서와 처리 방법 확인
    /// </summary>
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("01");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("02");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("03");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("04");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("05");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("06");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("07");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("08");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("-----------------------------------------------");
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Window_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("01");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Window_PreviewMouseUp(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("02");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Grid_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("03");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Grid_PreviewMouseUp(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("04");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("05");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("06");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            System.Diagnostics.Debug.WriteLine("07");
            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e) {
            // 이벤트 핸들러가 이미 이벤트를 처리 하였다는 것을 의미
            // 더 이상의 처리가 요구되지 않기 때문에, 이후의 이벤트는 발새하지 않음
            // Bubbling 및 Tunneling 종료
            e.Handled = true;

            System.Diagnostics.Debug.WriteLine("08");

            System.Diagnostics.Debug.Write(e.Source + " is ");
            System.Diagnostics.Debug.WriteLine(e.ButtonState);
            System.Diagnostics.Debug.WriteLine(e.RoutedEvent);
            System.Diagnostics.Debug.WriteLine("e.Handled = " + e.Handled);
            System.Diagnostics.Debug.WriteLine("");
        }
    }
}