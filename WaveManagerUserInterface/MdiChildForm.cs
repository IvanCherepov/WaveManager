using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaveManagerBusiness;
using WaveManagerInfoObjects;

namespace WaveManagerUserInterface
{
	public partial class MdiChildForm : Form
	{
		private Wave _wave = null;
		private int _thickness;
		private bool _switchMode = false;

		public int Thickness
		{
			get { return _thickness; }
			set { _thickness = value; }
		}

		public Wave Wave
		{
			get { return _wave; }
			set { _wave = value; }
		}

		public bool SwitchMode
		{
			get { return _switchMode; }
			set { _switchMode = value; }
		}

		public MdiChildForm()
		{
			InitializeComponent();
		}

		private string _filename = string.Empty;

		public string Filename
		{
			get { return _filename; }
			set { _filename = value; }
		}

		private void OnLoad(object sender, EventArgs e)
		{
			this.Text = Filename;
			if (!File.Exists(this.Filename))
				return;

			_wave = WaveMgr.Load(Filename);
		}

		private void OnMenuColor(object sender, EventArgs e)
		{
			ColorDialog dlg = new ColorDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				ContextMgr.ChangedForeColor = dlg.Color;
			}
		}

		private void OnMenuBkg(object sender, EventArgs e)
		{
			ColorDialog dlg = new ColorDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				ContextMgr.ChangedBackColor = dlg.Color;
			}
		}

		private void OnMenuThick1(object sender, EventArgs e)
		{
			ContextMgr.ChangedThickness = 1;
		}

		private void OnMenuThick2(object sender, EventArgs e)
		{
			ContextMgr.ChangedThickness = 2;
		}

		private void OnMenuThick4(object sender, EventArgs e)
		{
			ContextMgr.ChangedThickness = 4;
		}

		private void OnMenuThick8(object sender, EventArgs e)
		{
			ContextMgr.ChangedThickness = 8;
		}
	}
}
