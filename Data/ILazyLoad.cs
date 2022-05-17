namespace UniversalReferenceDataEditor.Data
{
   
    public interface ILazyLoad
    {
        void SetHighWaterMark(int rowNumber);
        int GetHighWaterMark();

        void RetrieveNext();

    }
}
