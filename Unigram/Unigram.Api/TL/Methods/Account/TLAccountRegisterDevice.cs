// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.registerDevice.
	/// Returns <see cref="Telegram.Api.TL.TLBoolBase"/>
	/// </summary>
	public partial class TLAccountRegisterDevice : TLObject
	{
		public Int32 TokenType { get; set; }
		public String Token { get; set; }

		public TLAccountRegisterDevice() { }
		public TLAccountRegisterDevice(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountRegisterDevice; } }

		public override void Read(TLBinaryReader from)
		{
			TokenType = from.ReadInt32();
			Token = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x637EA878);
			to.Write(TokenType);
			to.Write(Token);
		}
	}
}