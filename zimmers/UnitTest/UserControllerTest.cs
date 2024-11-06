using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.Controllers;
using zimmers.Entities;

namespace UnitTest
{
    public class UserControllerTest
    {
        [Fact]
        public void GetAll_ReturnListOfUsers()
        {
            var controller = new UserController();
            var result = controller.Get();
            Assert.IsType<ActionResult<IEnumerable<User>>>(result);
            //Assert.NotNull(result);
        }
        [Fact]
        public void Get_ReturnUsers()
        {
            var id = 1;
            var controller = new UserController();
            var result = controller.Get(id);
            Assert.IsType<ActionResult<User>>(result);
        }
        [Fact]
        public void Post()
        {
            User obj = new User("327868998", "as", "l", "1", "q", new DateTime(), 12, 1, 12);
            var controller = new UserController();
            bool result = controller.Post(obj).Value;
            Assert.True(result);
        }
        [Fact]
        public void Put()
        {
            var id = 5;
            User obj = new User("327868998", "as", "l", "1", "q", new DateTime(), 12, 1, 12);
            var controller = new UserController();
            bool result = controller.Put(id,obj).Value;
            Assert.False(result);
        }
    }
}
