using System;
using System.Collections.Generic;
using Gbe.Script.Classdefs;

namespace Gbe.Script
{
    public class Gbs
    {
        private readonly List<Classdef> _entities;

        public Gbs(List<Classdef> entities)
        {
            _entities = entities;
        }

        public List<Classdef> Entities
        {
            get { return _entities; }
        }

        public CompiledGbs Compile()
        {
            var compiled = new CompiledGbs();
            foreach (var entity in _entities)
            {
                if (compiled.GetClassdef(entity.ClassName) == null)
                {
                    compiled.AddClassdef(entity);
                    if (!entity.Check())
                    {
                        return null;
                    }
                }
                else
                {
                    Console.Error.WriteLine("Duplicate entity: " + entity.ClassName);
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