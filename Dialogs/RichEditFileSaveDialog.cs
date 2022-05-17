using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.Services;

namespace UniversalReferenceDataEditor.Dialogs
{
    public class CustomSaveDocumentAsCommand : SaveDocumentAsCommand
    {
        public CustomSaveDocumentAsCommand(IRichEditControl control)
            : base(control) { }
 
        protected override void ExecuteCore()
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*",
                FileName = "File 1.sql",
                RestoreDirectory = true,
                CheckFileExists = false,
                CheckPathExists = true,
                OverwritePrompt = true,
                DereferenceLinks = true,
                ValidateNames = true,
                AddExtension = false,
                FilterIndex = 1,
                InitialDirectory = Application.ExecutablePath
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ((RichEditControl)Control).SaveDocument(dialog.FileName, DocumentFormat.PlainText);
            }
            //base.ExecuteCore();
        }

        
    }

    public class CustomSaveDocumentCommand : SaveDocumentCommand
    {
        public CustomSaveDocumentCommand(IRichEditControl richEdit) : base(richEdit) { }

        protected override void ExecuteCore()
        {
            base.ExecuteCore();
            if (!DocumentServer.Modified)
            {
                MessageBox.Show("Document is saved successfully");
            }
        }
    }

    public class CustomOpenDocumentCommand : LoadDocumentCommand
    {
        public CustomOpenDocumentCommand(IRichEditControl richEdit) : base(richEdit) { }

        protected override void ExecuteCore()
        {
            base.ExecuteCore();
            var dialog = new OpenFileDialog
            {
                Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*",
                FileName = "File 1.sql",
                RestoreDirectory = true,
                CheckFileExists = false,
                CheckPathExists = true,
                DereferenceLinks = true,
                ValidateNames = true,
                AddExtension = false,
                FilterIndex = 1,
                InitialDirectory = Application.ExecutablePath
            };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            var stream = dialog.OpenFile();
            var format = ((RichEditControl) Control).GetService<IFormatDetectorService>()
                .DetectFormat(stream);
            ((RichEditControl) Control).LoadDocument(stream, format);
        }
    }
}
