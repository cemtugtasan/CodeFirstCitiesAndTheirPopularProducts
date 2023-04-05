namespace CitiesCodeFirst
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
            this.tbSehir = new System.Windows.Forms.TextBox();
            this.dgwSehirler = new System.Windows.Forms.DataGridView();
            this.tbMeshur = new System.Windows.Forms.TextBox();
            this.btnSehirAdıEkle = new System.Windows.Forms.Button();
            this.btnMeshurOzellikEkle = new System.Windows.Forms.Button();
            this.dgwMeshur = new System.Windows.Forms.DataGridView();
            this.btnSehirSil = new System.Windows.Forms.Button();
            this.btnOzellikSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSehirler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMeshur)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSehir
            // 
            this.tbSehir.Location = new System.Drawing.Point(12, 66);
            this.tbSehir.Name = "tbSehir";
            this.tbSehir.Size = new System.Drawing.Size(278, 23);
            this.tbSehir.TabIndex = 0;
            // 
            // dgwSehirler
            // 
            this.dgwSehirler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSehirler.Location = new System.Drawing.Point(12, 95);
            this.dgwSehirler.Name = "dgwSehirler";
            this.dgwSehirler.RowTemplate.Height = 25;
            this.dgwSehirler.Size = new System.Drawing.Size(378, 213);
            this.dgwSehirler.TabIndex = 1;
            this.dgwSehirler.SelectionChanged += new System.EventHandler(this.dgwSehirler_SelectionChanged);
            // 
            // tbMeshur
            // 
            this.tbMeshur.Location = new System.Drawing.Point(421, 66);
            this.tbMeshur.Name = "tbMeshur";
            this.tbMeshur.Size = new System.Drawing.Size(278, 23);
            this.tbMeshur.TabIndex = 0;
            // 
            // btnSehirAdıEkle
            // 
            this.btnSehirAdıEkle.Location = new System.Drawing.Point(308, 58);
            this.btnSehirAdıEkle.Name = "btnSehirAdıEkle";
            this.btnSehirAdıEkle.Size = new System.Drawing.Size(82, 36);
            this.btnSehirAdıEkle.TabIndex = 2;
            this.btnSehirAdıEkle.Text = "Ekle";
            this.btnSehirAdıEkle.UseVisualStyleBackColor = true;
            this.btnSehirAdıEkle.Click += new System.EventHandler(this.btnSehirAdıEkle_Click);
            // 
            // btnMeshurOzellikEkle
            // 
            this.btnMeshurOzellikEkle.Location = new System.Drawing.Point(717, 58);
            this.btnMeshurOzellikEkle.Name = "btnMeshurOzellikEkle";
            this.btnMeshurOzellikEkle.Size = new System.Drawing.Size(82, 36);
            this.btnMeshurOzellikEkle.TabIndex = 2;
            this.btnMeshurOzellikEkle.Text = "Ekle";
            this.btnMeshurOzellikEkle.UseVisualStyleBackColor = true;
            this.btnMeshurOzellikEkle.Click += new System.EventHandler(this.btnMeshurOzellikEkle_Click);
            // 
            // dgwMeshur
            // 
            this.dgwMeshur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMeshur.Location = new System.Drawing.Point(421, 95);
            this.dgwMeshur.Name = "dgwMeshur";
            this.dgwMeshur.RowTemplate.Height = 25;
            this.dgwMeshur.Size = new System.Drawing.Size(378, 213);
            this.dgwMeshur.TabIndex = 1;
            // 
            // btnSehirSil
            // 
            this.btnSehirSil.Location = new System.Drawing.Point(308, 327);
            this.btnSehirSil.Name = "btnSehirSil";
            this.btnSehirSil.Size = new System.Drawing.Size(82, 36);
            this.btnSehirSil.TabIndex = 2;
            this.btnSehirSil.Text = "Sil";
            this.btnSehirSil.UseVisualStyleBackColor = true;
            this.btnSehirSil.Click += new System.EventHandler(this.btnSehirSil_Click);
            // 
            // btnOzellikSil
            // 
            this.btnOzellikSil.Location = new System.Drawing.Point(717, 327);
            this.btnOzellikSil.Name = "btnOzellikSil";
            this.btnOzellikSil.Size = new System.Drawing.Size(82, 36);
            this.btnOzellikSil.TabIndex = 2;
            this.btnOzellikSil.Text = "Sil";
            this.btnOzellikSil.UseVisualStyleBackColor = true;
            this.btnOzellikSil.Click += new System.EventHandler(this.btnOzellikSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sehir Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meshur Özelliği";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMeshurOzellikEkle);
            this.Controls.Add(this.btnOzellikSil);
            this.Controls.Add(this.btnSehirSil);
            this.Controls.Add(this.btnSehirAdıEkle);
            this.Controls.Add(this.dgwMeshur);
            this.Controls.Add(this.dgwSehirler);
            this.Controls.Add(this.tbMeshur);
            this.Controls.Add(this.tbSehir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSehirler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMeshur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbSehir;
        private DataGridView dgwSehirler;
        private TextBox tbMeshur;
        private Button btnSehirAdıEkle;
        private Button btnMeshurOzellikEkle;
        private DataGridView dgwMeshur;
        private Button btnSehirSil;
        private Button btnOzellikSil;
        private Label label1;
        private Label label2;
    }
}