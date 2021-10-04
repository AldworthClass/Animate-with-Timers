namespace Animate_with_Timers
{
    partial class FormAnimate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnimate));
            this.imgBoat = new System.Windows.Forms.PictureBox();
            this.tmrMoveBoat = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgBoat)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBoat
            // 
            this.imgBoat.Image = ((System.Drawing.Image)(resources.GetObject("imgBoat.Image")));
            this.imgBoat.Location = new System.Drawing.Point(125, 87);
            this.imgBoat.Name = "imgBoat";
            this.imgBoat.Size = new System.Drawing.Size(114, 65);
            this.imgBoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoat.TabIndex = 0;
            this.imgBoat.TabStop = false;
            // 
            // tmrMoveBoat
            // 
            this.tmrMoveBoat.Enabled = true;
            this.tmrMoveBoat.Interval = 300;
            this.tmrMoveBoat.Tick += new System.EventHandler(this.tmrMoveBoat_Tick);
            // 
            // FormAnimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgBoat);
            this.Name = "FormAnimate";
            this.Text = "Animation";
            this.Load += new System.EventHandler(this.FormAnimate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBoat;
        private System.Windows.Forms.Timer tmrMoveBoat;
    }
}

