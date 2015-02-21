using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace WaveManagerUserInterface
{
	public partial class StatusStripControl : UserControl
	{
		public StatusStripControl()
		{
			InitializeComponent();
		}

		private void OnTimer(object sender, EventArgs e)
		{
			//DateTime.Now.ToString();
			Process proc = Process.GetCurrentProcess();
			_pgbMemory.Value = Convert.ToInt32(proc.PrivateMemorySize64 / 1048576);
		}

		[DllImport("winmm.dll")]
		public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

		[DllImport("winmm.dll")]
		public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

		private void OnLoad(object sender, EventArgs e)
		{
			if (DesignMode)
				_timer.Enabled = false;
			else
				_timer.Enabled = true;

			Application.Idle += new EventHandler(OnIdle);
			uint CurrVol = 0;
			waveOutGetVolume(IntPtr.Zero, out CurrVol);
			ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
			_volumeBar.Value = CalcVol / (ushort.MaxValue / 10);
		}

		private void OnIdle(object sender, EventArgs e)
		{
			Form f = (Form)this.Parent;

			if (f.ActiveMdiChild == null)
			{
				_lblSamples.Text = "Samples";
				_lblWaves.Text = "Waves";
				return;
			}

			MdiChildForm m = (MdiChildForm)f.ActiveMdiChild;

			if (m.Wave != null)
			{
				_lblSamples.Text = string.Format(@"{0} {1}", "Samples", m.Wave.NumSamples);
			}
			else
			{
				_lblSamples.Text = string.Format(@"{0} {1}", "Samples", 0);
			}
			
			_lblWaves.Text = string.Format(@"{0} {1}", "Waves", f.MdiChildren.Count());
		}

		private void OnVolubeBarScroll(object sender, EventArgs e)
		{
			int NewVolume = ((ushort.MaxValue / 10) * _volumeBar.Value);
			// Set the same volume for both the left and the right channels
			uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
			waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
		}

		private void OnMouseHoverProgressBar(object sender, EventArgs e)
		{
			_tltipMemory.Show(string.Format(@"{0}: {1}", "Memory Usage in MB", _pgbMemory.Value.ToString()), _pgbMemory);
		}
	}
}
