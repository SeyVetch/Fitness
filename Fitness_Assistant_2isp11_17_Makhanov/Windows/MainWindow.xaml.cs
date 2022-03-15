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
using Fitness_Assistant_2isp11_17_Makhanov.ClassHelper;
using FitnessAssistant_Makhanov_2ISP11_17.Windows;

namespace FitnessAssistant_Makhanov_2ISP11_17
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

        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {
            
            string login = TBLog.Text;
            string password = TBPas.Text;
            var userAuth = AppData.Context.User.ToList().FirstOrDefault(i => i.Login == login && i.Password == password);
            if (userAuth != null)
            {
                PersonalCabinetWindow cabinet = new PersonalCabinetWindow(userAuth);
                cabinet.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Пользователь с такими данными не найден!");
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow register = new RegistrationWindow();
            register.Show();
            Close();
        }
    }
}
