namespace crud_c_sharp_sqlite;

internal static class Inicio
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    // Início.
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new formEstudante());
    }
}