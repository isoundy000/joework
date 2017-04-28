using System;

namespace CSProtocol
{
	public enum COM_TRANSACTION_MSG_EVNET_TYPE
	{
		COM_TRANSACTION_MSG_GETCLASSIDREQ = 1,
		COM_TRANSACTION_MSG_GETCLASSIDRSP,
		COM_TRANSACTION_MSG_GETGUILDNAMEREQ,
		COM_TRANSACTION_MSG_GETGUILDNAMERSP,
		COM_TRANSACTION_MSG_IDIP_SENDMAILREQ,
		COM_TRANSACTION_MSG_IDIP_SENDMAILRSP,
		COM_TRANSACTION_MSG_IDIP_BANACNTREQ,
		COM_TRANSACTION_MSG_IDIP_BANACNTRSP,
		COM_TRANSACTION_MSG_IDIP_BANTIMESYNREQ,
		COM_TRANSACTION_MSG_IDIP_BANTIMESYNRSP,
		COM_TRANSACTION_MSG_WORLD_REWARDLIMITREQ,
		COM_TRANSACTION_MSG_WORLD_REWARDLIMITRSP,
		COM_TRANSACTION_MSG_IDIP_CHGACNTINFOONLINEREQ,
		COM_TRANSACTION_MSG_IDIP_CHGACNTINFOONLINERSP,
		COM_TRANSACTION_MSG_OF_IDIP_DELACNTPKGINFOREQ,
		COM_TRANSACTION_MSG_OF_IDIP_DELACNTPKGINFORSP,
		COM_TRANSACTION_MSG_OF_IDIP_QUERYGOLDRANKINFOREQ,
		COM_TRANSACTION_MSG_OF_IDIP_QUERYGOLDRANKINFORSP,
		COM_TRANSACTION_MSG_DUPKICK,
		COM_TRANSACTION_MSG_ASSIST_FLAGSET,
		COM_TRANSACTION_MSG_IDIP_WUDAORANKREQ,
		COM_TRANSACTION_MSG_IDIP_WUDAORANKRSP,
		COM_TRANSACTION_MSG_IDIP_CHGGUILDLEADDERREQ,
		COM_TRANSACTION_MSG_IDIP_CHGGUILDLEADDERRSP,
		COM_TRANSACTION_MSG_GETACNTMOBAINFOREQ,
		COM_TRANSACTION_MSG_GETACNTMOBAINFORSP,
		COM_TRANSACTION_MSG_ASSIST_FLAGGET
	}
}
