namespace VaFoConnect.Client.Console
{
    public class ConsoleManager
    {
        #region [ Fields ]
        #endregion

        #region [ Properties ]
        #endregion

        #region [ Constructors ]
        public ConsoleManager()
        {
        }
        #endregion

        #region [ Public Methods ]
        public void Display(string text)
        {
            System.Console.WriteLine(text);
        }

        public string Read()
        {
            return System.Console.ReadLine();
        }
        #endregion

        #region [ Private Methods ]
        #endregion
    }
}