﻿using System.Collections.Generic;
using Gbe.Compiler.Triggers;

namespace Gbe.Compiler.Entities
{
    public class EngineEntity : Entity
    {
        public const string ENGINE_CLASSNAME = "Engine";

        public EngineEntity(List<Trigger> triggers)
            : base(ENGINE_CLASSNAME, null, triggers)
        {
        }

        public override string EntityType
        {
            get { return "ENGINE"; }
        }
    }
}
