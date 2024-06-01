using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        private PriorityQueue priorityQueue = new PriorityQueue();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            int studentNo = int.Parse(txtStudentNo.Text);
            string name = txtName.Text;
            double gpa = double.Parse(txtGPA.Text);
            int absenceCount = int.Parse(txtAbsenceCount.Text);
            bool hasDuty = chkHasDuty.Checked;

            Student student = new Student(studentNo, name, gpa, absenceCount, hasDuty);
            priorityQueue.Enqueue(student);
            UpdateListBox();
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateListBox()
        {
            lstQueue.Items.Clear();
            List<Student> students = priorityQueue.GetStudents();
            priorityQueue.HeapSort();
            foreach (Student student in students)
            {
                lstQueue.Items.Add($"{student.StudentNo} - {student.Name} - {student.GPA} - {student.AbsenceCount} - {(student.HasDuty ? "Evet" : "Hayır")}");
            }
        }

        private void btnDequeue_Click_1(object sender, EventArgs e)
        {
            Student student = priorityQueue.Dequeue();
            if (student != null)
            {
                txtStudentNoResult.Text = student.StudentNo.ToString();
                txtNameResult.Text = student.Name;
                txtGPAResult.Text = student.GPA.ToString();
                txtAbsenceCountResult.Text = student.AbsenceCount.ToString();
                chkHasDutyResult.Checked = student.HasDuty;
                UpdateListBox();
            }
        }
    }
}
