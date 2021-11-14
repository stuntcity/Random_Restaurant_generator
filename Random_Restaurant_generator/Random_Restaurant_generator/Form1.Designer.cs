
namespace Random_Restaurant_generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txtBox_Restaurant = new System.Windows.Forms.TextBox();
            this.txtBox_DayOfWeek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(445, 264);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(150, 46);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txtBox_Restaurant
            // 
            this.txtBox_Restaurant.Location = new System.Drawing.Point(405, 103);
            this.txtBox_Restaurant.Name = "txtBox_Restaurant";
            this.txtBox_Restaurant.Size = new System.Drawing.Size(236, 39);
            this.txtBox_Restaurant.TabIndex = 1;
            // 
            // txtBox_DayOfWeek
            // 
            this.txtBox_DayOfWeek.Location = new System.Drawing.Point(405, 185);
            this.txtBox_DayOfWeek.Name = "txtBox_DayOfWeek";
            this.txtBox_DayOfWeek.Size = new System.Drawing.Size(236, 39);
            this.txtBox_DayOfWeek.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Place";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Day";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_DayOfWeek);
            this.Controls.Add(this.txtBox_Restaurant);
            this.Controls.Add(this.btn_Generate);
            this.Name = "Form1";
            this.Text = "Day and Restaurant Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txtBox_Restaurant;
        private System.Windows.Forms.TextBox txtBox_DayOfWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

