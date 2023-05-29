using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileProcessing
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Button文件提取_Click(object sender, EventArgs e)
        {
            new FormExtraction().ShowDialog(); 
        }

        private void Button删空目录_Click(object sender, EventArgs e)
        {
            new FormClean().ShowDialog();
        }

        private void Button文件插入_Click(object sender, EventArgs e)
        {
            new FormInsert().ShowDialog();
        }

        private void Button文件删除_Click(object sender, EventArgs e)
        {
            new FormDelete().ShowDialog();
        }

        private void Button文件更名_Click(object sender, EventArgs e)
        {
            new FormRenaming().ShowDialog();
        }


        private void Button文件改名_Click(object sender, EventArgs e)
        {
            new FormRename().ShowDialog();
        }

        private void Form主窗口_Load(object sender, EventArgs e)
        {
            
        }

    }
}
