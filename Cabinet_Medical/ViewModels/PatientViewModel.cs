using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1
{
    public class PatientViewModel
    {
        public bool IsSelected { get; set; }
        public int Number { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public DateTime LastTimeArive { get; set; }
        public string Sexe { get; set; }
        public char character { get; set; }
        public Brush BgColor { get; set; }
    }
}
