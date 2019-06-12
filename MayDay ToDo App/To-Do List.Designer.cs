namespace MayDay_ToDo_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label10 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPCN = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lbGebeurtenissen = new System.Windows.Forms.ListBox();
            this.rbNietBegonnen = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGid = new System.Windows.Forms.Label();
            this.lblgLocatie = new System.Windows.Forms.Label();
            this.lblGEindDatum = new System.Windows.Forms.Label();
            this.lblgDatum = new System.Windows.Forms.Label();
            this.lblGgebeurtenis = new System.Windows.Forms.Label();
            this.rbInProgressie = new System.Windows.Forms.RadioButton();
            this.rbKlaar = new System.Windows.Forms.RadioButton();
            this.cbFilterNietKlaar = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtEindDatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(687, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Student Informatie:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(687, 203);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 49;
            this.lblID.Text = "ID";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(687, 125);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(45, 17);
            this.lblVoornaam.TabIndex = 50;
            this.lblVoornaam.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Gebeurtenis:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 22);
            this.textBox2.TabIndex = 43;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 42;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(555, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 58);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(555, 252);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 44);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(555, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 44);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2019, 6, 11, 0, 0, 0, 0);
            // 
            // lblPCN
            // 
            this.lblPCN.AutoSize = true;
            this.lblPCN.Location = new System.Drawing.Point(687, 177);
            this.lblPCN.Name = "lblPCN";
            this.lblPCN.Size = new System.Drawing.Size(36, 17);
            this.lblPCN.TabIndex = 54;
            this.lblPCN.Text = "PCN";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(687, 151);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(84, 17);
            this.lblAchternaam.TabIndex = 51;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Locatie:";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.Location = new System.Drawing.Point(785, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(26, 25);
            this.lblMinimize.TabIndex = 62;
            this.lblMinimize.Text = " -";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(811, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 25);
            this.lblClose.TabIndex = 61;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lbGebeurtenissen
            // 
            this.lbGebeurtenissen.FormattingEnabled = true;
            this.lbGebeurtenissen.ItemHeight = 16;
            this.lbGebeurtenissen.Location = new System.Drawing.Point(8, 56);
            this.lbGebeurtenissen.Name = "lbGebeurtenissen";
            this.lbGebeurtenissen.Size = new System.Drawing.Size(312, 340);
            this.lbGebeurtenissen.TabIndex = 63;
            this.lbGebeurtenissen.SelectedIndexChanged += new System.EventHandler(this.lbGebeurtenissen_SelectedIndexChanged);
            // 
            // rbNietBegonnen
            // 
            this.rbNietBegonnen.AutoSize = true;
            this.rbNietBegonnen.Location = new System.Drawing.Point(326, 286);
            this.rbNietBegonnen.Name = "rbNietBegonnen";
            this.rbNietBegonnen.Size = new System.Drawing.Size(122, 21);
            this.rbNietBegonnen.TabIndex = 64;
            this.rbNietBegonnen.TabStop = true;
            this.rbNietBegonnen.Text = "Niet begonnen";
            this.rbNietBegonnen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "ToDo Informatie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Status:";
            // 
            // lblGid
            // 
            this.lblGid.AutoSize = true;
            this.lblGid.Location = new System.Drawing.Point(323, 92);
            this.lblGid.Name = "lblGid";
            this.lblGid.Size = new System.Drawing.Size(21, 17);
            this.lblGid.TabIndex = 66;
            this.lblGid.Text = "ID";
            // 
            // lblgLocatie
            // 
            this.lblgLocatie.AutoSize = true;
            this.lblgLocatie.Location = new System.Drawing.Point(323, 204);
            this.lblgLocatie.Name = "lblgLocatie";
            this.lblgLocatie.Size = new System.Drawing.Size(54, 17);
            this.lblgLocatie.TabIndex = 70;
            this.lblgLocatie.Text = "Locatie";
            // 
            // lblGEindDatum
            // 
            this.lblGEindDatum.AutoSize = true;
            this.lblGEindDatum.Location = new System.Drawing.Point(323, 178);
            this.lblGEindDatum.Name = "lblGEindDatum";
            this.lblGEindDatum.Size = new System.Drawing.Size(77, 17);
            this.lblGEindDatum.TabIndex = 69;
            this.lblGEindDatum.Text = "EindDatum";
            // 
            // lblgDatum
            // 
            this.lblgDatum.AutoSize = true;
            this.lblgDatum.Location = new System.Drawing.Point(323, 151);
            this.lblgDatum.Name = "lblgDatum";
            this.lblgDatum.Size = new System.Drawing.Size(49, 17);
            this.lblgDatum.TabIndex = 68;
            this.lblgDatum.Text = "Datum";
            // 
            // lblGgebeurtenis
            // 
            this.lblGgebeurtenis.AutoSize = true;
            this.lblGgebeurtenis.Location = new System.Drawing.Point(323, 121);
            this.lblGgebeurtenis.Name = "lblGgebeurtenis";
            this.lblGgebeurtenis.Size = new System.Drawing.Size(78, 17);
            this.lblGgebeurtenis.TabIndex = 67;
            this.lblGgebeurtenis.Text = "Gebertenis";
            // 
            // rbInProgressie
            // 
            this.rbInProgressie.AutoSize = true;
            this.rbInProgressie.Location = new System.Drawing.Point(326, 313);
            this.rbInProgressie.Name = "rbInProgressie";
            this.rbInProgressie.Size = new System.Drawing.Size(112, 21);
            this.rbInProgressie.TabIndex = 72;
            this.rbInProgressie.TabStop = true;
            this.rbInProgressie.Text = "In Progressie";
            this.rbInProgressie.UseVisualStyleBackColor = true;
            // 
            // rbKlaar
            // 
            this.rbKlaar.AutoSize = true;
            this.rbKlaar.Location = new System.Drawing.Point(326, 340);
            this.rbKlaar.Name = "rbKlaar";
            this.rbKlaar.Size = new System.Drawing.Size(62, 21);
            this.rbKlaar.TabIndex = 73;
            this.rbKlaar.TabStop = true;
            this.rbKlaar.Text = "Klaar";
            this.rbKlaar.UseVisualStyleBackColor = true;
            // 
            // cbFilterNietKlaar
            // 
            this.cbFilterNietKlaar.AutoSize = true;
            this.cbFilterNietKlaar.Location = new System.Drawing.Point(12, 407);
            this.cbFilterNietKlaar.Name = "cbFilterNietKlaar";
            this.cbFilterNietKlaar.Size = new System.Drawing.Size(143, 21);
            this.cbFilterNietKlaar.TabIndex = 74;
            this.cbFilterNietKlaar.Text = "Filter op niet klaar";
            this.cbFilterNietKlaar.UseVisualStyleBackColor = true;
            this.cbFilterNietKlaar.CheckedChanged += new System.EventHandler(this.cbFilterNietKlaar_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "EindDatum:";
            // 
            // dtEindDatum
            // 
            this.dtEindDatum.CustomFormat = "dd-MM-yyy";
            this.dtEindDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEindDatum.Location = new System.Drawing.Point(561, 28);
            this.dtEindDatum.Name = "dtEindDatum";
            this.dtEindDatum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtEindDatum.Size = new System.Drawing.Size(162, 22);
            this.dtEindDatum.TabIndex = 8;
            this.dtEindDatum.Value = new System.DateTime(2019, 6, 11, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 460);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtEindDatum);
            this.Controls.Add(this.cbFilterNietKlaar);
            this.Controls.Add(this.rbKlaar);
            this.Controls.Add(this.rbInProgressie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGid);
            this.Controls.Add(this.lblgLocatie);
            this.Controls.Add(this.lblGEindDatum);
            this.Controls.Add(this.lblgDatum);
            this.Controls.Add(this.lblGgebeurtenis);
            this.Controls.Add(this.rbNietBegonnen);
            this.Controls.Add(this.lbGebeurtenissen);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblPCN);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MayDay ToDo List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPCN;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblMinimize;
        public System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.ListBox lbGebeurtenissen;
        private System.Windows.Forms.RadioButton rbNietBegonnen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGid;
        private System.Windows.Forms.Label lblgLocatie;
        private System.Windows.Forms.Label lblGEindDatum;
        private System.Windows.Forms.Label lblgDatum;
        private System.Windows.Forms.Label lblGgebeurtenis;
        private System.Windows.Forms.RadioButton rbInProgressie;
        private System.Windows.Forms.RadioButton rbKlaar;
        private System.Windows.Forms.CheckBox cbFilterNietKlaar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtEindDatum;
    }
}

