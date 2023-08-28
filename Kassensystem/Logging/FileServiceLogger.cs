namespace Kassensystem.DAL
{
    public class FileServiceLogger : IServiceLogger
    {
        public void Log(string message)
        {
            File.AppendAllText(@"C:\Users\dustin.dyckmanns\source\repos\Kassensystem\Kassensystem\ServiceLoggings\ServiceLoggings.txt", message+"\n");
        }
    }
}
