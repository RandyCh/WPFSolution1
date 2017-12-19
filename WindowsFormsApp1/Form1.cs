using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AdventureWorks2014Entities dbContext = new AdventureWorks2014Entities();
        private void myButton3_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.ProductPhotoes
                    select p;
            //dbContext.ProductPhotoes.Select(p => p);
            dbContext.Database.Log = Console.WriteLine;
            this.dataGridView1.DataSource = q.ToList();
          
            this.dataGridView2.DataSource = dbContext.ProductPhotoes.Local;
            //Local-IObservableCollection<ProductPhoto>
            //取得 System.Collections.ObjectModel.ObservableCollection`1，
            //代表此集合中所有 Added、Unchanged
            //     和 Modified 實體的本機檢視。當從內容中加入或移除實體時，此本機檢視會維持同步的狀態。同樣地，從本機檢視加入或移除的實體將會自動加入至內容中或是從內容中移除。
            //
            // 傳回:
            //     本機檢視。

        }
    }
}
