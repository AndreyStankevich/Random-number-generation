namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.editA = new System.Windows.Forms.TextBox();
            this.editM = new System.Windows.Forms.TextBox();
            this.editR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblDispersion = new System.Windows.Forms.Label();
            this.lblDeviation = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblAperiodic = new System.Windows.Forms.Label();
            this.cbDistribution = new System.Windows.Forms.ComboBox();
            this.rbLab1 = new System.Windows.Forms.RadioButton();
            this.rbLab2 = new System.Windows.Forms.RadioButton();
            this.editAlpha = new System.Windows.Forms.TextBox();
            this.editBeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.panelLab1 = new System.Windows.Forms.Panel();
            this.panelLab2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.editη = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editλ = new System.Windows.Forms.TextBox();
            this.panelLab1.SuspendLayout();
            this.panelLab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(34, 93);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // editA
            // 
            this.editA.Location = new System.Drawing.Point(34, 13);
            this.editA.Name = "editA";
            this.editA.Size = new System.Drawing.Size(100, 20);
            this.editA.TabIndex = 1;
            this.editA.Text = "1046527";
            // 
            // editM
            // 
            this.editM.Location = new System.Drawing.Point(34, 41);
            this.editM.Name = "editM";
            this.editM.Size = new System.Drawing.Size(100, 20);
            this.editM.TabIndex = 2;
            this.editM.Text = "65537";
            // 
            // editR
            // 
            this.editR.Location = new System.Drawing.Point(34, 67);
            this.editR.Name = "editR";
            this.editR.Size = new System.Drawing.Size(100, 20);
            this.editR.TabIndex = 3;
            this.editR.Text = "32771";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "R";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPeriod.Location = new System.Drawing.Point(31, 119);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(81, 20);
            this.lblPeriod.TabIndex = 7;
            this.lblPeriod.Text = "Период - ";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAverage.Location = new System.Drawing.Point(1280, 183);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(137, 20);
            this.lblAverage.TabIndex = 8;
            this.lblAverage.Text = "Мат. ожидание - ";
            // 
            // lblDispersion
            // 
            this.lblDispersion.AutoSize = true;
            this.lblDispersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDispersion.Location = new System.Drawing.Point(1281, 213);
            this.lblDispersion.Name = "lblDispersion";
            this.lblDispersion.Size = new System.Drawing.Size(104, 20);
            this.lblDispersion.TabIndex = 9;
            this.lblDispersion.Text = "Дисперсия - ";
            // 
            // lblDeviation
            // 
            this.lblDeviation.AutoSize = true;
            this.lblDeviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeviation.Location = new System.Drawing.Point(1282, 243);
            this.lblDeviation.Name = "lblDeviation";
            this.lblDeviation.Size = new System.Drawing.Size(115, 20);
            this.lblDeviation.TabIndex = 10;
            this.lblDeviation.Text = "Отклонение - ";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblK.Location = new System.Drawing.Point(32, 178);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(32, 20);
            this.lblK.TabIndex = 11;
            this.lblK.Text = "K - ";
            // 
            // lblAperiodic
            // 
            this.lblAperiodic.AutoSize = true;
            this.lblAperiodic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAperiodic.Location = new System.Drawing.Point(32, 148);
            this.lblAperiodic.Name = "lblAperiodic";
            this.lblAperiodic.Size = new System.Drawing.Size(151, 20);
            this.lblAperiodic.TabIndex = 12;
            this.lblAperiodic.Text = "Апериодичность - ";
            // 
            // cbDistribution
            // 
            this.cbDistribution.FormattingEnabled = true;
            this.cbDistribution.Items.AddRange(new object[] {
            "Равномерное",
            "Гауссовское",
            "Экспоненциальное",
            "Гамма",
            "Треугольное",
            "Симпсона"});
            this.cbDistribution.Location = new System.Drawing.Point(14, 3);
            this.cbDistribution.Name = "cbDistribution";
            this.cbDistribution.Size = new System.Drawing.Size(121, 21);
            this.cbDistribution.TabIndex = 13;
            this.cbDistribution.Text = "Равномерное";
            this.cbDistribution.SelectedIndexChanged += new System.EventHandler(this.cbDistribution_SelectedIndexChanged);
            // 
            // rbLab1
            // 
            this.rbLab1.AutoSize = true;
            this.rbLab1.Checked = true;
            this.rbLab1.Location = new System.Drawing.Point(1290, 288);
            this.rbLab1.Name = "rbLab1";
            this.rbLab1.Size = new System.Drawing.Size(107, 17);
            this.rbLab1.TabIndex = 14;
            this.rbLab1.TabStop = true;
            this.rbLab1.Text = "Лабораторная 1";
            this.rbLab1.UseVisualStyleBackColor = true;
            this.rbLab1.CheckedChanged += new System.EventHandler(this.rbLab1_CheckedChanged);
            // 
            // rbLab2
            // 
            this.rbLab2.AutoSize = true;
            this.rbLab2.Location = new System.Drawing.Point(1290, 311);
            this.rbLab2.Name = "rbLab2";
            this.rbLab2.Size = new System.Drawing.Size(107, 17);
            this.rbLab2.TabIndex = 15;
            this.rbLab2.Text = "Лабораторная 2";
            this.rbLab2.UseVisualStyleBackColor = true;
            this.rbLab2.CheckedChanged += new System.EventHandler(this.rbLab2_CheckedChanged);
            // 
            // editAlpha
            // 
            this.editAlpha.Location = new System.Drawing.Point(35, 29);
            this.editAlpha.Name = "editAlpha";
            this.editAlpha.Size = new System.Drawing.Size(100, 20);
            this.editAlpha.TabIndex = 16;
            this.editAlpha.Text = "0";
            // 
            // editBeta
            // 
            this.editBeta.Location = new System.Drawing.Point(35, 55);
            this.editBeta.Name = "editBeta";
            this.editBeta.Size = new System.Drawing.Size(100, 20);
            this.editBeta.TabIndex = 17;
            this.editBeta.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "B";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(35, 133);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(100, 23);
            this.btnProcess.TabIndex = 20;
            this.btnProcess.Text = "Вычислить";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // panelLab1
            // 
            this.panelLab1.Controls.Add(this.editA);
            this.panelLab1.Controls.Add(this.btnCalculate);
            this.panelLab1.Controls.Add(this.editM);
            this.panelLab1.Controls.Add(this.editR);
            this.panelLab1.Controls.Add(this.label1);
            this.panelLab1.Controls.Add(this.label2);
            this.panelLab1.Controls.Add(this.label3);
            this.panelLab1.Controls.Add(this.lblPeriod);
            this.panelLab1.Controls.Add(this.lblAperiodic);
            this.panelLab1.Controls.Add(this.lblK);
            this.panelLab1.Location = new System.Drawing.Point(1007, 12);
            this.panelLab1.Name = "panelLab1";
            this.panelLab1.Size = new System.Drawing.Size(260, 208);
            this.panelLab1.TabIndex = 21;
            // 
            // panelLab2
            // 
            this.panelLab2.Controls.Add(this.label7);
            this.panelLab2.Controls.Add(this.editη);
            this.panelLab2.Controls.Add(this.label6);
            this.panelLab2.Controls.Add(this.editλ);
            this.panelLab2.Controls.Add(this.cbDistribution);
            this.panelLab2.Controls.Add(this.editAlpha);
            this.panelLab2.Controls.Add(this.btnProcess);
            this.panelLab2.Controls.Add(this.editBeta);
            this.panelLab2.Controls.Add(this.label5);
            this.panelLab2.Controls.Add(this.label4);
            this.panelLab2.Enabled = false;
            this.panelLab2.Location = new System.Drawing.Point(1273, 12);
            this.panelLab2.Name = "panelLab2";
            this.panelLab2.Size = new System.Drawing.Size(200, 161);
            this.panelLab2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "η";
            // 
            // editη
            // 
            this.editη.Enabled = false;
            this.editη.Location = new System.Drawing.Point(35, 107);
            this.editη.Name = "editη";
            this.editη.Size = new System.Drawing.Size(100, 20);
            this.editη.TabIndex = 23;
            this.editη.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "λ";
            // 
            // editλ
            // 
            this.editλ.Enabled = false;
            this.editλ.Location = new System.Drawing.Point(35, 81);
            this.editλ.Name = "editλ";
            this.editλ.Size = new System.Drawing.Size(100, 20);
            this.editλ.TabIndex = 21;
            this.editλ.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 404);
            this.Controls.Add(this.panelLab2);
            this.Controls.Add(this.panelLab1);
            this.Controls.Add(this.rbLab2);
            this.Controls.Add(this.rbLab1);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblDeviation);
            this.Controls.Add(this.lblDispersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Алгоритм Лемера";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLab1.ResumeLayout(false);
            this.panelLab1.PerformLayout();
            this.panelLab2.ResumeLayout(false);
            this.panelLab2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox editA;
        private System.Windows.Forms.TextBox editM;
        private System.Windows.Forms.TextBox editR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblDispersion;
        private System.Windows.Forms.Label lblDeviation;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblAperiodic;
        private System.Windows.Forms.ComboBox cbDistribution;
        private System.Windows.Forms.RadioButton rbLab1;
        private System.Windows.Forms.RadioButton rbLab2;
        private System.Windows.Forms.TextBox editAlpha;
        private System.Windows.Forms.TextBox editBeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel panelLab1;
        private System.Windows.Forms.Panel panelLab2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox editλ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editη;
    }
}

