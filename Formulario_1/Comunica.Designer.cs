
namespace Formulario_1
{
    partial class Comunica
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
            this.btnTCP = new System.Windows.Forms.Button();
            this.btnUDP = new System.Windows.Forms.Button();
            this.gbComunica = new System.Windows.Forms.GroupBox();
            this.rbServer = new System.Windows.Forms.RadioButton();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.gbComunica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTCP
            // 
            this.btnTCP.Location = new System.Drawing.Point(68, 189);
            this.btnTCP.Name = "btnTCP";
            this.btnTCP.Size = new System.Drawing.Size(190, 60);
            this.btnTCP.TabIndex = 0;
            this.btnTCP.Text = "TCP";
            this.btnTCP.UseVisualStyleBackColor = true;
            this.btnTCP.Click += new System.EventHandler(this.btnTCP_Click);
            // 
            // btnUDP
            // 
            this.btnUDP.Location = new System.Drawing.Point(68, 73);
            this.btnUDP.Name = "btnUDP";
            this.btnUDP.Size = new System.Drawing.Size(190, 57);
            this.btnUDP.TabIndex = 1;
            this.btnUDP.Text = "UDP";
            this.btnUDP.UseVisualStyleBackColor = true;
            this.btnUDP.Click += new System.EventHandler(this.btnUDP_Click);
            // 
            // gbComunica
            // 
            this.gbComunica.Controls.Add(this.rbClient);
            this.gbComunica.Controls.Add(this.rbServer);
            this.gbComunica.Location = new System.Drawing.Point(331, 74);
            this.gbComunica.Name = "gbComunica";
            this.gbComunica.Size = new System.Drawing.Size(271, 215);
            this.gbComunica.TabIndex = 2;
            this.gbComunica.TabStop = false;
            this.gbComunica.Text = "Tipos de comunicação UDP";
            this.gbComunica.Visible = false;
            // 
            // rbServer
            // 
            this.rbServer.AutoSize = true;
            this.rbServer.Location = new System.Drawing.Point(44, 56);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(82, 21);
            this.rbServer.TabIndex = 0;
            this.rbServer.TabStop = true;
            this.rbServer.Text = "Servidor";
            this.rbServer.UseVisualStyleBackColor = true;
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(44, 115);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(72, 21);
            this.rbClient.TabIndex = 1;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Cliente";
            this.rbClient.UseVisualStyleBackColor = true;
            // 
            // Comunica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 351);
            this.Controls.Add(this.gbComunica);
            this.Controls.Add(this.btnUDP);
            this.Controls.Add(this.btnTCP);
            this.Name = "Comunica";
            this.gbComunica.ResumeLayout(false);
            this.gbComunica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTCP;
        private System.Windows.Forms.Button btnUDP;
        private System.Windows.Forms.GroupBox gbComunica;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.RadioButton rbServer;
    }
}

