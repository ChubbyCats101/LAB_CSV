namespace lab06_maybe_
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
            Save_button = new Button();
            Save_To_File_button = new Button();
            Rend_From_File_button = new Button();
            Name_textBox = new TextBox();
            Birthyear_textBox = new TextBox();
            ID_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Save_button
            // 
            Save_button.Location = new Point(136, 336);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(94, 29);
            Save_button.TabIndex = 0;
            Save_button.Text = "SAVE!!!";
            Save_button.UseVisualStyleBackColor = true;
            Save_button.Click += Save_button_Click;
            // 
            // Save_To_File_button
            // 
            Save_To_File_button.Location = new Point(321, 336);
            Save_To_File_button.Name = "Save_To_File_button";
            Save_To_File_button.Size = new Size(94, 29);
            Save_To_File_button.TabIndex = 1;
            Save_To_File_button.Text = "SavetoFile";
            Save_To_File_button.UseVisualStyleBackColor = true;
            // 
            // Rend_From_File_button
            // 
            Rend_From_File_button.Location = new Point(507, 336);
            Rend_From_File_button.Name = "Rend_From_File_button";
            Rend_From_File_button.Size = new Size(116, 29);
            Rend_From_File_button.TabIndex = 2;
            Rend_From_File_button.Text = "RendformFile";
            Rend_From_File_button.UseVisualStyleBackColor = true;
            Rend_From_File_button.Click += Rend_From_File_button_Click;
            // 
            // Name_textBox
            // 
            Name_textBox.Font = new Font("Segoe UI", 18F);
            Name_textBox.Location = new Point(292, 131);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(280, 47);
            Name_textBox.TabIndex = 3;
            // 
            // Birthyear_textBox
            // 
            Birthyear_textBox.Font = new Font("Segoe UI", 18F);
            Birthyear_textBox.Location = new Point(292, 240);
            Birthyear_textBox.Name = "Birthyear_textBox";
            Birthyear_textBox.Size = new Size(280, 47);
            Birthyear_textBox.TabIndex = 4;
            // 
            // ID_textBox
            // 
            ID_textBox.Font = new Font("Segoe UI", 18F);
            ID_textBox.Location = new Point(292, 187);
            ID_textBox.Name = "ID_textBox";
            ID_textBox.Size = new Size(280, 47);
            ID_textBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(155, 131);
            label1.Name = "label1";
            label1.Size = new Size(91, 38);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(168, 184);
            label2.Name = "label2";
            label2.Size = new Size(44, 38);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(136, 240);
            label3.Name = "label3";
            label3.Size = new Size(128, 38);
            label3.TabIndex = 8;
            label3.Text = "Birthyear";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 576);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ID_textBox);
            Controls.Add(Birthyear_textBox);
            Controls.Add(Name_textBox);
            Controls.Add(Rend_From_File_button);
            Controls.Add(Save_To_File_button);
            Controls.Add(Save_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Save_button;
        private Button Save_To_File_button;
        private Button Rend_From_File_button;
        private TextBox Name_textBox;
        private TextBox Birthyear_textBox;
        private TextBox ID_textBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
