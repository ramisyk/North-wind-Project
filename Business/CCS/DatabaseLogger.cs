namespace Business.CCS
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Veritabanına Loglandı");
        }
    }
}
