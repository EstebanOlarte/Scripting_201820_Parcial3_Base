using UnityEngine;

public class ExampleTask : Task
{
    [SerializeField]
    private bool testSucceeded;

    public override bool Execute()
    {
        print("hi");
        return testSucceeded;
    }
}