using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class HealZone : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		ai.Senses.GetSensor("HealZoneSensor").MatchAspectName("aPlayer");
		
		IList<RAIN.Entities.Aspects.RAINAspect> list = ai.Senses.GetSensor("HealZoneSensor").Matches;
		
		foreach (RAIN.Entities.Aspects.RAINAspect it in list) {
			Health hp = (Health)it.MountPoint.transform.GetComponent("Health");
			if(hp.CurrentHealth < hp.MaxHealth) {
				float newHp = hp.CurrentHealth + ai.WorkingMemory.GetItem<float>("healing");
				if(newHp > hp.MaxHealth) {
					hp.CurrentHealth = hp.MaxHealth;
				}
				else {
					hp.CurrentHealth = newHp;
				}
			}
		}

        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}