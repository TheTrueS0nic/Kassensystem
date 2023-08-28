namespace Kassensystem.DAL
{
    public class ConsoleServiceLogger : IServiceLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
