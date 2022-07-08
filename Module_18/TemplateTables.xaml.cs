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
using System.Windows.Shapes;

namespace Module_18
{
    /// <summary>
    /// Логика взаимодействия для TemplateTables.xaml
    /// </summary>
    public partial class TemplateTables : Window
    {
        public TemplateTables()
        {
            InitializeComponent();
            DataGrid.DataContext = Repository.CreateTemplateTable();
        }
    }
}
