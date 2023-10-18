using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStat
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void SetStudent(Student student)
        {
            nameLbr.Text = student.StudentName;
            stundetImagePbox.Image = student.StudentImage;
        }
    }

    public class Student
    {
        public Image StudentImage { get; set; }
        public string StudentName { get; set; }
    }
}
