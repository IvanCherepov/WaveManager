using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaveManagerInfoObjects;
using WaveManagerBusiness;
using System.IO;
using System.Drawing.Drawing2D;

namespace WaveManagerUserInterface
{
	public partial class GraphViewControl : UserControl
	{
		private Wave _wave = null;

		public GraphViewControl()
		{
			InitializeComponent();
		}

		private void OnPaint(object sender, PaintEventArgs e)
		{
			if (!File.Exists(this.Parent.Text))
				return;

			MdiChildForm f = (MdiChildForm)this.Parent;
			_wave = f.Wave;

			if (_wave == null)
				return;

			if (f.SwitchMode == true)
			{
				AutoScrollMinSize = new Size();
				e.Graphics.TranslateTransform(0, 0);

				float zoom = _wave.NumSamples / this.Width;
				float zoomy = this.Height / 192;
				Matrix m = new Matrix(1 / zoom, 0, 0, zoomy, 0, 0);
				m.Translate(1.0f / zoom, 1.0f / zoomy);
				e.Graphics.Transform = m;
			}
			else
			{
				AutoScrollMinSize = new Size(_wave.NumSamples, 256);
				e.Graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);
			}

			//WaveMgr.Draw(e.Graphics, _wave, f, f.Thickness, f.SwitchMode);

			Pen newPen = new Pen(f.ForeColor, f.Thickness);
			BackColor = f.BackColor;
			for (int i = 0; i < _wave.NumSamples - 1; i++)
				e.Graphics.DrawLine(newPen, i, _wave.Samples[i], i + 1, _wave.Samples[i + 1]);
		}

		private void OnLoad(object sender, EventArgs e)
		{
			SetStyle(ControlStyles.ResizeRedraw, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			SetStyle(ControlStyles.UserPaint, true);
		}
	}
}
