using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2_NZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(textBox.SelectedText);
            textBox.SelectedText = string.Empty;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(textBox.SelectedText);
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AlignLeft_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AlignCenter_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AlignRight_Click(object sender, RoutedEventArgs e)
        {

        }
        private void OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            UpdateCaretPosition();
        }
        private void UpdateCaretPosition()
        {
            int row = textBox.GetLineIndexFromCharacterIndex(textBox.CaretIndex);
            int column = textBox.CaretIndex - textBox.GetLineIndexFromCharacterIndex(row);

            currentColumn.Text = $"Col {column + 1}";
            currentLine.Text = $"Ln {row + 1}";
        }
    }
}
