namespace DI_Service_LifeTimes.Services
{
    public class TransientGuidService:ITransientGuidService
    {
        private Guid guid;
        public TransientGuidService()
        {
            guid = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return guid.ToString();
        }
    }
}
