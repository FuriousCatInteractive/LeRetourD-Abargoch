using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;
using RAIN.Memory;

[RAINAction]
public class testAI : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		Transform preFab = ai.WorkingMemory.GetItem<Transform>("skeletonPrefab");
		Health hp = (Health)ai.Body.GetComponent("Health");

		if(hp.CurrentHealth <= 0) {
			ai.WorkingMemory.SetItem<bool>("dead", true);
		}

        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}