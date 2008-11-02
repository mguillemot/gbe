using System;

namespace Gbe.Script
{
    public class SyntaxException : ApplicationException
    {
        public SyntaxException(string classdef, string message)
            : base(classdef + ": " + message)
        {
        }
    }
}
