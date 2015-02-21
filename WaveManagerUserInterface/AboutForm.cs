using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaveManagerInfoObjects;

namespace WaveManagerUserInterface
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private void OnLinkClick(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("IExplore.exe", e.LinkText);
		}

		private void OnLoad(object sender, EventArgs e)
		{
			_rtxInfo.Text = MyCompany.ProductName + Environment.NewLine + MyCompany.ProductVersion + Environment.NewLine + MyCompany.ProductCreator
				+ Environment.NewLine + MyCompany.CompanyName + Environment.NewLine + MyCompany.CompanySite;
		}
	}
}
