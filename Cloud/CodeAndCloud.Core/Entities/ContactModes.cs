using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAndCloud.Core.Entities
{
    class ContactModes
    {
        public virtual  string Email { get; set; }
        public virtual string Name { get; set; }

        public virtual string PhoneNumber { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual bool IsAnswer { get; set; }

    }
}
