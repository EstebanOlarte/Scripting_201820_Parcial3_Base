using UnityEngine;

/// <summary>
/// Selector that succeeeds if ControlledAI is marked as 'tagged'
/// </summary>
public class ActorIsTagged : Selector
{

    [SerializeField]
    AIController aiControl;


    

    protected override bool CheckCondition()
    {
        print("revisé si hay tag");
        return true;

        //return base.CheckCondition();
    }
}