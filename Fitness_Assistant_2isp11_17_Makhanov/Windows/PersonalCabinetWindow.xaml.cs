using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Fitness_Assistant_2isp11_17_Makhanov.ClassHelper;
using Fitness_Assistant_2isp11_17_Makhanov.EF;

namespace FitnessAssistant_Makhanov_2ISP11_17.Windows
{
    /// <summary>
    /// Логика взаимодействия для PersonalCabinetWindow.xaml
    /// </summary>
    public partial class PersonalCabinetWindow : Window
    {
        User user = null;
        public PersonalCabinetWindow()
        {
            InitializeComponent();
        }
        public PersonalCabinetWindow(User u)
        {
            InitializeComponent();
            user = u;
            txtWelcome.Text = "Добро пожаловать, " + user.LastName + " " + user.FirstName + "!";
            txtAge.Text = user.Age.ToString();
            txtHeight.Text = user.Height.ToString();
            txtWeight.Text = user.Weight.ToString();
            double h = user.Height / 100;
            double h2 = h * h;
            double indexMass = user.Weight / h2;
            txtIndexMass.Text = indexMass.ToString() + "кг/м2";
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow auth = new MainWindow();
            auth.Show();
            Close();
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow register = new RegistrationWindow(user);
            register.Show();
            Close();
        }
    }
}
