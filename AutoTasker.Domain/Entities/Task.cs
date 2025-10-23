using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoTasker.Domain.Exceptions;

namespace AutoTasker.Domain.Entities
{
    public class Task
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string? Description { get; private set; }
        public bool IsActive { get; private set; }
        private readonly List<Member> _members = new();
        public IReadOnlyCollection<Member> Members => _members.AsReadOnly();
        private Task() { }
        public static Task Create(string name, string? description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Task name cannot be empty.");
            }
            var task = new Task
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = description,
                IsActive = true
            };

            return task;
        }
        public void UpdateDetails(string newName, string? newDescription)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentNullException(nameof(newName), "Task name cannot be empty.");
            }
            this.Name = newName;
            this.Description = newDescription;
        }

        public void DeactivateTask()
        {
            if (!this.IsActive)
            {
                throw new TaskAlreadyInactiveException(this.Id);
            }

            if (this._members.Any())
            {
                //throw new TaskWithMembersException(this.Id, "Cannot deactivate a task that has members in its rotation. Please remove members first.");
            }

            this.IsActive = false;
        }

        public void AddMember(Member member)
        {
            if (this._members.Any(m => m.Id == member.Id))
            {
               // throw new MemberAlreadyInTaskException(member.Id, this.Id);
            }

            this._members.Add(member);
        }

        public void RemoveMember(Member member)
        {
            var existingMember = this._members.FirstOrDefault(m => m.Id == member.Id);
            if (existingMember == null)
            {
                //throw new MemberNotFoundInTaskException(member.Id, this.Id);
            }

            this._members.Remove(existingMember);
        }
    }
}