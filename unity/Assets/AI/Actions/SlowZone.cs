using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class SlowZone : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		GameObject mob = ai.WorkingMemory.GetItem<GameObject>("mob");
		
		ai.Senses.GetSensor("SlowZoneSensor").MatchAspectName("aMob");
		
		IList<RAIN.Entities.Aspects.RAINAspect> list = ai.Senses.GetSensor("SlowZoneSensor").Matches;
		
		foreach (RAIN.Entities.Aspects.RAINAspect it in list) {
			AIRig aiMob = it.MountPoint.GetComponentsInChildren<AIRig>()[0];
			aiMob.AI.Motor.DefaultSpeed = 2;

			//Transform aiMob = (Transform)it.MountPoint;
		}

        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}