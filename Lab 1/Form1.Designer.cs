namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.x_label = new System.Windows.Forms.Label();
            this.x_textBox = new System.Windows.Forms.TextBox();
            this.y_label = new System.Windows.Forms.Label();
            this.y_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result_lable = new System.Windows.Forms.Label();
            this.calculate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_label.Location = new System.Drawing.Point(58, 66);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(111, 29);
            this.x_label.TabIndex = 0;
            this.x_label.Text = "X values:";
            // 
            // x_textBox
            // 
            this.x_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_textBox.Location = new System.Drawing.Point(63, 98);
            this.x_textBox.Name = "x_textBox";
            this.x_textBox.Size = new System.Drawing.Size(406, 26);
            this.x_textBox.TabIndex = 1;
            this.x_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.X_textBox_Validating);
            this.x_textBox.Validated += new System.EventHandler(this.X_textBox_Validated);
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y_label.Location = new System.Drawing.Point(58, 166);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(110, 29);
            this.y_label.TabIndex = 2;
            this.y_label.Text = "Y values:";
            // 
            // y_textBox
            // 
            this.y_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y_textBox.Location = new System.Drawing.Point(63, 198);
            this.y_textBox.Name = "y_textBox";
            this.y_textBox.Size = new System.Drawing.Size(406, 26);
            this.y_textBox.TabIndex = 3;
            this.y_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.Y_textBox_Validating);
            this.y_textBox.Validated += new System.EventHandler(this.Y_textBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result Point Vector: ";
            // 
            // result_lable
            // 
            this.result_lable.AllowDrop = true;
            this.result_lable.AutoSize = true;
            this.result_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_lable.Location = new System.Drawing.Point(244, 331);
            this.result_lable.Name = "result_lable";
            this.result_lable.Size = new System.Drawing.Size(91, 20);
            this.result_lable.TabIndex = 5;
            this.result_lable.Text = "result lable";
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate_button.Location = new System.Drawing.Point(521, 249);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(140, 46);
            this.calculate_button.TabIndex = 6;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(734, 516);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.result_lable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y_textBox);
            this.Controls.Add(this.y_label);
            this.Controls.Add(this.x_textBox);
            this.Controls.Add(this.x_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.TextBox x_textBox;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.TextBox y_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result_lable;
        private System.Windows.Forms.Button calculate_button;
    }
}

