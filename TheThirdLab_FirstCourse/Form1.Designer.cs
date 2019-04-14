namespace TheThirdLab_FirstCourse
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
            this.calculateDrobResault = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textNumenator = new System.Windows.Forms.TextBox();
            this.textDenominator = new System.Windows.Forms.TextBox();
            this.NumeroDrob = new System.Windows.Forms.Label();
            this.DenomoDrob = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textDenomiSecondDrob = new System.Windows.Forms.TextBox();
            this.textNumerSecDrob = new System.Windows.Forms.TextBox();
            this.rotateDrob = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textThirdDenomin = new System.Windows.Forms.TextBox();
            this.textThirdNumer = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateDrobResault
            // 
            this.calculateDrobResault.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateDrobResault.Location = new System.Drawing.Point(163, 342);
            this.calculateDrobResault.Name = "calculateDrobResault";
            this.calculateDrobResault.Size = new System.Drawing.Size(116, 65);
            this.calculateDrobResault.TabIndex = 0;
            this.calculateDrobResault.Text = "Calculate";
            this.calculateDrobResault.UseVisualStyleBackColor = true;
            this.calculateDrobResault.Click += new System.EventHandler(this.calculateDrobResault_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(426, 263);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textNumenator
            // 
            this.textNumenator.Location = new System.Drawing.Point(467, 55);
            this.textNumenator.Name = "textNumenator";
            this.textNumenator.Size = new System.Drawing.Size(100, 22);
            this.textNumenator.TabIndex = 2;
            // 
            // textDenominator
            // 
            this.textDenominator.Location = new System.Drawing.Point(467, 115);
            this.textDenominator.Name = "textDenominator";
            this.textDenominator.Size = new System.Drawing.Size(100, 22);
            this.textDenominator.TabIndex = 3;
            // 
            // NumeroDrob
            // 
            this.NumeroDrob.AutoSize = true;
            this.NumeroDrob.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumeroDrob.Location = new System.Drawing.Point(588, 56);
            this.NumeroDrob.Name = "NumeroDrob";
            this.NumeroDrob.Size = new System.Drawing.Size(175, 19);
            this.NumeroDrob.TabIndex = 4;
            this.NumeroDrob.Text = "Numerator First Drob";
            // 
            // DenomoDrob
            // 
            this.DenomoDrob.AutoSize = true;
            this.DenomoDrob.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DenomoDrob.Location = new System.Drawing.Point(588, 116);
            this.DenomoDrob.Name = "DenomoDrob";
            this.DenomoDrob.Size = new System.Drawing.Size(191, 19);
            this.DenomoDrob.TabIndex = 5;
            this.DenomoDrob.Text = "Denominator First Drob";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(583, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Denominator Second Drob";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(588, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numerator Second Drob";
            // 
            // textDenomiSecondDrob
            // 
            this.textDenomiSecondDrob.Location = new System.Drawing.Point(467, 253);
            this.textDenomiSecondDrob.Name = "textDenomiSecondDrob";
            this.textDenomiSecondDrob.Size = new System.Drawing.Size(100, 22);
            this.textDenomiSecondDrob.TabIndex = 7;
            // 
            // textNumerSecDrob
            // 
            this.textNumerSecDrob.Location = new System.Drawing.Point(467, 195);
            this.textNumerSecDrob.Name = "textNumerSecDrob";
            this.textNumerSecDrob.Size = new System.Drawing.Size(100, 22);
            this.textNumerSecDrob.TabIndex = 6;
            // 
            // rotateDrob
            // 
            this.rotateDrob.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rotateDrob.Location = new System.Drawing.Point(23, 342);
            this.rotateDrob.Name = "rotateDrob";
            this.rotateDrob.Size = new System.Drawing.Size(116, 65);
            this.rotateDrob.TabIndex = 10;
            this.rotateDrob.Text = "RotateDrob";
            this.rotateDrob.UseVisualStyleBackColor = true;
            this.rotateDrob.Click += new System.EventHandler(this.rotateDrob_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(585, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Denominator Third Drob";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(590, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Numerator Third Drob";
            // 
            // textThirdDenomin
            // 
            this.textThirdDenomin.Location = new System.Drawing.Point(469, 380);
            this.textThirdDenomin.Name = "textThirdDenomin";
            this.textThirdDenomin.Size = new System.Drawing.Size(100, 22);
            this.textThirdDenomin.TabIndex = 12;
            // 
            // textThirdNumer
            // 
            this.textThirdNumer.Location = new System.Drawing.Point(469, 322);
            this.textThirdNumer.Name = "textThirdNumer";
            this.textThirdNumer.Size = new System.Drawing.Size(100, 22);
            this.textThirdNumer.TabIndex = 11;
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.Location = new System.Drawing.Point(300, 343);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(116, 65);
            this.PrintButton.TabIndex = 15;
            this.PrintButton.Text = "PrintDrob";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textThirdDenomin);
            this.Controls.Add(this.textThirdNumer);
            this.Controls.Add(this.rotateDrob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDenomiSecondDrob);
            this.Controls.Add(this.textNumerSecDrob);
            this.Controls.Add(this.DenomoDrob);
            this.Controls.Add(this.NumeroDrob);
            this.Controls.Add(this.textDenominator);
            this.Controls.Add(this.textNumenator);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.calculateDrobResault);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateDrobResault;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textNumenator;
        private System.Windows.Forms.TextBox textDenominator;
        private System.Windows.Forms.Label NumeroDrob;
        private System.Windows.Forms.Label DenomoDrob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDenomiSecondDrob;
        private System.Windows.Forms.TextBox textNumerSecDrob;
        private System.Windows.Forms.Button rotateDrob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textThirdDenomin;
        private System.Windows.Forms.TextBox textThirdNumer;
        private System.Windows.Forms.Button PrintButton;
    }
}

