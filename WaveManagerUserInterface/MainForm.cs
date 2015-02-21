using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaveManagerBusiness;
using WaveManagerInfoObjects;

namespace WaveManagerUserInterface
{
	public partial class MainForm : Form
	{
		private int _emptyWaveNumber = 1;
		private int _itemNumber;

		private Wave _waveCopy = new Wave();

		private Splash m_SplashForm;

		private Color _mdiBackColor;
		private Color _mdiForeColor;
		private int _mdiThickness;

		public Color MdiBackColor
		{
			get { return _mdiBackColor; }
			set { _mdiBackColor = value; }
		}

		public Color MdiForeColor
		{
			get { return _mdiForeColor; }
			set { _mdiForeColor = value; }
		}

		public int MdiThickness
		{
			get { return _mdiThickness; }
			set { _mdiThickness = value; }
		}

		public MainForm()
		{
			InitializeComponent();

			m_SplashForm = new Splash();
			m_SplashForm.Show();

			Application.DoEvents();
			Thread.Sleep(2000);
		}

		private void OnClosing(object sender, FormClosingEventArgs e)
		{

		}

		private void OnFileExit(object sender, EventArgs e)
		{
			Close();
		}

		private void OnNotifyRestore(object sender, EventArgs e)
		{
			this.Show();
			WindowState = FormWindowState.Normal;
		}

		private void OnFormResize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
				this.Hide();
		}

		private void OnHelpAbout(object sender, EventArgs e)
		{
			AboutForm f = new AboutForm();
			f.ShowDialog();
		}

		private void OnViewToolBar(object sender, EventArgs e)
		{
			_tspMain.Visible = !_tspMain.Visible;
			_mnuViewToolBar.Checked = !_mnuViewToolBar.Checked;
		}

		private void OnViewStatusBar(object sender, EventArgs e)
		{
			_statusStripControl.Visible = !_statusStripControl.Visible;
			_mnuViewStatusBar.Checked = !_mnuViewStatusBar.Checked;
		}

		private void OnFileOpen(object sender, EventArgs e)
		{
			OpenFileDialog d = new OpenFileDialog();
			d.Multiselect = true;
			d.Filter = @"Wave Files|*.wav";
			using (d)
			{
				if (d.ShowDialog(this) != DialogResult.OK)
					return;
			}
			OpenMdiDocuments(d.FileNames);
		}

		private void OpenMdiDocuments(string[] filenames)
		{
			foreach (string filename in filenames)
			{
				if ((Path.GetExtension(filename) == ".wav") | (Path.GetExtension(filename) == ".WAV"))
					OpenMidDocument(filename);
			}
		}

		private void OpenMidDocument(string filename)
		{
			if (!File.Exists(filename))
				return;

			VerifyWavFile(filename);

			LayoutMdi(MdiLayout.TileVertical);

			WaveManagerBusiness.ContextMgr.OpenedFile = Path.GetDirectoryName(filename);
		}

		private void VerifyWavFile(string filename)
		{
			try
			{
				Wave _wave = WaveMgr.Load(filename);

				string chunkID = Encoding.ASCII.GetString(_wave.Header);
				if (!chunkID.StartsWith("RIFF"))
				{
					MessageBox.Show("This file can't be opened", "WaveManager");
					return;
				}

				MdiChildForm f = new MdiChildForm();
				f.MdiParent = this;
				f.Filename = filename;
				f.Thickness = _mdiThickness;
				f.BackColor = _mdiBackColor;
				f.ForeColor = _mdiForeColor;
				f.Show();
			}
			catch (Exception)
			{
				MessageBox.Show("Incorret format of the file", "WaveManager");
			}
		}

		private void OnFileNew(object sender, EventArgs e)
		{
			MdiChildForm f = new MdiChildForm();

			f.MdiParent = this;
			f.Filename = string.Format("{0}{1}", "Wave", _emptyWaveNumber);
			f.Thickness = _mdiThickness;
			f.BackColor = _mdiBackColor;
			f.ForeColor = _mdiForeColor;
			f.Show();

			_emptyWaveNumber++;
		}

