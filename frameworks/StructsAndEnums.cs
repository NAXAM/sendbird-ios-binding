using System;
using ObjCRuntime;

namespace SendbirdSDK
{
	[Native]
	public enum SBDGroupChannelListOrder : long
	{
		Chronological = 0,
		LatestLastMessage = 1
	}

	[Native]
	public enum SDBErrorCode : long
	{
		InvalidParameterValueString = 400100,
		InvalidParameterValueNumber = 400101,
		InvalidParameterValueList = 400102,
		InvalidParameterValueJson = 400103,
		InvalidParameterValueBoolean = 400104,
		InvalidParameterValueRequired = 400105,
		InvalidParameterValuePositive = 400106,
		InvalidParameterValueNegative = 400107,
		NonAuthorized = 400108,
		TokenExpired = 400109,
		InvalidChannelUrl = 400110,
		InvalidParameterValue = 400111,
		UnusableCharacterIncluded = 400151,
		NotFoundInDatabase = 400201,
		DuplicatedData = 400202,
		InvalidApiToken = 400401,
		ParameterMissing = 400402,
		InvalidJsonBody = 400403,
		AppIdNotValid = 400404,
		AccessTokenEmpty = 400500,
		AccessTokenNotValid = 400501,
		UserNotExist = 400502,
		UserDeactivated = 400503,
		UserCreationFailed = 400504,
		InternalServerError = 500901,
		InvalidInitialization = 800100,
		ConnectionRequired = 800101,
		InvalidParameter = 800110,
		NetworkError = 800120,
		NetworkRoutingError = 800121,
		MalformedData = 800130,
		MalformedErrorData = 800140,
		WrongChannelType = 800150,
		MarkAsReadRateLimitExceeded = 800160,
		QueryInProgress = 800170,
		AckTimeout = 800180,
		LoginTimeout = 800190,
		WebSocketConnectionClosed = 800200,
		WebSocketConnectionFailed = 800210,
		RequestFailed = 800220,
		FileUploadCancelFailed = 800230,
		FileUploadCancelled = 800240
	}

	[Native]
	public enum SBDWebSocketConnectionState : ulong
	{
		Connecting = 0,
		Open = 1,
		Closing = 2,
		Closed = 3
	}

	[Native]
	public enum SBDUserConnectionStatus : ulong
	{
		NonAvailable = 0,
		Online = 1,
		Offline = 2
	}

	[Native]
	public enum SBDChannelType : ulong
	{
		Open = 0,
		Group = 1
	}

	[Native]
	public enum SBDPushTokenRegistrationStatus : ulong
	{
		Success = 0,
		Pending = 1,
		Error = 2
	}

	[Native]
	public enum SBDGroupChannelListQueryType : long
	{
		And = 0,
		Or = 1
	}

	[Native]
	public enum SBDMessageTypeFilter : long
	{
		All = 0,
		User = 1,
		File = 2,
		Admin = 3
	}

	[Native]
	public enum SBDMemberStateFilter : long
	{
		All = 0,
		JoinedOnly = 1,
		InvitedOnly = 2
	}

	[Native]
	public enum SBDMemberState : long
	{
		Joined = 0,
		Invited = 1
	}

	[Native]
	public enum SBDOpenChannelMetaCountersUpdateMode : long
	{
		Set = 0,
		Increase = 1,
		Decrease = 2
	}

	[Native]
	public enum SBDChannelEventCategory : long
	{
		None = 0,
		ChannelEnter = 10102,
		ChannelExit = 10103,
		ChannelMute = 10201,
		ChannelUnmute = 10200,
		ChannelBan = 10601,
		ChannelUnban = 10600,
		ChannelFrozen = 10701,
		ChannelUnfrozen = 10700,
		TypingStart = 10900,
		TypingEnd = 10901,
		ChannelJoin = 10000,
		ChannelLeave = 10001,
		ChannelInvite = 10020,
		ChannelDeclineInvite = 10022,
		ChannelPropChanged = 11000,
		ChannelDeleted = 12000,
		MetaDataChanged = 11100,
		MetaCounterChanged = 11200
	}

	[Native]
	public enum SBDUserListQueryType : ulong
	{
		AllUser = 1,
		BlockedUsers = 2,
		OpenChannelParticipants = 3,
		OpenChannelMutedUsers = 4,
		OpenChannelBannedUsers = 5,
		FilteredUsers = 6
	}

	[Native]
	public enum SBDLogLevel : long
	{
		None = 0,
		Error = 1,
		Warning = 2,
		Info = 3,
		Debug = 4
	}
}
