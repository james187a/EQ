namespace EverQuest
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.prgHP = new System.Windows.Forms.ProgressBar();
            this.prgXP = new System.Windows.Forms.ProgressBar();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblXP = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.btnFightWolf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(12, 35);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 2;
            this.lblRace.Text = "Race";
            // 
            // cmbRace
            // 
            this.cmbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Location = new System.Drawing.Point(56, 32);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(121, 21);
            this.cmbRace.TabIndex = 3;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(56, 59);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 4;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(12, 62);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Class";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(56, 87);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // prgHP
            // 
            this.prgHP.Location = new System.Drawing.Point(56, 132);
            this.prgHP.Name = "prgHP";
            this.prgHP.Size = new System.Drawing.Size(121, 23);
            this.prgHP.TabIndex = 7;
            // 
            // prgXP
            // 
            this.prgXP.Location = new System.Drawing.Point(56, 161);
            this.prgXP.Name = "prgXP";
            this.prgXP.Size = new System.Drawing.Size(121, 23);
            this.prgXP.TabIndex = 8;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(12, 132);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(22, 13);
            this.lblHP.TabIndex = 9;
            this.lblHP.Text = "HP";
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.Location = new System.Drawing.Point(13, 161);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(21, 13);
            this.lblXP.TabIndex = 10;
            this.lblXP.Text = "XP";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(12, 195);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 11;
            this.lblLevel.Text = "Level";
            // 
            // txtLevel
            // 
            this.txtLevel.Enabled = false;
            this.txtLevel.Location = new System.Drawing.Point(56, 191);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(121, 20);
            this.txtLevel.TabIndex = 12;
            // 
            // btnFightWolf
            // 
            this.btnFightWolf.Location = new System.Drawing.Point(222, 12);
            this.btnFightWolf.Name = "btnFightWolf";
            this.btnFightWolf.Size = new System.Drawing.Size(75, 23);
            this.btnFightWolf.TabIndex = 13;
            this.btnFightWolf.Text = "Fight Wolf";
            this.btnFightWolf.UseVisualStyleBackColor = true;
            this.btnFightWolf.Click += new System.EventHandler(this.btnFightWolf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 390);
            this.Controls.Add(this.btnFightWolf);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblXP);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.prgXP);
            this.Controls.Add(this.prgHP);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ProgressBar prgHP;
        private System.Windows.Forms.ProgressBar prgXP;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblXP;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Button btnFightWolf;
    }
}

