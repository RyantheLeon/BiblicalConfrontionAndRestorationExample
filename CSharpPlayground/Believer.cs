using Action = BiblicalConfrontationAndRestoration;

namespace BiblicalConfrontationAndRestoration;

public class Believer : Person
{
    public Relationship React(Action action) 
    { 
        if (action.Actor.IsBeliever() && action.IsSin() && action.Recipient == this) 
        { 
            if (Confront([this], action.Actor).Confessed 
                || Confront([this, ..action.Witnesses], action.Actor).Confessed 
                || Confront([this, ..action.Recipient.Church], action.Actor).Confessed)
            { 
                return Relationship.Restored; 
            } 
            return Relationship.Disassociated; 
        } 
        throw new NotImplementedException("Other situations not defined"); 
    }

    public Reaction Confront(Person[] confronter, Person confrontee)
    {
        throw new NotImplementedException();
    }
}
