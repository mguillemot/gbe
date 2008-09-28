using System;

namespace Gbe.Engine
{
    public abstract class EntityState : ICloneable
    {
        #region ICloneable Members

        public abstract object Clone();

        #endregion
    }
}