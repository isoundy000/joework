using Assets.Scripts.GameLogic;
using ResData;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Hero_HeroLowAI_node346 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			RES_LEVEL_HEROAITYPE mapAIMode = ((ObjAgent)pAgent).GetMapAIMode();
			RES_LEVEL_HEROAITYPE rES_LEVEL_HEROAITYPE = 3;
			bool flag = mapAIMode == rES_LEVEL_HEROAITYPE;
			return (!flag) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}
	}
}
