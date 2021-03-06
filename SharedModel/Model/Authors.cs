﻿using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public partial class Authors:IPermission
    {
        public Authors()
        {
            Articles = new HashSet<Articles>();
            Comments = new HashSet<Comments>();
        }

        [HideColumnIfAutoGenerated()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public string Description { get; set; }
        public int? SecurityLabel { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} {MiddleName} Возраст - {Age}";
        }

        [HideColumnIfAutoGenerated()]
        public virtual SecurityLabels SecurityLabelNavigation { get; set; }
        [HideColumnIfAutoGenerated()]
        public virtual ICollection<Articles> Articles { get; set; }
        [HideColumnIfAutoGenerated()]
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
