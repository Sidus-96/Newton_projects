namespace GreenThumb.Manager
{
    public class UserManager
    {
        public static int SignedInUser { get; set; }

        public static void setUserId(int id)
        {
            SignedInUser = id;
        }
    }
}
