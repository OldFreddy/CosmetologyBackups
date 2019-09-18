using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CosmetologyBackups
{
    public partial class Form1 : Form
    
    {
        public string[] filesindir; //глобальный массив данных, который будет содержать имена файлов из родительской директории
        public string ThisDay; //глобальная переменная, которая будет возвращать текущую дату

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ThisDay = DateTime.Today.ToShortDateString(); //отсечение времени из даты

            Directory.CreateDirectory("E:/2/" + ThisDay + "/");
            DirectoryInfo SourceDir = new DirectoryInfo("E:/3/");
            DirectoryInfo DestDir = new DirectoryInfo("E:/2/" + ThisDay + "/");

            foreach (var item in SourceDir.GetFiles())
            {
                item.CopyTo(DestDir + item.Name, true);
            }

            MessageBox.Show("Резервная копия создана");
            this.Close();

        }
        
    }
}