namespace SimASM
{
    public static class Settings
    {
        public static bool IfMakeCom = true;
        public static string WorkDir = InitDir();
        private static string InitDir()
        {
            return Application.StartupPath + "bin\\";
        }
    }
}
    