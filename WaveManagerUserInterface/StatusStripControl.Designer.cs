namespace WaveManagerUserInterface
{
	partial class StatusStripControl
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._lblWaves = new System.Windows.Forms.Label();
			this._pgbMemory = new System.Windows.Forms.ProgressBar();
			this._cmxStatus = new System.Windows.Forms.ComboBox();
			this._volumeBar = new System.Windows.Forms.TrackBar();
			this._lblSamples = new System.Windows.Forms.Label();
			this._timer = new System.Windows.Forms.Timer(this.components);
			this._tltipMemory = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._volumeBar)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41F));
			this.tableLayoutPanel1.Controls.Add(this._lblWaves, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this._pgbMemory, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this._cmxStatus, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this._volumeBar, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this._lblSamples, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 31);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _lblWaves
			// 
			this._lblWaves.AutoSize = true;
			this._lblWaves.BackColor = System.Drawing.SystemColors.Control;
			this._lblWaves.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblWaves.Location = new System.Drawing.Point(480, 0);
			this._lblWaves.Name = "_lblWaves";
			this._lblWaves.Size = new System.Drawing.Size(48, 31);
			this._lblWaves.TabIndex = 4;
			this._lblWaves.Text = "Waves";
			this._lblWaves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _pgbMemory
			// 
			this._pgbMemory.Dock = System.Windows.Forms.DockStyle.Fill;
			this._pgbMemory.Location = new System.Drawing.Point(3, 3);
			this._pgbMemory.Name = "_pgbMemory";
			this._pgbMemory.Size = new System.Drawing.Size(194, 25);
			this._pgbMemory.TabIndex = 0;
			this._pgbMemory.MouseHover += new System.EventHandler(this.OnMouseHoverProgressBar);
			// 
			// _cmxStatus
			// 
			this._cmxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this._cmxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmxStatus.FormattingEnabled = true;
			this._cmxStatus.Location = new System.Drawing.Point(203, 3);
			this._cmxStatus.Name = "_cmxStatus";
			this._cmxStatus.Size = new System.Drawing.Size(271, 25);
			this._cmxStatus.TabIndex = 1;
			// 
			// _volumeBar
			// 
			this._volumeBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this._volumeBar.Location = new System.Drawing.Point(598, 3);
			this._volumeBar.Name = "_volumeBar";
			this._volumeBar.Size = new System.Drawing.Size(103, 25);
			this._volumeBar.TabIndex = 5;
			this._volumeBar.Scroll += new System.EventHandler(this.OnVolubeBarScroll);
			// 
			// _lblSamples
			// 
			this._lblSamples.AutoSize = true;
			this._lblSamples.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblSamples.Location = new System.Drawing.Point(534, 0);
			this._lblSamples.Name = "_lblSamples";
			this._lblSamples.Size = new System.Drawing.Size(58, 31);
			this._lblSamples.TabIndex = 3;
			this._lblSamples.Text = "Samples";
			this._lblSamples.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _timer
			// 
			this._timer.Interval = 1000;
			this._timer.Tick += new System.EventHandler(this.OnTimer);
			// 
			// StatusStripControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "StatusStripControl";
			this.Size = new System.Drawing.Size(867, 31);
			this.Load += new System.EventHandler(this.OnLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._volumeBar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ProgressBar _pgbMemory;
		private System.Windows.Forms.Label _lblWaves;
		private System.Windows.Forms.ComboBox _cmxStatus;
		private System.Windows.Forms.Label _lblSamples;
		private System.Windows.Forms.TrackBar _volumeBar;
		private System.Windows.Forms.Timer _timer;
		private System.Windows.Forms.ToolTip _tltipMemory;


	}
}
