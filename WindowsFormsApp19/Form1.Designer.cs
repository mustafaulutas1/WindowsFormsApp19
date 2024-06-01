
namespace WindowsFormsApp19
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstQueue = new System.Windows.Forms.ListBox();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkHasDutyResult = new System.Windows.Forms.CheckBox();
            this.chkHasDuty = new System.Windows.Forms.CheckBox();
            this.txtAbsenceCountResult = new System.Windows.Forms.TextBox();
            this.txtGPAResult = new System.Windows.Forms.TextBox();
            this.txtNameResult = new System.Windows.Forms.TextBox();
            this.txtStudentNoResult = new System.Windows.Forms.TextBox();
            this.txtAbsenceCount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstQueue
            // 
            this.lstQueue.FormattingEnabled = true;
            this.lstQueue.ItemHeight = 16;
            this.lstQueue.Location = new System.Drawing.Point(331, 120);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(290, 276);
            this.lstQueue.TabIndex = 50;
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(484, 402);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(137, 30);
            this.btnDequeue.TabIndex = 49;
            this.btnDequeue.Text = "Kuyruktan Çıkar";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(328, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "KUYRUKTAKİ ÖĞRENCİLER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(632, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(289, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "KUYRUKTAN ÇEKİLEN ÖĞRENCİ BİLGİLERİ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "ÖĞRENCİ BİLGİLERİ";
            // 
            // chkHasDutyResult
            // 
            this.chkHasDutyResult.AutoSize = true;
            this.chkHasDutyResult.Location = new System.Drawing.Point(777, 299);
            this.chkHasDutyResult.Name = "chkHasDutyResult";
            this.chkHasDutyResult.Size = new System.Drawing.Size(112, 21);
            this.chkHasDutyResult.TabIndex = 45;
            this.chkHasDutyResult.Text = "Görev Alıyor:";
            this.chkHasDutyResult.UseVisualStyleBackColor = true;
            // 
            // chkHasDuty
            // 
            this.chkHasDuty.AutoSize = true;
            this.chkHasDuty.Location = new System.Drawing.Point(196, 300);
            this.chkHasDuty.Name = "chkHasDuty";
            this.chkHasDuty.Size = new System.Drawing.Size(112, 21);
            this.chkHasDuty.TabIndex = 44;
            this.chkHasDuty.Text = "Görev Alıyor:";
            this.chkHasDuty.UseVisualStyleBackColor = true;
            // 
            // txtAbsenceCountResult
            // 
            this.txtAbsenceCountResult.Location = new System.Drawing.Point(775, 261);
            this.txtAbsenceCountResult.Name = "txtAbsenceCountResult";
            this.txtAbsenceCountResult.Size = new System.Drawing.Size(100, 22);
            this.txtAbsenceCountResult.TabIndex = 43;
            // 
            // txtGPAResult
            // 
            this.txtGPAResult.Location = new System.Drawing.Point(775, 219);
            this.txtGPAResult.Name = "txtGPAResult";
            this.txtGPAResult.Size = new System.Drawing.Size(100, 22);
            this.txtGPAResult.TabIndex = 42;
            // 
            // txtNameResult
            // 
            this.txtNameResult.Location = new System.Drawing.Point(775, 173);
            this.txtNameResult.Name = "txtNameResult";
            this.txtNameResult.Size = new System.Drawing.Size(100, 22);
            this.txtNameResult.TabIndex = 41;
            // 
            // txtStudentNoResult
            // 
            this.txtStudentNoResult.Location = new System.Drawing.Point(775, 129);
            this.txtStudentNoResult.Name = "txtStudentNoResult";
            this.txtStudentNoResult.Size = new System.Drawing.Size(100, 22);
            this.txtStudentNoResult.TabIndex = 40;
            // 
            // txtAbsenceCount
            // 
            this.txtAbsenceCount.Location = new System.Drawing.Point(196, 256);
            this.txtAbsenceCount.Name = "txtAbsenceCount";
            this.txtAbsenceCount.Size = new System.Drawing.Size(100, 22);
            this.txtAbsenceCount.TabIndex = 39;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(196, 171);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 38;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(196, 214);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(100, 22);
            this.txtGPA.TabIndex = 37;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(196, 131);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(100, 22);
            this.txtStudentNo.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(632, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Öğrenci Toplulukları:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Devamsızlık Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ortalama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ad-Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Öğrenci NO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Öğrenci Toplulukları:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Devamsızlık Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ortalama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ad-Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Öğrenci NO:";
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(196, 356);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(75, 23);
            this.btnEnqueue.TabIndex = 51;
            this.btnEnqueue.Text = "EKLE";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 542);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.lstQueue);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkHasDutyResult);
            this.Controls.Add(this.chkHasDuty);
            this.Controls.Add(this.txtAbsenceCountResult);
            this.Controls.Add(this.txtGPAResult);
            this.Controls.Add(this.txtNameResult);
            this.Controls.Add(this.txtStudentNoResult);
            this.Controls.Add(this.txtAbsenceCount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstQueue;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkHasDutyResult;
        private System.Windows.Forms.CheckBox chkHasDuty;
        private System.Windows.Forms.TextBox txtAbsenceCountResult;
        private System.Windows.Forms.TextBox txtGPAResult;
        private System.Windows.Forms.TextBox txtNameResult;
        private System.Windows.Forms.TextBox txtStudentNoResult;
        private System.Windows.Forms.TextBox txtAbsenceCount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnqueue;
    }
}

