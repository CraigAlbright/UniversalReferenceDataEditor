using System.ComponentModel;
using DevExpress.XtraTreeList;

namespace UniversalReferenceDataEditor {
    public class Datatable {
        string _name;
        Database owner;
        Database dataTables;
        bool _isTask;
        public Datatable() {
            owner = null;
            _name = "";
            _isTask = false;
            dataTables = new Database();
        }
        public Datatable(string name, bool isTask) {
            _name = name;
            _isTask = isTask;
            dataTables = new Database();
        }
        public Datatable(Database dts, string name, bool isTask)
            : this(name, isTask) {
                dataTables = dts;
        }
        [Browsable(false)]
        public Database Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public bool IsTask {
            get { return _isTask; }
            set {
                if(_isTask == value) return;
                _isTask = value;
                OnChanged();
            }
        }
        public string Name {
            get { return _name; }
            set {
                if(Name == value) return;
                _name = value;
                OnChanged();
            }
        }
        [Browsable(false)]
        public Database DataTables { get { return dataTables; } }
        void OnChanged() {
            if(owner == null) return;
            var index = owner.IndexOf(this);
            owner.ResetItem(index);
        }
    }
    public class Database : BindingList<Datatable>, TreeList.IVirtualTreeListData {
        void TreeList.IVirtualTreeListData.VirtualTreeGetChildNodes(VirtualTreeGetChildNodesInfo info) {
            var obj = info.Node as Datatable;
            info.Children = obj.DataTables;
        }
        protected override void InsertItem(int index, Datatable item) {
            item.Owner = this;
            base.InsertItem(index, item);
        }
        void TreeList.IVirtualTreeListData.VirtualTreeGetCellValue(VirtualTreeGetCellValueInfo info) {
            var obj = info.Node as Datatable;
            switch(info.Column.Name) {
                case "colName":
                    info.CellData = obj.Name;
                    break;
            }
        }
        void TreeList.IVirtualTreeListData.VirtualTreeSetCellValue(VirtualTreeSetCellValueInfo info) {
            var obj = info.Node as Datatable;
            switch(info.Column.Caption) {
                case "Name":
                    obj.Name = (string)info.NewCellData;
                    break;
            }
        }
    }
}
