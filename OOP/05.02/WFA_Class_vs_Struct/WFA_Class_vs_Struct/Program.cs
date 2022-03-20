using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Class_vs_Struct
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Struct
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Rıdvan";
            ogrenci.Soyad = "AKsoy";

            Ogrenci ogrenci1 = ogrenci;
            ogrenci1.Ad = "Kürşat";
            ogrenci1.Soyad = "Eren";
            #endregion

            #region Class
            Student student = new Student();
            student.FirstName = "Rüstem";
            student.LastName = "Yıldız";

            Student student1 = student;
            student1.FirstName = "Emre";
            student1.LastName = "Geveze";
            #endregion



        }



    }
}
