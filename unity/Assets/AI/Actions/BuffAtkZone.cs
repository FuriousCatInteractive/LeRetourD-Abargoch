using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class BuffAtkZone : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		ai.Senses.GetSensor("BuffAtkZoneSensor").MatchAspectName("aPlayer");
		
		IList<RAIN.Entities.Aspects.RAINAspect> list = ai.Senses.GetSensor("BuffAtkZoneSensor").Matches;
		
		foreach (RAIN.Entities.Aspects.RAINAspect it in list) {
			PlayerController player = (PlayerController)it.MountPoint.transform.GetComponent("PlayerController");
			player.atkBuff = true;
			player.Damage = player.DefaultDamage + ai.WorkingMemory.GetItem<float>("buffAtk");
		}

        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}