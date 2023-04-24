namespace WindowsFormsApp2
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.program = new System.Windows.Forms.ComboBox();
            this.profession = new System.Windows.Forms.ComboBox();
            this.note = new System.Windows.Forms.RichTextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26697F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.73303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.code, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.firstname, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lastname, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.program, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.profession, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.note, 2, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оюутны код";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Хөтөлбөр";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Мэргэжил";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Овог";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Нэр";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Элссэн огноо";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Тайлбар";
            // 
            // code
            // 
            this.code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.code.Location = new System.Drawing.Point(204, 10);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(184, 20);
            this.code.TabIndex = 7;
            // 
            // firstname
            // 
            this.firstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstname.Location = new System.Drawing.Point(204, 130);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(184, 20);
            this.firstname.TabIndex = 8;
            // 
            // lastname
            // 
            this.lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastname.Location = new System.Drawing.Point(204, 170);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(184, 20);
            this.lastname.TabIndex = 9;
            // 
            // program
            // 
            this.program.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.program.FormattingEnabled = true;
            this.program.Location = new System.Drawing.Point(204, 49);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(158, 21);
            this.program.TabIndex = 10;
            // 
            // profession
            // 
            this.profession.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.profession.FormattingEnabled = true;
            this.profession.Location = new System.Drawing.Point(204, 89);
            this.profession.Name = "profession";
            this.profession.Size = new System.Drawing.Size(158, 21);
            this.profession.TabIndex = 11;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(204, 243);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(158, 75);
            this.note.TabIndex = 12;
            this.note.Text = "";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(315, 409);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 29);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Цуцлах";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(234, 409);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 29);
            this.save.TabIndex = 14;
            this.save.Text = "Хадгалах";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cancel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.ComboBox program;
        private System.Windows.Forms.ComboBox profession;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
    }
}