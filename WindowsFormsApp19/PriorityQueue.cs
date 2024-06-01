using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    class PriorityQueue
    {
        private List<Student> students = new List<Student>();

        public void Enqueue(Student student)
        {
            students.Add(student);
            HeapifyUp(students.Count - 1);
        }

        public Student Dequeue()
        {
            if (students.Count == 0) return null;
            Student top = students[0];
            students[0] = students[students.Count - 1];
            students.RemoveAt(students.Count - 1);
            HeapifyDown(0);
            return top;
        }

        public void HeapSort()
        {
            for (int i = students.Count / 2 - 1; i >= 0; i--)
                HeapifyDown(i);
            for (int i = students.Count - 1; i > 0; i--)
            {
                Student temp = students[0];
                students[0] = students[i];
                students[i] = temp;
                HeapifyDown(0, i);
            }
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (Compare(students[index], students[parent]) > 0)
                {
                    Student temp = students[index];
                    students[index] = students[parent];
                    students[parent] = temp;
                    index = parent;
                }
                else
                    break;
            }
        }

        private void HeapifyDown(int index, int count = -1)
        {
            if (count == -1) count = students.Count;
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int largest = index;

            if (left < count && Compare(students[left], students[largest]) > 0)
                largest = left;
            if (right < count && Compare(students[right], students[largest]) > 0)
                largest = right;
            if (largest != index)
            {
                Student temp = students[index];
                students[index] = students[largest];
                students[largest] = temp;
                HeapifyDown(largest, count);
            }
        }

        private int Compare(Student a, Student b)
        {
            if (a.GPA != b.GPA)
                return a.GPA.CompareTo(b.GPA);
            if (a.HasDuty != b.HasDuty)
                return a.HasDuty.CompareTo(b.HasDuty);
            return -a.AbsenceCount.CompareTo(b.AbsenceCount); // Az olan üstte
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
