using System;
using System.Runtime.InteropServices;

namespace DiscordRpcDemo
{
	// Token: 0x02000005 RID: 5
	public class DiscordRpc
	{
		// Token: 0x0600001F RID: 31
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x06000020 RID: 32
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
		public static extern void RunCallbacks();

		// Token: 0x06000021 RID: 33
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
		public static extern void Shutdown();

		// Token: 0x06000022 RID: 34
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
		public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

		// Token: 0x06000023 RID: 35 RVA: 0x00002C83 File Offset: 0x00000E83
		internal static void Initialize(string v1, ref object handlers, bool v2, object p)
		{
			throw new NotImplementedException();
		}

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600005C RID: 92
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DisconnectedCallback(int errorCode, string message);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000060 RID: 96
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ErrorCallback(int errorCode, string message);

		// Token: 0x0200000B RID: 11
		public struct EventHandlers
		{
			// Token: 0x0400005C RID: 92
			public DiscordRpc.ReadyCallback readyCallback;

			// Token: 0x0400005D RID: 93
			public DiscordRpc.DisconnectedCallback disconnectedCallback;

			// Token: 0x0400005E RID: 94
			public DiscordRpc.ErrorCallback errorCallback;
		}

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000064 RID: 100
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReadyCallback();

		// Token: 0x0200000D RID: 13
		[Serializable]
		public struct RichPresence
		{
			// Token: 0x0400005F RID: 95
			public string state;

			// Token: 0x04000060 RID: 96
			public string details;

			// Token: 0x04000061 RID: 97
			public long startTimestamp;

			// Token: 0x04000062 RID: 98
			public long endTimestamp;

			// Token: 0x04000063 RID: 99
			public string largeImageKey;

			// Token: 0x04000064 RID: 100
			public string largeImageText;

			// Token: 0x04000065 RID: 101
			public string smallImageKey;

			// Token: 0x04000066 RID: 102
			public string smallImageText;

			// Token: 0x04000067 RID: 103
			public string partyId;

			// Token: 0x04000068 RID: 104
			public int partySize;

			// Token: 0x04000069 RID: 105
			public int partyMax;

			// Token: 0x0400006A RID: 106
			public string matchSecret;

			// Token: 0x0400006B RID: 107
			public string joinSecret;

			// Token: 0x0400006C RID: 108
			public string spectateSecret;

			// Token: 0x0400006D RID: 109
			public bool instance;
		}
	}
}
