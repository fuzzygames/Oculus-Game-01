// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;
using Ovr;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("OVR")]
	[Tooltip("Recenters the HMD.")]
	public class OvrResetOrientation : FsmStateAction
	{
		public override void OnEnter()
		{
			OVRManager.display.RecenterPose();
			Finish ();
		}
	}
}