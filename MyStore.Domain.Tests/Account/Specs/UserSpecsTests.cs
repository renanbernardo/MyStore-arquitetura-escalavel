using MyStore.Domain.Account.Entities;
using MyStore.Domain.Account.Scopes;
using MyStore.Domain.Account.Specs;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Categories;

namespace MyStore.Domain.Tests.Account.Specs
{
    public class UserSpecsTests
    {
        private List<User> _users;

        public UserSpecsTests()
        {
            _users = new List<User>();

            _users.Add(new User("teste00@teste.com", "teste00", "123456"));
            _users.Add(new User("teste01@teste.com", "teste01", "123456"));
            _users.Add(new User("teste02@teste.com", "teste02", "123456"));
            _users.Add(new User("teste03@teste.com", "teste03", "123456"));
            _users.Add(new User("teste04@teste.com", "teste04", "123456"));
        }

        [Fact]
        [Category("User - Specs")]
        public void GetByUsernameShouldReturnValue()
        {
            var user = _users
                .AsQueryable()
                .Where(UserSpecs.GetByUsername("teste00"))
                .FirstOrDefault();

            Assert.NotNull(user);
        }

        [Fact]
        [Category("User - Specs")]
        public void GetByUsernameShouldNotReturnValue()
        {
            var user = _users
                .AsQueryable()
                .Where(UserSpecs.GetByUsername("teste9999"))
                .FirstOrDefault();

            Assert.Null(user);
        }
    }
}
