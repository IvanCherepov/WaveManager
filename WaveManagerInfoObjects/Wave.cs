using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveManagerInfoObjects
{
	[Serializable]
	public class Wave
	{
		private byte[] _header;
		private int _numSamples;
		private byte[] _samples;
		private string _name = string.Empty;
		private bool _isModified = false;

		public byte[] Header
		{
			get { return _header; }
			set { _header = value; }
		}

		public int NumSamples
		{
			get { return _numSamples; }
			set { _numSamples = value; }
		}

		public byte[] Samples
		{
			get { return _samples; }
			set { _samples = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public bool IsNew
		{
			get { return string.IsNullOrEmpty(_name); }
		}

		public bool IsModified
		{
			get { return _isModified; }
			set { _isModified = value; }
		}
	}
}
