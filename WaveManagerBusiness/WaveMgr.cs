using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveManagerInfoObjects;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.Collections;
using System.Xml;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace WaveManagerBusiness
{
	public static class WaveMgr
	{
		public const int HeaderSize = 40;

		private static Wave _wave = new Wave();

		public static Wave Wave
		{
			get { return _wave; }
		}

		public static Wave Load(string filename)
		{
			Wave w = new Wave();
			w.Name = filename;

			BinaryReader br = new BinaryReader(File.OpenRead(filename));
			using (br)
			{
				w.Header = br.ReadBytes(HeaderSize);
				w.NumSamples = br.ReadInt32();
				w.Samples = br.ReadBytes(w.NumSamples);
			}
			return w;
		}

		public static void Save(string filename, Wave wave)
		{
			SaveAsWave(filename, wave);
		}

		public static void SaveAs(string filename, WaveManagerInfoObjects.Wave wave, Form f, int thickness, bool switchMode)
		{
			_wave = wave;

			if ((Path.GetExtension(filename) == ".wav") | (Path.GetExtension(filename) == ".WAV"))
			{
				SaveAsWave(filename, wave);
				_wave.IsModified = false;
			}

			if ((Path.GetExtension(filename) == ".png") | (Path.GetExtension(filename) == ".bmp") | (Path.GetExtension(filename) == ".jpg"))
			{
				SaveAsBitmap(filename, _wave, f, thickness, switchMode);
				_wave.IsModified = false;
			}
		}

		private static void SaveAsWave(string filename, WaveManagerInfoObjects.Wave wave)
		{
			BinaryWriter bw = new BinaryWriter(File.Create(filename));
			using (bw)
			{
				bw.Write(_wave.Header);
				bw.Write(_wave.NumSamples);
				bw.Write(_wave.Samples);
			}
		}

		private static void SaveAsBitmap(string filename, WaveManagerInfoObjects.Wave _wave, Form f, int thickness, bool switchMode)
		{
			Bitmap newBitmap = new Bitmap(f.Width, f.Height);
			Graphics memG = Graphics.FromImage(newBitmap);
			Draw(memG, _wave, f, thickness, switchMode);
			newBitmap.Save(filename);
		}


		public static void Draw(Graphics g, Wave wave, Form f, int thickness, bool switchMode)
		{
			if (switchMode == true)
			{
				//AutoScrollMinSize = new Size();
				g.TranslateTransform(0, 0);

				float zoom = _wave.NumSamples / f.Width;
				float zoomy = f.Height / 192;
				Matrix m = new Matrix(1 / zoom, 0, 0, zoomy, 0, 0);
				m.Translate(1.0f / zoom, 1.0f / zoomy);
				g.Transform = m;
			}

			_wave = wave;

			Pen newPen = new Pen(f.ForeColor, thickness);
			g.Clear(f.BackColor);

			for (int i = 0; i < _wave.NumSamples - 1; i++)
				g.DrawLine(newPen, i, _wave.Samples[i], i + 1, _wave.Samples[i + 1]);
		}

		public static void Rotate(Wave w)
		{
			Array.Reverse(w.Samples);
		}

		public static byte[] Modulate(byte[] samples, int numSamples)
		{
			for (int i = 0; i < numSamples - 1; i++)
			{
				samples[i] = (byte)(Math.Sin(i + 3.2f) * 20 + samples[i]);
			}

			return samples;
		}

		public static void Modulate(Wave w)
		{
			for (int i = 0; i < w.NumSamples - 1; i++)
			{
				w.Samples[i] = (byte)(Math.Sin(i + 3.2f) * 20 + w.Samples[i]);
			}
		}

		public static Wave Copy(Wave w)
		{
			MemoryStream ms = new MemoryStream();
			BinaryFormatter bf = new BinaryFormatter();
			bf.Serialize(ms, w);

			ms.Position = 0;
			return (Wave)bf.Deserialize(ms);
		}

		public static void Delete(Wave w)
		{
			w.Samples.Initialize();
			w.NumSamples = 0;
		}

		public static void CopyAsBitmap(string filename, WaveManagerInfoObjects.Wave _wave, Form f, int thickness, bool switchMode)
		{
			Bitmap newBitmap = new Bitmap(f.Width, f.Height);
			Graphics memG = Graphics.FromImage(newBitmap);
			Draw(memG, _wave, f, thickness, switchMode);

			Clipboard.SetImage(newBitmap);
		}
	}
}
