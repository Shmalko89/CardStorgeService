using CardStorgeService.Models;
using CardStorgeService.Models.Requests;

namespace CardStorgeService.Services.Impl
{
    public class AuthenticationService : IAunthenticateService 
    {
        public SessionInfo GetSessionInfo(string sessionToken)
        {
            throw new NotImplementedException();
        }

        public AuthenticationResponse Login(AuthenticationRequest authenticationRequest)
        {
            throw new NotImplementedException();
        }
    }
}
