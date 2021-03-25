using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public abstract class Command : IdentifiableObject
    {
        protected Command(string[] idents) : base(idents)
        {
        }
       
    }
}
