namespace Sistem_Perpustakaan.Model
{
    public static class Session
    {
        public static int CurrentUserId { get; set; }
        public static string CurrentUsername { get; set; }
        public static string CurrentFullName { get; set; }
        public static string CurrentRole { get; set; }

        public static void Clear()
        {
            CurrentUserId = 0;
            CurrentUsername = null;
            CurrentFullName = null;
            CurrentRole = null;
        }
    }
}
