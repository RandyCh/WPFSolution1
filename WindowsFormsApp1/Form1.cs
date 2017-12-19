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
            //Notes:
            //參考 ...DBDataModel.dll  , EntityFramework.dll,    EntityFramework.SqlServer.dll, 
            //using NameSpace {}  DataModel;  System.Linq;        
            //要加入連線字串
            //app.config   <add name="AdventureWorks2014Entities" connectionString="metadata=res://*/AdventureWorksModel.csdl|res://*/AdventureWorksModel.ssdl|res://*/AdventureWorksModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.;initial catalog=AdventureWorks2014;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />

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

        private void Form1_Load(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();
            //var q = from p in dbContext.ProductPhotoes
            //        //where p.LargePhoto != null
            //        select p.LargePhoto;
            var q = dbContext.ProductPhotoes.Select(g => g.LargePhoto);
            foreach (var c in q)
            {
                PictureBox PBx = new PictureBox();
                PBx.Size = new Size(250, 200);
                PBx.BackColor = Color.White;
                //PBx.SizeMode =System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                PBx.MouseEnter += PBx_MouseEnter;
                PBx.MouseLeave += PBx_MouseLeave;
                PBx.MouseClick += PBx_MouseClick;
                
                using (MemoryStream ms = new MemoryStream(c))
                {
                    PBx.Image = Image.FromStream(ms);
                }
                this.flowLayoutPanel1.Controls.Add(PBx);
            }

        }

        private void PBx_MouseClick(object sender, MouseEventArgs e)
        {
            //PictureBox pb1 = ((PictureBox)sender);
            //pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           // pb1.BackColor = System.Drawing.Color.White;
            //pb1.Padding = new System.Windows.Forms.Padding(3);

        }

        private void PBx_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb1 = ((PictureBox)sender);
            pb1.Size = new Size(250, 200);
            pb1.BorderStyle = BorderStyle.FixedSingle;
            pb1.Margin = new Padding(5);
            pb1.Padding = new Padding(3);
        }

        private void PBx_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb1 = ((PictureBox)sender);
            pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pb1.Margin = new Padding(0);
            pb1.Padding = new System.Windows.Forms.Padding(5);
            pb1.Size = new Size((int)(pb1.Width * 1.1), (int)(pb1.Height));

            
        }
    }
}
