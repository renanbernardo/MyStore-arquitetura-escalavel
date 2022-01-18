using MyStore.Domain.Account.Entities;
using MyStore.Domain.Account.Scopes;
using Xunit;
using Xunit.Categories;

namespace MyStore.Domain.Tests.Account
{
    public class UserScopeTests
    {
        [Fact] 
        [Category("User - Scopes")]
        public void RegisterScopeIsValid()
        {
            var user = new User("renan.brnrd@gmail.com", "renanbernardo", "123456");
            Assert.True(user.RegisterScopeIsValid());
        }

        [Fact]
        [Category("User - Scopes")]
        public void RegisterScopeIsInvalidWhenUsernameIsNull()
        {
            var user = new User("renan.brnrd@gmail.com", "", "123456");
            Assert.False(user.RegisterScopeIsValid());
        }

        [Fact]
        [Category("User - Scopes")]
        public void VerificationScopeIsValid()
        {
            var user = new User("renan.brnrd@gmail.com", "renanbernardo", "123456");
            var verificationCode = user.VerificationCode;
            Assert.True(user.VerificationScopeIsValid(verificationCode));
        }

        [Fact]
        [Category("User - Scopes")]
        public void VerificationScopeIsInvalid()
        {
            var user = new User("renan.brnrd@gmail.com", "renanbernardo", "123456");
            var verificationCode = "123456";
            Assert.False(user.VerificationScopeIsValid(verificationCode));
        }

        // TO-DO TESTAR REQUESTLOGINSCOPEISVALID
    }
}
