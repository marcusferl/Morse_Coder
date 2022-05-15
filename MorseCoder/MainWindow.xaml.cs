using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MorseCoder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int start = 0;
        private Dictionary<string, string> codeLegende = new Dictionary<string, string>();
        private List<string> morseWord = new List<string>();
        private Stopwatch sw = new Stopwatch();
        public MainWindow()    
        {
            
            MorseCode getCode = new MorseCode();
            getCode.Code(codeLegende);
            
            InitializeComponent();
        }
        private void mousen_MouseDown(object sender, MouseButtonEventArgs e)
        {
                sw.Start();
        }
        private void mousen_MouseUp(object sender, MouseButtonEventArgs e)
        {   
            sw.Stop();
            if(sw.Elapsed.TotalMilliseconds > 500)
            {
                morseWord.Add("long");
            }
            else
            {
                morseWord.Add("short");
            }
            sw.Reset();
            code_label.Content = String.Join(" ",morseWord);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(KeyValuePair<string, string> pair in codeLegende)
            {
                if(pair.Value.Equals(String.Join(" ", morseWord)))
                {
                    decode_label.Content += pair.Key;
                    morseWord.Clear();
                }
            }
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            code_label.Content = "";
            decode_label.Content = "";
            morseWord.Clear();
        }
    }
    }
    
