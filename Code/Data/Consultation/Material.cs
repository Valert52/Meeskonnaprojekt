using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Data.Common;

namespace Abc.Data.Consultation;

    public class Material: NamedEntity
{
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Description { get; set; }
    }

