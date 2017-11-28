using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{
    public enum TransitionStates : short
    {
        None = 0,
        Failed = 1
    }

    public class LearningActivityRelation
    {
        public int RelationId { get; set; }

        public bool IsMandatory { get; set; }

        public int AccessOrder { get; set; }

        public int DisplayOrder { get; set; }

        public TransitionStates TransitionState { get; set; }
        
        public int ParentRelationId { get; set; }

        public int ParentContainerId { get; set; }

        public string HierarchyPath { get; set; }
    }
}
