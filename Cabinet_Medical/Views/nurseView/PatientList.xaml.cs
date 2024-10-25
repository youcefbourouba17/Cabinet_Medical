using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp1;

namespace Cabinet_Medical.Views.nurseView
{
    /// <summary>
    /// Interaction logic for PatientList.xaml
    /// </summary>
    public partial class PatientList : Window
    {
        public ObservableCollection<PatientViewModel> Patients { get; set; }
        public BrushConverter converter { get; set; }

        public PatientList()
        {
            InitializeComponent();
            LoadPatientData();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool isMaximazed = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (isMaximazed)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 720;
                    this.Height = 1080;
                    isMaximazed = false;
                }
                else
                {

                    this.WindowState = WindowState.Maximized;
                    isMaximazed = true;
                }
            }
        }


        private void LoadPatientData()
        {
            // Initialize the data
            Patients = new ObservableCollection<PatientViewModel>
                {
                    new PatientViewModel { Number = 1, character = 'S', BgColor = Brushes.Blue, Nom = "Smith John", Prenom = "John", DateDeNaissance = new DateTime(1985, 6, 15), LastTimeArive = DateTime.Now.AddDays(-5), Sexe = "M" },
                    new PatientViewModel { Number = 2, character = 'D', BgColor = Brushes.Red, Nom = "Doe Jane", Prenom = "Jane", DateDeNaissance = new DateTime(1990, 3, 22), LastTimeArive = DateTime.Now.AddDays(-10), Sexe = "F" },
                    new PatientViewModel { Number = 3, character = 'D', BgColor = Brushes.Green, Nom = "Dupont Pierre", Prenom = "Pierre", DateDeNaissance = new DateTime(1978, 12, 5), LastTimeArive = DateTime.Now.AddDays(-3), Sexe = "M" },
                    new PatientViewModel { Number = 4, character = 'A', BgColor = Brushes.Yellow, Nom = "Anderson Alice", Prenom = "Alice", DateDeNaissance = new DateTime(1995, 7, 18), LastTimeArive = DateTime.Now.AddDays(-7), Sexe = "F" },
                    new PatientViewModel { Number = 5, character = 'B', BgColor = Brushes.Purple, Nom = "Brown Bob", Prenom = "Bob", DateDeNaissance = new DateTime(1988, 1, 25), LastTimeArive = DateTime.Now.AddDays(-15), Sexe = "M" },
                    new PatientViewModel { Number = 6, character = 'C', BgColor = Brushes.Orange, Nom = "Clark Carol", Prenom = "Carol", DateDeNaissance = new DateTime(1975, 8, 30), LastTimeArive = DateTime.Now.AddDays(-2), Sexe = "F" },
                    new PatientViewModel { Number = 7, character = 'M', BgColor = Brushes.Teal, Nom = "Martin Mark", Prenom = "Mark", DateDeNaissance = new DateTime(1992, 11, 11), LastTimeArive = DateTime.Now.AddDays(-20), Sexe = "M" },
                    new PatientViewModel { Number = 8, character = 'H', BgColor = Brushes.Gray, Nom = "Harrison Helen", Prenom = "Helen", DateDeNaissance = new DateTime(1969, 4, 3), LastTimeArive = DateTime.Now.AddDays(-30), Sexe = "F" },
                    new PatientViewModel { Number = 9, character = 'L', BgColor = Brushes.Cyan, Nom = "Lewis Leo", Prenom = "Leo", DateDeNaissance = new DateTime(1982, 2, 28), LastTimeArive = DateTime.Now.AddDays(-12), Sexe = "M" },
                    new PatientViewModel { Number = 10, character = 'W', BgColor = Brushes.Magenta, Nom = "Walker Wendy", Prenom = "Wendy", DateDeNaissance = new DateTime(1970, 5, 21), LastTimeArive = DateTime.Now.AddDays(-8), Sexe = "F" },
                    new PatientViewModel { Number = 11, character = 'F', BgColor = Brushes.LightBlue, Nom = "Fisher Frank", Prenom = "Frank", DateDeNaissance = new DateTime(1980, 9, 15), LastTimeArive = DateTime.Now.AddDays(-6), Sexe = "M" },
                    new PatientViewModel { Number = 12, character = 'P', BgColor = Brushes.Lavender, Nom = "Price Paula", Prenom = "Paula", DateDeNaissance = new DateTime(1993, 6, 10), LastTimeArive = DateTime.Now.AddDays(-9), Sexe = "F" },
                    new PatientViewModel { Number = 13, character = 'J', BgColor = Brushes.Coral, Nom = "Jameson Jake", Prenom = "Jake", DateDeNaissance = new DateTime(1987, 12, 2), LastTimeArive = DateTime.Now.AddDays(-13), Sexe = "M" },
                    new PatientViewModel { Number = 14, character = 'T', BgColor = Brushes.DarkBlue, Nom = "Taylor Tina", Prenom = "Tina", DateDeNaissance = new DateTime(1976, 8, 23), LastTimeArive = DateTime.Now.AddDays(-16), Sexe = "F" },
                    new PatientViewModel { Number = 15, character = 'N', BgColor = Brushes.DarkGray, Nom = "Nelson Nick", Prenom = "Nick", DateDeNaissance = new DateTime(1981, 5, 12), LastTimeArive = DateTime.Now.AddDays(-11), Sexe = "M" },
                    new PatientViewModel { Number = 16, character = 'G', BgColor = Brushes.Pink, Nom = "Green Grace", Prenom = "Grace", DateDeNaissance = new DateTime(1994, 4, 28), LastTimeArive = DateTime.Now.AddDays(-4), Sexe = "F" },
                    new PatientViewModel { Number = 17, character = 'K', BgColor = Brushes.Olive, Nom = "King Kyle", Prenom = "Kyle", DateDeNaissance = new DateTime(1989, 10, 18), LastTimeArive = DateTime.Now.AddDays(-18), Sexe = "M" },
                    new PatientViewModel { Number = 18, character = 'Q', BgColor = Brushes.Aqua, Nom = "Quinn Quinn", Prenom = "Quinn", DateDeNaissance = new DateTime(1983, 3, 14), LastTimeArive = DateTime.Now.AddDays(-14), Sexe = "M" },
                    new PatientViewModel { Number = 19, character = 'R', BgColor = Brushes.Brown, Nom = "Rivera Rosa", Prenom = "Rosa", DateDeNaissance = new DateTime(1996, 7, 9), LastTimeArive = DateTime.Now.AddDays(-19), Sexe = "F" },
                    new PatientViewModel { Number = 20, character = 'V', BgColor = Brushes.Gold, Nom = "Vasquez Victor", Prenom = "Victor", DateDeNaissance = new DateTime(1984, 11, 5), LastTimeArive = DateTime.Now.AddDays(-1), Sexe = "M" },
                    new PatientViewModel { Number = 21, character = 'E', BgColor = Brushes.Silver, Nom = "Evans Emma", Prenom = "Emma", DateDeNaissance = new DateTime(1979, 1, 27), LastTimeArive = DateTime.Now.AddDays(-21), Sexe = "F" },
                    new PatientViewModel { Number = 22, character = 'Y', BgColor = Brushes.PeachPuff, Nom = "Young Yolanda", Prenom = "Yolanda", DateDeNaissance = new DateTime(1991, 6, 20), LastTimeArive = DateTime.Now.AddDays(-17), Sexe = "F" },
                    new PatientViewModel { Number = 23, character = 'Z', BgColor = Brushes.Chartreuse, Nom = "Zimmer Zack", Prenom = "Zack", DateDeNaissance = new DateTime(1986, 12, 19), LastTimeArive = DateTime.Now.AddDays(-22), Sexe = "M" },
                    new PatientViewModel { Number = 24, character = 'O', BgColor = Brushes.Plum, Nom = "Owens Olivia", Prenom = "Olivia", DateDeNaissance = new DateTime(1974, 5, 16), LastTimeArive = DateTime.Now.AddDays(-23), Sexe = "F" },
                    new PatientViewModel { Number = 25, character = 'R', BgColor = Brushes.Sienna, Nom = "Reed Riley", Prenom = "Riley", DateDeNaissance = new DateTime(1983, 7, 29), LastTimeArive = DateTime.Now.AddDays(-24), Sexe = "M" },
                    new PatientViewModel { Number = 26, character = 'M', BgColor = Brushes.Maroon, Nom = "Mason Maria", Prenom = "Maria", DateDeNaissance = new DateTime(1997, 3, 15), LastTimeArive = DateTime.Now.AddDays(-25), Sexe = "F" },
                    new PatientViewModel { Number = 27, character = 'C', BgColor = Brushes.Tomato, Nom = "Carter Chris", Prenom = "Chris", DateDeNaissance = new DateTime(1971, 9, 10), LastTimeArive = DateTime.Now.AddDays(-26), Sexe = "M" },
                    new PatientViewModel { Number = 28, character = 'D', BgColor = Brushes.Salmon, Nom = "Diaz Diana", Prenom = "Diana", DateDeNaissance = new DateTime(1998, 2, 13), LastTimeArive = DateTime.Now.AddDays(-27), Sexe = "F" },
                    new PatientViewModel { Number = 29, character = 'H', BgColor = Brushes.Indigo, Nom = "Howard Henry", Prenom = "Henry", DateDeNaissance = new DateTime(1982, 10, 9), LastTimeArive = DateTime.Now.AddDays(-28), Sexe = "M" },
                    new PatientViewModel { Number = 30, character = 'T', BgColor = Brushes.Khaki, Nom = "Turner Tammy", Prenom = "Tammy", DateDeNaissance = new DateTime(1977, 12, 1), LastTimeArive = DateTime.Now.AddDays(-29), Sexe = "F" }
                };




            // Set the DataContext for data binding
            DataContext = this;
        }
    }
}
