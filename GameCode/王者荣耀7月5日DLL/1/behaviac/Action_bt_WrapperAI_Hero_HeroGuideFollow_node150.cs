using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Action_bt_WrapperAI_Hero_HeroGuideFollow_node150 : Action
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			return ((ObjAgent)pAgent).CanMove();
		}
	}
}
