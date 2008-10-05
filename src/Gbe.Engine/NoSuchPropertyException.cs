using System;

namespace Gbe.Engine
{
    public class NoSuchPropertyException : ApplicationException
    {
        private readonly string _propertyName;

        public NoSuchPropertyException(string propertyName) : base("No such property: " + propertyName)
        {
            _propertyName = propertyName;
        }

        public string PropertyName
        {
            get { return _propertyName; }
        }
    }
}
