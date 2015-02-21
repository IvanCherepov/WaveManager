using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveManagerBusiness
{
	public delegate void FileOpenedEventHandler(string filename);
	public delegate void FileSelectedEventHandler(string filename);

	public delegate void ThicknessChangedEventHandler(int thickness);
	public delegate void BackColorChangedEventHandler(Color backColor);
	public delegate void ForeColorChangedEventHandler(Color foreColor);
}
