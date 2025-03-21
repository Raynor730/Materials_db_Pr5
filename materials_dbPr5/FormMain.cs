
using System.ComponentModel;
using materials_dbPr5.Models;
using Microsoft.EntityFrameworkCore;

namespace materials_dbPr5
{

    //��������� ��������� ��������� ������, ������� ����� ��������������
    //��� �������� � ������������ ��������� � �����������
    public partial class FormMain : Form
    {
        private MaterialsDbContext? db;

        public FormMain()
        {
            InitializeComponent();
        }

        //����� OnLoad ���������� ��� �������� �����

        private void FormMain_Load(object sender, EventArgs e)
        {
            

            this.db = new MaterialsDbContext();

            // ����� Load ���������� ������������ ��� �������� ���� ����������� �� ���� ������ � MaterialsDbContext ���� ������
            this.db.Suppliers.Load();
            this.dataGridViewSupplier.DataSource = db.Suppliers.Local.ToBindingList();
        }

        // ����� OnClosing ���������� ��� �������� �����
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;

        }
        
    }
}
