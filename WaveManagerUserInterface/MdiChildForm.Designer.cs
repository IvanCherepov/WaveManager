namespace WaveManagerUserInterface
{
	partial class MdiChildForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiChildForm));
			this._ctxMenuChild = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thicknessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.graphViewControl1 = new WaveManagerUserInterface.GraphViewControl();
			this._ctxMenuChild.SuspendLayout();
			this.SuspendLayout();
			// 
			// _ctxMenuChild
			// 
			this._ctxMenuChild.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.thicknessToolStripMenuItem,
            this.backgroundToolStripMenuItem});
			this._ctxMenuChild.Name = "_ctxMenuChild";
			this._ctxMenuChild.Size = new System.Drawing.Size(139, 70);
			// 
			// colorToolStripMenuItem
			// 
			this.colorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorToolStripMenuItem.Image")));
			this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			this.colorToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.colorToolStripMenuItem.Text = "Color";
			this.colorToolStripMenuItem.Click += new System.EventHandler(this.OnMenuColor);
			// 
			// thicknessToolStripMenuItem
			// 
			this.thicknessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
			this.thicknessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thicknessToolStripMenuItem.Image")));
			this.thicknessToolStripMenuItem.Name = "thicknessToolStripMenuItem";
			this.thicknessToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.thicknessToolStripMenuItem.Text = "Thickness...";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.toolStripMenuItem1.Text = "1";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.OnMenuThick1);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.toolStripMenuItem2.Text = "2";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.OnMenuThick2);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
			this.toolStripMenuItem3.Text = "4";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.OnMenuThick4);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
			this.toolStripMenuItem4.Text = "8";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.OnMenuThick8);
			// 
			// backgroundToolStripMenuItem
			// 
			this.backgroundToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backgroundToolStripMenuItem.Image")));
			this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
			this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.backgroundToolStripMenuItem.Text = "Background";
			this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.OnMenuBkg);
			// 
			// graphViewControl1
			// 
			this.graphViewControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.graphViewControl1.ContextMenuStrip = this._ctxMenuChild;
			this.graphViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.graphViewControl1.Location = new System.Drawing.Point(0, 0);
			this.graphViewControl1.Name = "graphViewControl1";
			this.graphViewControl1.Size = new System.Drawing.Size(743, 506);
			this.graphViewControl1.TabIndex = 0;
			// 
			// MdiChildForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(743, 506);
			this.Controls.Add(this.graphViewControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MdiChildForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MdiChildForm";
			this.Load += new System.EventHandler(this.OnLoad);
			this._ctxMenuChild.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GraphViewControl graphViewControl1;
		private System.Windows.Forms.ContextMenuStrip _ctxMenuChild;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thicknessToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;



	}
}