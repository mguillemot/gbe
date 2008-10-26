using System;
using System.Collections.Generic;
using Gbe.Script.Classdefs;

namespace Gbe.Script
{
    public class Gbs
    {
        private readonly List<Classdef> _classdefs;

        public Gbs(List<Classdef> classdefs)
        {
            _classdefs = classdefs;
        }

        public List<Classdef> Classdefs
        {
            get { return _classdefs; }
        }

        public CompiledGbs Compile()
        {
            var compiled = new CompiledGbs();
            foreach (var classdef in _classdefs)
            {
                if (compiled.GetClassdef(classdef.ClassName) == null)
                {
                    classdef.Compile();
                    compiled.AddClassdef(classdef);
                    if (!classdef.Check())
                    {
                        return null;
                    }
                }
                else
                {
                    Console.Error.WriteLine("Duplicate entity: " + classdef.ClassName);
                    return null;
                }
            }
            if (compiled.GetEngineClassdef() == null)
            {
                Console.Error.WriteLine("No ENGINE entity.");
                return null;
            }
            if (compiled.GetPlayerClassdefCount() == 0)
            {
                Console.Error.WriteLine("No PLAYER entity.");
                return null;
            }
            return compiled;
        }
    }
}