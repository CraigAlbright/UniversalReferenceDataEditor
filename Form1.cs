using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using CraigLib;
using CraigLib.Data;
using DevExpress.XtraEditors;
using System.Configuration;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTreeList;


namespace UniversalReferenceDataEditor
{
    public partial class Form1 : XtraForm
    {
        readonly string _conString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        private string _currentDatabase = string.Empty;
        private string _currentTableName = string.Empty;
        
        public Form1()
        {
            InitializeComponent();
            InitTreeListControl();
            InitGrid();

        }
        void InitTreeListControl()
        {
            var projects = InitData();
            DataBinding(projects);
            treeList.AfterFocusNode += TreeListTableClicked;
        }

        private void TreeListTableClicked(object sender, NodeEventArgs e)
        {
            if(e.Node.ParentNode == null)
                return;
            var column = treeList.Columns[0];
            var nodeText = e.Node[column].ToString();
            var databaseName = e.Node.ParentNode[column].ToString();
            var dt = new DataTable();
            var sql = "select top 1000 * from " + nodeText;
            using (var sqlCon = new SqlConnection(_conString))
            {
                sqlCon.Open();
                sqlCon.ChangeDatabase(databaseName);
                _currentDatabase = databaseName;
                _currentTableName = nodeText;
                DatabaseHelper.FillDataTable(dt, sql, sqlCon);
                gridControl.DataBindings.Clear();
                gridView1.Columns.Clear();
                gridControl.DataSource = dt;
                dt.ExtendedProperties.Add("SelectSql",sql);
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    gridView1.Columns.Add(new GridColumn() {Caption = dataColumn.Caption});
                }
                gridView1.BestFitColumns();
                var keys = dt.PrimaryKey;
                foreach (var dataColumn in keys)
                {
                    gridView1.Columns[dataColumn.ColumnName].OptionsColumn.AllowEdit = false;
                    gridView1.Columns[dataColumn.ColumnName].AppearanceCell.BackColor = Color.Gray;
                    //gridView1.Columns[dataColumn.ColumnName].
                }
            }
        }

        Database InitData()
        {
            var databaseList = new Database();
            using (var sqlCon = new SqlConnection(_conString))
            {
                sqlCon.Open();
                var databases = sqlCon.GetSchema("Databases");
                
                foreach (DataRow row in databases.Rows)
                {
                    var dbName = row["database_name"].ToString();
                    databaseList.Add(new Datatable(dbName, false));
                }
                foreach (var db in databaseList)
                {
                    var serverConnection = new Microsoft.SqlServer.Management.Common.ServerConnection(sqlCon);
                    var server = new Microsoft.SqlServer.Management.Smo.Server(serverConnection);
                    var database = server.Databases[db.Name];
                    foreach (Microsoft.SqlServer.Management.Smo.Table table in database.Tables)
                    {
                        var currentDb = databaseList.FirstOrDefault(x => x.Name == table.Parent.Name);
                        if(currentDb == null)
                            continue;
                        currentDb.DataTables.Add(new Datatable(table.Name, false));
                    }
                }
            }
            return databaseList;
        }
        void DataBinding(Database projects)
        {
            treeList.ExpandAll();
            treeList.DataSource = projects;
            treeList.BestFitColumns();
        }
        void InitGrid()
        {
            
        }

        private void ApplyChanges(object sender, EventArgs e)
        {
            var dataTable = gridControl.DataSource as DataTable;
           
            if(dataTable == null)
                return;
            dataTable.TableName = _currentTableName;
            var changes = dataTable.GetChanges();
            if(changes == null)
                return;
            var conInfo = new ConnectionInfo(_conString) {Database = _currentDatabase};
            using (var adapter = new DatabaseAdapter(conInfo))
            {
                adapter.Update(dataTable, false);
            }
        }

    }
}