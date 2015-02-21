using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveManagerBusiness
{
	public static class ContextMgr
	{
		private static string _dirname = string.Empty;
		private static string _filename = string.Empty;

		private static int _thickness = 1;
		private static Color _backColor;
		private static Color _foreColor;

		public static event FileOpenedEventHandler FileOpened;
		public static event FileSelectedEventHandler FileSelected;

		public static event ThicknessChangedEventHandler ThicknessChanged;
		public static event BackColorChangedEventHandler BackColorChanged;
		public static event ForeColorChangedEventHandler ForeColorChanged;

		public static string OpenedFile
		{
			get { return _dirname; }
			set
			{
				_dirname = value;

				if (FileOpened != null)
				{
					FileOpened(value);
				}
			}
		}

		public static string SelectedFile
		{
			get { return _filename; }
			set
			{
				_filename = value;

				if (FileSelected != null)
				{
					FileSelected(value);
				}
			}
		}

		public static int ChangedThickness
		{
			get { return _thickness; }
			set
			{
				_thickness = value;

				if (ThicknessChanged != null)
				{
					ThicknessChanged(value);
				}
			}
		}

		public static Color ChangedBackColor
		{
			get { return _backColor; }
			set
			{
				_backColor = value;

				if (BackColorChanged != null)
				{
					BackColorChanged(value);
				}
			}
		}

		public static Color ChangedForeColor
		{
			get { return _foreColor; }
			set
			{
				_foreColor = value;

				if (ForeColorChanged != null)
				{
					ForeColorChanged(value);
				}
			}
		}
	}
}
