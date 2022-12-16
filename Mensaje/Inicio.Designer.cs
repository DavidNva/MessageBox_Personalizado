namespace Mensaje
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarDialogo = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarDialogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // btnMostrarDialogo
            // 
            this.btnMostrarDialogo.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnMostrarDialogo.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnMostrarDialogo.BorderStyle.EdgeRadius = 10;
            this.btnMostrarDialogo.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnMostrarDialogo.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnMostrarDialogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMostrarDialogo.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMostrarDialogo.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnMostrarDialogo.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnMostrarDialogo.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrarDialogo.Location = new System.Drawing.Point(66, 61);
            this.btnMostrarDialogo.Name = "btnMostrarDialogo";
            this.btnMostrarDialogo.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btnMostrarDialogo.Size = new System.Drawing.Size(275, 35);
            this.btnMostrarDialogo.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.YellowGreen;
            this.btnMostrarDialogo.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.YellowGreen;
            this.btnMostrarDialogo.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDialogo.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMostrarDialogo.StateStyles.PressedStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMostrarDialogo.TabIndex = 102;
            this.btnMostrarDialogo.TextStyle.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDialogo.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btnMostrarDialogo.TextStyle.Text = "Mostrar Dialogo correcto";
            this.btnMostrarDialogo.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrarDialogo.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btnMostrarDialogo.Click += new System.EventHandler(this.btnMostrarDialogo_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 297);
            this.Controls.Add(this.btnMostrarDialogo);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrarDialogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnMostrarDialogo;
    }
}