
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;
[RAINAction]
public class DeleteMobDetect : RAINAction
{
		public override void Start (RAIN.Core.AI ai)
		{
				base.Start (ai);
		}
		public override ActionResult Execute (RAIN.Core.AI ai)
		{
				GameObject mob = ai.WorkingMemory.GetItem<GameObject> ("detectMob");
				if(mob != null) {
					PlayerController.vieTour--;
				}
				MonoBehaviour.Destroy (mob);
				return ActionResult.SUCCESS;
		}
		public override void Stop (RAIN.Core.AI ai)
		{
				base.Stop (ai);
		}
}