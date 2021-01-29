using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;
namespace AI_Data_Manger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update_tree_list();
        }
        private bool create_tree(string path, TreeNodeCollection node)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (Directory.Exists(path))
            {
                if (dir.GetDirectories("*").Length != 0)
                {
                    foreach (DirectoryInfo dChild in dir.GetDirectories("*"))
                    {
                        node.Add(dChild.ToString(), dChild.ToString());
                        create_tree(path + "\\" + dChild, node[dChild.ToString()].Nodes);
                    }
                }
                else
                {
                    foreach (var x in dir.GetFiles())
                    {
                        Console.WriteLine(x);
                        node.Add(dir.ToString() + "\\" + x, get_csv_number(dir.ToString() + "\\" + x).ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine(path);
            }
            return true;
        }
        private void update_tree_list()
        {
            treeView1.Nodes.Clear();
            create_tree(@"\\10.1.2.88\jack2\David\Data Server", treeView1.Nodes);
        }
        private int get_csv_number(string filePath)
        {
            FileStream fs = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string strLine = "";
            int number = 0;
            while ((strLine = sr.ReadLine()) != null)
            {
                number++;
            }
            return number;
        }
    }
}
