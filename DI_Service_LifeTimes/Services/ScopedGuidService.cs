namespace DI_Service_LifeTimes.Services
{
    public class ScopedGuidService : IScopedGuidService
    {
        private Guid guid;
        public ScopedGuidService()
        {
            guid = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return guid.ToString();
        }
    }
}
