using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScanBarCodeWinCE
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            Loaded += Page1_Loaded;
        }

        private void Page1_Loaded(object sender, RoutedEventArgs e)
        {
            _txbInput.Focus();
        }

        public bool AlwaysFocus { get; set; }

        private void _btnClear_Click(object sender, RoutedEventArgs e)
        {
            _txbInput.Clear();
            _txbInput.Focus();
            _txbInput.SelectAll();
        }

        private void _toggleFocus_Checked(object sender, RoutedEventArgs e)
        {
            AlwaysFocus = true;
            UpdateFocus();
        }

        private void _toggleFocus_Unchecked(object sender, RoutedEventArgs e)
        {
            AlwaysFocus = false;
            UpdateFocus();
        }


        private void _txbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                DoLog(_txbInput.Text);
                _btnClear_Click(null, null);
            }
        }

        private void UpdateFocus()
        {
            if (AlwaysFocus)
            {
                if (!_txbInput.IsFocused || !_txbInput.IsKeyboardFocusWithin)
                {
                    _txbInput.Focus();
                }
            }
        }

        private string GetCurrentLogFile()
        {
            
            return System.IO.Path.Combine(Properties.Settings.Default.LogDir, (DateTime.Now.ToString("yyyy-MM-dd") + ".txt"));
        }

        private bool DoLog(string message)
        {
            try
            {
                string fileName = GetCurrentLogFile();

                if (!File.Exists(fileName))
                {
                    using (var fs = File.Create(fileName)) { }
                }

                using (var sr = File.AppendText(fileName))
                {
                    string currentDate = DateTime.Now.ToString("yyyyMMdd");
                    string currentTime = DateTime.Now.ToString("HH:mm:ss");

                    sr.Write($"{currentDate},{currentTime},{message}");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi: {ex}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return false;
        }

        private void _txbInput_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (_txbInput.IsKeyboardFocused)
            {
                _txbInput.Background = Brushes.Green;
            }
            else
            {
                _txbInput.Background = Brushes.Orange;
            }
        }
    }
}
