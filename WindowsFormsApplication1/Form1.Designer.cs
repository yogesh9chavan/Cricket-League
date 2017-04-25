namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.matches = new System.Windows.Forms.TextBox();
            this.team = new System.Windows.Forms.TextBox();
            this.speciality = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.nationality = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "player id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "no of matches";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "speciality";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Age";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(311, 57);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(221, 20);
            this.id.TabIndex = 7;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(311, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(221, 20);
            this.name.TabIndex = 8;
            // 
            // matches
            // 
            this.matches.Location = new System.Drawing.Point(311, 152);
            this.matches.Name = "matches";
            this.matches.Size = new System.Drawing.Size(221, 20);
            this.matches.TabIndex = 9;
            // 
            // team
            // 
            this.team.Location = new System.Drawing.Point(311, 199);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(221, 20);
            this.team.TabIndex = 10;
            // 
            // speciality
            // 
            this.speciality.Location = new System.Drawing.Point(311, 255);
            this.speciality.Name = "speciality";
            this.speciality.Size = new System.Drawing.Size(221, 20);
            this.speciality.TabIndex = 11;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(311, 305);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(221, 20);
            this.age.TabIndex = 12;
            // 
            // nationality
            // 
            this.nationality.Location = new System.Drawing.Point(311, 355);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(221, 20);
            this.nationality.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nationality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "mom#";
            // 
            // mom
            // 
            this.mom.Location = new System.Drawing.Point(311, 410);
            this.mom.Name = "mom";
            this.mom.Size = new System.Drawing.Size(221, 20);
            this.mom.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 511);
            this.Controls.Add(this.mom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.age);
            this.Controls.Add(this.speciality);
            this.Controls.Add(this.team);
            this.Controls.Add(this.matches);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox matches;
        private System.Windows.Forms.TextBox team;
        private System.Windows.Forms.TextBox speciality;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox nationality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mom;
    }
}

