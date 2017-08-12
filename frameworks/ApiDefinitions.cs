using System;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using SendBirdSDK;

namespace SendbirdSDK
{
	// @interface SBDError : NSError
	[BaseType (typeof(NSError))]
	interface SBDError
	{
		// +(SBDError * _Nonnull)errorWithDictionary:(NSDictionary * _Nonnull)dict;
		[Static]
		[Export ("errorWithDictionary:")]
		SBDError ErrorWithDictionary (NSDictionary dict);

		// +(SBDError * _Nonnull)errorWithNSError:(NSError * _Nonnull)error;
		[Static]
		[Export ("errorWithNSError:")]
		SBDError ErrorWithNSError (NSError error);
	}

	// @interface SBDUser : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDUser
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull userId;
		[Export ("userId", ArgumentSemantic.Strong)]
		string UserId { get; }

		// @property (nonatomic, strong) NSString * _Nullable nickname;
		[NullAllowed, Export ("nickname", ArgumentSemantic.Strong)]
		string Nickname { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable profileUrl;
		[NullAllowed, Export ("profileUrl", ArgumentSemantic.Strong)]
		string ProfileUrl { get; set; }

		// @property (readonly, atomic) SBDUserConnectionStatus connectionStatus;
		[Export ("connectionStatus")]
		SBDUserConnectionStatus ConnectionStatus { get; }

		// @property (readonly, atomic) long long lastSeenAt;
		[Export ("lastSeenAt")]
		long LastSeenAt { get; }

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// +(instancetype _Nullable)buildFromSerializedData:(NSData * _Nonnull)data;
		[Static]
		[Export ("buildFromSerializedData:")]
		[return: NullAllowed]
		SBDUser BuildFromSerializedData (NSData data);

		// -(NSData * _Nullable)serialize;
		[NullAllowed, Export ("serialize")]
		[Verify (MethodToProperty)]
		NSData Serialize { get; }

		// -(NSDictionary * _Nullable)_toDictionary;
		[NullAllowed, Export ("_toDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary _toDictionary { get; }
	}

	// @interface SBDBaseMessage : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDBaseMessage
	{
		// @property (atomic) long long messageId;
		[Export ("messageId")]
		long MessageId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable channelUrl;
		[NullAllowed, Export ("channelUrl", ArgumentSemantic.Strong)]
		string ChannelUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable channelType;
		[NullAllowed, Export ("channelType", ArgumentSemantic.Strong)]
		string ChannelType { get; set; }

		// @property (atomic) long long createdAt;
		[Export ("createdAt")]
		long CreatedAt { get; set; }

		// @property (atomic) long long updatedAt;
		[Export ("updatedAt")]
		long UpdatedAt { get; set; }

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// +(SBDBaseMessage * _Nullable)buildWithDictionary:(NSDictionary * _Nonnull)dict;
		[Static]
		[Export ("buildWithDictionary:")]
		[return: NullAllowed]
		SBDBaseMessage BuildWithDictionary (NSDictionary dict);

		// +(SBDBaseMessage * _Nullable)buildWithDictionary:(NSDictionary * _Nonnull)dict channel:(SBDBaseChannel * _Nonnull)channel;
		[Static]
		[Export ("buildWithDictionary:channel:")]
		[return: NullAllowed]
		SBDBaseMessage BuildWithDictionary (NSDictionary dict, SBDBaseChannel channel);

		// +(SBDBaseMessage * _Nullable)buildWithData:(NSString * _Nonnull)data;
		[Static]
		[Export ("buildWithData:")]
		[return: NullAllowed]
		SBDBaseMessage BuildWithData (string data);

		// -(BOOL)isOpenChannel;
		[Export ("isOpenChannel")]
		[Verify (MethodToProperty)]
		bool IsOpenChannel { get; }

		// -(BOOL)isGroupChannel;
		[Export ("isGroupChannel")]
		[Verify (MethodToProperty)]
		bool IsGroupChannel { get; }

		// +(instancetype _Nullable)buildFromSerializedData:(NSData * _Nonnull)data;
		[Static]
		[Export ("buildFromSerializedData:")]
		[return: NullAllowed]
		SBDBaseMessage BuildFromSerializedData (NSData data);

		// -(NSData * _Nullable)serialize;
		[NullAllowed, Export ("serialize")]
		[Verify (MethodToProperty)]
		NSData Serialize { get; }

		// -(NSDictionary * _Nullable)_toDictionary;
		[NullAllowed, Export ("_toDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary _toDictionary { get; }
	}

	// @interface SBDAdminMessage : SBDBaseMessage
	[BaseType (typeof(SBDBaseMessage))]
	interface SBDAdminMessage
	{
		// @property (readonly, nonatomic, strong) NSString * _Nullable message;
		[NullAllowed, Export ("message", ArgumentSemantic.Strong)]
		string Message { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable data;
		[NullAllowed, Export ("data", ArgumentSemantic.Strong)]
		string Data { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable customType;
		[NullAllowed, Export ("customType", ArgumentSemantic.Strong)]
		string CustomType { get; }

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// -(NSData * _Nullable)serialize;
		[NullAllowed, Export ("serialize")]
		[Verify (MethodToProperty)]
		NSData Serialize { get; }

		// -(NSDictionary * _Nullable)_toDictionary;
		[NullAllowed, Export ("_toDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary _toDictionary { get; }
	}

	// @interface SBDUserMessage : SBDBaseMessage
	[BaseType (typeof(SBDBaseMessage))]
	interface SBDUserMessage
	{
		// @property (readonly, nonatomic, strong) NSString * _Nullable message;
		[NullAllowed, Export ("message", ArgumentSemantic.Strong)]
		string Message { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable data;
		[NullAllowed, Export ("data", ArgumentSemantic.Strong)]
		string Data { get; }

		// @property (getter = sender, nonatomic, strong) SBDUser * _Nullable sender;
		[NullAllowed, Export ("sender", ArgumentSemantic.Strong)]
		SBDUser Sender { [Bind ("sender")] get; set; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable requestId;
		[NullAllowed, Export ("requestId", ArgumentSemantic.Strong)]
		string RequestId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable customType;
		[NullAllowed, Export ("customType", ArgumentSemantic.Strong)]
		string CustomType { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nullable translations;
		[NullAllowed, Export ("translations", ArgumentSemantic.Strong)]
		NSDictionary Translations { get; }

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// -(NSData * _Nullable)serialize;
		[NullAllowed, Export ("serialize")]
		[Verify (MethodToProperty)]
		NSData Serialize { get; }

		// -(NSDictionary * _Nullable)_toDictionary;
		[NullAllowed, Export ("_toDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary _toDictionary { get; }
	}

	// @interface SBDThumbnailSize : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDThumbnailSize
	{
		// @property (readonly, nonatomic) CGSize maxSize;
		[Export ("maxSize")]
		CGSize MaxSize { get; }

		// +(instancetype _Nullable)makeWithMaxCGSize:(CGSize)size;
		[Static]
		[Export ("makeWithMaxCGSize:")]
		[return: NullAllowed]
		SBDThumbnailSize MakeWithMaxCGSize (CGSize size);

		// +(instancetype _Nullable)makeWithMaxWidth:(CGFloat)width maxHeight:(CGFloat)height;
		[Static]
		[Export ("makeWithMaxWidth:maxHeight:")]
		[return: NullAllowed]
		SBDThumbnailSize MakeWithMaxWidth (nfloat width, nfloat height);
	}

	// @interface SBDThumbnail : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDThumbnail
	{
		// @property (readonly, getter = url, nonatomic, strong) NSString * _Nonnull url;
		[Export ("url", ArgumentSemantic.Strong)]
		string Url { [Bind ("url")] get; }

		// @property (readonly, nonatomic) CGSize maxSize;
		[Export ("maxSize")]
		CGSize MaxSize { get; }

		// @property (readonly, nonatomic) CGSize realSize;
		[Export ("realSize")]
		CGSize RealSize { get; }

		// @property (readonly, atomic) BOOL requireAuth;
		[Export ("requireAuth")]
		bool RequireAuth { get; }

		// -(NSDictionary * _Nullable)_toDictionary;
		[NullAllowed, Export ("_toDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary _toDictionary { get; }
	}

	// @interface SBDFileMessage : SBDBaseMessage
	[BaseType (typeof(SBDBaseMessage))]
	interface SBDFileMessage
	{
		// @property (getter = sender, nonatomic, strong) SBDUser * _Nullable sender;
		[NullAllowed, Export ("sender", ArgumentSemantic.Strong)]
		SBDUser Sender { [Bind ("sender")] get; set; }

		// @property (readonly, getter = url, nonatomic, strong) NSString * _Nonnull url;
		[Export ("url", ArgumentSemantic.Strong)]
		string Url { [Bind ("url")] get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, atomic) NSUInteger size;
		[Export ("size")]
		nuint Size { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull type;
		[Export ("type", ArgumentSemantic.Strong)]
		string Type { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull data;
		[Export ("data", ArgumentSemantic.Strong)]
		string Data { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable requestId;
		[NullAllowed, Export ("requestId", ArgumentSemantic.Strong)]
		string RequestId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable customType;
		[NullAllowed, Export ("customType", ArgumentSemantic.Strong)]
		string CustomType { get; }

		// @property (readonly, nonatomic, strong) NSArray<SBDThumbnail *> * _Nullable thumbnails;
		[NullAllowed, Export ("thumbnails", ArgumentSemantic.Strong)]
		SBDThumbnail[] Thumbnails { get; }

		// @property (readonly, atomic) BOOL requireAuth;
		[Export ("requireAuth")]
		bool RequireAuth { get; }

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// +(NSMutableDictionary<NSString *,NSObject *> * _Nullable)buildWithFileUrl:(NSString * _Nonnull)url name:(NSString * _Nullable)name size:(NSUInteger)size type:(NSString * _Nonnull)type data:(NSString * _Nullable)data requestId:(NSString * _Nullable)requestId sender:(SBDUser * _Nonnull)sender channel:(SBDBaseChannel * _Nonnull)channel customType:(NSString * _Nullable)customType;
		[Static]
		[Export ("buildWithFileUrl:name:size:type:data:requestId:sender:channel:customType:")]
		[return: NullAllowed]
		NSMutableDictionary<NSString, NSObject> BuildWithFileUrl (string url, [NullAllowed] string name, nuint size, string type, [NullAllowed] string data, [NullAllowed] string requestId, SBDUser sender, SBDBaseChannel channel, [NullAllowed] string customType);

		// +(NSMutableDictionary<NSString *,NSObject *> * _Nullable)buildWithFileUrl:(NSString * _Nonnull)url name:(NSString * _Nullable)name size:(NSUInteger)size type:(NSString * _Nonnull)type data:(NSString * _Nullable)data requestId:(NSString * _Nullable)requestId sender:(SBDUser * _Nonnull)sender channel:(SBDBaseChannel * _Nonnull)channel customType:(NSString * _Nullable)customType thumbnailSizes:(NSArray<SBDThumbnailSize *> * _Nullable)thumbnailSizes;
		[Static]
		[Export ("buildWithFileUrl:name:size:type:data:requestId:sender:channel:customType:thumbnailSizes:")]
		[return: NullAllowed]
		NSMutableDictionary<NSString, NSObject> BuildWithFileUrl (string url, [NullAllowed] string name, nuint size, string type, [NullAllowed] string data, [NullAllowed] string requestId, SBDUser sender, SBDBaseChannel channel, [NullAllowed] string customType, [NullAllowed] SBDThumbnailSize[] thumbnailSizes);

		// -(NSData * _Nullable)serialize;
		[NullAllowed, Export ("serialize")]
		[Verify (MethodToProperty)]
		NSData Serialize { get; }

		// -(NSDictionary * _Nullable)_toDictionary;
		[NullAllowed, Export ("_toDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary _toDictionary { get; }
	}

	// @interface SBDMember : SBDUser
	[BaseType (typeof(SBDUser))]
	interface SBDMember
	{
		// @property (atomic) SBDMemberState state;
		[Export ("state", ArgumentSemantic.Assign)]
		SBDMemberState State { get; set; }

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// +(instancetype _Nullable)buildFromSerializedData:(NSData * _Nonnull)data;
		[Static]
		[Export ("buildFromSerializedData:")]
		[return: NullAllowed]
		SBDMember BuildFromSerializedData (NSData data);

		// -(NSData * _Nullable)serialize;
		[NullAllowed, Export ("serialize")]
		[Verify (MethodToProperty)]
		NSData Serialize { get; }

		// -(NSDictionary * _Nullable)_toDictionary;
		[NullAllowed, Export ("_toDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary _toDictionary { get; }
	}

	// @protocol SBDChannelDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface SBDChannelDelegate
	{
		// @optional -(void)channel:(SBDBaseChannel * _Nonnull)sender didReceiveMessage:(SBDBaseMessage * _Nonnull)message;
		[Export ("channel:didReceiveMessage:")]
		void Channel (SBDBaseChannel sender, SBDBaseMessage message);

		// @optional -(void)channel:(SBDBaseChannel * _Nonnull)sender didUpdateMessage:(SBDBaseMessage * _Nonnull)message;
		[Export ("channel:didUpdateMessage:")]
		void Channel (SBDBaseChannel sender, SBDBaseMessage message);

		// @optional -(void)channelDidUpdateReadReceipt:(SBDGroupChannel * _Nonnull)sender;
		[Export ("channelDidUpdateReadReceipt:")]
		void ChannelDidUpdateReadReceipt (SBDGroupChannel sender);

		// @optional -(void)channelDidUpdateTypingStatus:(SBDGroupChannel * _Nonnull)sender;
		[Export ("channelDidUpdateTypingStatus:")]
		void ChannelDidUpdateTypingStatus (SBDGroupChannel sender);

		// @optional -(void)channel:(SBDGroupChannel * _Nonnull)sender didReceiveInvitation:(NSArray<SBDUser *> * _Nullable)invitees inviter:(SBDUser * _Nullable)inviter;
		[Export ("channel:didReceiveInvitation:inviter:")]
		void Channel (SBDGroupChannel sender, [NullAllowed] SBDUser[] invitees, [NullAllowed] SBDUser inviter);

		// @optional -(void)channel:(SBDGroupChannel * _Nonnull)sender didDeclineInvitation:(SBDUser * _Nonnull)invitee inviter:(SBDUser * _Nullable)inviter;
		[Export ("channel:didDeclineInvitation:inviter:")]
		void Channel (SBDGroupChannel sender, SBDUser invitee, [NullAllowed] SBDUser inviter);

		// @optional -(void)channel:(SBDGroupChannel * _Nonnull)sender userDidJoin:(SBDUser * _Nonnull)user;
		[Export ("channel:userDidJoin:")]
		void Channel (SBDGroupChannel sender, SBDUser user);

		// @optional -(void)channel:(SBDGroupChannel * _Nonnull)sender userDidLeave:(SBDUser * _Nonnull)user;
		[Export ("channel:userDidLeave:")]
		void Channel (SBDGroupChannel sender, SBDUser user);

		// @optional -(void)channel:(SBDOpenChannel * _Nonnull)sender userDidEnter:(SBDUser * _Nonnull)user;
		[Export ("channel:userDidEnter:")]
		void Channel (SBDOpenChannel sender, SBDUser user);

		// @optional -(void)channel:(SBDOpenChannel * _Nonnull)sender userDidExit:(SBDUser * _Nonnull)user;
		[Export ("channel:userDidExit:")]
		void Channel (SBDOpenChannel sender, SBDUser user);

		// @optional -(void)channel:(SBDOpenChannel * _Nonnull)sender userWasMuted:(SBDUser * _Nonnull)user;
		[Export ("channel:userWasMuted:")]
		void Channel (SBDOpenChannel sender, SBDUser user);

		// @optional -(void)channel:(SBDOpenChannel * _Nonnull)sender userWasUnmuted:(SBDUser * _Nonnull)user;
		[Export ("channel:userWasUnmuted:")]
		void Channel (SBDOpenChannel sender, SBDUser user);

		// @optional -(void)channel:(SBDOpenChannel * _Nonnull)sender userWasBanned:(SBDUser * _Nonnull)user;
		[Export ("channel:userWasBanned:")]
		void Channel (SBDOpenChannel sender, SBDUser user);

		// @optional -(void)channel:(SBDOpenChannel * _Nonnull)sender userWasUnbanned:(SBDUser * _Nonnull)user;
		[Export ("channel:userWasUnbanned:")]
		void Channel (SBDOpenChannel sender, SBDUser user);

		// @optional -(void)channelWasFrozen:(SBDOpenChannel * _Nonnull)sender;
		[Export ("channelWasFrozen:")]
		void ChannelWasFrozen (SBDOpenChannel sender);

		// @optional -(void)channelWasUnfrozen:(SBDOpenChannel * _Nonnull)sender;
		[Export ("channelWasUnfrozen:")]
		void ChannelWasUnfrozen (SBDOpenChannel sender);

		// @optional -(void)channelWasChanged:(SBDBaseChannel * _Nonnull)sender;
		[Export ("channelWasChanged:")]
		void ChannelWasChanged (SBDBaseChannel sender);

		// @optional -(void)channelWasDeleted:(NSString * _Nonnull)channelUrl channelType:(SBDChannelType)channelType;
		[Export ("channelWasDeleted:channelType:")]
		void ChannelWasDeleted (string channelUrl, SBDChannelType channelType);

		// @optional -(void)channel:(SBDBaseChannel * _Nonnull)sender messageWasDeleted:(long long)messageId;
		[Export ("channel:messageWasDeleted:")]
		void Channel (SBDBaseChannel sender, long messageId);

		// @optional -(void)channel:(SBDBaseChannel * _Nonnull)sender createdMetaData:(NSDictionary<NSString *,NSString *> * _Nullable)createdMetaData;
		[Export ("channel:createdMetaData:")]
		void Channel (SBDBaseChannel sender, [NullAllowed] NSDictionary<NSString, NSString> createdMetaData);

		// @optional -(void)channel:(SBDBaseChannel * _Nonnull)sender updatedMetaData:(NSDictionary<NSString *,NSString *> * _Nullable)updatedMetaData;
		[Export ("channel:updatedMetaData:")]
		void Channel (SBDBaseChannel sender, [NullAllowed] NSDictionary<NSString, NSString> updatedMetaData);

		// @optional -(void)channel:(SBDBaseChannel * _Nonnull)sender deletedMetaDataKeys:(NSArray<NSString *> * _Nullable)deletedMetaDataKeys;
		[Export ("channel:deletedMetaDataKeys:")]
		void Channel (SBDBaseChannel sender, [NullAllowed] string[] deletedMetaDataKeys);

		// @optional -(void)channel:(SBDBaseChannel * _Nonnull)sender createdMetaCounters:(NSDictionary<NSString *,NSNumber *> * _Nullable)createdMetaCounters;
		[Export ("channel:createdMetaCounters:")]
		void Channel (SBDBaseChannel sender, [NullAllowed] NSDictionary<NSString, NSNumber> createdMetaCounters);

		// @optional -(void)channel:(SBDBaseChannel * _Nonnull)sender updatedMetaCounters:(NSDictionary<NSString *,NSNumber *> * _Nullable)updatedMetaCounters;
		[Export ("channel:updatedMetaCounters:")]
		void Channel (SBDBaseChannel sender, [NullAllowed] NSDictionary<NSString, NSNumber> updatedMetaCounters);

		// @optional -(void)channel:(SBDBaseChannel * _Nonnull)sender deletedMetaCountersKeys:(NSArray<NSString *> * _Nullable)deletedMetaCountersKeys;
		[Export ("channel:deletedMetaCountersKeys:")]
		void Channel (SBDBaseChannel sender, [NullAllowed] string[] deletedMetaCountersKeys);
	}

	// @interface SBDBaseChannel : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDBaseChannel
	{
		// @property (nonatomic, strong) NSString * _Nonnull channelUrl;
		[Export ("channelUrl", ArgumentSemantic.Strong)]
		string ChannelUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable coverUrl;
		[NullAllowed, Export ("coverUrl", ArgumentSemantic.Strong)]
		string CoverUrl { get; set; }

		// @property (atomic) NSUInteger createdAt;
		[Export ("createdAt")]
		nuint CreatedAt { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable data;
		[NullAllowed, Export ("data", ArgumentSemantic.Strong)]
		string Data { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable customType;
		[NullAllowed, Export ("customType", ArgumentSemantic.Strong)]
		string CustomType { get; set; }

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// -(SBDUserMessage * _Nonnull)sendUserMessage:(NSString * _Nullable)message completionHandler:(void (^ _Nullable)(SBDUserMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendUserMessage:completionHandler:")]
		SBDUserMessage SendUserMessage ([NullAllowed] string message, [NullAllowed] Action<SBDUserMessage, SBDError> completionHandler);

		// -(SBDUserMessage * _Nonnull)sendUserMessage:(NSString * _Nullable)message targetLanguages:(NSArray<NSString *> * _Nullable)targetLanguages completionHandler:(void (^ _Nullable)(SBDUserMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendUserMessage:targetLanguages:completionHandler:")]
		SBDUserMessage SendUserMessage ([NullAllowed] string message, [NullAllowed] string[] targetLanguages, [NullAllowed] Action<SBDUserMessage, SBDError> completionHandler);

		// -(SBDUserMessage * _Nonnull)sendUserMessage:(NSString * _Nullable)message data:(NSString * _Nullable)data completionHandler:(void (^ _Nullable)(SBDUserMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendUserMessage:data:completionHandler:")]
		SBDUserMessage SendUserMessage ([NullAllowed] string message, [NullAllowed] string data, [NullAllowed] Action<SBDUserMessage, SBDError> completionHandler);

		// -(SBDUserMessage * _Nonnull)sendUserMessage:(NSString * _Nullable)message data:(NSString * _Nullable)data targetLanguages:(NSArray<NSString *> * _Nullable)targetLanguages completionHandler:(void (^ _Nullable)(SBDUserMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendUserMessage:data:targetLanguages:completionHandler:")]
		SBDUserMessage SendUserMessage ([NullAllowed] string message, [NullAllowed] string data, [NullAllowed] string[] targetLanguages, [NullAllowed] Action<SBDUserMessage, SBDError> completionHandler);

		// -(SBDUserMessage * _Nonnull)sendUserMessage:(NSString * _Nullable)message data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(SBDUserMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendUserMessage:data:customType:completionHandler:")]
		SBDUserMessage SendUserMessage ([NullAllowed] string message, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<SBDUserMessage, SBDError> completionHandler);

		// -(SBDUserMessage * _Nonnull)sendUserMessage:(NSString * _Nullable)message data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType targetLanguages:(NSArray<NSString *> * _Nullable)targetLanguages completionHandler:(void (^ _Nullable)(SBDUserMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendUserMessage:data:customType:targetLanguages:completionHandler:")]
		SBDUserMessage SendUserMessage ([NullAllowed] string message, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] string[] targetLanguages, [NullAllowed] Action<SBDUserMessage, SBDError> completionHandler);

		// -(SBDFileMessage * _Nonnull)sendFileMessageWithBinaryData:(NSData * _Nonnull)file filename:(NSString * _Nonnull)filename type:(NSString * _Nonnull)type size:(NSUInteger)size data:(NSString * _Nullable)data completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendFileMessageWithBinaryData:filename:type:size:data:completionHandler:")]
		SBDFileMessage SendFileMessageWithBinaryData (NSData file, string filename, string type, nuint size, [NullAllowed] string data, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(SBDFileMessage * _Nonnull)sendFileMessageWithBinaryData:(NSData * _Nonnull)file filename:(NSString * _Nonnull)filename type:(NSString * _Nonnull)type size:(NSUInteger)size data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendFileMessageWithBinaryData:filename:type:size:data:customType:completionHandler:")]
		SBDFileMessage SendFileMessageWithBinaryData (NSData file, string filename, string type, nuint size, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(SBDFileMessage * _Nonnull)sendFileMessageWithUrl:(NSString * _Nonnull)url size:(NSUInteger)size type:(NSString * _Nonnull)type data:(NSString * _Nullable)data completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("sendFileMessageWithUrl:size:type:data:completionHandler:")]
		SBDFileMessage SendFileMessageWithUrl (string url, nuint size, string type, [NullAllowed] string data, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(SBDFileMessage * _Nonnull)sendFileMessageWithUrl:(NSString * _Nonnull)url filename:(NSString * _Nullable)filename size:(NSUInteger)size type:(NSString * _Nonnull)type data:(NSString * _Nullable)data completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendFileMessageWithUrl:filename:size:type:data:completionHandler:")]
		SBDFileMessage SendFileMessageWithUrl (string url, [NullAllowed] string filename, nuint size, string type, [NullAllowed] string data, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(SBDFileMessage * _Nonnull)sendFileMessageWithUrl:(NSString * _Nonnull)url size:(NSUInteger)size type:(NSString * _Nonnull)type data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("sendFileMessageWithUrl:size:type:data:customType:completionHandler:")]
		SBDFileMessage SendFileMessageWithUrl (string url, nuint size, string type, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(SBDFileMessage * _Nonnull)sendFileMessageWithUrl:(NSString * _Nonnull)url filename:(NSString * _Nullable)filename size:(NSUInteger)size type:(NSString * _Nonnull)type data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendFileMessageWithUrl:filename:size:type:data:customType:completionHandler:")]
		SBDFileMessage SendFileMessageWithUrl (string url, [NullAllowed] string filename, nuint size, string type, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(SBDFileMessage * _Nonnull)sendFileMessageWithBinaryData:(NSData * _Nonnull)file filename:(NSString * _Nonnull)filename type:(NSString * _Nonnull)type size:(NSUInteger)size data:(NSString * _Nullable)data progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendFileMessageWithBinaryData:filename:type:size:data:progressHandler:completionHandler:")]
		SBDFileMessage SendFileMessageWithBinaryData (NSData file, string filename, string type, nuint size, [NullAllowed] string data, [NullAllowed] Action<long, long, long> progressHandler, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(SBDFileMessage * _Nonnull)sendFileMessageWithBinaryData:(NSData * _Nonnull)file filename:(NSString * _Nonnull)filename type:(NSString * _Nonnull)type size:(NSUInteger)size data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendFileMessageWithBinaryData:filename:type:size:data:customType:progressHandler:completionHandler:")]
		SBDFileMessage SendFileMessageWithBinaryData (NSData file, string filename, string type, nuint size, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(SBDFileMessage * _Nonnull)sendFileMessageWithBinaryData:(NSData * _Nonnull)file filename:(NSString * _Nonnull)filename type:(NSString * _Nonnull)type size:(NSUInteger)size thumbnailSizes:(NSArray<SBDThumbnailSize *> * _Nullable)thumbnailSizes data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendFileMessageWithBinaryData:filename:type:size:thumbnailSizes:data:customType:progressHandler:completionHandler:")]
		SBDFileMessage SendFileMessageWithBinaryData (NSData file, string filename, string type, nuint size, [NullAllowed] SBDThumbnailSize[] thumbnailSizes, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(SBDFileMessage * _Nonnull)sendFileMessageWithFilePath:(NSString * _Nonnull)filepath type:(NSString * _Nonnull)type thumbnailSizes:(NSArray<SBDThumbnailSize *> * _Nullable)thumbnailSizes data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("sendFileMessageWithFilePath:type:thumbnailSizes:data:customType:progressHandler:completionHandler:")]
		SBDFileMessage SendFileMessageWithFilePath (string filepath, string type, [NullAllowed] SBDThumbnailSize[] thumbnailSizes, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(SBDPreviousMessageListQuery * _Nullable)createPreviousMessageListQuery;
		[NullAllowed, Export ("createPreviousMessageListQuery")]
		[Verify (MethodToProperty)]
		SBDPreviousMessageListQuery CreatePreviousMessageListQuery { get; }

		// -(SBDMessageListQuery * _Nullable)createMessageListQuery __attribute__((deprecated("")));
		[NullAllowed, Export ("createMessageListQuery")]
		[Verify (MethodToProperty)]
		SBDMessageListQuery CreateMessageListQuery { get; }

		// -(void)createMetaCounters:(NSDictionary<NSString *,NSNumber *> * _Nonnull)metaCounters completionHandler:(void (^ _Nullable)(NSDictionary<NSString *,NSNumber *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("createMetaCounters:completionHandler:")]
		void CreateMetaCounters (NSDictionary<NSString, NSNumber> metaCounters, [NullAllowed] Action<NSDictionary<NSString, NSNumber>, SBDError> completionHandler);

		// -(void)getMetaCountersWithKeys:(NSArray<NSString *> * _Nullable)keys completionHandler:(void (^ _Nullable)(NSDictionary<NSString *,NSNumber *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("getMetaCountersWithKeys:completionHandler:")]
		void GetMetaCountersWithKeys ([NullAllowed] string[] keys, [NullAllowed] Action<NSDictionary<NSString, NSNumber>, SBDError> completionHandler);

		// -(void)getAllMetaCountersWithCompletionHandler:(void (^ _Nullable)(NSDictionary<NSString *,NSNumber *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("getAllMetaCountersWithCompletionHandler:")]
		void GetAllMetaCountersWithCompletionHandler ([NullAllowed] Action<NSDictionary<NSString, NSNumber>, SBDError> completionHandler);

		// -(void)updateMetaCounters:(NSDictionary<NSString *,NSNumber *> * _Nonnull)metaCounters completionHandler:(void (^ _Nullable)(NSDictionary<NSString *,NSNumber *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateMetaCounters:completionHandler:")]
		void UpdateMetaCounters (NSDictionary<NSString, NSNumber> metaCounters, [NullAllowed] Action<NSDictionary<NSString, NSNumber>, SBDError> completionHandler);

		// -(void)increaseMetaCounters:(NSDictionary<NSString *,NSNumber *> * _Nonnull)metaCounters completionHandler:(void (^ _Nullable)(NSDictionary<NSString *,NSNumber *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("increaseMetaCounters:completionHandler:")]
		void IncreaseMetaCounters (NSDictionary<NSString, NSNumber> metaCounters, [NullAllowed] Action<NSDictionary<NSString, NSNumber>, SBDError> completionHandler);

		// -(void)decreaseMetaCounters:(NSDictionary<NSString *,NSNumber *> * _Nonnull)metaCounters completionHandler:(void (^ _Nullable)(NSDictionary<NSString *,NSNumber *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("decreaseMetaCounters:completionHandler:")]
		void DecreaseMetaCounters (NSDictionary<NSString, NSNumber> metaCounters, [NullAllowed] Action<NSDictionary<NSString, NSNumber>, SBDError> completionHandler);

		// -(void)deleteMetaCountersWithKey:(NSString * _Nonnull)key completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("deleteMetaCountersWithKey:completionHandler:")]
		void DeleteMetaCountersWithKey (string key, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)deleteAllMetaCountersWithCompletionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("deleteAllMetaCountersWithCompletionHandler:")]
		void DeleteAllMetaCountersWithCompletionHandler ([NullAllowed] Action<SBDError> completionHandler);

		// -(void)createMetaData:(NSDictionary<NSString *,NSString *> * _Nonnull)metaData completionHandler:(void (^ _Nullable)(NSDictionary<NSString *,NSString *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("createMetaData:completionHandler:")]
		void CreateMetaData (NSDictionary<NSString, NSString> metaData, [NullAllowed] Action<NSDictionary<NSString, NSString>, SBDError> completionHandler);

		// -(void)getMetaDataWithKeys:(NSArray<NSString *> * _Nullable)keys completionHandler:(void (^ _Nullable)(NSDictionary<NSString *,NSObject *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("getMetaDataWithKeys:completionHandler:")]
		void GetMetaDataWithKeys ([NullAllowed] string[] keys, [NullAllowed] Action<NSDictionary<NSString, NSObject>, SBDError> completionHandler);

		// -(void)getAllMetaDataWithCompletionHandler:(void (^ _Nullable)(NSDictionary<NSString *,NSObject *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("getAllMetaDataWithCompletionHandler:")]
		void GetAllMetaDataWithCompletionHandler ([NullAllowed] Action<NSDictionary<NSString, NSObject>, SBDError> completionHandler);

		// -(void)updateMetaData:(NSDictionary<NSString *,NSString *> * _Nonnull)metaData completionHandler:(void (^ _Nullable)(NSDictionary<NSString *,NSObject *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateMetaData:completionHandler:")]
		void UpdateMetaData (NSDictionary<NSString, NSString> metaData, [NullAllowed] Action<NSDictionary<NSString, NSObject>, SBDError> completionHandler);

		// -(void)deleteMetaDataWithKey:(NSString * _Nonnull)key completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("deleteMetaDataWithKey:completionHandler:")]
		void DeleteMetaDataWithKey (string key, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)deleteAllMetaDataWithCompletionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("deleteAllMetaDataWithCompletionHandler:")]
		void DeleteAllMetaDataWithCompletionHandler ([NullAllowed] Action<SBDError> completionHandler);

		// -(void)deleteMessage:(SBDBaseMessage * _Nonnull)message completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("deleteMessage:completionHandler:")]
		void DeleteMessage (SBDBaseMessage message, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)updateUserMessage:(SBDUserMessage * _Nonnull)userMessage messageText:(NSString * _Nullable)messageText data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(SBDUserMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateUserMessage:messageText:data:customType:completionHandler:")]
		void UpdateUserMessage (SBDUserMessage userMessage, [NullAllowed] string messageText, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<SBDUserMessage, SBDError> completionHandler);

		// -(void)updateFileMessage:(SBDFileMessage * _Nonnull)fileMessage data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateFileMessage:data:customType:completionHandler:")]
		void UpdateFileMessage (SBDFileMessage fileMessage, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(BOOL)isGroupChannel;
		[Export ("isGroupChannel")]
		[Verify (MethodToProperty)]
		bool IsGroupChannel { get; }

		// -(BOOL)isOpenChannel;
		[Export ("isOpenChannel")]
		[Verify (MethodToProperty)]
		bool IsOpenChannel { get; }

		// -(void)getNextMessagesByTimestamp:(long long)timestamp limit:(NSInteger)limit reverse:(BOOL)reverse completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("getNextMessagesByTimestamp:limit:reverse:completionHandler:")]
		void GetNextMessagesByTimestamp (long timestamp, nint limit, bool reverse, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)getNextMessagesByTimestamp:(long long)timestamp limit:(NSInteger)limit reverse:(BOOL)reverse messageType:(SBDMessageTypeFilter)messageType customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("getNextMessagesByTimestamp:limit:reverse:messageType:customType:completionHandler:")]
		void GetNextMessagesByTimestamp (long timestamp, nint limit, bool reverse, SBDMessageTypeFilter messageType, [NullAllowed] string customType, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)getPreviousMessagesByTimestamp:(long long)timestamp limit:(NSInteger)limit reverse:(BOOL)reverse completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("getPreviousMessagesByTimestamp:limit:reverse:completionHandler:")]
		void GetPreviousMessagesByTimestamp (long timestamp, nint limit, bool reverse, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)getPreviousMessagesByTimestamp:(long long)timestamp limit:(NSInteger)limit reverse:(BOOL)reverse messageType:(SBDMessageTypeFilter)messageType customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("getPreviousMessagesByTimestamp:limit:reverse:messageType:customType:completionHandler:")]
		void GetPreviousMessagesByTimestamp (long timestamp, nint limit, bool reverse, SBDMessageTypeFilter messageType, [NullAllowed] string customType, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)getPreviousAndNextMessagesByTimestamp:(long long)timestamp prevLimit:(NSInteger)prevLimit nextLimit:(NSInteger)nextLimit reverse:(BOOL)reverse completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("getPreviousAndNextMessagesByTimestamp:prevLimit:nextLimit:reverse:completionHandler:")]
		void GetPreviousAndNextMessagesByTimestamp (long timestamp, nint prevLimit, nint nextLimit, bool reverse, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)getPreviousAndNextMessagesByTimestamp:(long long)timestamp prevLimit:(NSInteger)prevLimit nextLimit:(NSInteger)nextLimit reverse:(BOOL)reverse messageType:(SBDMessageTypeFilter)messageType customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("getPreviousAndNextMessagesByTimestamp:prevLimit:nextLimit:reverse:messageType:customType:completionHandler:")]
		void GetPreviousAndNextMessagesByTimestamp (long timestamp, nint prevLimit, nint nextLimit, bool reverse, SBDMessageTypeFilter messageType, [NullAllowed] string customType, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)getNextMessagesByMessageId:(long long)messageId limit:(NSInteger)limit reverse:(BOOL)reverse completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("getNextMessagesByMessageId:limit:reverse:completionHandler:")]
		void GetNextMessagesByMessageId (long messageId, nint limit, bool reverse, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)getNextMessagesByMessageId:(long long)messageId limit:(NSInteger)limit reverse:(BOOL)reverse messageType:(SBDMessageTypeFilter)messageType customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("getNextMessagesByMessageId:limit:reverse:messageType:customType:completionHandler:")]
		void GetNextMessagesByMessageId (long messageId, nint limit, bool reverse, SBDMessageTypeFilter messageType, [NullAllowed] string customType, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)getPreviousMessagesByMessageId:(long long)messageId limit:(NSInteger)limit reverse:(BOOL)reverse completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("getPreviousMessagesByMessageId:limit:reverse:completionHandler:")]
		void GetPreviousMessagesByMessageId (long messageId, nint limit, bool reverse, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)getPreviousMessagesByMessageId:(long long)messageId limit:(NSInteger)limit reverse:(BOOL)reverse messageType:(SBDMessageTypeFilter)messageType customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("getPreviousMessagesByMessageId:limit:reverse:messageType:customType:completionHandler:")]
		void GetPreviousMessagesByMessageId (long messageId, nint limit, bool reverse, SBDMessageTypeFilter messageType, [NullAllowed] string customType, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)getPreviousAndNextMessagesByMessageId:(long long)messageId prevLimit:(NSInteger)prevLimit nextLimit:(NSInteger)nextLimit reverse:(BOOL)reverse completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("getPreviousAndNextMessagesByMessageId:prevLimit:nextLimit:reverse:completionHandler:")]
		void GetPreviousAndNextMessagesByMessageId (long messageId, nint prevLimit, nint nextLimit, bool reverse, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)getPreviousAndNextMessagesByMessageId:(long long)messageId prevLimit:(NSInteger)prevLimit nextLimit:(NSInteger)nextLimit reverse:(BOOL)reverse messageType:(SBDMessageTypeFilter)messageType customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("getPreviousAndNextMessagesByMessageId:prevLimit:nextLimit:reverse:messageType:customType:completionHandler:")]
		void GetPreviousAndNextMessagesByMessageId (long messageId, nint prevLimit, nint nextLimit, bool reverse, SBDMessageTypeFilter messageType, [NullAllowed] string customType, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// +(instancetype _Nullable)buildFromSerializedData:(NSData * _Nonnull)data;
		[Static]
		[Export ("buildFromSerializedData:")]
		[return: NullAllowed]
		SBDBaseChannel BuildFromSerializedData (NSData data);

		// -(NSData * _Nullable)serialize;
		[NullAllowed, Export ("serialize")]
		[Verify (MethodToProperty)]
		NSData Serialize { get; }

		// +(void)cancelUploadingFileMessageWithRequestId:(NSString * _Nonnull)requestId completionHandler:(void (^ _Nullable)(BOOL, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("cancelUploadingFileMessageWithRequestId:completionHandler:")]
		void CancelUploadingFileMessageWithRequestId (string requestId, [NullAllowed] Action<bool, SBDError> completionHandler);

		// -(SBDUserMessage * _Nullable)copyUserMessage:(SBDUserMessage * _Nonnull)message toTargetChannel:(SBDBaseChannel * _Nonnull)targetChannel completionHandler:(void (^ _Nullable)(SBDUserMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("copyUserMessage:toTargetChannel:completionHandler:")]
		[return: NullAllowed]
		SBDUserMessage CopyUserMessage (SBDUserMessage message, SBDBaseChannel targetChannel, [NullAllowed] Action<SBDUserMessage, SBDError> completionHandler);

		// -(SBDFileMessage * _Nullable)copyFileMessage:(SBDFileMessage * _Nonnull)message toTargetChannel:(SBDBaseChannel * _Nonnull)targetChannel completionHandler:(void (^ _Nullable)(SBDFileMessage * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("copyFileMessage:toTargetChannel:completionHandler:")]
		[return: NullAllowed]
		SBDFileMessage CopyFileMessage (SBDFileMessage message, SBDBaseChannel targetChannel, [NullAllowed] Action<SBDFileMessage, SBDError> completionHandler);

		// -(NSDictionary * _Nullable)_toDictionary;
		[NullAllowed, Export ("_toDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary _toDictionary { get; }
	}

	// @interface SBDChannelEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDChannelEvent
	{
		// @property (readonly, nonatomic, strong) NSDictionary * _Nonnull data;
		[Export ("data", ArgumentSemantic.Strong)]
		NSDictionary Data { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull channelUrl;
		[Export ("channelUrl", ArgumentSemantic.Strong)]
		string ChannelUrl { get; }

		// @property (readonly, atomic) SBDChannelEventCategory channelEventCategory;
		[Export ("channelEventCategory")]
		SBDChannelEventCategory ChannelEventCategory { get; }

		// @property (atomic) NSInteger participantCount;
		[Export ("participantCount")]
		nint ParticipantCount { get; set; }

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// -(BOOL)isOpenChannel;
		[Export ("isOpenChannel")]
		[Verify (MethodToProperty)]
		bool IsOpenChannel { get; }

		// -(BOOL)isGroupChannel;
		[Export ("isGroupChannel")]
		[Verify (MethodToProperty)]
		bool IsGroupChannel { get; }
	}

	// @interface SBDGroupChannelListQuery : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDGroupChannelListQuery
	{
		// @property (atomic) NSUInteger limit;
		[Export ("limit")]
		nuint Limit { get; set; }

		// @property (atomic) BOOL includeEmptyChannel;
		[Export ("includeEmptyChannel")]
		bool IncludeEmptyChannel { get; set; }

		// @property (atomic) BOOL includeMemberList;
		[Export ("includeMemberList")]
		bool IncludeMemberList { get; set; }

		// @property (atomic) SBDGroupChannelListOrder order;
		[Export ("order", ArgumentSemantic.Assign)]
		SBDGroupChannelListOrder Order { get; set; }

		// @property (readonly, atomic) BOOL hasNext;
		[Export ("hasNext")]
		bool HasNext { get; }

		// @property (atomic) SBDGroupChannelListQueryType queryType;
		[Export ("queryType", ArgumentSemantic.Assign)]
		SBDGroupChannelListQueryType QueryType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable customTypeFilter;
		[NullAllowed, Export ("customTypeFilter", ArgumentSemantic.Strong)]
		string CustomTypeFilter { get; set; }

		// @property (atomic) SBDMemberStateFilter memberStateFilter;
		[Export ("memberStateFilter", ArgumentSemantic.Assign)]
		SBDMemberStateFilter MemberStateFilter { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable channelUrlsFilter;
		[NullAllowed, Export ("channelUrlsFilter", ArgumentSemantic.Strong)]
		string[] ChannelUrlsFilter { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable channelNameFilter;
		[NullAllowed, Export ("channelNameFilter", ArgumentSemantic.Strong)]
		string ChannelNameFilter { get; set; }

		// -(BOOL)isLoading;
		[Export ("isLoading")]
		[Verify (MethodToProperty)]
		bool IsLoading { get; }

		// -(instancetype _Nullable)initWithUser:(SBDUser * _Nonnull)user;
		[Export ("initWithUser:")]
		IntPtr Constructor (SBDUser user);

		// -(void)setNicknameContainsFilter:(NSString * _Nullable)nickname;
		[Export ("setNicknameContainsFilter:")]
		void SetNicknameContainsFilter ([NullAllowed] string nickname);

		// -(void)setUserIdsFilter:(NSArray<NSString *> * _Nonnull)userIds exactMatch:(BOOL)exactMatch __attribute__((deprecated("")));
		[Export ("setUserIdsFilter:exactMatch:")]
		void SetUserIdsFilter (string[] userIds, bool exactMatch);

		// -(void)setUserIdsIncludeFilter:(NSArray<NSString *> * _Nonnull)userIds queryType:(SBDGroupChannelListQueryType)queryType;
		[Export ("setUserIdsIncludeFilter:queryType:")]
		void SetUserIdsIncludeFilter (string[] userIds, SBDGroupChannelListQueryType queryType);

		// -(void)setUserIdsExactFilter:(NSArray<NSString *> * _Nonnull)userIds;
		[Export ("setUserIdsExactFilter:")]
		void SetUserIdsExactFilter (string[] userIds);

		// -(void)loadNextPageWithCompletionHandler:(void (^ _Nullable)(NSArray<SBDGroupChannel *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("loadNextPageWithCompletionHandler:")]
		void LoadNextPageWithCompletionHandler ([NullAllowed] Action<NSArray<SBDGroupChannel>, SBDError> completionHandler);
	}

	// @interface SBDGroupChannel : SBDBaseChannel
	[BaseType (typeof(SBDBaseChannel))]
	interface SBDGroupChannel
	{
		// @property (nonatomic, strong) SBDBaseMessage * _Nullable lastMessage;
		[NullAllowed, Export ("lastMessage", ArgumentSemantic.Strong)]
		SBDBaseMessage LastMessage { get; set; }

		// @property (atomic) BOOL isDistinct;
		[Export ("isDistinct")]
		bool IsDistinct { get; set; }

		// @property (atomic) NSUInteger unreadMessageCount;
		[Export ("unreadMessageCount")]
		nuint UnreadMessageCount { get; set; }

		// @property (readonly, nonatomic, strong) NSMutableArray<SBDMember *> * _Nullable members;
		[NullAllowed, Export ("members", ArgumentSemantic.Strong)]
		NSMutableArray<SBDMember> Members { get; }

		// @property (readonly, atomic) NSUInteger memberCount;
		[Export ("memberCount")]
		nuint MemberCount { get; }

		// @property (atomic) BOOL sendMarkAsReadEnable __attribute__((deprecated("")));
		[Export ("sendMarkAsReadEnable")]
		bool SendMarkAsReadEnable { get; set; }

		// @property (readonly, atomic) BOOL isPushEnabled;
		[Export ("isPushEnabled")]
		bool IsPushEnabled { get; }

		// @property (atomic) BOOL hasBeenUpdated;
		[Export ("hasBeenUpdated")]
		bool HasBeenUpdated { get; set; }

		// -(void)refreshWithCompletionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("refreshWithCompletionHandler:")]
		void RefreshWithCompletionHandler ([NullAllowed] Action<SBDError> completionHandler);

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// +(SBDGroupChannelListQuery * _Nullable)createMyGroupChannelListQuery;
		[Static]
		[NullAllowed, Export ("createMyGroupChannelListQuery")]
		[Verify (MethodToProperty)]
		SBDGroupChannelListQuery CreateMyGroupChannelListQuery { get; }

		// +(void)createChannelWithUsers:(NSArray<SBDUser *> * _Nonnull)users isDistinct:(BOOL)isDistinct completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithUsers:isDistinct:completionHandler:")]
		void CreateChannelWithUsers (SBDUser[] users, bool isDistinct, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithUserIds:(NSArray<NSString *> * _Nonnull)userIds isDistinct:(BOOL)isDistinct completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithUserIds:isDistinct:completionHandler:")]
		void CreateChannelWithUserIds (string[] userIds, bool isDistinct, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name users:(NSArray<SBDUser *> * _Nonnull)users coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:users:coverUrl:data:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, SBDUser[] users, [NullAllowed] string coverUrl, [NullAllowed] string data, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name users:(NSArray<SBDUser *> * _Nonnull)users coverImage:(NSData * _Nonnull)coverImage coverImageName:(NSString * _Nonnull)coverImageName data:(NSString * _Nullable)data progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:users:coverImage:coverImageName:data:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, SBDUser[] users, NSData coverImage, string coverImageName, [NullAllowed] string data, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name userIds:(NSArray<NSString *> * _Nonnull)userIds coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:userIds:coverUrl:data:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, string[] userIds, [NullAllowed] string coverUrl, [NullAllowed] string data, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name userIds:(NSArray<NSString *> * _Nonnull)userIds coverImage:(NSData * _Nonnull)coverImage coverImageName:(NSString * _Nonnull)coverImageName data:(NSString * _Nullable)data progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:userIds:coverImage:coverImageName:data:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, string[] userIds, NSData coverImage, string coverImageName, [NullAllowed] string data, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct users:(NSArray<SBDUser *> * _Nonnull)users coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:isDistinct:users:coverUrl:data:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, bool isDistinct, SBDUser[] users, [NullAllowed] string coverUrl, [NullAllowed] string data, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct users:(NSArray<SBDUser *> * _Nonnull)users coverImage:(NSData * _Nonnull)coverImage coverImageName:(NSString * _Nonnull)coverImageName data:(NSString * _Nullable)data progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:isDistinct:users:coverImage:coverImageName:data:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, bool isDistinct, SBDUser[] users, NSData coverImage, string coverImageName, [NullAllowed] string data, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct userIds:(NSArray<NSString *> * _Nonnull)userIds coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:isDistinct:userIds:coverUrl:data:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, bool isDistinct, string[] userIds, [NullAllowed] string coverUrl, [NullAllowed] string data, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct userIds:(NSArray<NSString *> * _Nonnull)userIds coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:isDistinct:userIds:coverUrl:data:customType:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, bool isDistinct, string[] userIds, [NullAllowed] string coverUrl, [NullAllowed] string data, [NullAllowed] string customType, Action<SBDGroupChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:isDistinct:coverUrl:data:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, bool isDistinct, [NullAllowed] string coverUrl, [NullAllowed] string data, Action<SBDGroupChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:isDistinct:coverUrl:data:customType:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, bool isDistinct, [NullAllowed] string coverUrl, [NullAllowed] string data, [NullAllowed] string customType, Action<SBDGroupChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:coverUrl:data:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, [NullAllowed] string coverUrl, [NullAllowed] string data, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct userIds:(NSArray<NSString *> * _Nonnull)userIds coverImage:(NSData * _Nonnull)coverImage coverImageName:(NSString * _Nonnull)coverImageName data:(NSString * _Nullable)data progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:isDistinct:userIds:coverImage:coverImageName:data:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, bool isDistinct, string[] userIds, NSData coverImage, string coverImageName, [NullAllowed] string data, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct userIds:(NSArray<NSString *> * _Nonnull)userIds coverImage:(NSData * _Nonnull)coverImage coverImageName:(NSString * _Nonnull)coverImageName data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:isDistinct:userIds:coverImage:coverImageName:data:customType:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, bool isDistinct, string[] userIds, NSData coverImage, string coverImageName, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct userIds:(NSArray<NSString *> * _Nonnull)userIds coverImageFilePath:(NSString * _Nonnull)coverImageFilePath data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:isDistinct:userIds:coverImageFilePath:data:customType:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, bool isDistinct, string[] userIds, string coverImageFilePath, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDGroupChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct coverImage:(NSData * _Nullable)coverImage coverImageName:(NSString * _Nullable)coverImageName data:(NSString * _Nullable)data progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:isDistinct:coverImage:coverImageName:data:progressHandler:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, bool isDistinct, [NullAllowed] NSData coverImage, [NullAllowed] string coverImageName, [NullAllowed] string data, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDGroupChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct coverImage:(NSData * _Nullable)coverImage coverImageName:(NSString * _Nullable)coverImageName data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:isDistinct:coverImage:coverImageName:data:customType:progressHandler:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, bool isDistinct, [NullAllowed] NSData coverImage, [NullAllowed] string coverImageName, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDGroupChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name isDistinct:(BOOL)isDistinct coverImageFilePath:(NSString * _Nullable)coverImageFilePath data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:isDistinct:coverImageFilePath:data:customType:progressHandler:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, bool isDistinct, [NullAllowed] string coverImageFilePath, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDGroupChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name coverImage:(NSData * _Nullable)coverImage coverImageName:(NSString * _Nullable)coverImageName data:(NSString * _Nullable)data progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:coverImage:coverImageName:data:progressHandler:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, [NullAllowed] NSData coverImage, [NullAllowed] string coverImageName, [NullAllowed] string data, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)getChannelWithoutCache:(NSString * _Nonnull)channelUrl completionHandler:(void (^ _Nullable)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("getChannelWithoutCache:completionHandler:")]
		void GetChannelWithoutCache (string channelUrl, [NullAllowed] Action<SBDGroupChannel, SBDError> completionHandler);

		// +(void)getChannelWithUrl:(NSString * _Nonnull)channelUrl completionHandler:(void (^ _Nullable)(SBDGroupChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("getChannelWithUrl:completionHandler:")]
		void GetChannelWithUrl (string channelUrl, [NullAllowed] Action<SBDGroupChannel, SBDError> completionHandler);

		// -(void)inviteUser:(SBDUser * _Nonnull)user completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("inviteUser:completionHandler:")]
		void InviteUser (SBDUser user, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)inviteUserId:(NSString * _Nonnull)userId completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("inviteUserId:completionHandler:")]
		void InviteUserId (string userId, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)inviteUsers:(NSArray<SBDUser *> * _Nonnull)users completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("inviteUsers:completionHandler:")]
		void InviteUsers (SBDUser[] users, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)inviteUserIds:(NSArray<NSString *> * _Nonnull)userIds completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("inviteUserIds:completionHandler:")]
		void InviteUserIds (string[] userIds, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)hideChannelWithCompletionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("hideChannelWithCompletionHandler:")]
		void HideChannelWithCompletionHandler ([NullAllowed] Action<SBDError> completionHandler);

		// -(void)leaveChannelWithCompletionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("leaveChannelWithCompletionHandler:")]
		void LeaveChannelWithCompletionHandler ([NullAllowed] Action<SBDError> completionHandler);

		// +(void)markAsReadAllWithCompletionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("markAsReadAllWithCompletionHandler:")]
		void MarkAsReadAllWithCompletionHandler ([NullAllowed] Action<SBDError> completionHandler);

		// +(void)_markAsRead __attribute__((deprecated("")));
		[Static]
		[Export ("_markAsRead")]
		void _markAsRead ();

		// -(void)markAsRead;
		[Export ("markAsRead")]
		void MarkAsRead ();

		// -(void)startTyping;
		[Export ("startTyping")]
		void StartTyping ();

		// -(void)endTyping;
		[Export ("endTyping")]
		void EndTyping ();

		// +(void)clearCache;
		[Static]
		[Export ("clearCache")]
		void ClearCache ();

		// +(void)removeChannelFromCacheWithChannelUrl:(NSString * _Nonnull)channelUrl;
		[Static]
		[Export ("removeChannelFromCacheWithChannelUrl:")]
		void RemoveChannelFromCacheWithChannelUrl (string channelUrl);

		// +(SBDGroupChannel * _Nullable)getChannelFromCacheWithChannelUrl:(NSString * _Nonnull)channelUrl;
		[Static]
		[Export ("getChannelFromCacheWithChannelUrl:")]
		[return: NullAllowed]
		SBDGroupChannel GetChannelFromCacheWithChannelUrl (string channelUrl);

		// -(int)getReadReceiptOfMessage:(SBDBaseMessage * _Nonnull)message;
		[Export ("getReadReceiptOfMessage:")]
		int GetReadReceiptOfMessage (SBDBaseMessage message);

		// -(long long)getLastSeenAtByUser:(SBDUser * _Nonnull)user;
		[Export ("getLastSeenAtByUser:")]
		long GetLastSeenAtByUser (SBDUser user);

		// -(long long)getLastSeenAtByUserId:(NSString * _Nonnull)userId;
		[Export ("getLastSeenAtByUserId:")]
		long GetLastSeenAtByUserId (string userId);

		// -(NSArray<SBDMember *> * _Nullable)getReadMembersWithMessage:(SBDBaseMessage * _Nonnull)message;
		[Export ("getReadMembersWithMessage:")]
		[return: NullAllowed]
		SBDMember[] GetReadMembersWithMessage (SBDBaseMessage message);

		// -(NSArray<SBDMember *> * _Nullable)getUnreadMemebersWithMessage:(SBDBaseMessage * _Nonnull)message;
		[Export ("getUnreadMemebersWithMessage:")]
		[return: NullAllowed]
		SBDMember[] GetUnreadMemebersWithMessage (SBDBaseMessage message);

		// -(NSDictionary<NSString *,NSDictionary<NSString *,NSObject *> *> * _Nullable)getReadStatus;
		[NullAllowed, Export ("getReadStatus")]
		[Verify (MethodToProperty)]
		NSDictionary<NSString, NSDictionary<NSString, NSObject>> ReadStatus { get; }

		// -(BOOL)isTyping;
		[Export ("isTyping")]
		[Verify (MethodToProperty)]
		bool IsTyping { get; }

		// -(NSArray<SBDMember *> * _Nullable)getTypingMembers;
		[NullAllowed, Export ("getTypingMembers")]
		[Verify (MethodToProperty)]
		SBDMember[] TypingMembers { get; }

		// -(void)updateReadReceiptWithUserId:(NSString * _Nonnull)userId timestamp:(long long)timestamp;
		[Export ("updateReadReceiptWithUserId:timestamp:")]
		void UpdateReadReceiptWithUserId (string userId, long timestamp);

		// -(void)updateTypingStatusWithUser:(SBDUser * _Nonnull)user start:(BOOL)start;
		[Export ("updateTypingStatusWithUser:start:")]
		void UpdateTypingStatusWithUser (SBDUser user, bool start);

		// -(void)addMember:(SBDMember * _Nonnull)user;
		[Export ("addMember:")]
		void AddMember (SBDMember user);

		// -(SBDMember * _Nullable)removeMember:(SBDMember * _Nonnull)user;
		[Export ("removeMember:")]
		[return: NullAllowed]
		SBDMember RemoveMember (SBDMember user);

		// -(void)typingStatusTimeout;
		[Export ("typingStatusTimeout")]
		void TypingStatusTimeout ();

		// +(void)updateTypingStatus;
		[Static]
		[Export ("updateTypingStatus")]
		void UpdateTypingStatus ();

		// -(void)setPushPreferenceWithPushOn:(BOOL)pushOn completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("setPushPreferenceWithPushOn:completionHandler:")]
		void SetPushPreferenceWithPushOn (bool pushOn, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)getPushPreferenceWithCompletionHandler:(void (^ _Nullable)(BOOL, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("getPushPreferenceWithCompletionHandler:")]
		void GetPushPreferenceWithCompletionHandler ([NullAllowed] Action<bool, SBDError> completionHandler);

		// +(void)getTotalUnreadMessageCountWithCompletionHandler:(void (^ _Nullable)(NSUInteger, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("getTotalUnreadMessageCountWithCompletionHandler:")]
		void GetTotalUnreadMessageCountWithCompletionHandler ([NullAllowed] Action<nuint, SBDError> completionHandler);

		// +(void)getTotalUnreadChannelCountWithCompletionHandler:(void (^ _Nullable)(NSUInteger, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("getTotalUnreadChannelCountWithCompletionHandler:")]
		void GetTotalUnreadChannelCountWithCompletionHandler ([NullAllowed] Action<nuint, SBDError> completionHandler);

		// +(instancetype _Nullable)buildFromSerializedData:(NSData * _Nonnull)data;
		[Static]
		[Export ("buildFromSerializedData:")]
		[return: NullAllowed]
		SBDGroupChannel BuildFromSerializedData (NSData data);

		// -(NSData * _Nullable)serialize;
		[NullAllowed, Export ("serialize")]
		[Verify (MethodToProperty)]
		NSData Serialize { get; }

		// +(BOOL)hasChannelInCache:(NSString * _Nonnull)channelUrl;
		[Static]
		[Export ("hasChannelInCache:")]
		bool HasChannelInCache (string channelUrl);

		// -(BOOL)hasMember:(NSString * _Nonnull)userId;
		[Export ("hasMember:")]
		bool HasMember (string userId);

		// -(SBDMember * _Nullable)getMember:(NSString * _Nonnull)userId;
		[Export ("getMember:")]
		[return: NullAllowed]
		SBDMember GetMember (string userId);

		// -(void)acceptInvitationWithCompletionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("acceptInvitationWithCompletionHandler:")]
		void AcceptInvitationWithCompletionHandler ([NullAllowed] Action<SBDError> completionHandler);

		// -(void)declineInvitationWithCompletionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("declineInvitationWithCompletionHandler:")]
		void DeclineInvitationWithCompletionHandler ([NullAllowed] Action<SBDError> completionHandler);

		// -(SBDUser * _Nullable)getInviter;
		[NullAllowed, Export ("getInviter")]
		[Verify (MethodToProperty)]
		SBDUser Inviter { get; }

		// -(NSDictionary * _Nullable)_toDictionary;
		[NullAllowed, Export ("_toDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary _toDictionary { get; }
	}

	// @interface SBDCommand : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDCommand
	{
		// @property (readonly, nonatomic, strong) NSString * _Nullable cmd;
		[NullAllowed, Export ("cmd", ArgumentSemantic.Strong)]
		string Cmd { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable payload;
		[NullAllowed, Export ("payload", ArgumentSemantic.Strong)]
		string Payload { get; }

		// @property (readonly, nonatomic, strong) NSMutableDictionary * _Nullable payloadDictionary;
		[NullAllowed, Export ("payloadDictionary", ArgumentSemantic.Strong)]
		NSMutableDictionary PayloadDictionary { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable requestId;
		[NullAllowed, Export ("requestId", ArgumentSemantic.Strong)]
		string RequestId { get; }

		// -(NSString * _Nullable)encode;
		[NullAllowed, Export ("encode")]
		[Verify (MethodToProperty)]
		string Encode { get; }

		// -(BOOL)isAckRequired;
		[Export ("isAckRequired")]
		[Verify (MethodToProperty)]
		bool IsAckRequired { get; }

		// -(BOOL)hasRequestId;
		[Export ("hasRequestId")]
		[Verify (MethodToProperty)]
		bool HasRequestId { get; }

		// +(SBDCommand * _Nullable)parseMessage:(NSString * _Nonnull)message;
		[Static]
		[Export ("parseMessage:")]
		[return: NullAllowed]
		SBDCommand ParseMessage (string message);

		// +(SBDCommand * _Nullable)buildEnterChannel:(SBDBaseChannel * _Nonnull)channel;
		[Static]
		[Export ("buildEnterChannel:")]
		[return: NullAllowed]
		SBDCommand BuildEnterChannel (SBDBaseChannel channel);

		// +(SBDCommand * _Nullable)buildExitChannel:(SBDBaseChannel * _Nonnull)aUser;
		[Static]
		[Export ("buildExitChannel:")]
		[return: NullAllowed]
		SBDCommand BuildExitChannel (SBDBaseChannel aUser);

		// +(SBDCommand * _Nullable)buildUserMessageWithChannelUrl:(NSString * _Nonnull)channelUrl messageText:(NSString * _Nonnull)messageText data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType targetLanguages:(NSArray<NSString *> * _Nullable)targetLanguages;
		[Static]
		[Export ("buildUserMessageWithChannelUrl:messageText:data:customType:targetLanguages:")]
		[return: NullAllowed]
		SBDCommand BuildUserMessageWithChannelUrl (string channelUrl, string messageText, [NullAllowed] string data, [NullAllowed] string customType, [NullAllowed] string[] targetLanguages);

		// +(SBDCommand * _Nullable)buildUpdateUserMessageWithChannelUrl:(NSString * _Nonnull)channelUrl messageId:(long long)messageId messageText:(NSString * _Nullable)messageText data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType;
		[Static]
		[Export ("buildUpdateUserMessageWithChannelUrl:messageId:messageText:data:customType:")]
		[return: NullAllowed]
		SBDCommand BuildUpdateUserMessageWithChannelUrl (string channelUrl, long messageId, [NullAllowed] string messageText, [NullAllowed] string data, [NullAllowed] string customType);

		// +(SBDCommand * _Nullable)buildFileMessageWithFileUrl:(NSString * _Nonnull)fileUrl name:(NSString * _Nullable)name type:(NSString * _Nullable)type size:(NSUInteger)size data:(NSString * _Nullable)data requestId:(NSString * _Nullable)requestId channel:(SBDBaseChannel * _Nonnull)channel customType:(NSString * _Nullable)customType thumbnails:(NSArray * _Nullable)thumbnails __attribute__((deprecated("")));
		[Static]
		[Export ("buildFileMessageWithFileUrl:name:type:size:data:requestId:channel:customType:thumbnails:")]
		[Verify (StronglyTypedNSArray)]
		[return: NullAllowed]
		SBDCommand BuildFileMessageWithFileUrl (string fileUrl, [NullAllowed] string name, [NullAllowed] string type, nuint size, [NullAllowed] string data, [NullAllowed] string requestId, SBDBaseChannel channel, [NullAllowed] string customType, [NullAllowed] NSObject[] thumbnails);

		// +(SBDCommand * _Nullable)buildFileMessageWithFileUrl:(NSString * _Nonnull)fileUrl name:(NSString * _Nullable)name type:(NSString * _Nullable)type size:(NSUInteger)size data:(NSString * _Nullable)data requestId:(NSString * _Nullable)requestId channel:(SBDBaseChannel * _Nonnull)channel customType:(NSString * _Nullable)customType thumbnails:(NSArray * _Nullable)thumbnails requireAuth:(BOOL)requireAuth;
		[Static]
		[Export ("buildFileMessageWithFileUrl:name:type:size:data:requestId:channel:customType:thumbnails:requireAuth:")]
		[Verify (StronglyTypedNSArray)]
		[return: NullAllowed]
		SBDCommand BuildFileMessageWithFileUrl (string fileUrl, [NullAllowed] string name, [NullAllowed] string type, nuint size, [NullAllowed] string data, [NullAllowed] string requestId, SBDBaseChannel channel, [NullAllowed] string customType, [NullAllowed] NSObject[] thumbnails, bool requireAuth);

		// +(SBDCommand * _Nullable)buildUpdateFileMessageWithChannelUrl:(NSString * _Nonnull)channelUrl messageId:(long long)messageId data:(NSString * _Nullable)data customType:(NSString * _Nullable)customType;
		[Static]
		[Export ("buildUpdateFileMessageWithChannelUrl:messageId:data:customType:")]
		[return: NullAllowed]
		SBDCommand BuildUpdateFileMessageWithChannelUrl (string channelUrl, long messageId, [NullAllowed] string data, [NullAllowed] string customType);

		// +(SBDCommand * _Nullable)buildPing;
		[Static]
		[NullAllowed, Export ("buildPing")]
		[Verify (MethodToProperty)]
		SBDCommand BuildPing { get; }

		// +(SBDCommand * _Nullable)buildStartTyping:(SBDGroupChannel * _Nonnull)channel startAt:(long long)startAt;
		[Static]
		[Export ("buildStartTyping:startAt:")]
		[return: NullAllowed]
		SBDCommand BuildStartTyping (SBDGroupChannel channel, long startAt);

		// +(SBDCommand * _Nullable)buildEndTyping:(SBDGroupChannel * _Nonnull)channel endAt:(long long)endAt;
		[Static]
		[Export ("buildEndTyping:endAt:")]
		[return: NullAllowed]
		SBDCommand BuildEndTyping (SBDGroupChannel channel, long endAt);

		// +(SBDCommand * _Nullable)buildReadOfChannel:(SBDGroupChannel * _Nonnull)channel;
		[Static]
		[Export ("buildReadOfChannel:")]
		[return: NullAllowed]
		SBDCommand BuildReadOfChannel (SBDGroupChannel channel);
	}

	// @interface SBDUserListQuery : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDUserListQuery
	{
		// @property (readonly, strong) SBDBaseChannel * _Nullable channel;
		[NullAllowed, Export ("channel", ArgumentSemantic.Strong)]
		SBDBaseChannel Channel { get; }

		// @property (readonly, atomic) SBDUserListQueryType queryType;
		[Export ("queryType")]
		SBDUserListQueryType QueryType { get; }

		// @property (atomic) NSUInteger limit;
		[Export ("limit")]
		nuint Limit { get; set; }

		// @property (readonly, atomic) BOOL hasNext;
		[Export ("hasNext")]
		bool HasNext { get; }

		// -(instancetype _Nullable)initWithQueryType:(SBDUserListQueryType)queryType channel:(SBDBaseChannel * _Nullable)channel;
		[Export ("initWithQueryType:channel:")]
		IntPtr Constructor (SBDUserListQueryType queryType, [NullAllowed] SBDBaseChannel channel);

		// -(instancetype _Nullable)initWithUserIds:(NSArray<NSString *> * _Nonnull)userIds;
		[Export ("initWithUserIds:")]
		IntPtr Constructor (string[] userIds);

		// -(BOOL)isLoading;
		[Export ("isLoading")]
		[Verify (MethodToProperty)]
		bool IsLoading { get; }

		// -(void)loadNextPageWithCompletionHandler:(void (^ _Nullable)(NSArray<SBDUser *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("loadNextPageWithCompletionHandler:")]
		void LoadNextPageWithCompletionHandler ([NullAllowed] Action<NSArray<SBDUser>, SBDError> completionHandler);
	}

	// @interface SBDOpenChannel : SBDBaseChannel
	[BaseType (typeof(SBDBaseChannel))]
	interface SBDOpenChannel
	{
		// @property (nonatomic) NSInteger participantCount;
		[Export ("participantCount")]
		nint ParticipantCount { get; set; }

		// @property (readonly, nonatomic, strong) NSMutableArray<SBDUser *> * _Nullable operators;
		[NullAllowed, Export ("operators", ArgumentSemantic.Strong)]
		NSMutableArray<SBDUser> Operators { get; }

		// +(void)clearCache;
		[Static]
		[Export ("clearCache")]
		void ClearCache ();

		// +(void)clearEnteredChannels;
		[Static]
		[Export ("clearEnteredChannels")]
		void ClearEnteredChannels ();

		// +(void)removeChannelFromCacheWithChannelUrl:(NSString * _Nonnull)channelUrl;
		[Static]
		[Export ("removeChannelFromCacheWithChannelUrl:")]
		void RemoveChannelFromCacheWithChannelUrl (string channelUrl);

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);

		// +(SBDOpenChannelListQuery * _Nullable)createOpenChannelListQuery;
		[Static]
		[NullAllowed, Export ("createOpenChannelListQuery")]
		[Verify (MethodToProperty)]
		SBDOpenChannelListQuery CreateOpenChannelListQuery { get; }

		// +(void)createChannelWithCompletionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithCompletionHandler:")]
		void CreateChannelWithCompletionHandler (Action<SBDOpenChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data operatorUsers:(NSArray<SBDUser *> * _Nullable)operatorUsers completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:coverUrl:data:operatorUsers:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, [NullAllowed] string coverUrl, [NullAllowed] string data, [NullAllowed] SBDUser[] operatorUsers, Action<SBDOpenChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data operatorUsers:(NSArray<SBDUser *> * _Nullable)operatorUsers completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:coverUrl:data:operatorUsers:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, [NullAllowed] string coverUrl, [NullAllowed] string data, [NullAllowed] SBDUser[] operatorUsers, Action<SBDOpenChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name coverImage:(NSData * _Nonnull)coverImage coverImageName:(NSString * _Nonnull)coverImageName data:(NSString * _Nullable)data operatorUsers:(NSArray<SBDUser *> * _Nullable)operatorUsers progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:coverImage:coverImageName:data:operatorUsers:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, NSData coverImage, string coverImageName, [NullAllowed] string data, [NullAllowed] SBDUser[] operatorUsers, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDOpenChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name coverImage:(NSData * _Nullable)coverImage coverImageName:(NSString * _Nullable)coverImageName data:(NSString * _Nullable)data operatorUsers:(NSArray<SBDUser *> * _Nullable)operatorUsers progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:coverImage:coverImageName:data:operatorUsers:progressHandler:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, [NullAllowed] NSData coverImage, [NullAllowed] string coverImageName, [NullAllowed] string data, [NullAllowed] SBDUser[] operatorUsers, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDOpenChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:coverUrl:data:operatorUserIds:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, [NullAllowed] string coverUrl, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, Action<SBDOpenChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:coverUrl:data:operatorUserIds:customType:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, [NullAllowed] string coverUrl, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, [NullAllowed] string customType, Action<SBDOpenChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name channelUrl:(NSString * _Nullable)channelUrl coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:channelUrl:coverUrl:data:operatorUserIds:customType:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, [NullAllowed] string channelUrl, [NullAllowed] string coverUrl, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, [NullAllowed] string customType, Action<SBDOpenChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:coverUrl:data:operatorUserIds:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, [NullAllowed] string coverUrl, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, Action<SBDOpenChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name coverUrl:(NSString * _Nullable)coverUrl data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds customType:(NSString * _Nullable)customType completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:coverUrl:data:operatorUserIds:customType:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, [NullAllowed] string coverUrl, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, [NullAllowed] string customType, Action<SBDOpenChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name coverImage:(NSData * _Nonnull)coverImage coverImageName:(NSString * _Nonnull)coverImageName data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:coverImage:coverImageName:data:operatorUserIds:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, NSData coverImage, string coverImageName, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDOpenChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name coverImage:(NSData * _Nonnull)coverImage coverImageName:(NSString * _Nonnull)coverImageName data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:coverImage:coverImageName:data:operatorUserIds:customType:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, NSData coverImage, string coverImageName, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDOpenChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name channelUrl:(NSString * _Nullable)channelUrl coverImage:(NSData * _Nonnull)coverImage coverImageName:(NSString * _Nonnull)coverImageName data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:channelUrl:coverImage:coverImageName:data:operatorUserIds:customType:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, [NullAllowed] string channelUrl, NSData coverImage, string coverImageName, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDOpenChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name coverImageFilePath:(NSString * _Nonnull)coverImageFilePath data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:coverImageFilePath:data:operatorUserIds:customType:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, string coverImageFilePath, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDOpenChannel, SBDError> completionHandler);

		// +(void)createChannelWithName:(NSString * _Nullable)name channelUrl:(NSString * _Nullable)channelUrl coverImageFilePath:(NSString * _Nonnull)coverImageFilePath data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("createChannelWithName:channelUrl:coverImageFilePath:data:operatorUserIds:customType:progressHandler:completionHandler:")]
		void CreateChannelWithName ([NullAllowed] string name, [NullAllowed] string channelUrl, string coverImageFilePath, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDOpenChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name coverImage:(NSData * _Nullable)coverImage coverImageName:(NSString * _Nullable)coverImageName data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:coverImage:coverImageName:data:operatorUserIds:progressHandler:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, [NullAllowed] NSData coverImage, [NullAllowed] string coverImageName, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDOpenChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name coverImage:(NSData * _Nullable)coverImage coverImageName:(NSString * _Nullable)coverImageName data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:coverImage:coverImageName:data:operatorUserIds:customType:progressHandler:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, [NullAllowed] NSData coverImage, [NullAllowed] string coverImageName, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDOpenChannel, SBDError> completionHandler);

		// -(void)updateChannelWithName:(NSString * _Nullable)name coverImageFilePath:(NSString * _Nullable)coverImageFilePath data:(NSString * _Nullable)data operatorUserIds:(NSArray<NSString *> * _Nullable)operatorUserIds customType:(NSString * _Nullable)customType progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nonnull)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("updateChannelWithName:coverImageFilePath:data:operatorUserIds:customType:progressHandler:completionHandler:")]
		void UpdateChannelWithName ([NullAllowed] string name, [NullAllowed] string coverImageFilePath, [NullAllowed] string data, [NullAllowed] string[] operatorUserIds, [NullAllowed] string customType, [NullAllowed] Action<long, long, long> progressHandler, Action<SBDOpenChannel, SBDError> completionHandler);

		// +(void)getChannelWithUrl:(NSString * _Nonnull)channelUrl completionHandler:(void (^ _Nullable)(SBDOpenChannel * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("getChannelWithUrl:completionHandler:")]
		void GetChannelWithUrl (string channelUrl, [NullAllowed] Action<SBDOpenChannel, SBDError> completionHandler);

		// -(void)enterChannelWithCompletionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("enterChannelWithCompletionHandler:")]
		void EnterChannelWithCompletionHandler ([NullAllowed] Action<SBDError> completionHandler);

		// -(void)exitChannelWithCompletionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("exitChannelWithCompletionHandler:")]
		void ExitChannelWithCompletionHandler ([NullAllowed] Action<SBDError> completionHandler);

		// -(SBDUserListQuery * _Nullable)createParticipantListQuery;
		[NullAllowed, Export ("createParticipantListQuery")]
		[Verify (MethodToProperty)]
		SBDUserListQuery CreateParticipantListQuery { get; }

		// -(SBDUserListQuery * _Nullable)createMutedUserListQuery;
		[NullAllowed, Export ("createMutedUserListQuery")]
		[Verify (MethodToProperty)]
		SBDUserListQuery CreateMutedUserListQuery { get; }

		// -(SBDUserListQuery * _Nullable)createBannedUserListQuery;
		[NullAllowed, Export ("createBannedUserListQuery")]
		[Verify (MethodToProperty)]
		SBDUserListQuery CreateBannedUserListQuery { get; }

		// -(void)refreshWithCompletionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("refreshWithCompletionHandler:")]
		void RefreshWithCompletionHandler ([NullAllowed] Action<SBDError> completionHandler);

		// +(NSMutableDictionary<NSString *,SBDOpenChannel *> * _Nullable)enteredChannels;
		[Static]
		[NullAllowed, Export ("enteredChannels")]
		[Verify (MethodToProperty)]
		NSMutableDictionary<NSString, SBDOpenChannel> EnteredChannels { get; }

		// -(void)banUser:(SBDUser * _Nonnull)user seconds:(int)seconds completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("banUser:seconds:completionHandler:")]
		void BanUser (SBDUser user, int seconds, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)banUserWithUserId:(NSString * _Nonnull)userId seconds:(int)seconds completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("banUserWithUserId:seconds:completionHandler:")]
		void BanUserWithUserId (string userId, int seconds, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)unbanUser:(SBDUser * _Nonnull)user completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("unbanUser:completionHandler:")]
		void UnbanUser (SBDUser user, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)unbanUserWithUserId:(NSString * _Nonnull)userId completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("unbanUserWithUserId:completionHandler:")]
		void UnbanUserWithUserId (string userId, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)muteUser:(SBDUser * _Nonnull)user completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("muteUser:completionHandler:")]
		void MuteUser (SBDUser user, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)muteUserWithUserId:(NSString * _Nonnull)userId completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("muteUserWithUserId:completionHandler:")]
		void MuteUserWithUserId (string userId, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)unmuteUser:(SBDUser * _Nonnull)user completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("unmuteUser:completionHandler:")]
		void UnmuteUser (SBDUser user, [NullAllowed] Action<SBDError> completionHandler);

		// -(void)unmuteUserWithUserId:(NSString * _Nonnull)userId completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Export ("unmuteUserWithUserId:completionHandler:")]
		void UnmuteUserWithUserId (string userId, [NullAllowed] Action<SBDError> completionHandler);

		// -(BOOL)isOperatorWithUser:(SBDUser * _Nonnull)user;
		[Export ("isOperatorWithUser:")]
		bool IsOperatorWithUser (SBDUser user);

		// -(BOOL)isOperatorWithUserId:(NSString * _Nonnull)userId;
		[Export ("isOperatorWithUserId:")]
		bool IsOperatorWithUserId (string userId);

		// +(instancetype _Nullable)buildFromSerializedData:(NSData * _Nonnull)data;
		[Static]
		[Export ("buildFromSerializedData:")]
		[return: NullAllowed]
		SBDOpenChannel BuildFromSerializedData (NSData data);

		// -(NSData * _Nullable)serialize;
		[NullAllowed, Export ("serialize")]
		[Verify (MethodToProperty)]
		NSData Serialize { get; }

		// -(NSDictionary * _Nullable)_toDictionary;
		[NullAllowed, Export ("_toDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary _toDictionary { get; }
	}

	// @interface SBDOpenChannelListQuery : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDOpenChannelListQuery
	{
		// @property (atomic) NSUInteger limit;
		[Export ("limit")]
		nuint Limit { get; set; }

		// @property (readonly, atomic) BOOL hasNext;
		[Export ("hasNext")]
		bool HasNext { get; }

		// @property (nonatomic, strong) NSString * _Nullable urlKeyword;
		[NullAllowed, Export ("urlKeyword", ArgumentSemantic.Strong)]
		string UrlKeyword { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nameKeyword;
		[NullAllowed, Export ("nameKeyword", ArgumentSemantic.Strong)]
		string NameKeyword { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable customTypeFilter;
		[NullAllowed, Export ("customTypeFilter", ArgumentSemantic.Strong)]
		string CustomTypeFilter { get; set; }

		// -(BOOL)isLoading;
		[Export ("isLoading")]
		[Verify (MethodToProperty)]
		bool IsLoading { get; }

		// -(void)loadNextPageWithCompletionHandler:(void (^ _Nullable)(NSArray<SBDOpenChannel *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("loadNextPageWithCompletionHandler:")]
		void LoadNextPageWithCompletionHandler ([NullAllowed] Action<NSArray<SBDOpenChannel>, SBDError> completionHandler);
	}

	// @interface SBDOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDOptions
	{
		// +(BOOL)useMemberAsMessageSender;
		// +(void)setUseMemberAsMessageSender:(BOOL)tf;
		[Static]
		[Export ("useMemberAsMessageSender")]
		[Verify (MethodToProperty)]
		bool UseMemberAsMessageSender { get; set; }
	}

	// @protocol SBDConnectionDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface SBDConnectionDelegate
	{
		// @optional -(void)didStartReconnection;
		[Export ("didStartReconnection")]
		void DidStartReconnection ();

		// @optional -(void)didSucceedReconnection;
		[Export ("didSucceedReconnection")]
		void DidSucceedReconnection ();

		// @optional -(void)didFailReconnection;
		[Export ("didFailReconnection")]
		void DidFailReconnection ();

		// @optional -(void)didCancelReconnection;
		[Export ("didCancelReconnection")]
		void DidCancelReconnection ();
	}

	// @interface SBDMain : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDMain
	{
		// @property (atomic) SBDLogLevel logLevel;
		[Export ("logLevel", ArgumentSemantic.Assign)]
		SBDLogLevel LogLevel { get; set; }

		// @property (readonly, nonatomic, strong) NSMapTable<NSString *,id<SBDConnectionDelegate>> * _Nullable connectionDelegatesDictionary;
		[NullAllowed, Export ("connectionDelegatesDictionary", ArgumentSemantic.Strong)]
		NSMapTable<NSString, SBDConnectionDelegate> ConnectionDelegatesDictionary { get; }

		// @property (readonly, nonatomic, strong) NSMapTable<NSString *,id<SBDChannelDelegate>> * _Nullable channelDelegatesDictionary;
		[NullAllowed, Export ("channelDelegatesDictionary", ArgumentSemantic.Strong)]
		NSMapTable<NSString, SBDChannelDelegate> ChannelDelegatesDictionary { get; }

		// @property (nonatomic, strong) void (^ _Nullable)() backgroundSessionCompletionHandler;
		[NullAllowed, Export ("backgroundSessionCompletionHandler", ArgumentSemantic.Strong)]
		Action BackgroundSessionCompletionHandler { get; set; }

		// @property (nonatomic, strong) NSMutableArray<void (^)()> * _Nonnull backgroundTaskBlock;
		[Export ("backgroundTaskBlock", ArgumentSemantic.Strong)]
		NSMutableArray<Action> BackgroundTaskBlock { get; set; }

		// @property (atomic) int URLSessionDidFinishEventsForBackgroundURLSession;
		[Export ("URLSessionDidFinishEventsForBackgroundURLSession")]
		int URLSessionDidFinishEventsForBackgroundURLSession { get; set; }

		// +(NSString * _Nonnull)getSDKVersion;
		[Static]
		[Export ("getSDKVersion")]
		[Verify (MethodToProperty)]
		string SDKVersion { get; }

		// +(SBDLogLevel)getLogLevel;
		[Static]
		[Export ("getLogLevel")]
		[Verify (MethodToProperty)]
		SBDLogLevel LogLevel { get; }

		// +(NSString * _Nullable)getApplicationId;
		[Static]
		[NullAllowed, Export ("getApplicationId")]
		[Verify (MethodToProperty)]
		string ApplicationId { get; }

		// +(void)setLogLevel:(SBDLogLevel)logLevel;
		[Static]
		[Export ("setLogLevel:")]
		void SetLogLevel (SBDLogLevel logLevel);

		// +(BOOL)getDebugMode;
		[Static]
		[Export ("getDebugMode")]
		[Verify (MethodToProperty)]
		bool DebugMode { get; }

		// +(SBDMain * _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		SBDMain SharedInstance { get; }

		// +(BOOL)isInitialized;
		[Static]
		[Export ("isInitialized")]
		[Verify (MethodToProperty)]
		bool IsInitialized { get; }

		// +(void)initWithApplicationId:(NSString * _Nonnull)applicationId;
		[Static]
		[Export ("initWithApplicationId:")]
		void InitWithApplicationId (string applicationId);

		// +(void)logWithLevel:(SBDLogLevel)logLevel format:(NSString * _Nonnull)format, ...;
		[Static, Internal]
		[Export ("logWithLevel:format:", IsVariadic = true)]
		void LogWithLevel (SBDLogLevel logLevel, string format, IntPtr varArgs);

		// +(void)connectWithUserId:(NSString * _Nonnull)userId completionHandler:(void (^ _Nullable)(SBDUser * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("connectWithUserId:completionHandler:")]
		void ConnectWithUserId (string userId, [NullAllowed] Action<SBDUser, SBDError> completionHandler);

		// +(void)connectWithUserId:(NSString * _Nonnull)userId accessToken:(NSString * _Nullable)accessToken completionHandler:(void (^ _Nullable)(SBDUser * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("connectWithUserId:accessToken:completionHandler:")]
		void ConnectWithUserId (string userId, [NullAllowed] string accessToken, [NullAllowed] Action<SBDUser, SBDError> completionHandler);

		// +(void)connectWithUserId:(NSString * _Nonnull)userId accessToken:(NSString * _Nullable)accessToken apiHost:(NSString * _Nullable)apiHost wsHost:(NSString * _Nullable)wsHost completionHandler:(void (^ _Nullable)(SBDUser * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("connectWithUserId:accessToken:apiHost:wsHost:completionHandler:")]
		void ConnectWithUserId (string userId, [NullAllowed] string accessToken, [NullAllowed] string apiHost, [NullAllowed] string wsHost, [NullAllowed] Action<SBDUser, SBDError> completionHandler);

		// +(SBDUser * _Nullable)getCurrentUser;
		[Static]
		[NullAllowed, Export ("getCurrentUser")]
		[Verify (MethodToProperty)]
		SBDUser CurrentUser { get; }

		// +(void)clearCurrentUser;
		[Static]
		[Export ("clearCurrentUser")]
		void ClearCurrentUser ();

		// +(void)disconnectWithCompletionHandler:(void (^ _Nullable)())completionHandler;
		[Static]
		[Export ("disconnectWithCompletionHandler:")]
		void DisconnectWithCompletionHandler ([NullAllowed] Action completionHandler);

		// +(void)addConnectionDelegate:(id<SBDConnectionDelegate> _Nonnull)delegate identifier:(NSString * _Nonnull)identifier;
		[Static]
		[Export ("addConnectionDelegate:identifier:")]
		void AddConnectionDelegate (SBDConnectionDelegate @delegate, string identifier);

		// +(void)removeConnectionDelegateForIdentifier:(NSString * _Nonnull)identifier;
		[Static]
		[Export ("removeConnectionDelegateForIdentifier:")]
		void RemoveConnectionDelegateForIdentifier (string identifier);

		// +(id<SBDConnectionDelegate> _Nullable)connectionDelegateForIdentifier:(NSString * _Nonnull)identifier;
		[Static]
		[Export ("connectionDelegateForIdentifier:")]
		[return: NullAllowed]
		SBDConnectionDelegate ConnectionDelegateForIdentifier (string identifier);

		// +(void)removeAllConnectionDelegates;
		[Static]
		[Export ("removeAllConnectionDelegates")]
		void RemoveAllConnectionDelegates ();

		// +(void)addChannelDelegate:(id<SBDChannelDelegate> _Nonnull)delegate identifier:(NSString * _Nonnull)identifier;
		[Static]
		[Export ("addChannelDelegate:identifier:")]
		void AddChannelDelegate (SBDChannelDelegate @delegate, string identifier);

		// +(void)removeChannelDelegateForIdentifier:(NSString * _Nonnull)identifier;
		[Static]
		[Export ("removeChannelDelegateForIdentifier:")]
		void RemoveChannelDelegateForIdentifier (string identifier);

		// +(id<SBDChannelDelegate> _Nullable)channelDelegateForIdentifier:(NSString * _Nonnull)identifier;
		[Static]
		[Export ("channelDelegateForIdentifier:")]
		[return: NullAllowed]
		SBDChannelDelegate ChannelDelegateForIdentifier (string identifier);

		// +(void)removeAllChannelDelegates;
		[Static]
		[Export ("removeAllChannelDelegates")]
		void RemoveAllChannelDelegates ();

		// +(SBDWebSocketConnectionState)getConnectState;
		[Static]
		[Export ("getConnectState")]
		[Verify (MethodToProperty)]
		SBDWebSocketConnectionState ConnectState { get; }

		// +(void)setCompletionHandlerDelegateQueue:(dispatch_queue_t _Nullable)queue;
		[Static]
		[Export ("setCompletionHandlerDelegateQueue:")]
		void SetCompletionHandlerDelegateQueue ([NullAllowed] DispatchQueue queue);

		// +(void)performComletionHandlerDelegateQueueBlock:(dispatch_block_t _Nullable)block;
		[Static]
		[Export ("performComletionHandlerDelegateQueueBlock:")]
		void PerformComletionHandlerDelegateQueueBlock ([NullAllowed] dispatch_block_t block);

		// -(void)_sendCommand:(SBDCommand * _Nonnull)command completionHandler:(void (^ _Nullable)(SBDCommand * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("_sendCommand:completionHandler:")]
		void _sendCommand (SBDCommand command, [NullAllowed] Action<SBDCommand, SBDError> completionHandler);

		// +(SBDUserListQuery * _Nullable)createAllUserListQuery;
		[Static]
		[NullAllowed, Export ("createAllUserListQuery")]
		[Verify (MethodToProperty)]
		SBDUserListQuery CreateAllUserListQuery { get; }

		// +(SBDUserListQuery * _Nullable)createUserListQueryWithUserIds:(NSArray<NSString *> * _Nonnull)userIds;
		[Static]
		[Export ("createUserListQueryWithUserIds:")]
		[return: NullAllowed]
		SBDUserListQuery CreateUserListQueryWithUserIds (string[] userIds);

		// +(SBDUserListQuery * _Nullable)createBlockedUserListQuery;
		[Static]
		[NullAllowed, Export ("createBlockedUserListQuery")]
		[Verify (MethodToProperty)]
		SBDUserListQuery CreateBlockedUserListQuery { get; }

		// +(void)updateCurrentUserInfoWithNickname:(NSString * _Nullable)nickname profileUrl:(NSString * _Nullable)profileUrl completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("updateCurrentUserInfoWithNickname:profileUrl:completionHandler:")]
		void UpdateCurrentUserInfoWithNickname ([NullAllowed] string nickname, [NullAllowed] string profileUrl, [NullAllowed] Action<SBDError> completionHandler);

		// +(void)updateCurrentUserInfoWithNickname:(NSString * _Nullable)nickname profileImage:(NSData * _Nullable)profileImage completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("updateCurrentUserInfoWithNickname:profileImage:completionHandler:")]
		void UpdateCurrentUserInfoWithNickname ([NullAllowed] string nickname, [NullAllowed] NSData profileImage, [NullAllowed] Action<SBDError> completionHandler);

		// +(void)updateCurrentUserInfoWithNickname:(NSString * _Nullable)nickname profileImage:(NSData * _Nullable)profileImage progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("updateCurrentUserInfoWithNickname:profileImage:progressHandler:completionHandler:")]
		void UpdateCurrentUserInfoWithNickname ([NullAllowed] string nickname, [NullAllowed] NSData profileImage, [NullAllowed] Action<long, long, long> progressHandler, [NullAllowed] Action<SBDError> completionHandler);

		// +(void)updateCurrentUserInfoWithNickname:(NSString * _Nullable)nickname profileImageFilePath:(NSString * _Nullable)profileImageFilePath progressHandler:(void (^ _Nullable)(int64_t, int64_t, int64_t))progressHandler completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("updateCurrentUserInfoWithNickname:profileImageFilePath:progressHandler:completionHandler:")]
		void UpdateCurrentUserInfoWithNickname ([NullAllowed] string nickname, [NullAllowed] string profileImageFilePath, [NullAllowed] Action<long, long, long> progressHandler, [NullAllowed] Action<SBDError> completionHandler);

		// +(NSData * _Nullable)getPendingPushToken;
		[Static]
		[NullAllowed, Export ("getPendingPushToken")]
		[Verify (MethodToProperty)]
		NSData PendingPushToken { get; }

		// +(void)registerDevicePushToken:(NSData * _Nonnull)devToken unique:(BOOL)unique completionHandler:(void (^ _Nullable)(SBDPushTokenRegistrationStatus, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("registerDevicePushToken:unique:completionHandler:")]
		void RegisterDevicePushToken (NSData devToken, bool unique, [NullAllowed] Action<SBDPushTokenRegistrationStatus, SBDError> completionHandler);

		// +(void)registerDevicePushToken:(NSData * _Nonnull)devToken completionHandler:(void (^ _Nullable)(SBDPushTokenRegistrationStatus, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Static]
		[Export ("registerDevicePushToken:completionHandler:")]
		void RegisterDevicePushToken (NSData devToken, [NullAllowed] Action<SBDPushTokenRegistrationStatus, SBDError> completionHandler);

		// +(void)registerPushToken:(NSData * _Nonnull)devToken completionHandler:(void (^ _Nullable)(NSDictionary * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Static]
		[Export ("registerPushToken:completionHandler:")]
		void RegisterPushToken (NSData devToken, [NullAllowed] Action<NSDictionary, SBDError> completionHandler);

		// +(void)unregisterPushToken:(NSData * _Nonnull)devToken completionHandler:(void (^ _Nullable)(NSDictionary * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("unregisterPushToken:completionHandler:")]
		void UnregisterPushToken (NSData devToken, [NullAllowed] Action<NSDictionary, SBDError> completionHandler);

		// +(void)unregisterAllPushTokenWithCompletionHandler:(void (^ _Nullable)(NSDictionary * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("unregisterAllPushTokenWithCompletionHandler:")]
		void UnregisterAllPushTokenWithCompletionHandler ([NullAllowed] Action<NSDictionary, SBDError> completionHandler);

		// +(void)blockUserId:(NSString * _Nonnull)userId completionHandler:(void (^ _Nullable)(SBDUser * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("blockUserId:completionHandler:")]
		void BlockUserId (string userId, [NullAllowed] Action<SBDUser, SBDError> completionHandler);

		// +(void)blockUser:(SBDUser * _Nonnull)user completionHandler:(void (^ _Nullable)(SBDUser * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("blockUser:completionHandler:")]
		void BlockUser (SBDUser user, [NullAllowed] Action<SBDUser, SBDError> completionHandler);

		// +(void)unblockUserId:(NSString * _Nonnull)userId completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("unblockUserId:completionHandler:")]
		void UnblockUserId (string userId, [NullAllowed] Action<SBDError> completionHandler);

		// +(void)unblockUser:(SBDUser * _Nonnull)user completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("unblockUser:completionHandler:")]
		void UnblockUser (SBDUser user, [NullAllowed] Action<SBDError> completionHandler);

		// +(void)setDoNotDisturbWithEnable:(BOOL)enable startHour:(int)startHour startMin:(int)startMin endHour:(int)endHour endMin:(int)endMin timezone:(NSString * _Nonnull)timezone completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("setDoNotDisturbWithEnable:startHour:startMin:endHour:endMin:timezone:completionHandler:")]
		void SetDoNotDisturbWithEnable (bool enable, int startHour, int startMin, int endHour, int endMin, string timezone, [NullAllowed] Action<SBDError> completionHandler);

		// +(void)getDoNotDisturbWithCompletionHandler:(void (^ _Nullable)(BOOL, int, int, int, int, NSString * _Nonnull, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("getDoNotDisturbWithCompletionHandler:")]
		void GetDoNotDisturbWithCompletionHandler ([NullAllowed] Action<bool, int, int, int, int, NSString, SBDError> completionHandler);

		// +(void)setPushSound:(NSString * _Nonnull)sound completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("setPushSound:completionHandler:")]
		void SetPushSound (string sound, [NullAllowed] Action<SBDError> completionHandler);

		// +(void)getPushSoundWithCompletionHandler:(void (^ _Nullable)(NSString * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("getPushSoundWithCompletionHandler:")]
		void GetPushSoundWithCompletionHandler ([NullAllowed] Action<NSString, SBDError> completionHandler);

		// +(void)setPushTemplateWithName:(NSString * _Nonnull)name completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("setPushTemplateWithName:completionHandler:")]
		void SetPushTemplateWithName (string name, [NullAllowed] Action<SBDError> completionHandler);

		// +(void)getPushTemplateWithCompletionHandler:(void (^ _Nullable)(NSString * _Nullable, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("getPushTemplateWithCompletionHandler:")]
		void GetPushTemplateWithCompletionHandler ([NullAllowed] Action<NSString, SBDError> completionHandler);

		// +(BOOL)reconnect;
		[Static]
		[Export ("reconnect")]
		[Verify (MethodToProperty)]
		bool Reconnect { get; }

		// +(NSString * _Nullable)getMimeType:(NSData * _Nullable)file;
		[Static]
		[Export ("getMimeType:")]
		[return: NullAllowed]
		string GetMimeType ([NullAllowed] NSData file);

		// +(void)setNetworkAwarenessReconnection:(BOOL)onOff;
		[Static]
		[Export ("setNetworkAwarenessReconnection:")]
		void SetNetworkAwarenessReconnection (bool onOff);

		// +(NSString * _Nullable)getCustomApiHost;
		[Static]
		[NullAllowed, Export ("getCustomApiHost")]
		[Verify (MethodToProperty)]
		string CustomApiHost { get; }

		// +(NSString * _Nullable)getCustomWsHost;
		[Static]
		[NullAllowed, Export ("getCustomWsHost")]
		[Verify (MethodToProperty)]
		string CustomWsHost { get; }

		// +(void)setChannelInvitationPreferenceAutoAccept:(BOOL)autoAccept completionHandler:(void (^ _Nullable)(SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("setChannelInvitationPreferenceAutoAccept:completionHandler:")]
		void SetChannelInvitationPreferenceAutoAccept (bool autoAccept, [NullAllowed] Action<SBDError> completionHandler);

		// +(void)getChannelInvitationPreferenceAutoAcceptWithCompletionHandler:(void (^ _Nullable)(BOOL, SBDError * _Nullable))completionHandler;
		[Static]
		[Export ("getChannelInvitationPreferenceAutoAcceptWithCompletionHandler:")]
		void GetChannelInvitationPreferenceAutoAcceptWithCompletionHandler ([NullAllowed] Action<bool, SBDError> completionHandler);
	}

	// @interface SBDMessageListQuery : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDMessageListQuery
	{
		// -(instancetype _Nullable)initWithChannel:(SBDBaseChannel * _Nonnull)channel;
		[Export ("initWithChannel:")]
		IntPtr Constructor (SBDBaseChannel channel);

		// -(BOOL)isLoading __attribute__((deprecated("")));
		[Export ("isLoading")]
		[Verify (MethodToProperty)]
		bool IsLoading { get; }

		// -(void)loadNextMessagesFromTimestamp:(long long)timestamp limit:(NSInteger)limit reverse:(BOOL)reverse completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("loadNextMessagesFromTimestamp:limit:reverse:completionHandler:")]
		void LoadNextMessagesFromTimestamp (long timestamp, nint limit, bool reverse, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)loadPreviousMessagesFromTimestamp:(long long)timestamp limit:(NSInteger)limit reverse:(BOOL)reverse completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("loadPreviousMessagesFromTimestamp:limit:reverse:completionHandler:")]
		void LoadPreviousMessagesFromTimestamp (long timestamp, nint limit, bool reverse, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);

		// -(void)loadMessagesFromTimestamp:(long long)timestamp prevLimit:(NSInteger)prevLimit nextLimit:(NSInteger)nextLimit reverse:(BOOL)reverse completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler __attribute__((deprecated("")));
		[Export ("loadMessagesFromTimestamp:prevLimit:nextLimit:reverse:completionHandler:")]
		void LoadMessagesFromTimestamp (long timestamp, nint prevLimit, nint nextLimit, bool reverse, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);
	}

	// @interface SBDPreviousMessageListQuery : NSObject
	[BaseType (typeof(NSObject))]
	interface SBDPreviousMessageListQuery
	{
		// -(instancetype _Nullable)initWithChannel:(SBDBaseChannel * _Nonnull)channel;
		[Export ("initWithChannel:")]
		IntPtr Constructor (SBDBaseChannel channel);

		// -(BOOL)isLoading;
		[Export ("isLoading")]
		[Verify (MethodToProperty)]
		bool IsLoading { get; }

		// -(void)loadPreviousMessagesWithLimit:(NSInteger)limit reverse:(BOOL)reverse completionHandler:(void (^ _Nullable)(NSArray<SBDBaseMessage *> * _Nullable, SBDError * _Nullable))completionHandler;
		[Export ("loadPreviousMessagesWithLimit:reverse:completionHandler:")]
		void LoadPreviousMessagesWithLimit (nint limit, bool reverse, [NullAllowed] Action<NSArray<SBDBaseMessage>, SBDError> completionHandler);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double SendBirdSDKVersionNumber;
		[Field ("SendBirdSDKVersionNumber", "__Internal")]
		double SendBirdSDKVersionNumber { get; }

		// extern const unsigned char [] SendBirdSDKVersionString;
		[Field ("SendBirdSDKVersionString", "__Internal")]
		byte[] SendBirdSDKVersionString { get; }
	}
}
