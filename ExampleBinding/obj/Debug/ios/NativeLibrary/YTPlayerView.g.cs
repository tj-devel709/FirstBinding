//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace NativeLibrary {
	[Register("YTPlayerView", true)]
	public unsafe partial class YTPlayerView : global::UIKit.UIView, global::UIKit.IUIWebViewDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("YTPlayerView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public YTPlayerView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public YTPlayerView (NSCoder coder) : base (NSObjectFlag.Empty)
		{

			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected YTPlayerView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal YTPlayerView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("availablePlaybackRates")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[] AvailablePlaybackRates ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("availablePlaybackRates")));
			} else {
				return NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("availablePlaybackRates")));
			}
		}
		
		[Export ("availableQualityLevels")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AvailableQualityLevels ()
		{
			if (IsDirectBinding) {
				return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("availableQualityLevels")));
			} else {
				return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("availableQualityLevels")));
			}
		}
		
		[Export ("cuePlaylistByPlaylistId:index:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CuePlaylistByPlaylistId (string playlistId, int index, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (playlistId == null)
				throw new ArgumentNullException ("playlistId");
			var nsplaylistId = NSString.CreateNative (playlistId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_float_int (this.Handle, Selector.GetHandle ("cuePlaylistByPlaylistId:index:startSeconds:suggestedQuality:"), nsplaylistId, index, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int_float_int (this.SuperHandle, Selector.GetHandle ("cuePlaylistByPlaylistId:index:startSeconds:suggestedQuality:"), nsplaylistId, index, startSeconds, (int)suggestedQuality);
			}
			NSString.ReleaseNative (nsplaylistId);
			
		}
		
		[Export ("cuePlaylistByVideos:index:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CuePlaylistByVideosId (string[] videoIds, int index, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (videoIds == null)
				throw new ArgumentNullException ("videoIds");
			var nsa_videoIds = NSArray.FromStrings (videoIds);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_float_int (this.Handle, Selector.GetHandle ("cuePlaylistByVideos:index:startSeconds:suggestedQuality:"), nsa_videoIds.Handle, index, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int_float_int (this.SuperHandle, Selector.GetHandle ("cuePlaylistByVideos:index:startSeconds:suggestedQuality:"), nsa_videoIds.Handle, index, startSeconds, (int)suggestedQuality);
			}
			nsa_videoIds.Dispose ();
			
		}
		
		[Export ("cueVideoById:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CueVideoById (string videoId, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (videoId == null)
				throw new ArgumentNullException ("videoId");
			var nsvideoId = NSString.CreateNative (videoId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_int (this.Handle, Selector.GetHandle ("cueVideoById:startSeconds:suggestedQuality:"), nsvideoId, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_int (this.SuperHandle, Selector.GetHandle ("cueVideoById:startSeconds:suggestedQuality:"), nsvideoId, startSeconds, (int)suggestedQuality);
			}
			NSString.ReleaseNative (nsvideoId);
			
		}
		
		[Export ("cueVideoById:startSeconds:endSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CueVideoById (string videoId, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (videoId == null)
				throw new ArgumentNullException ("videoId");
			var nsvideoId = NSString.CreateNative (videoId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_float_int (this.Handle, Selector.GetHandle ("cueVideoById:startSeconds:endSeconds:suggestedQuality:"), nsvideoId, startSeconds, endSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_float_int (this.SuperHandle, Selector.GetHandle ("cueVideoById:startSeconds:endSeconds:suggestedQuality:"), nsvideoId, startSeconds, endSeconds, (int)suggestedQuality);
			}
			NSString.ReleaseNative (nsvideoId);
			
		}
		
		[Export ("cueVideoByURL:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CueVideoByURL (string videoURL, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (videoURL == null)
				throw new ArgumentNullException ("videoURL");
			var nsvideoURL = NSString.CreateNative (videoURL);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_int (this.Handle, Selector.GetHandle ("cueVideoByURL:startSeconds:suggestedQuality:"), nsvideoURL, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_int (this.SuperHandle, Selector.GetHandle ("cueVideoByURL:startSeconds:suggestedQuality:"), nsvideoURL, startSeconds, (int)suggestedQuality);
			}
			NSString.ReleaseNative (nsvideoURL);
			
		}
		
		[Export ("cueVideoByURL:startSeconds:endSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CueVideoByURL (string videoURL, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (videoURL == null)
				throw new ArgumentNullException ("videoURL");
			var nsvideoURL = NSString.CreateNative (videoURL);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_float_int (this.Handle, Selector.GetHandle ("cueVideoByURL:startSeconds:endSeconds:suggestedQuality:"), nsvideoURL, startSeconds, endSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_float_int (this.SuperHandle, Selector.GetHandle ("cueVideoByURL:startSeconds:endSeconds:suggestedQuality:"), nsvideoURL, startSeconds, endSeconds, (int)suggestedQuality);
			}
			NSString.ReleaseNative (nsvideoURL);
			
		}
		
		[Export ("currentTime")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float CurrentTime ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("currentTime"));
			} else {
				return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentTime"));
			}
		}
		
		[Export ("duration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Duration ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("duration"));
			} else {
				return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("duration"));
			}
		}
		
		[Export ("loadPlaylistByPlaylistId:index:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadPlaylistByPlaylistId (string playlistId, int index, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (playlistId == null)
				throw new ArgumentNullException ("playlistId");
			var nsplaylistId = NSString.CreateNative (playlistId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_float_int (this.Handle, Selector.GetHandle ("loadPlaylistByPlaylistId:index:startSeconds:suggestedQuality:"), nsplaylistId, index, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int_float_int (this.SuperHandle, Selector.GetHandle ("loadPlaylistByPlaylistId:index:startSeconds:suggestedQuality:"), nsplaylistId, index, startSeconds, (int)suggestedQuality);
			}
			NSString.ReleaseNative (nsplaylistId);
			
		}
		
		[Export ("loadPlaylistByVideos:index:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadPlaylistByVideos (string[] videoIds, int index, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (videoIds == null)
				throw new ArgumentNullException ("videoIds");
			var nsa_videoIds = NSArray.FromStrings (videoIds);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_float_int (this.Handle, Selector.GetHandle ("loadPlaylistByVideos:index:startSeconds:suggestedQuality:"), nsa_videoIds.Handle, index, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int_float_int (this.SuperHandle, Selector.GetHandle ("loadPlaylistByVideos:index:startSeconds:suggestedQuality:"), nsa_videoIds.Handle, index, startSeconds, (int)suggestedQuality);
			}
			nsa_videoIds.Dispose ();
			
		}
		
		[Export ("loadVideoById:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadVideoById (string videoId, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (videoId == null)
				throw new ArgumentNullException ("videoId");
			var nsvideoId = NSString.CreateNative (videoId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_int (this.Handle, Selector.GetHandle ("loadVideoById:startSeconds:suggestedQuality:"), nsvideoId, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_int (this.SuperHandle, Selector.GetHandle ("loadVideoById:startSeconds:suggestedQuality:"), nsvideoId, startSeconds, (int)suggestedQuality);
			}
			NSString.ReleaseNative (nsvideoId);
			
		}
		
		[Export ("loadVideoById:startSeconds:endSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadVideoById (string videoId, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (videoId == null)
				throw new ArgumentNullException ("videoId");
			var nsvideoId = NSString.CreateNative (videoId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_float_int (this.Handle, Selector.GetHandle ("loadVideoById:startSeconds:endSeconds:suggestedQuality:"), nsvideoId, startSeconds, endSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_float_int (this.SuperHandle, Selector.GetHandle ("loadVideoById:startSeconds:endSeconds:suggestedQuality:"), nsvideoId, startSeconds, endSeconds, (int)suggestedQuality);
			}
			NSString.ReleaseNative (nsvideoId);
			
		}
		
		[Export ("loadVideoByURL:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadVideoByURL (string videoURL, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (videoURL == null)
				throw new ArgumentNullException ("videoURL");
			var nsvideoURL = NSString.CreateNative (videoURL);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_int (this.Handle, Selector.GetHandle ("loadVideoByURL:startSeconds:suggestedQuality:"), nsvideoURL, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_int (this.SuperHandle, Selector.GetHandle ("loadVideoByURL:startSeconds:suggestedQuality:"), nsvideoURL, startSeconds, (int)suggestedQuality);
			}
			NSString.ReleaseNative (nsvideoURL);
			
		}
		
		[Export ("loadVideoByURL:startSeconds:endSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadVideoByURL (string videoURL, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (videoURL == null)
				throw new ArgumentNullException ("videoURL");
			var nsvideoURL = NSString.CreateNative (videoURL);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_float_int (this.Handle, Selector.GetHandle ("loadVideoByURL:startSeconds:endSeconds:suggestedQuality:"), nsvideoURL, startSeconds, endSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_float_int (this.SuperHandle, Selector.GetHandle ("loadVideoByURL:startSeconds:endSeconds:suggestedQuality:"), nsvideoURL, startSeconds, endSeconds, (int)suggestedQuality);
			}
			NSString.ReleaseNative (nsvideoURL);
			
		}
		
		[Export ("loadWithPlayerParams:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LoadWithPlayerParams (NSDictionary additionalPlayerParams)
		{
			if (additionalPlayerParams == null)
				throw new ArgumentNullException ("additionalPlayerParams");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadWithPlayerParams:"), additionalPlayerParams.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithPlayerParams:"), additionalPlayerParams.Handle);
			}
		}
		
		[Export ("loadWithPlaylistId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LoadWithPlaylistId (string playlistId)
		{
			if (playlistId == null)
				throw new ArgumentNullException ("playlistId");
			var nsplaylistId = NSString.CreateNative (playlistId);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadWithPlaylistId:"), nsplaylistId);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithPlaylistId:"), nsplaylistId);
			}
			NSString.ReleaseNative (nsplaylistId);
			
			return ret;
		}
		
		[Export ("loadWithPlaylistId:playerVars:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LoadWithPlaylistId (string playlistId, NSDictionary playerVars)
		{
			if (playlistId == null)
				throw new ArgumentNullException ("playlistId");
			if (playerVars == null)
				throw new ArgumentNullException ("playerVars");
			var nsplaylistId = NSString.CreateNative (playlistId);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("loadWithPlaylistId:playerVars:"), nsplaylistId, playerVars.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithPlaylistId:playerVars:"), nsplaylistId, playerVars.Handle);
			}
			NSString.ReleaseNative (nsplaylistId);
			
			return ret;
		}
		
		[Export ("loadWithVideoId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LoadWithVideoId (string videoId)
		{
			if (videoId == null)
				throw new ArgumentNullException ("videoId");
			var nsvideoId = NSString.CreateNative (videoId);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadWithVideoId:"), nsvideoId);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithVideoId:"), nsvideoId);
			}
			NSString.ReleaseNative (nsvideoId);
			
			return ret;
		}
		
		[Export ("loadWithVideoId:playerVars:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LoadWithVideoId (string videoId, NSDictionary playerVars)
		{
			if (videoId == null)
				throw new ArgumentNullException ("videoId");
			if (playerVars == null)
				throw new ArgumentNullException ("playerVars");
			var nsvideoId = NSString.CreateNative (videoId);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("loadWithVideoId:playerVars:"), nsvideoId, playerVars.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithVideoId:playerVars:"), nsvideoId, playerVars.Handle);
			}
			NSString.ReleaseNative (nsvideoId);
			
			return ret;
		}
		
		[Export ("nextVideo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NextVideo ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("nextVideo"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nextVideo"));
			}
		}
		
		[Export ("pauseVideo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PauseVideo ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pauseVideo"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pauseVideo"));
			}
		}
		
		[Export ("playVideo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayVideo ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("playVideo"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playVideo"));
			}
		}
		
		[Export ("playVideoAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayVideoAt (int index)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("playVideoAt:"), index);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("playVideoAt:"), index);
			}
		}
		
		[Export ("playbackQuality")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual YTPlaybackQuality PlaybackQuality ()
		{
			if (IsDirectBinding) {
				return (YTPlaybackQuality) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("playbackQuality"));
			} else {
				return (YTPlaybackQuality) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playbackQuality"));
			}
		}
		
		[Export ("playbackRate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float PlaybackRate ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("playbackRate"));
			} else {
				return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playbackRate"));
			}
		}
		
		[Export ("playerState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual YTPlayerState PlayerState ()
		{
			if (IsDirectBinding) {
				return (YTPlayerState) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("playerState"));
			} else {
				return (YTPlayerState) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playerState"));
			}
		}
		
		[Export ("playlist")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] Playlist ()
		{
			if (IsDirectBinding) {
				return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("playlist")));
			} else {
				return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playlist")));
			}
		}
		
		[Export ("playlistIndex")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint PlaylistIndex ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("playlistIndex"));
			} else {
				return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playlistIndex"));
			}
		}
		
		[Export ("previousVideo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PreviousVideo ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("previousVideo"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("previousVideo"));
			}
		}
		
		[Export ("removeWebView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveWebView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeWebView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeWebView"));
			}
		}
		
		[Export ("seekToSeconds:allowSeekAhead:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SeekToSeconds (float seekToSeconds, bool allowSeekAhead)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_float_bool (this.Handle, Selector.GetHandle ("seekToSeconds:allowSeekAhead:"), seekToSeconds, allowSeekAhead);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_float_bool (this.SuperHandle, Selector.GetHandle ("seekToSeconds:allowSeekAhead:"), seekToSeconds, allowSeekAhead);
			}
		}
		
		[Export ("setLoop:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLoop (bool loop)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLoop:"), loop);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setLoop:"), loop);
			}
		}
		
		[Export ("setPlaybackQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPlaybackQuality (YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setPlaybackQuality:"), (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setPlaybackQuality:"), (int)suggestedQuality);
			}
		}
		
		[Export ("setPlaybackRate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPlaybackRate (float suggestedRate)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setPlaybackRate:"), suggestedRate);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setPlaybackRate:"), suggestedRate);
			}
		}
		
		[Export ("setShuffle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetShuffle (bool shuffle)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShuffle:"), shuffle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShuffle:"), shuffle);
			}
		}
		
		[Export ("stopVideo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopVideo ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopVideo"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopVideo"));
			}
		}
		
		[Export ("videoEmbedCode")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string VideoEmbedCode ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("videoEmbedCode")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("videoEmbedCode")));
			}
		}
		
		[Export ("videoLoadedFraction")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float VideoLoadedFraction ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("videoLoadedFraction"));
			} else {
				return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("videoLoadedFraction"));
			}
		}
		
		[Export ("videoUrl")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl VideoUrl ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("videoUrl")));
			} else {
				return  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("videoUrl")));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IYTPlayerViewDelegate Delegate {
			get {
				return WeakDelegate as IYTPlayerViewDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIWebView WebView {
			[Export ("webView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIWebView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIWebView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("webView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIWebView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("webView")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
		public partial class YTPlayerViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal YTPlayerViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new YTPlayerViewAppearance Appearance {
			get { return new YTPlayerViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new YTPlayerViewAppearance GetAppearance<T> () where T: YTPlayerView {
			return new YTPlayerViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new YTPlayerViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new YTPlayerViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new YTPlayerViewAppearance GetAppearance (UITraitCollection traits) {
			return new YTPlayerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new YTPlayerViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new YTPlayerViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new YTPlayerViewAppearance GetAppearance<T> (UITraitCollection traits) where T: YTPlayerView {
			return new YTPlayerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new YTPlayerViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: YTPlayerView{
			return new YTPlayerViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class YTPlayerView */
}
