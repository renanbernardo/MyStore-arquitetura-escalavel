using MyStore.Domain.Account.Entities;
using Xunit;

namespace MyStore.Domain.Tests.Account
{
    public class UserTests
    {
        [Fact]
        public void CanActivateUserTest()
        {
            var user = new User();

            user.Active = true;

            if (user.Verified)
            {
                // user Repository.Save(user);
            }
        }
    }
}
