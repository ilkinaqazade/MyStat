using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyStat
{
    public partial class Form1 : Form
    {
        public List<Student> Students { get; set; }
        UserControl1 user = new UserControl1();

        public Form1()
        {
            InitializeComponent();
            colorRgb();

            Students = new List<Student>
            {
                new Student
                {
                    StudentName = "ilkin",
                    StudentImage = null,
                },
                new Student
                {
                    StudentName = "ilkin",
                    StudentImage = null,
                },
                new Student
                {
                    StudentName = "ilkin",
                    StudentImage = null,
                }
            };

            user.Location = new Point(0, 100);
            this.Controls.Add(user);

            user.SetStudent(Students[0]);

            int x = 0;
            int y = 150;
            foreach (var item in Students)
            {
                var studentUC = new UserControl1();
                studentUC.Name = item.StudentName;
                studentUC.Location = new Point(x, y);
                studentUC.SetStudent(item);
                y += 100;
                this.Controls.Add(studentUC);
            }
        }

        private void colorRgb()
        {
            pictureBox1.BackColor = Color.FromArgb(58, 96, 110);
            mystatLb.BackColor = Color.FromArgb(58, 96, 110);
            menuPicBoxBacnkround.BackColor = Color.FromArgb(170, 192, 175);
            photoLb.BackColor = Color.FromArgb(170, 192, 175);
            fullNameLb.BackColor = Color.FromArgb(170, 192, 175);
            markpresenceLb.BackColor = Color.FromArgb(170, 192, 175);
            markonlineLb.BackColor = Color.FromArgb(170, 192, 175);
            testLb.BackColor = Color.FromArgb(170, 192, 175);
            classworkLb.BackColor = Color.FromArgb(170, 192, 175);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

   

}
