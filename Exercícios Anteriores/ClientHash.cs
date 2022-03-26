using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class ClientHash
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is ClientHash))
            {
                return false;
            }
            ClientHash other = obj as ClientHash;
            return Email.Equals(other.Email);
        }
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
