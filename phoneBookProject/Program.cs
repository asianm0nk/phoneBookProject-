namespace phoneBookProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Form1 form = new Form1();
            Controller controller = new Controller(form);

            Application.Run(form);
        }
    }
}