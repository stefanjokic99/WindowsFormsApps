namespace Vjezbanje_23_03
{
    partial class FormRacun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRacun));
            this.pcbSlikaKonobara = new System.Windows.Forms.PictureBox();
            this.lblImeKonobara = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listPonude = new System.Windows.Forms.ListBox();
            this.listRacun = new System.Windows.Forms.ListBox();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlikaKonobara)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbSlikaKonobara
            // 
            this.pcbSlikaKonobara.Location = new System.Drawing.Point(12, 12);
            this.pcbSlikaKonobara.Name = "pcbSlikaKonobara";
            this.pcbSlikaKonobara.Size = new System.Drawing.Size(100, 100);
            this.pcbSlikaKonobara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSlikaKonobara.TabIndex = 0;
            this.pcbSlikaKonobara.TabStop = false;
            // 
            // lblImeKonobara
            // 
            this.lblImeKonobara.AutoSize = true;
            this.lblImeKonobara.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeKonobara.Location = new System.Drawing.Point(118, 85);
            this.lblImeKonobara.Name = "lblImeKonobara";
            this.lblImeKonobara.Size = new System.Drawing.Size(0, 27);
            this.lblImeKonobara.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.btnObrisi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDodaj, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIzdajRacun, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 118);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 335);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listPonude);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(163, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ponuda";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listRacun);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(165, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Račun";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDodaj.Location = new System.Drawing.Point(172, 125);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(31, 22);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = " >>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listPonude
            // 
            this.listPonude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPonude.FormattingEnabled = true;
            this.listPonude.Location = new System.Drawing.Point(3, 16);
            this.listPonude.Name = "listPonude";
            this.listPonude.Size = new System.Drawing.Size(157, 275);
            this.listPonude.TabIndex = 0;
            this.listPonude.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPonude_MouseDoubleClick);
            // 
            // listRacun
            // 
            this.listRacun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRacun.FormattingEnabled = true;
            this.listRacun.Location = new System.Drawing.Point(3, 16);
            this.listRacun.Name = "listRacun";
            this.listRacun.Size = new System.Drawing.Size(159, 275);
            this.listRacun.TabIndex = 0;
            this.listRacun.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listRacun_MouseDoubleClick);
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnIzdajRacun, 3);
            this.btnIzdajRacun.Location = new System.Drawing.Point(151, 306);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(75, 23);
            this.btnIzdajRacun.TabIndex = 3;
            this.btnIzdajRacun.Text = "Izdaj Račun";
            this.btnIzdajRacun.UseVisualStyleBackColor = true;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObrisi.Location = new System.Drawing.Point(172, 153);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(31, 22);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "<<";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FormRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 456);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblImeKonobara);
            this.Controls.Add(this.pcbSlikaKonobara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "FormRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlikaKonobara)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSlikaKonobara;
        private System.Windows.Forms.Label lblImeKonobara;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ListBox listPonude;
        private System.Windows.Forms.ListBox listRacun;
        private System.Windows.Forms.Button btnIzdajRacun;
    }
}