using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Fitness_Assistant_2isp11_17_Makhanov.EF;
using Fitness_Assistant_2isp11_17_Makhanov.ClassHelper;
using Fitness_Assistant_2isp11_17_Makhanov.Classes;

namespace FitnessAssistant_Makhanov_2ISP11_17.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        int id = -1;
        public RegistrationWindow()
        {
            InitializeComponent();
        }
        public RegistrationWindow(User u)
        {
            InitializeComponent();
            BtnReg.Content = "ИЗМЕНИТЬ ДАННЫЕ";
            txtTitle.Text = "Изменение данных";
            id = u.idUser;
            TBLName.Text = u.LastName;
            TBFName.Text = u.FirstName;
            TBLog.Text = u.Login;
            TBPas.Text = u.Password;
            TBWeight.Text = u.Weight.ToString();
            TBHeight.Text = u.Height.ToString();
            TBBirthDate.Text = u.DateBirth.Date.ToString();
            Gender g = AppData.Context.Gender.ToList().FirstOrDefault(i => i.idGender == u.idGender);
            CBGender.Text = g.Gender1;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (id == -1)
            {
                MainWindow auth = new MainWindow();
                auth.Show();
                Close();
            }
            else
            {
                var userAuth = AppData.Context.User.ToList().FirstOrDefault(i => i.idUser == id);
                PersonalCabinetWindow cabinet = new PersonalCabinetWindow(userAuth);
                cabinet.Show();
                Close();
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            bool flagLog = id != -1 ? ValidationReg.IsLoginValid(TBLog.Text, id) : ValidationReg.IsLoginValid(TBLog.Text);
            bool flagPas = ValidationReg.IsPasswordValid(TBPas.Text);
            bool flagLName = ValidationReg.IsNameValid(TBLName.Text);
            bool flagFName = ValidationReg.IsNameValid(TBFName.Text);
            bool flagWeight = ValidationReg.IsParameterValid(TBWeight.Text);
            bool flagHeight = ValidationReg.IsParameterValid(TBHeight.Text);
            bool flagBirthDate = ValidationReg.IsBirthDateValid(TBBirthDate.Text);
            bool flagGender = ValidationReg.IsGenderValid(CBGender.Text);
            if (flagLog && flagPas && flagLName && flagFName && flagWeight && flagHeight && flagBirthDate && flagGender)
            {
                if (id == -1)
                {
                    Gender g = AppData.Context.Gender.ToList().FirstOrDefault(i => i.Gender1 == CBGender.Text);
                    User newUser = new User
                    {
                        LastName = TBLName.Text,
                        FirstName = TBFName.Text,
                        Login = TBLog.Text,
                        Password = TBPas.Text,
                        Weight = double.Parse(TBWeight.Text),
                        Height = double.Parse(TBHeight.Text),
                        DateBirth = DateTime.Parse(TBBirthDate.Text),
                        Gender = g
                    };
                    AppData.Context.User.Add(newUser);
                    AppData.Context.SaveChanges();
                    MainWindow auth = new MainWindow();
                    auth.Show();
                    Close();
                }
                else
                {
                    var users = AppData.Context.User.ToList();
                    var userAuth = users.FirstOrDefault(i => i.idUser == id);
                    int n = users.IndexOf(userAuth);
                    userAuth.LastName = TBLName.Text;
                    userAuth.FirstName = TBFName.Text;
                    userAuth.Login = TBLog.Text;
                    userAuth.Password = TBPas.Text;
                    userAuth.Weight = double.Parse(TBWeight.Text);
                    userAuth.Height = double.Parse(TBHeight.Text);
                    userAuth.DateBirth = DateTime.Parse(TBBirthDate.Text);
                    Gender g = AppData.Context.Gender.ToList().FirstOrDefault(i => i.Gender1 == CBGender.Text);
                    userAuth.Gender = g;
                    users.RemoveAt(n);
                    users.Insert(n, userAuth);
                    AppData.Context.SaveChanges();
                    PersonalCabinetWindow cabinet = new PersonalCabinetWindow(userAuth);
                    cabinet.Show();
                    Close();
                }
            }
            else
            {
                Brush err = Brushes.Red;
                Brush blue = BtnCancel.BorderBrush;

                TBLog.BorderBrush = flagLog ? blue : err;
                TBPas.BorderBrush = flagPas ? blue : err;
                TBLName.BorderBrush = flagLName ? blue : err;
                TBFName.BorderBrush = flagFName ? blue : err;
                TBWeight.BorderBrush = flagWeight ? blue : err;
                TBHeight.BorderBrush = flagHeight ? blue : err;
                TBBirthDate.BorderBrush = flagBirthDate ? blue : err;
            }
        }
    }
}
