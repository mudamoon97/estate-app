namespace EstateApp.Data.DatabaseContests.AuthenticationDBContests
{
    public class AuthenticationDBContests : identityDBContests<Applicationuser>
    {
        public AuthenticationDBContests(DBContestsOptions<AuthenticationDBContest> options ) 
            : class (options)
        {
        }

    }
}