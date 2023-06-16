using ReactiveUI;
using System;

namespace sEdit.Framework
{
    public class Interactions
    {
        public static readonly Interaction<Exception, bool> ErrorMessage = new Interaction<Exception, bool>();
    }
}