using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixtures
    {
        public static List<User> GetTestUsers() => new()
        {
                new User
                {
                    Id = 1,
                    Name = "Test User 1",
                    Adress = new Address()
                    {
                        Street = "123 Main St",
                        City = "Madison",
                        ZipCode = "153704"

                    },
                    Email="test.user.1@example.com"
                },
                new User
                {
                    Id = 2,
                    Name = "Test User 2",
                    Adress = new Address()
                    {
                        Street = "234 Main St",
                        City = "Madison",
                        ZipCode = "253704"

                    },
                    Email="test.user.2@example.com"
                },
                new User
                {
                    Id = 3,
                    Name = "Test User 3",
                    Adress = new Address()
                    {
                        Street = "345 Main St",
                        City = "Madison",
                        ZipCode = "353704"

                    },
                    Email="test.user.3@example.com"
                }
        };

    }
}
