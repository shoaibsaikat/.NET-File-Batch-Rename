using System;
using System.Windows;
using System.IO;

namespace FileBatchRename
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

        private void BtnReplace_Click(object sender, RoutedEventArgs e)
        {
            if(tbDirectory.Text != string.Empty && tbOrigName.Text != string.Empty)
            {
                var files = Directory.GetFiles(tbDirectory.Text, "*" + tbOrigName.Text + "*");
                String name = string.Empty;
                if(tbReplaceName.Text != string.Empty)
                {
                    foreach (var item in files)
                    {
                        name = item.Replace(tbOrigName.Text, tbReplaceName.Text);
                        File.Move(item, name);
                    }
                }
            }
        }
    }
}
