
namespace AdminitracionDeTorneosP.View
{
    partial class Reporte_Jugadores
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
            this.button5 = new System.Windows.Forms.Button();
            this.Listado_Jugadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Listado_Jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(733, 11);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 31);
            this.button5.TabIndex = 42;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Listado_Jugadores
            // 
            this.Listado_Jugadores.AllowUserToAddRows = false;
            this.Listado_Jugadores.AllowUserToDeleteRows = false;
            this.Listado_Jugadores.BackgroundColor = System.Drawing.Color.Azure;
            this.Listado_Jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listado_Jugadores.GridColor = System.Drawing.Color.Azure;
            this.Listado_Jugadores.Location = new System.Drawing.Point(68, 142);
            this.Listado_Jugadores.Margin = new System.Windows.Forms.Padding(2);
            this.Listado_Jugadores.Name = "Listado_Jugadores";
            this.Listado_Jugadores.ReadOnly = true;
            this.Listado_Jugadores.RowHeadersVisible = false;
            this.Listado_Jugadores.RowHeadersWidth = 51;
            this.Listado_Jugadores.RowTemplate.Height = 24;
            this.Listado_Jugadores.Size = new System.Drawing.Size(664, 248);
            this.Listado_Jugadores.TabIndex = 43;
            // 
            // Reporte_Jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Listado_Jugadores);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_Jugadores";
            this.Text = "Reporte_Jugadores";
            this.Load += new System.EventHandler(this.Reporte_Jugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listado_Jugadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView Listado_Jugadores;
    }
}