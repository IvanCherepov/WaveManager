namespace WaveManagerUserInterface
{
	partial class Splash
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
			this._pctSpash = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._pctSpash)).BeginInit();
			this.SuspendLayout();
			// 
			// _pctSpash
			// 
			this._pctSpash.Dock = System.Windows.Forms.DockStyle.Fill;
			this._pctSpash.Image = ((System.Drawing.Image)(resources.GetObject("_pctSpash.Image")));
			this._pctSpash.Location = new System.Drawing.Point(0, 0);
			this._pctSpash.Name = "_pctSpash";
			this._pctSpash.Size = new System.Drawing.Size(590, 262);
			this._pctSpash.TabIndex = 0;
			this._pctSpash.TabStop = false;
			// 
			// Splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 262);
			this.Controls.Add(this._pctSpash);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Splash";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this._pctSpash)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox _pctSpash;
	}
}