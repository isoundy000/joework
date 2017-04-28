using System;

namespace CSProtocol
{
	public enum CS_SINGLEGAME_ERRCODE
	{
		CS_SINGLEGAME_ERR_FAIL = 1,
		CS_SINGLEGAMEOFARENA_ERR_SELFLOCK,
		CS_SINGLEGAMEOFARENA_ERR_TARGETLOCK,
		CS_SINGLEGAMEOFARENA_ERR_TARGETCHG,
		CS_SINGLEGAMEOFARENA_ERR_NOTFINDTARGET,
		CS_SINGLEGAMEOFARENA_ERR_OTHERS,
		CS_SINGLEGAMEOFARENA_ERR_LIMIT_CNT,
		CS_SINGLEGAMEOFARENA_ERR_LIMIT_CD,
		CS_SINGLEGAMEOFARENA_ERR_REWARD_STATE,
		CS_SINGLEGAME_ERR_BANTIME,
		CS_SINGLEGAME_ERR_FREEHERO,
		CS_SINGLEGAME_ERR_EXPSKIN
	}
}
