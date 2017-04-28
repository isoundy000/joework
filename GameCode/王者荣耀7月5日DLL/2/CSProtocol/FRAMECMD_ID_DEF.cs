using System;

namespace CSProtocol
{
	public enum FRAMECMD_ID_DEF
	{
		FRAME_CMD_INVALID,
		FRAME_CMD_PLAYERMOVE,
		FRAME_CMD_PLAYERSTOPMOVE = 3,
		FRAME_CMD_ATTACKPOSITION,
		FRAME_CMD_ATTACKACTOR,
		FRAME_CMD_LEARNSKILL,
		FRAME_CMD_USECURVETRACKSKILL = 9,
		FRAME_CMD_USECOMMONATTACK,
		FRAME_CMD_SWITCHAOUTAI,
		FRAME_CMD_SWITCHCAPTAIN,
		FRAME_CMD_SWITCHSUPERKILLER,
		FRAME_CMD_SWITCHGODMODE,
		FRAME_CMD_LEARNTALENT,
		FRAME_CMD_TESTCOMMANDDELAY,
		FRAME_CMD_PLAYATTACKTARGETMODE = 20,
		FRAME_CMD_SVRNTFCHGKFRAMELATER,
		FRAME_CMD_PLAYER_BUY_EQUIP = 24,
		FRAME_CMD_PLAYER_SELL_EQUIP,
		FRAME_CMD_PLAYER_ADD_GOLD_COIN_IN_BATTLE,
		FRAME_CMD_SET_SKILL_LEVEL,
		FRAME_CMD_PLAYCOMMONATTACKTMODE,
		FRAME_CMD_LOCKATTACKTARGET,
		FRAME_CMD_Signal_Btn_Position,
		FRAME_CMD_Signal_MiniMap_Position,
		FRAME_CMD_Signal_MiniMap_Target,
		FRAME_CMD_BUY_HORIZON_EQUIP = 34,
		FRAME_CMD_PLAYER_IN_OUT_EQUIPSHOP,
		FRAME_CMD_PLAYLASTHITMODE = 37,
		FRAME_CMD_PLAYER_CHOOSE_EQUIPSKILL,
		FRAME_CMD_PLAYER_CHEAT
	}
}
