namespace WaveManagerUserInterface
{
	partial class FileViewControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileViewControl));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this._tvwFolders = new System.Windows.Forms.TreeView();
			this._ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._btnBrowse = new System.Windows.Forms.Button();
			this._imgList = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this._ctxMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this._tvwFolders);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this._btnBrowse);
			this.splitContainer1.Size = new System.Drawing.Size(364, 602);
			this.splitContainer1.SplitterDistance = 559;
			this.splitContainer1.TabIndex = 9;
			// 
			// _tvwFolders
			// 
			this._tvwFolders.BackColor = System.Drawing.SystemColors.Info;
			this._tvwFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._tvwFolders.ContextMenuStrip = this._ctxMenu;
			this._tvwFolders.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tvwFolders.Location = new System.Drawing.Point(0, 0);
			this._tvwFolders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this._tvwFolders.Name = "_tvwFolders";
			this._tvwFolders.Size = new System.Drawing.Size(362, 557);
			this._tvwFolders.TabIndex = 10;
			this._tvwFolders.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.OnNodeDrag);
			this._tvwFolders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnNodeDoubleClick);
			// 
			// _ctxMenu
			// 
			this._ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
			this._ctxMenu.Name = "_ctxMenu";
			this._ctxMenu.Size = new System.Drawing.Size(177, 48);
			// 
			// fontToolStripMenuItem
			// 
			this.fontToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fontToolStripMenuItem.Image")));
			this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
			this.fontToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.fontToolStripMenuItem.Text = "Font...";
			this.fontToolStripMenuItem.Click += new System.EventHandler(this.OnFontClick);
			// 
			// backgroundColorToolStripMenuItem
			// 
			this.backgroundColorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backgroundColorToolStripMenuItem.Image")));
			this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
			this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.backgroundColorToolStripMenuItem.Text = "BackgroundColor...";
			this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.OnBkgColorClick);
			// 
			// _btnBrowse
			// 
			this._btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this._btnBrowse.Location = new System.Drawing.Point(0, 0);
			this._btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this._btnBrowse.Name = "_btnBrowse";
			this._btnBrowse.Size = new System.Drawing.Size(362, 37);
			this._btnBrowse.TabIndex = 9;
			this._btnBrowse.Text = "Browse";
			this._btnBrowse.UseVisualStyleBackColor = true;
			this._btnBrowse.Click += new System.EventHandler(this.OnBrowseClick);
			// 
			// _imgList
			// 
			this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
			this._imgList.TransparentColor = System.Drawing.Color.Transparent;
			this._imgList.Images.SetKeyName(0, "Folder.ico");
			this._imgList.Images.SetKeyName(1, "Wav.ico");
			// 
			// FileViewControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FileViewControl";
			this.Size = new System.Drawing.Size(364, 602);
			this.Load += new System.EventHandler(this.OnLoad);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this._ctxMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView _tvwFolders;
		private System.Windows.Forms.Button _btnBrowse;
		private System.Windows.Forms.ImageList _imgList;
		private System.Windows.Forms.ContextMenuStrip _ctxMenu;
		private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;






	}
}
