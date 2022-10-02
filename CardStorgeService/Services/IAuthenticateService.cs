using CardStorgeService.Models;
using CardStorgeService.Models.Requests;

namespace CardStorgeService.Services
{
    public interface IAunthenticateService
    {
        AuthenticationResponse Login(AuthenticationRequest authenticationRequest);
        public SessionInfo GetSessionInfo(string sessionToken);
    }
}
