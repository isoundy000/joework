using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Soldier_BTSoldierPro_node429 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			uint objID = (uint)pAgent.GetVariable(1128863647u);
			int range = (int)pAgent.GetVariable(1944425156u);
			bool flag = ((ObjAgent)pAgent).IsDistanceToActorMoreThanRange(objID, range);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}
	}
}
