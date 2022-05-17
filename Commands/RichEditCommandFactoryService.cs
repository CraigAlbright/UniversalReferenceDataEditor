using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.Services;
using UniversalReferenceDataEditor.Dialogs;

namespace UniversalReferenceDataEditor.Commands
{
    public class CustomRichEditCommandFactoryService : IRichEditCommandFactoryService
    {
        readonly IRichEditCommandFactoryService service;
        readonly RichEditControl control;
        public CustomRichEditCommandFactoryService(RichEditControl control, IRichEditCommandFactoryService service)
        {
            DevExpress.Utils.Guard.ArgumentNotNull(control, "control");
            DevExpress.Utils.Guard.ArgumentNotNull(service, "service");
            this.control = control;
            this.service = service;
        }
        public RichEditCommand CreateCommand(RichEditCommandId id)
        {
            if (id == RichEditCommandId.FileSaveAs)
            {
                return new CustomSaveDocumentAsCommand(control);
            }
            if (id == RichEditCommandId.FileSave)
            {
                return new CustomSaveDocumentCommand(control);
            }

            return id == RichEditCommandId.FileOpen ? new CustomOpenDocumentCommand(control) : service.CreateCommand(id);
        }
    }
}
