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

namespace NT106.O23_LAB2_22521103
{
    public partial class BAI7 : Form
    {
        public BAI7()
        {
            InitializeComponent();
            CreateTreeView();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void CreateTreeView()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady == true)
                {
                    DirectoryInfo infor = new DirectoryInfo(drive.Name);
                    if (infor.Exists)
                    {
                        TreeNode node = new TreeNode(infor.Name, 0, 1);
                        node.Tag = infor;
                        node.Text = $"{drive.VolumeLabel} {drive.Name}";
                        treeView1.Nodes.Add(node);
                        GetDirectories(infor, node);
                    }
                }
            }
        }
        private void GetDirectories(DirectoryInfo directory, TreeNode nodeAdd)
        {
            try
            {
                foreach (DirectoryInfo eachdirect in directory.GetDirectories())
                {
                    TreeNode subDirectory = new TreeNode(eachdirect.Name, 0, 1);
                    subDirectory.Tag = eachdirect;
                    GetDirectories(eachdirect, subDirectory);
                    nodeAdd.Nodes.Add(subDirectory);
                }
            }
            catch { }

            foreach (FileInfo file in directory.GetFiles())
            {
                TreeNode fileNode = new TreeNode(file.Name, 2, 2);
                fileNode.Tag = file;
                nodeAdd.Nodes.Add(fileNode);
            }
        }
        private bool isImageFile(FileInfo file)
        {
            string[] image = { ".jpg", ".jpeg", ".png" };
            return image.Contains(file.Extension);
        }
        private bool isTxtFile(FileInfo file)
        {
            return file.Extension == ".txt";
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is FileInfo)
            {
                FileInfo fileInfo = (FileInfo)e.Node.Tag;
                if (isImageFile(fileInfo))
                {
                    
                    pictureBox1.Image = Image.FromFile(fileInfo.FullName);
                }
                else
                {
                    if (isTxtFile(fileInfo))
                    {
                        
                        using (StreamReader sr = new StreamReader(fileInfo.FullName))
                        {
                            richTextBox1.Text = sr.ReadToEnd();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot read this file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
    }
}
