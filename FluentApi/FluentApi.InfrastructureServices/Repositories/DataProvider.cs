using FluentApi.Infrastructure.Interfaces;
using FluentApi.Infrastructure.Models;
using System.Collections.Generic;
using System.Linq;

namespace FluentApi.InfrastructureServices.Repositories
{
    public class DataProvider : IDataProvider
    {
        public List<InfrastructureUser> users = new List<InfrastructureUser>()
        {
            new InfrastructureUser() { Name = "Денис", Role = "Admin", Sex = "М", Age = 20},
            new InfrastructureUser() { Name = "Александр", Role = "Admin", Sex = "М", Age = 21},
            new InfrastructureUser() { Name = "Арсений", Role = "Admin", Sex = "М", Age = 22},
            new InfrastructureUser() { Name = "Виктория", Role = "Admin", Sex = "Ж", Age = 25},
            new InfrastructureUser() { Name = "Андрей", Role = "Admin", Sex = "М", Age = 20},
            new InfrastructureUser() { Name = "Дмитрий", Role = "Admin", Sex = "М", Age = 40},
            new InfrastructureUser() { Name = "Евгений", Role = "Admin", Sex = "М", Age = 33},
            new InfrastructureUser() { Name = "Юрий", Role = "Admin", Sex = "М", Age = 21}
        };

        public List<InfrastructureDevice> devices = new List<InfrastructureDevice>()
        {
            new InfrastructureDevice() {Name = "Phone", UserId = 1},
            new InfrastructureDevice() {Name = "Computer", UserId = 1},
            new InfrastructureDevice() {Name = "Phone", UserId = 2},
            new InfrastructureDevice() {Name = "Computer", UserId = 2},
            new InfrastructureDevice() {Name = "Phone", UserId = 3},
            new InfrastructureDevice() {Name = "Computer", UserId = 3},
            new InfrastructureDevice() {Name = "Phone", UserId = 4},
            new InfrastructureDevice() {Name = "Computer", UserId = 4},
            new InfrastructureDevice() {Name = "Phone", UserId = 5},
            new InfrastructureDevice() {Name = "Phone", UserId = 6},
            new InfrastructureDevice() {Name = "Computer", UserId = 6},
            new InfrastructureDevice() {Name = "Computer", UserId = 7},
            new InfrastructureDevice() {Name = "Phone", UserId = 8}
        };

        public IList<InfrastructureUser> GetUsers()
        {
            return users.ToList();
        }

        public IList<InfrastructureDevice> GetDevices()
        {
            return devices.ToList();
        }
    }
}
