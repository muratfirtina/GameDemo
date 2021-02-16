using System;
using GameDemo.Abstract;

namespace GameDemo.Entities
{
    public class Gamer : IEntitiy
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
