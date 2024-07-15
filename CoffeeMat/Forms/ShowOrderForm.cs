using CoffeeMat.Classes;
using System.Windows.Forms;

namespace CoffeeMat.Forms
{
    public partial class ShowOrderForm : Form
    {
        readonly DataBaseDao dataBaseDao = new DataBaseDao();
        public ShowOrderForm()
        {
            InitializeComponent();
            CreateColumns();
            RefreshPage();
        }

        private void CreateColumns()
        {
            PurchaseGridView.Columns.Add("name", "имя");
            PurchaseGridView.Columns.Add("price", "цена");
            PurchaseGridView.Columns.Add("picture", "картинка");
        }

        private void RefreshPage()
        {
            PurchaseGridView.Rows.Clear();


            foreach (Purchase purchase in dataBaseDao.GetSqlTableList("purchase"))
            {
                PurchaseGridView.Rows.Add(
                purchase.Name,
                purchase.Amount,
                purchase.Picture);
            }
        }
    }
}
