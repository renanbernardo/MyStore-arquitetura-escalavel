using MyStore.Domain.Account.Entities;
using Xunit;

namespace MyStore.Domain.Tests.Account
{
    public class UserTests
    {
        [Fact] 
        public void VerificaUsuario()
        {
            var verificationCode = "NADA"; // Debugar e colocar o Verification Code gerado ao instanciar
            var user = new User("renanbernardo", "123456");
            user.Verify(verificationCode);

            Assert.True(user.Verified);
        }
     
    }
}
