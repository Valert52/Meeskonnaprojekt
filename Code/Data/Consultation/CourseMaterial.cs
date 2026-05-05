using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Data.Common;

namespace Abc.Data.Consultation;

    public class CourseMaterial:BaseEntity
    {
        public int CourseId { get; set; }

        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public Course Course { get; set; }
    }

