using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowyFastFood
{
    public partial class frmAdminControlPanel : Form
    {
        public int Authorization { get; set; }
        public string Identity { get; set; }

        public frmAdminControlPanel(int Authorization, string Identity)
        {
            InitializeComponent();
            this.Authorization = Authorization;
            this.Identity = Identity;
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dgvOrder.Rows[dgvOrder.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            using (var Context = new DomowyFastFoodContext())
            {
                var removeOrder = Context
                     .Zamowienies
                     .FirstOrDefault(x => x.ID_Zamowienia == id);
                var removeCommand = Context
                           .Entry(removeOrder);
                removeCommand.State = EntityState.Deleted;
                Context.SaveChanges();
            }
            this.OnLoad(e);
        }
    }
}
