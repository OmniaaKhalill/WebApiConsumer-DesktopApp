namespace AppConsumer
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
            DGV_Department = new DataGridView();
            Depts_Data = new Button();
            std_address = new TextBox();
            f_name = new TextBox();
            add_std = new Button();
            std_age = new TextBox();
            L_name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Department).BeginInit();
            SuspendLayout();
            // 
            // DGV_Department
            // 
            DGV_Department.BackgroundColor = SystemColors.Window;
            DGV_Department.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Department.Location = new Point(270, 34);
            DGV_Department.Name = "DGV_Department";
            DGV_Department.RowHeadersWidth = 62;
            DGV_Department.Size = new Size(1117, 296);
            DGV_Department.TabIndex = 0;
            // 
            // Depts_Data
            // 
            Depts_Data.BackColor = SystemColors.MenuHighlight;
            Depts_Data.ForeColor = SystemColors.ButtonHighlight;
            Depts_Data.Location = new Point(676, 370);
            Depts_Data.Name = "Depts_Data";
            Depts_Data.Size = new Size(287, 50);
            Depts_Data.TabIndex = 1;
            Depts_Data.Text = "Departments Data";
            Depts_Data.UseVisualStyleBackColor = false;
            Depts_Data.Click += Depts_Data_Click;
            // 
            // std_address
            // 
            std_address.Location = new Point(463, 700);
            std_address.Name = "std_address";
            std_address.PlaceholderText = "Address";
            std_address.Size = new Size(685, 31);
            std_address.TabIndex = 3;
            // 
            // f_name
            // 
            f_name.Location = new Point(463, 511);
            f_name.Name = "f_name";
            f_name.PlaceholderText = "First Name";
            f_name.Size = new Size(685, 31);
            f_name.TabIndex = 8;
            // 
            // add_std
            // 
            add_std.BackColor = SystemColors.MenuHighlight;
            add_std.ForeColor = SystemColors.ButtonHighlight;
            add_std.Location = new Point(749, 764);
            add_std.Name = "add_std";
            add_std.Size = new Size(174, 43);
            add_std.TabIndex = 6;
            add_std.Text = "Add Student";
            add_std.UseVisualStyleBackColor = false;
            add_std.Click += add_std_Click;
            // 
            // std_age
            // 
            std_age.Location = new Point(463, 642);
            std_age.Name = "std_age";
            std_age.PlaceholderText = "Age";
            std_age.Size = new Size(685, 31);
            std_age.TabIndex = 7;
            // 
            // L_name
            // 
            L_name.Location = new Point(463, 587);
            L_name.Name = "L_name";
            L_name.PlaceholderText = "Last name";
            L_name.Size = new Size(685, 31);
            L_name.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1672, 905);
            Controls.Add(L_name);
            Controls.Add(std_age);
            Controls.Add(add_std);
            Controls.Add(f_name);
            Controls.Add(std_address);
            Controls.Add(Depts_Data);
            Controls.Add(DGV_Department);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV_Department).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_Department;
        private Button Depts_Data;
        private TextBox L_name;
        private TextBox std_address;
        private TextBox textBox3;
        private TextBox f_name;
        private Button add_std;
        private TextBox std_age;
    }
}
