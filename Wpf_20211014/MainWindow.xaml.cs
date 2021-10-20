using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Wpf_20211014
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenFileDialog openFileDailog = new OpenFileDialog();
            openFileDailog.Filter = "CSV檔案|*.csv|文字檔案|*.txt|所有檔案|*.*";

            if (openFileDailog.ShowDialog() == true)
            {

                string path = openFileDailog.FileName;
                StreamReader sr = new StreamReader(path, Encoding.Unicode);
                TextBlock1.Text = sr.ReadToEnd();

            }


        }

        
    }
}
