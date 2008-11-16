using Gbe.Script.Formulas;
using Gbe.Script.Shapes;

namespace Gbe.Script.Shapedefs
{
    public abstract class Shapedef
    {
        public abstract Shape NewInstance(EvaluationContext context);

        public abstract Shapedef Compile();
    }
}
