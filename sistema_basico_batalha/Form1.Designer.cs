namespace sistema_basico_batalha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVidaP1 = new System.Windows.Forms.Label();
            this.btnAtacarP1 = new System.Windows.Forms.Button();
            this.lblVidaP2 = new System.Windows.Forms.Label();
            this.btnAtacarP2 = new System.Windows.Forms.Button();
            this.lblPoderEspada = new System.Windows.Forms.Label();
            this.btnVisitarFerreiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVidaP1
            // 
            this.lblVidaP1.AutoSize = true;
            this.lblVidaP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaP1.Location = new System.Drawing.Point(55, 42);
            this.lblVidaP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVidaP1.Name = "lblVidaP1";
            this.lblVidaP1.Size = new System.Drawing.Size(147, 29);
            this.lblVidaP1.TabIndex = 1;
            this.lblVidaP1.Text = "Vida P1: 100";
            // 
            // btnAtacarP1
            // 
            this.btnAtacarP1.BackColor = System.Drawing.Color.IndianRed;
            this.btnAtacarP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtacarP1.Location = new System.Drawing.Point(325, 42);
            this.btnAtacarP1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtacarP1.Name = "btnAtacarP1";
            this.btnAtacarP1.Size = new System.Drawing.Size(219, 48);
            this.btnAtacarP1.TabIndex = 3;
            this.btnAtacarP1.Text = "Atacar P1 (Dano 10)";
            this.btnAtacarP1.UseVisualStyleBackColor = false;
            this.btnAtacarP1.Click += new System.EventHandler(this.btnAtacarP1_Click);
            // 
            // lblVidaP2
            // 
            this.lblVidaP2.AutoSize = true;
            this.lblVidaP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaP2.Location = new System.Drawing.Point(55, 146);
            this.lblVidaP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVidaP2.Name = "lblVidaP2";
            this.lblVidaP2.Size = new System.Drawing.Size(147, 29);
            this.lblVidaP2.TabIndex = 4;
            this.lblVidaP2.Text = "Vida P2: 100";
            // 
            // btnAtacarP2
            // 
            this.btnAtacarP2.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAtacarP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtacarP2.Location = new System.Drawing.Point(325, 137);
            this.btnAtacarP2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtacarP2.Name = "btnAtacarP2";
            this.btnAtacarP2.Size = new System.Drawing.Size(219, 49);
            this.btnAtacarP2.TabIndex = 5;
            this.btnAtacarP2.Text = "Atacar P2 (Dano 10)";
            this.btnAtacarP2.UseVisualStyleBackColor = false;
            this.btnAtacarP2.Click += new System.EventHandler(this.btnAtacarP2_Click);
            // 
            // lblPoderEspada
            // 
            this.lblPoderEspada.AutoSize = true;
            this.lblPoderEspada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoderEspada.Location = new System.Drawing.Point(13, 295);
            this.lblPoderEspada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoderEspada.Name = "lblPoderEspada";
            this.lblPoderEspada.Size = new System.Drawing.Size(282, 29);
            this.lblPoderEspada.TabIndex = 6;
            this.lblPoderEspada.Text = "Poder da sua Espada: 20";
            // 
            // btnVisitarFerreiro
            // 
            this.btnVisitarFerreiro.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVisitarFerreiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitarFerreiro.Location = new System.Drawing.Point(325, 286);
            this.btnVisitarFerreiro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisitarFerreiro.Name = "btnVisitarFerreiro";
            this.btnVisitarFerreiro.Size = new System.Drawing.Size(219, 49);
            this.btnVisitarFerreiro.TabIndex = 7;
            this.btnVisitarFerreiro.Text = "Visitar Ferreiro";
            this.btnVisitarFerreiro.UseVisualStyleBackColor = false;
            this.btnVisitarFerreiro.Click += new System.EventHandler(this.btnVisitarFerreiro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 591);
            this.Controls.Add(this.btnVisitarFerreiro);
            this.Controls.Add(this.lblPoderEspada);
            this.Controls.Add(this.btnAtacarP2);
            this.Controls.Add(this.lblVidaP2);
            this.Controls.Add(this.btnAtacarP1);
            this.Controls.Add(this.lblVidaP1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVidaP1;
        private System.Windows.Forms.Button btnAtacarP1;
        private System.Windows.Forms.Label lblVidaP2;
        private System.Windows.Forms.Button btnAtacarP2;
        private System.Windows.Forms.Label lblPoderEspada;
        private System.Windows.Forms.Button btnVisitarFerreiro;
    }
}