		private void OnDragDrop(object sender, DragEventArgs e)
		{
			string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
			string filenamefromtrvw = (string)e.Data.GetData(DataFormats.Text);

			if (filenames != null)
				OpenMdiDocuments(filenames);

			if (!string.IsNullOrEmpty(filenamefromtrvw))
				OpenMidDocument(filenamefromtrvw);
		}

		private void OnDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;

			if (e.Data.GetDataPresent(DataFormats.Text))
				e.Effect = DragDropEffects.Copy;
		}

		private void OnWindowTileHorizontally(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void OnWindowTileVertically(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void OnWindowCascade(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void OnLoad(object sender, EventArgs e)
		{
			if (m_SplashForm != null)
				m_SplashForm.Dispose();

			ContextMgr.FileSelected += OnFileSelected;
			ContextMgr.ThicknessChanged += OnThicknessChanged;
			ContextMgr.BackColorChanged += OnBackColorChanged;
			ContextMgr.ForeColorChanged += OnForeColorChanged;
		}

		private void OnForeColorChanged(Color foreColor)
		{
			this._mdiForeColor = foreColor;
			ReDrawMdiChildren();
		}

		private void ReDrawMdiChildren()
		{
			foreach (Form child in this.MdiChildren)
			{
				MdiChildForm f = (MdiChildForm)child;
				f.Thickness = _mdiThickness;
				f.BackColor = _mdiBackColor;
				f.ForeColor = _mdiForeColor;
				Invalidate(true);
			}
		}

		private void OnBackColorChanged(Color backColor)
		{
			this._mdiBackColor = backColor;
			ReDrawMdiChildren();
		}

		private void OnThicknessChanged(int thickness)
		{
			this._mdiThickness = thickness;
			ReDrawMdiChildren();
		}

		private void OnFileSelected(string filename)
		{
			OpenMidDocument(filename);
		}

		private void OnFileClose(object sender, EventArgs e)
		{
			if (this.ActiveMdiChild != null)
				this.ActiveMdiChild.Close();
		}

		private void OnFileCloseAll(object sender, EventArgs e)
		{
			foreach (Form child in this.MdiChildren)
				child.Close();
		}

		private void OnWindowMenuOpening(object sender, EventArgs e)
		{
			_itemNumber = 1;

			for (int i = _mnuWindow.DropDownItems.Count - 1; i > 3; i--)
				if (_mnuWindow.DropDownItems[i].Tag != null)
					_mnuWindow.DropDownItems.RemoveAt(i);

			foreach (Form child in this.MdiChildren)
			{
				AddItemToWindowsMenu(child);
				_itemNumber++;
			}
		}

		private void AddItemToWindowsMenu(Form child)
		{
			ToolStripMenuItem t = new ToolStripMenuItem(string.Format("{0} {1}", _itemNumber, child.Text));
			t.Tag = child;
			t.Name = child.Text;

			if (child == this.ActiveMdiChild)
				t.Checked = true;

			_mnuWindow.DropDownItems.Add(t);
		}

		private void OnWindowMenuItem(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem.Tag == null)
				return;

			Form f = (Form)e.ClickedItem.Tag;
			f.Activate();
		}

		private void OnMenuFormatWaveColor(object sender, EventArgs e)
		{
			ColorDialog dlg = new ColorDialog();

			if (dlg.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			OnForeColorChanged(dlg.Color);
		}

		private void OnMenuFormatWaveBkg(object sender, EventArgs e)
		{
			ColorDialog dlg = new ColorDialog();

			if (dlg.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			OnBackColorChanged(dlg.Color);
		}

		private void OnMenuFormatThick1(object sender, EventArgs e)
		{
			this._mdiThickness = 1;
			ReDrawMdiChildren();
		}

		private void OnMenuFormatThick2(object sender, EventArgs e)
		{
			this._mdiThickness = 2;
			ReDrawMdiChildren(); ;
		}

		private void OnMenuFormatThick4(object sender, EventArgs e)
		{
			this._mdiThickness = 4;
			ReDrawMdiChildren();
		}

		private void OnMenuFormatThick8(object sender, EventArgs e)
		{
			this._mdiThickness = 8;
			ReDrawMdiChildren();
		}

		private void OnViewFullNormal(object sender, EventArgs e)
		{
			MdiChildForm f = (MdiChildForm)this.ActiveMdiChild;

			if (f == null)
				return;

			f.SwitchMode = !f.SwitchMode;
			f.Invalidate(true);
		}

		private void OnToolsPlay(object sender, EventArgs e)
		{
			if (!File.Exists(this.ActiveMdiChild.Text))
				return;

			SoundPlayer simpleSound = new SoundPlayer(this.ActiveMdiChild.Text);
			simpleSound.Play();
		}

		private void OnFileSave(object sender, EventArgs e)
		{
			MdiChildForm f = (MdiChildForm)this.ActiveMdiChild;
			if (f.Wave.IsNew)
			{
				SaveAs();
				return;
			}

			WaveMgr.Save(f.Filename, f.Wave);
		}

		private void OnFileSaveAs(object sender, EventArgs e)
		{
			SaveAs();
		}

		private void SaveAs()
		{
			MdiChildForm f = (MdiChildForm)this.ActiveMdiChild;

			SaveFileDialog d = new SaveFileDialog();
			d.Filter = @"WAV (*.wav)|*.wav|Image Files (*.png,*.jpg,*bmp)|*.png;*.jpg;*.bmp";
			d.DefaultExt = @".wav";
			using (d)
			{
				if (d.ShowDialog() != DialogResult.OK)
				{
					return;
				}

				WaveMgr.SaveAs(d.FileName, f.Wave, this.ActiveMdiChild, _mdiThickness, f.SwitchMode);
			}
		}

		private void OnToolsRotate(object sender, EventArgs e)
		{
			MdiChildForm f = (MdiChildForm)this.ActiveMdiChild;
			WaveMgr.Rotate(f.Wave);

			f.Invalidate(true);
		}

		private void OnToolsModulate(object sender, EventArgs e)
		{
			MdiChildForm f = (MdiChildForm)this.ActiveMdiChild;
			WaveMgr.Modulate(f.Wave);

			f.Invalidate(true);
		}


		private void OnEditCopy(object sender, EventArgs e)
		{
			MdiChildForm f = (MdiChildForm)this.ActiveMdiChild;

			_waveCopy = WaveMgr.Copy(f.Wave);
		}

		private void OnEditCopyBtmp(object sender, EventArgs e)
		{
			MdiChildForm f = (MdiChildForm)this.ActiveMdiChild;

			WaveMgr.CopyAsBitmap(f.Filename, f.Wave, f, _mdiThickness, f.SwitchMode);
		}

		private void OnEditPaste(object sender, EventArgs e)
		{
			MdiChildForm f = (MdiChildForm)this.ActiveMdiChild;
			f.Wave = new Wave();
			f.Wave = _waveCopy;

			f.Invalidate(true);
		}

		private void OnEditDelete(object sender, EventArgs e)
		{
			MdiChildForm f = (MdiChildForm)this.ActiveMdiChild;

			WaveMgr.Delete(f.Wave);

			f.Invalidate(true);
		}

		private void OnEditCut(object sender, EventArgs e)
		{
			MdiChildForm f = (MdiChildForm)this.ActiveMdiChild;

			_waveCopy = WaveMgr.Copy(f.Wave);
			WaveMgr.Delete(f.Wave);

			f.Invalidate(true);
		}
	}
}

