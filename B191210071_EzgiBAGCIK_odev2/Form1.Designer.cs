namespace B191210071_EzgiBAGCIK_odev2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnArkadas = new System.Windows.Forms.Button();
            this.btnSon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblX.Location = new System.Drawing.Point(37, 51);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 17);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblY.Location = new System.Drawing.Point(37, 96);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(18, 17);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(63, 46);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(132, 22);
            this.txtX.TabIndex = 2;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            this.txtX.Validated += new System.EventHandler(this.txtX_Validated);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(63, 96);
            this.txtY.Margin = new System.Windows.Forms.Padding(4);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(132, 22);
            this.txtY.TabIndex = 3;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            this.txtY.Validated += new System.EventHandler(this.txtY_Validated);
            // 
            // btnArkadas
            // 
            this.btnArkadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArkadas.Location = new System.Drawing.Point(35, 181);
            this.btnArkadas.Margin = new System.Windows.Forms.Padding(4);
            this.btnArkadas.Name = "btnArkadas";
            this.btnArkadas.Size = new System.Drawing.Size(151, 42);
            this.btnArkadas.TabIndex = 4;
            this.btnArkadas.Text = "ARKADAŞ MI ?";
            this.btnArkadas.UseVisualStyleBackColor = true;
            this.btnArkadas.Click += new System.EventHandler(this.btnArkadas_Click);
            // 
            // btnSon
            // 
            this.btnSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSon.Location = new System.Drawing.Point(220, 181);
            this.btnSon.Margin = new System.Windows.Forms.Padding(4);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(151, 42);
            this.btnSon.TabIndex = 5;
            this.btnSon.Text = "SON";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 249);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.btnArkadas);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkadaş Sayılar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnArkadas;
        private System.Windows.Forms.Button btnSon;
        public System.Windows.Forms.TextBox txtX;
        public System.Windows.Forms.TextBox txtY;
    }
}

