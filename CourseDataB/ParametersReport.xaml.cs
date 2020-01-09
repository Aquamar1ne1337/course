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
using Stimulsoft.Report;
namespace CourseDataB
{
    /// <summary>
    /// Логика взаимодействия для ParametersReport.xaml
    /// </summary>
    public partial class ParametersReport : Window
    {
        public ParametersReport()
        {
            InitializeComponent();
        }

        private void Closebt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Buildbt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StiReport report = new StiReport();
                report.Load("Report2.mrt");
                report.Compile();
                report["DatePar"] = datep.SelectedDate;
                report.Render();
                report.ShowWithWpf();
            }
            catch { MessageBox.Show("Выберите дату!"); }
        }
    }
}
