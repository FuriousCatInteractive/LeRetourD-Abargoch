using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class hitTarget : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		GameObject target = ai.WorkingMemory.GetItem<GameObject>("varSkeleton");
		Health hp = (Health)target.GetComponent("Health");
		hp.CurrentHealth = hp.CurrentHealth - ai.WorkingMemory.GetItem<int>("damage");

        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}