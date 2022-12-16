namespace Mensaje
{
    partial class DialogCorrecto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogCorrecto));
            this.lblMensaje = new System.Windows.Forms.Label();
            this.icon_delay = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.icono = new System.Windows.Forms.PictureBox();
            this.lblTipoObjeto = new System.Windows.Forms.Label();
            this.btnOK = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(2, 118);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(273, 18);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "se registró correctamente";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon_delay
            // 
            this.icon_delay.Interval = 5000;
            this.icon_delay.Tick += new System.EventHandler(this.icon_delay_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 0;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition1_TransitionEnd);
            // 
            // icono
            // 
            this.icono.Enabled = false;
            this.icono.Image = ((System.Drawing.Image)(resources.GetObject("icono.Image")));
            this.icono.Location = new System.Drawing.Point(-14, -37);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(304, 184);
            this.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono.TabIndex = 2;
            this.icono.TabStop = false;
            // 
            // lblTipoObjeto
            // 
            this.lblTipoObjeto.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoObjeto.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoObjeto.Location = new System.Drawing.Point(-1, 100);
            this.lblTipoObjeto.Name = "lblTipoObjeto";
            this.lblTipoObjeto.Size = new System.Drawing.Size(276, 18);
            this.lblTipoObjeto.TabIndex = 3;
            this.lblTipoObjeto.Text = "El libro";
            this.lblTipoObjeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnOK.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnOK.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.btnOK.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.btnOK.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.btnOK.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle;
            this.btnOK.BorderStyle.EdgeRadius = 10;
            this.btnOK.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnOK.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnOK.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnOK.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnOK.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Location = new System.Drawing.Point(0, 139);
            this.btnOK.Name = "btnOK";
            this.btnOK.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btnOK.Size = new System.Drawing.Size(275, 35);
            this.btnOK.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.YellowGreen;
            this.btnOK.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.YellowGreen;
            this.btnOK.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOK.StateStyles.PressedStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOK.TabIndex = 101;
            this.btnOK.TextStyle.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btnOK.TextStyle.Text = "Aceptar";
            this.btnOK.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Visible = false;
            this.btnOK.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DialogCorrecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(276, 174);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTipoObjeto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.icono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogCorrecto";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialogo";
            this.Load += new System.EventHandler(this.DialogCorrecto_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DialogCorrecto_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Timer icon_delay;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.PictureBox icono;
        private System.Windows.Forms.Label lblTipoObjeto;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnOK;
    }
}