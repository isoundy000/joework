using Assets.Scripts.Common;
using System;
using tsf4g_tdr_csharp;

namespace CSProtocol
{
	public class COMDT_TRANSACTION_MSG_OF_WORLDREWARDLIMITRSP : ProtocolObject
	{
		public int iResult;

		public COMDT_LIMITITEM_DATA stLimitItemData;

		public static readonly uint BASEVERSION = 1u;

		public static readonly uint CURRVERSION = 1u;

		public static readonly int CLASS_ID = 460;

		public COMDT_TRANSACTION_MSG_OF_WORLDREWARDLIMITRSP()
		{
			this.stLimitItemData = (COMDT_LIMITITEM_DATA)ProtocolObjectPool.Get(COMDT_LIMITITEM_DATA.CLASS_ID);
		}

		public override TdrError.ErrorType construct()
		{
			return TdrError.ErrorType.TDR_NO_ERROR;
		}

		public TdrError.ErrorType pack(ref byte[] buffer, int size, ref int usedSize, uint cutVer)
		{
			if (buffer == null || buffer.GetLength(0) == 0 || size > buffer.GetLength(0))
			{
				return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
			}
			TdrWriteBuf tdrWriteBuf = ClassObjPool<TdrWriteBuf>.Get();
			tdrWriteBuf.set(ref buffer, size);
			TdrError.ErrorType errorType = this.pack(ref tdrWriteBuf, cutVer);
			if (errorType == TdrError.ErrorType.TDR_NO_ERROR)
			{
				buffer = tdrWriteBuf.getBeginPtr();
				usedSize = tdrWriteBuf.getUsedSize();
			}
			tdrWriteBuf.Release();
			return errorType;
		}

		public override TdrError.ErrorType pack(ref TdrWriteBuf destBuf, uint cutVer)
		{
			if (cutVer == 0u || COMDT_TRANSACTION_MSG_OF_WORLDREWARDLIMITRSP.CURRVERSION < cutVer)
			{
				cutVer = COMDT_TRANSACTION_MSG_OF_WORLDREWARDLIMITRSP.CURRVERSION;
			}
			if (COMDT_TRANSACTION_MSG_OF_WORLDREWARDLIMITRSP.BASEVERSION > cutVer)
			{
				return TdrError.ErrorType.TDR_ERR_CUTVER_TOO_SMALL;
			}
			TdrError.ErrorType errorType = destBuf.writeInt32(this.iResult);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			errorType = this.stLimitItemData.pack(ref destBuf, cutVer);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			return errorType;
		}

		public TdrError.ErrorType unpack(ref byte[] buffer, int size, ref int usedSize, uint cutVer)
		{
			if (buffer == null || buffer.GetLength(0) == 0 || size > buffer.GetLength(0))
			{
				return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
			}
			TdrReadBuf tdrReadBuf = ClassObjPool<TdrReadBuf>.Get();
			tdrReadBuf.set(ref buffer, size);
			TdrError.ErrorType result = this.unpack(ref tdrReadBuf, cutVer);
			usedSize = tdrReadBuf.getUsedSize();
			tdrReadBuf.Release();
			return result;
		}

		public override TdrError.ErrorType unpack(ref TdrReadBuf srcBuf, uint cutVer)
		{
			if (cutVer == 0u || COMDT_TRANSACTION_MSG_OF_WORLDREWARDLIMITRSP.CURRVERSION < cutVer)
			{
				cutVer = COMDT_TRANSACTION_MSG_OF_WORLDREWARDLIMITRSP.CURRVERSION;
			}
			if (COMDT_TRANSACTION_MSG_OF_WORLDREWARDLIMITRSP.BASEVERSION > cutVer)
			{
				return TdrError.ErrorType.TDR_ERR_CUTVER_TOO_SMALL;
			}
			TdrError.ErrorType errorType = srcBuf.readInt32(ref this.iResult);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			errorType = this.stLimitItemData.unpack(ref srcBuf, cutVer);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			return errorType;
		}

		public override int GetClassID()
		{
			return COMDT_TRANSACTION_MSG_OF_WORLDREWARDLIMITRSP.CLASS_ID;
		}

		public override void OnRelease()
		{
			this.iResult = 0;
			if (this.stLimitItemData != null)
			{
				this.stLimitItemData.Release();
				this.stLimitItemData = null;
			}
		}

		public override void OnUse()
		{
			this.stLimitItemData = (COMDT_LIMITITEM_DATA)ProtocolObjectPool.Get(COMDT_LIMITITEM_DATA.CLASS_ID);
		}
	}
}
