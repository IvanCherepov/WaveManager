using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaveManagerBusiness;
using System.IO;

namespace WaveManagerUserInterface
{
	public partial class FileViewControl : UserControl
	{
		public FileViewControl()
		{
			InitializeComponent();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			ContextMgr.FileOpened += OnFileOpened;
		}

		private void OnFileOpened(string directoryName)
		{
			AddTreeNode(directoryName);
		}

		private void AddTreeNode(string dirName)
		{
			TreeNode node = new TreeNode(dirName, 0, 0);
			node.Name = node.Text;
			node.Tag = dirName;

			if (!_tvwFolders.Nodes.ContainsKey(node.Name))
			{
				_tvwFolders.Nodes.Add(node);
				AddSubNodes(node, dirName);
			}

			node.Expand();

			SetUpWatcher(dirName);
		}

		private void SetUpWatcher(string dirName)
		{
			FileSystemWatcher watcher = new FileSystemWatcher(dirName, "*.wav");
			watcher.EnableRaisingEvents = true;

			watcher.Created += new FileSystemEventHandler(OnChanged);
			watcher.Deleted += new FileSystemEventHandler(OnChanged);
			watcher.Renamed += new RenamedEventHandler(OnChanged);
		}

		private void OnChanged(object sender, FileSystemEventArgs e)
		{
			string fileName = Path.GetFileName(e.FullPath);
			string dirName = Path.GetDirectoryName(e.FullPath);

			this.Invoke((MethodInvoker)delegate
			{
				this.UpdateTreeNode(dirName);
			});
		}

		private void UpdateTreeNode(string dirName)
		{
			TreeNode node = FindNodeByTag(dirName);
			node.Remove();
			AddTreeNode(dirName);
		}

		private TreeNode FindNodeByTag(string dirName)
		{
			foreach (TreeNode node in _tvwFolders.Nodes)
			{
				if (node.Tag.ToString() == dirName)
					return node;
			}

			return null;
		}

		private void OnFileRenamed(object sender, RenamedEventArgs e)
		{

		}

		private void OnFileDeleted(object sender, FileSystemEventArgs e)
		{

		}



		private void AddSubNodes(TreeNode node, string directory)
		{
			string[] filesinDir = Directory.GetFiles(directory, "*.wav");
			foreach (string file in filesinDir)
			{
				TreeNode subNode = new TreeNode(Path.GetFileName(file), 1, 1);
				subNode.Name = file;
				subNode.Tag = file;

				node.Nodes.Add(subNode);
			}
		}

		private void OnNodeDrag(object sender, ItemDragEventArgs e)
		{
			TreeNode n = (TreeNode)e.Item;
			DragDropEffects dde = DoDragDrop(n.Tag, DragDropEffects.All);
		}

		private void OnNodeSelected(object sender, TreeViewEventArgs e)
		{
			ContextMgr.SelectedFile = _tvwFolders.SelectedNode.Name;
		}

		private void OnNodeDoubleClick(object sender, MouseEventArgs e)
		{
			ContextMgr.SelectedFile = _tvwFolders.SelectedNode.Name;
		}

		private void OnBrowseClick(object sender, EventArgs e)
		{
			FolderBrowserDialog b = new FolderBrowserDialog();

			if (b.ShowDialog() == DialogResult.OK)
			{
				AddTreeNode(b.SelectedPath);
			}
		}

		private void OnFontClick(object sender, EventArgs e)
		{
			FontDialog dlg = new FontDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
				_tvwFolders.Font = dlg.Font;
		}

		private void OnBkgColorClick(object sender, EventArgs e)
		{
			ColorDialog dlg = new ColorDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				_tvwFolders.BackColor = dlg.Color;
			}
		}
	}
}
