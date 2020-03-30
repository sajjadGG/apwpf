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
using MahApps.Metro;
using MahApps.Metro.Controls;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public static TabControl tbcstatic;

        public MainWindow()
        {
            InitializeComponent();
            tbcstatic = tbc;
        }

        private void Tbc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabItem oldTabItem;
            try
            {
                oldTabItem = e.RemovedItems[0] as TabItem;
            }catch(Exception ex)
            {
                oldTabItem = homeTab;
            }
            if (blackItem.IsSelected)
            {
                if (!App.isBlack)
                {
                    ThemeManager.ChangeAppStyle(Application.Current,
                                            ThemeManager.GetAccent("Cyan"),
                                            ThemeManager.GetAppTheme("BaseDark"));
                    App.isBlack = true;
                }
                else
                {
                    ThemeManager.ChangeAppStyle(Application.Current,
                                            ThemeManager.GetAccent("Cyan"),
                                            ThemeManager.GetAppTheme("BaseLight"));
                    App.isBlack = false;
                }
                tbc.SelectedIndex = 0;
            }
        }
    }
}
