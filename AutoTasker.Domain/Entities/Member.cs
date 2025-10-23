using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AutoTasker.Domain.Entities
{
    public class Member
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool IsActive { get; private set; }

        private Member() { }

        public static Member Create(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Member name cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException(nameof(email), "Member email cannot be empty.");
            }
            if (!email.Contains("@"))
            {
                throw new ArgumentException("Member email is not a valid format.", nameof(email));
            }
            Member member = new Member
            {
                Id = Guid.NewGuid(),
                Name = name,
                Email = email.ToLower(),
                IsActive = true
            };

            return member;
        }
        public void Deactivate()
        {
            this.IsActive = false;
        }
        public void UpdateName(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentNullException(nameof(newName), "Member name cannot be empty.");
            }
            this.Name = newName;
        }
    }
}