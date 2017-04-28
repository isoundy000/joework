using Assets.Scripts.GameSystem;
using Assets.Scripts.UI;
using System;
using UnityEngine;

internal class NewbieGuideClickMatching : NewbieGuideBaseScript
{
	protected override void Initialize()
	{
	}

	protected override void Update()
	{
		if (base.isInitialize)
		{
			base.Update();
			return;
		}
		CUIFormScript form = Singleton<CUIManager>.GetInstance().GetForm(CMatchingSystem.PATH_MATCHING_MULTI);
		if (form != null)
		{
			GameObject gameObject = form.transform.FindChild("Panel_Main/Btn_Matching").gameObject;
			if (gameObject != null)
			{
				base.AddHighLightGameObject(gameObject, true, form, true);
				base.Initialize();
			}
		}
	}

	protected override bool IsDelegateClickEvent()
	{
		return true;
	}
}
