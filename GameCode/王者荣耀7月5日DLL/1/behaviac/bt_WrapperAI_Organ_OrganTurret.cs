using System;

namespace behaviac
{
	public static class bt_WrapperAI_Organ_OrganTurret
	{
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("WrapperAI/Organ/OrganTurret");
			bt.AddPar("Assets.Scripts.GameLogic.SkillSlotType", "p_curSlotType", "SLOT_SKILL_0", string.Empty);
			bt.AddPar("uint", "p_targetID", "0", string.Empty);
			bt.AddPar("int", "p_srchRange", "0", string.Empty);
			bt.AddPar("UnityEngine.Vector3", "p_AttackMoveDest", "{kEpsilon=0;x=0;y=0;z=0;}", string.Empty);
			bt.AddPar("bool", "p_IsAttackMove_Attack", "false", string.Empty);
			bt.AddPar("bool", "p_AttackIsFinished", "true", string.Empty);
			bt.AddPar("uint", "p_CmdID", "0", string.Empty);
			bt.AddPar("UnityEngine.Vector3", "p_attackPathCurTargetPos", "{kEpsilon=0;x=0;y=0;z=0;}", string.Empty);
			DecoratorLoop_bt_WrapperAI_Organ_OrganTurret_node14 decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node = new DecoratorLoop_bt_WrapperAI_Organ_OrganTurret_node14();
			decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node.SetClassNameString("DecoratorLoop");
			decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node.SetId(14);
			bt.AddChild(decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node);
			SelectorLoop selectorLoop = new SelectorLoop();
			selectorLoop.SetClassNameString("SelectorLoop");
			selectorLoop.SetId(1);
			decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node.AddChild(selectorLoop);
			WithPrecondition withPrecondition = new WithPrecondition();
			withPrecondition.SetClassNameString("WithPrecondition");
			withPrecondition.SetId(11);
			selectorLoop.AddChild(withPrecondition);
			Or or = new Or();
			or.SetClassNameString("Or");
			or.SetId(0);
			withPrecondition.AddChild(or);
			Condition_bt_WrapperAI_Organ_OrganTurret_node12 condition_bt_WrapperAI_Organ_OrganTurret_node = new Condition_bt_WrapperAI_Organ_OrganTurret_node12();
			condition_bt_WrapperAI_Organ_OrganTurret_node.SetClassNameString("Condition");
			condition_bt_WrapperAI_Organ_OrganTurret_node.SetId(12);
			or.AddChild(condition_bt_WrapperAI_Organ_OrganTurret_node);
			or.SetHasEvents(or.HasEvents() | condition_bt_WrapperAI_Organ_OrganTurret_node.HasEvents());
			Condition_bt_WrapperAI_Organ_OrganTurret_node26 condition_bt_WrapperAI_Organ_OrganTurret_node2 = new Condition_bt_WrapperAI_Organ_OrganTurret_node26();
			condition_bt_WrapperAI_Organ_OrganTurret_node2.SetClassNameString("Condition");
			condition_bt_WrapperAI_Organ_OrganTurret_node2.SetId(26);
			or.AddChild(condition_bt_WrapperAI_Organ_OrganTurret_node2);
			or.SetHasEvents(or.HasEvents() | condition_bt_WrapperAI_Organ_OrganTurret_node2.HasEvents());
			Condition_bt_WrapperAI_Organ_OrganTurret_node27 condition_bt_WrapperAI_Organ_OrganTurret_node3 = new Condition_bt_WrapperAI_Organ_OrganTurret_node27();
			condition_bt_WrapperAI_Organ_OrganTurret_node3.SetClassNameString("Condition");
			condition_bt_WrapperAI_Organ_OrganTurret_node3.SetId(27);
			or.AddChild(condition_bt_WrapperAI_Organ_OrganTurret_node3);
			or.SetHasEvents(or.HasEvents() | condition_bt_WrapperAI_Organ_OrganTurret_node3.HasEvents());
			withPrecondition.SetHasEvents(withPrecondition.HasEvents() | or.HasEvents());
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(86);
			withPrecondition.AddChild(sequence);
			Action_bt_WrapperAI_Organ_OrganTurret_node140 action_bt_WrapperAI_Organ_OrganTurret_node = new Action_bt_WrapperAI_Organ_OrganTurret_node140();
			action_bt_WrapperAI_Organ_OrganTurret_node.SetClassNameString("Action");
			action_bt_WrapperAI_Organ_OrganTurret_node.SetId(140);
			sequence.AddChild(action_bt_WrapperAI_Organ_OrganTurret_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_WrapperAI_Organ_OrganTurret_node.HasEvents());
			Action_bt_WrapperAI_Organ_OrganTurret_node88 action_bt_WrapperAI_Organ_OrganTurret_node2 = new Action_bt_WrapperAI_Organ_OrganTurret_node88();
			action_bt_WrapperAI_Organ_OrganTurret_node2.SetClassNameString("Action");
			action_bt_WrapperAI_Organ_OrganTurret_node2.SetId(88);
			sequence.AddChild(action_bt_WrapperAI_Organ_OrganTurret_node2);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_WrapperAI_Organ_OrganTurret_node2.HasEvents());
			Action_bt_WrapperAI_Organ_OrganTurret_node91 action_bt_WrapperAI_Organ_OrganTurret_node3 = new Action_bt_WrapperAI_Organ_OrganTurret_node91();
			action_bt_WrapperAI_Organ_OrganTurret_node3.SetClassNameString("Action");
			action_bt_WrapperAI_Organ_OrganTurret_node3.SetId(91);
			sequence.AddChild(action_bt_WrapperAI_Organ_OrganTurret_node3);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_WrapperAI_Organ_OrganTurret_node3.HasEvents());
			DecoratorLoopUntil_bt_WrapperAI_Organ_OrganTurret_node92 decoratorLoopUntil_bt_WrapperAI_Organ_OrganTurret_node = new DecoratorLoopUntil_bt_WrapperAI_Organ_OrganTurret_node92();
			decoratorLoopUntil_bt_WrapperAI_Organ_OrganTurret_node.SetClassNameString("DecoratorLoopUntil");
			decoratorLoopUntil_bt_WrapperAI_Organ_OrganTurret_node.SetId(92);
			sequence.AddChild(decoratorLoopUntil_bt_WrapperAI_Organ_OrganTurret_node);
			Condition_bt_WrapperAI_Organ_OrganTurret_node93 condition_bt_WrapperAI_Organ_OrganTurret_node4 = new Condition_bt_WrapperAI_Organ_OrganTurret_node93();
			condition_bt_WrapperAI_Organ_OrganTurret_node4.SetClassNameString("Condition");
			condition_bt_WrapperAI_Organ_OrganTurret_node4.SetId(93);
			decoratorLoopUntil_bt_WrapperAI_Organ_OrganTurret_node.AddChild(condition_bt_WrapperAI_Organ_OrganTurret_node4);
			decoratorLoopUntil_bt_WrapperAI_Organ_OrganTurret_node.SetHasEvents(decoratorLoopUntil_bt_WrapperAI_Organ_OrganTurret_node.HasEvents() | condition_bt_WrapperAI_Organ_OrganTurret_node4.HasEvents());
			sequence.SetHasEvents(sequence.HasEvents() | decoratorLoopUntil_bt_WrapperAI_Organ_OrganTurret_node.HasEvents());
			withPrecondition.SetHasEvents(withPrecondition.HasEvents() | sequence.HasEvents());
			selectorLoop.SetHasEvents(selectorLoop.HasEvents() | withPrecondition.HasEvents());
			WithPrecondition withPrecondition2 = new WithPrecondition();
			withPrecondition2.SetClassNameString("WithPrecondition");
			withPrecondition2.SetId(5);
			selectorLoop.AddChild(withPrecondition2);
			Condition_bt_WrapperAI_Organ_OrganTurret_node9 condition_bt_WrapperAI_Organ_OrganTurret_node5 = new Condition_bt_WrapperAI_Organ_OrganTurret_node9();
			condition_bt_WrapperAI_Organ_OrganTurret_node5.SetClassNameString("Condition");
			condition_bt_WrapperAI_Organ_OrganTurret_node5.SetId(9);
			withPrecondition2.AddChild(condition_bt_WrapperAI_Organ_OrganTurret_node5);
			withPrecondition2.SetHasEvents(withPrecondition2.HasEvents() | condition_bt_WrapperAI_Organ_OrganTurret_node5.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(59);
			withPrecondition2.AddChild(sequence2);
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(487);
			sequence2.AddChild(selector);
			Action_bt_WrapperAI_Organ_OrganTurret_node488 action_bt_WrapperAI_Organ_OrganTurret_node4 = new Action_bt_WrapperAI_Organ_OrganTurret_node488();
			action_bt_WrapperAI_Organ_OrganTurret_node4.SetClassNameString("Action");
			action_bt_WrapperAI_Organ_OrganTurret_node4.SetId(488);
			selector.AddChild(action_bt_WrapperAI_Organ_OrganTurret_node4);
			selector.SetHasEvents(selector.HasEvents() | action_bt_WrapperAI_Organ_OrganTurret_node4.HasEvents());
			Action_bt_WrapperAI_Organ_OrganTurret_node10 action_bt_WrapperAI_Organ_OrganTurret_node5 = new Action_bt_WrapperAI_Organ_OrganTurret_node10();
			action_bt_WrapperAI_Organ_OrganTurret_node5.SetClassNameString("Action");
			action_bt_WrapperAI_Organ_OrganTurret_node5.SetId(10);
			selector.AddChild(action_bt_WrapperAI_Organ_OrganTurret_node5);
			selector.SetHasEvents(selector.HasEvents() | action_bt_WrapperAI_Organ_OrganTurret_node5.HasEvents());
			sequence2.SetHasEvents(sequence2.HasEvents() | selector.HasEvents());
			DecoratorLoop_bt_WrapperAI_Organ_OrganTurret_node65 decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node2 = new DecoratorLoop_bt_WrapperAI_Organ_OrganTurret_node65();
			decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node2.SetClassNameString("DecoratorLoop");
			decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node2.SetId(65);
			sequence2.AddChild(decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node2);
			Noop noop = new Noop();
			noop.SetClassNameString("Noop");
			noop.SetId(66);
			decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node2.AddChild(noop);
			decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node2.SetHasEvents(decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node2.HasEvents() | noop.HasEvents());
			sequence2.SetHasEvents(sequence2.HasEvents() | decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node2.HasEvents());
			withPrecondition2.SetHasEvents(withPrecondition2.HasEvents() | sequence2.HasEvents());
			selectorLoop.SetHasEvents(selectorLoop.HasEvents() | withPrecondition2.HasEvents());
			decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node.SetHasEvents(decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node.HasEvents() | selectorLoop.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | decoratorLoop_bt_WrapperAI_Organ_OrganTurret_node.HasEvents());
			return true;
		}
	}
}
