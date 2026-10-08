using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CSharpPlayground;

public class Action
{
    public Person Actor;
    public Person Recipient;
    public Person[] Witnesses;
    public bool IsSin() => true;
}
