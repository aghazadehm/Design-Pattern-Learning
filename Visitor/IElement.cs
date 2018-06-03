using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IElement
    {
        void Accept(IElementVisitor visitor);
    }
}
