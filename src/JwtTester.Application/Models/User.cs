using System;
using System.Collections.Generic;
using Flunt.Notifications;
using Newtonsoft.Json;

namespace JwtTester.Application.Models
{
    public class User : Notifiable
    {
        private readonly IList<string> roles = new List<string>();
        private readonly IList<string> permissions = new List<string>();

        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }
        public string Email { get; }
        public IEnumerable<string> Roles => this.roles;
        public IEnumerable<string> Permissions => this.permissions;

        [JsonIgnore]
        public Password Password { get; private set; }
    }
}
