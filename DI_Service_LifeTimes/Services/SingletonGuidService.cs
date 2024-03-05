namespace DI_Service_LifeTimes.Services
{
    public class SingletonGuidService:ISingletonGuidService
    {
        private Guid guid;
        public SingletonGuidService()
        {
            guid = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return guid.ToString();
        }
    }
}
