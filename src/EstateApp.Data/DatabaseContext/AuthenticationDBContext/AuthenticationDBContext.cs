namespace EstateApp.Data.DatabaseContext.AuthenticationDBContext
{
    public class AuthenticationDBContext : identityDBContext<Applicationuser>
    {
        public AuthenticationDBContext(DBContextOptions<AuthenticationDBContext> options ) 
            : base (options)
        {
        }

    }
}