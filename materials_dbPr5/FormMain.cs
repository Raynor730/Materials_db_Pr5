
using System.ComponentModel;
using materials_dbPr5.Models;
using Microsoft.EntityFrameworkCore;

namespace materials_dbPr5
{

    //—оздаетс€ экземпл€р контекста данных, который будет использоватьс€
    //дл€ загрузки и отслеживани€ изменений о поставщиках
    public partial class FormMain : Form
    {
        private MaterialsDbContext? db;

        public FormMain()
        {
            InitializeComponent();
        }

        //ћетод OnLoad вызываетс€ при загрузке формы

        private void FormMain_Load(object sender, EventArgs e)
        {
            

            this.db = new MaterialsDbContext();

            // метод Load расширени€ используетс€ дл€ загрузки всех поставщиков из базы данных в MaterialsDbContext базу данных
            this.db.Suppliers.Load();
            this.dataGridViewSupplier.DataSource = db.Suppliers.Local.ToBindingList();
        }

        // метод OnClosing вызываетс€ при закрытии формы
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;

        }
        
    }
}
