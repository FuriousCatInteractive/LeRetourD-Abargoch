using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class DamageZone : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		GameObject mob = ai.WorkingMemory.GetItem<GameObject>("mob");

		ai.Senses.GetSensor("DamageZoneSensor").MatchAspectName("aMob");

		IList<RAIN.Entities.Aspects.RAINAspect> list = ai.Senses.GetSensor("DamageZoneSensor").Matches;

		foreach (RAIN.Entities.Aspects.RAINAspect it in list) {
			Health hp = (Health)it.MountPoint.transform.GetComponent("Health");
			hp.CurrentHealth = hp.CurrentHealth - ai.WorkingMemory.GetItem<int>("damage");
		}

        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}