using HtmlAgilityPack;
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

namespace DomowyFastFood
{
    public partial class frmUserControlPanel : Form
    {
        string path = @"SyncDateTime.txt";
        public string Identity { get; set; }

        public frmUserControlPanel(string Identity)
        {
            InitializeComponent();
            this.Identity = Identity;
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            using (var Context = new DomowyFastFoodContext())
            {
                var currentDate = $"{DateTime.Now.ToShortDateString()} \t {DateTime.Now.ToShortTimeString()}";

                lblSyncInfo.Text = currentDate;

                File.WriteAllText(path, $"");
                File.AppendAllText(path, currentDate);

                string url = "http://www.poswieciekuchni.pl/menu-dnia/";
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = web.Load(url);


                var node = document.DocumentNode
                               .SelectNodes("//div[@class='wpb_wrapper']/p[position() > 5]").ToArray();

                string Dinner = string.Empty;

                if (node != null)
                {
                    foreach (var item in node)
                    {
                        Dinner += item.InnerText;
                    }
                }
                var Result = Context.Restauracjas.SingleOrDefault(x => x.ID_Restauracji == 1);
                if (Result != null)
                {
                    Result.DanieDnia = Dinner;
                    Context.SaveChanges();
                }
                this.OnLoad(e);
            }
        }

        private void frmUserControlPanel_Load(object sender, EventArgs e)
        {
            var Lines = File.ReadAllText(path);
            lblSyncInfo.Text = Lines;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (DomowyFastFoodContext Context = new DomowyFastFoodContext())
            {
                var client = Context.Klients.SingleOrDefault(x => x.Nick == Identity);
                var id = client.ID_Klienta;
                var idRestaurant = int.Parse(dgvRestaurant.Rows[dgvRestaurant.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

                Context.Zamowienies.Add(new Zamowienie
                {
                    ID_Zamowienia = Context.Zamowienies.Max(x => x.ID_Zamowienia) + 1,
                    Klient = Context.Klients.Where(x => x.ID_Klienta == id).Select(x => x.Nick).ToString(),
                    TelefonDoKlienta = Context.Klients.Where(x => x.ID_Klienta == id).Select(x => x.Telefon).ToString(),
                    NazwaRestauracji = Context.Restauracjas.Where(x => x.ID_Restauracji == idRestaurant).Select(x => x.NazwaRestauracji).ToString(),
                    DanieDnia = Context.Restauracjas.Where(x => x.ID_Restauracji == idRestaurant).Select(x => x.DanieDnia).ToString(),
                    TelefonDoRestauracji = Context.Restauracjas.Where(x => x.ID_Restauracji == idRestaurant).Select(x => x.Telefon).ToString(),
                    DataZamowienia = DateTime.Now.Date
                });
                Context.SaveChanges();
                MessageBox.Show("Pomyslnie dodano zamowienie", "Zamow!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvRestaurant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
