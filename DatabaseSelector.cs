using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniversalReferenceDataEditor
{
    public partial class DatabaseSelector : DevExpress.XtraEditors.XtraForm
    {
        private DialogResult _dialogResult;

        public DialogResult GetDialogResult()
        {
            return _dialogResult;
        }

        private void SetDialogResult(DialogResult value)
        {
            _dialogResult = value;
        }

        public string DatabaseName { get; private set; }
        public DatabaseSelector(Database databases)
        {
            InitializeComponent();
            InitializeListBox(databases);
        }

        private void InitializeListBox(Database databases)
        {
            foreach (var item in databases)
            {
                listBoxControl1.Items.Add(item.Name);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SetDialogResult(DialogResult.OK);
            if (listBoxControl1.SelectedValue == null)
            {
                SetDialogResult(DialogResult.Cancel);
                Hide();
            }

            if (listBoxControl1.SelectedValue != null) 
                DatabaseName = listBoxControl1.SelectedValue.ToString();
            Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SetDialogResult(DialogResult.Cancel);
            Hide();
        }
    }
}