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
            this.id = u.idUser;
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
            bool flagLog = ValidationReg.IsLoginValid(TBLog.Text);
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
            else
            {
                Brush err = Brushes.Red;
                Brush blue = BtnCancel.BorderBrush;
                //Style CB = (Style)FindResource("ComboBoxToggleButton");
                //Style CBBlue = CB;
                //Style CBErr = CB;
                //Setter col = new Setter();
                //col.Property = "BorderBrush";
                //CBErr.Resources.Add(col);
                //Setter template = (Setter)CB.Setters.FirstOrDefault(i => ((Setter)i).Property.Name == "Template");
                //int n = CB.Setters.IndexOf(template);
                //ControlTemplate CT = (ControlTemplate)template.Value;
                //ResourceDictionary tr = CT.FindName("templateRoot", Border);
                //Border BBlue = (Border)CT.Resources["templateRoot"];
                //Border BErr = (Border)CT.Resources["templateRoot"];
                //BErr.BorderBrush = err;
                //BBlue.BorderBrush = blue;
                //ControlTemplate CTBlue = CT;
                //CTBlue.Resources["templateRoot"] = BBlue;
                //Setter TBlue = template;
                //TBlue.Value = CTBlue;
                //CBBlue.Setters[n] = TBlue;
                //ControlTemplate CTErr = CT;
                //CTErr.Resources["templateRoot"] = BErr;
                //Setter TErr = template;
                //TErr.Value = CTErr;
                //CBErr.Setters[n] = TErr;
                //Resources["ComboBoxToggleButton"] = CBErr;

                TBLog.BorderBrush = flagLog ? blue : err;
                TBPas.BorderBrush = flagPas ? blue : err;
                TBLName.BorderBrush = flagLName ? blue : err;
                TBFName.BorderBrush = flagFName ? blue : err;
                TBWeight.BorderBrush = flagWeight ? blue : err;
                TBHeight.BorderBrush = flagHeight ? blue : err;
                //CBGender.Style = flagGender ? CBBlue : CBErr;
                TBBirthDate.BorderBrush = flagBirthDate ? blue : err;
            }
        }
    }
}
