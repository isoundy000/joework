using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Action_bt_WrapperAI_Monster_BTMonsterPassiveThief_node19 : Action
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			return ((ObjAgent)pAgent).CanMove();
		}
	}
}
