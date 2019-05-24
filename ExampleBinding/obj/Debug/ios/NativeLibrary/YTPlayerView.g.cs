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
	public unsafe partial class YTPlayerView : global::UIKit.UIWebViewDelegate {
		
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
		public virtual global::System.IntPtr AvailablePlaybackRates ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("availablePlaybackRates"));
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("availablePlaybackRates"));
			}
		}
		
		[Export ("availableQualityLevels")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.IntPtr AvailableQualityLevels ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("availableQualityLevels"));
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("availableQualityLevels"));
			}
		}
		
		[Export ("cuePlaylistByPlaylistId:index:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CuePlaylistByPlaylistIdIndexStartSecondsSuggestedQuality (global::System.IntPtr playlistId, int index, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_float_int (this.Handle, Selector.GetHandle ("cuePlaylistByPlaylistId:index:startSeconds:suggestedQuality:"), playlistId, index, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int_float_int (this.SuperHandle, Selector.GetHandle ("cuePlaylistByPlaylistId:index:startSeconds:suggestedQuality:"), playlistId, index, startSeconds, (int)suggestedQuality);
			}
		}
		
		[Export ("cuePlaylistByVideos:index:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CuePlaylistByVideosIdIndexStartSecondsSuggestedQuality (global::System.IntPtr videoIds, int index, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_float_int (this.Handle, Selector.GetHandle ("cuePlaylistByVideos:index:startSeconds:suggestedQuality:"), videoIds, index, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int_float_int (this.SuperHandle, Selector.GetHandle ("cuePlaylistByVideos:index:startSeconds:suggestedQuality:"), videoIds, index, startSeconds, (int)suggestedQuality);
			}
		}
		
		[Export ("cueVideoById:startSeconds:endSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CueVideoByIdStartSecondsEndSecondsSuggestedQuality (global::System.IntPtr videoId, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_float_int (this.Handle, Selector.GetHandle ("cueVideoById:startSeconds:endSeconds:suggestedQuality:"), videoId, startSeconds, endSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_float_int (this.SuperHandle, Selector.GetHandle ("cueVideoById:startSeconds:endSeconds:suggestedQuality:"), videoId, startSeconds, endSeconds, (int)suggestedQuality);
			}
		}
		
		[Export ("cueVideoById:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CueVideoByIdStartSecondsSuggestedQuality (global::System.IntPtr videoId, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_int (this.Handle, Selector.GetHandle ("cueVideoById:startSeconds:suggestedQuality:"), videoId, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_int (this.SuperHandle, Selector.GetHandle ("cueVideoById:startSeconds:suggestedQuality:"), videoId, startSeconds, (int)suggestedQuality);
			}
		}
		
		[Export ("cueVideoByURL:startSeconds:endSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CueVideoByURLStartSecondsEndSecondsSuggestedQuality (global::System.IntPtr videoURL, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_float_int (this.Handle, Selector.GetHandle ("cueVideoByURL:startSeconds:endSeconds:suggestedQuality:"), videoURL, startSeconds, endSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_float_int (this.SuperHandle, Selector.GetHandle ("cueVideoByURL:startSeconds:endSeconds:suggestedQuality:"), videoURL, startSeconds, endSeconds, (int)suggestedQuality);
			}
		}
		
		[Export ("cueVideoByURL:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CueVideoByURLStartSecondsSuggestedQuality (global::System.IntPtr videoURL, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_int (this.Handle, Selector.GetHandle ("cueVideoByURL:startSeconds:suggestedQuality:"), videoURL, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_int (this.SuperHandle, Selector.GetHandle ("cueVideoByURL:startSeconds:suggestedQuality:"), videoURL, startSeconds, (int)suggestedQuality);
			}
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
		public virtual void LoadPlaylistByPlaylistIdIndexStartSecondsSuggestedQuality (global::System.IntPtr playlistId, int index, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_float_int (this.Handle, Selector.GetHandle ("loadPlaylistByPlaylistId:index:startSeconds:suggestedQuality:"), playlistId, index, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int_float_int (this.SuperHandle, Selector.GetHandle ("loadPlaylistByPlaylistId:index:startSeconds:suggestedQuality:"), playlistId, index, startSeconds, (int)suggestedQuality);
			}
		}
		
		[Export ("loadPlaylistByVideos:index:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadPlaylistByVideosIndexStartSecondsSuggestedQuality (global::System.IntPtr videoIds, int index, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_float_int (this.Handle, Selector.GetHandle ("loadPlaylistByVideos:index:startSeconds:suggestedQuality:"), videoIds, index, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int_float_int (this.SuperHandle, Selector.GetHandle ("loadPlaylistByVideos:index:startSeconds:suggestedQuality:"), videoIds, index, startSeconds, (int)suggestedQuality);
			}
		}
		
		[Export ("loadVideoById:startSeconds:endSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadVideoByIdStartSecondsEndSecondsSuggestedQuality (global::System.IntPtr videoId, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_float_int (this.Handle, Selector.GetHandle ("loadVideoById:startSeconds:endSeconds:suggestedQuality:"), videoId, startSeconds, endSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_float_int (this.SuperHandle, Selector.GetHandle ("loadVideoById:startSeconds:endSeconds:suggestedQuality:"), videoId, startSeconds, endSeconds, (int)suggestedQuality);
			}
		}
		
		[Export ("loadVideoById:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadVideoByIdStartSecondsSuggestedQuality (global::System.IntPtr videoId, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_int (this.Handle, Selector.GetHandle ("loadVideoById:startSeconds:suggestedQuality:"), videoId, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_int (this.SuperHandle, Selector.GetHandle ("loadVideoById:startSeconds:suggestedQuality:"), videoId, startSeconds, (int)suggestedQuality);
			}
		}
		
		[Export ("loadVideoByURL:startSeconds:endSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadVideoByURLStartSecondsEndSecondsSuggestedQuality (global::System.IntPtr videoURL, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_float_int (this.Handle, Selector.GetHandle ("loadVideoByURL:startSeconds:endSeconds:suggestedQuality:"), videoURL, startSeconds, endSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_float_int (this.SuperHandle, Selector.GetHandle ("loadVideoByURL:startSeconds:endSeconds:suggestedQuality:"), videoURL, startSeconds, endSeconds, (int)suggestedQuality);
			}
		}
		
		[Export ("loadVideoByURL:startSeconds:suggestedQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadVideoByURLStartSecondsSuggestedQuality (global::System.IntPtr videoURL, float startSeconds, YTPlaybackQuality suggestedQuality)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_int (this.Handle, Selector.GetHandle ("loadVideoByURL:startSeconds:suggestedQuality:"), videoURL, startSeconds, (int)suggestedQuality);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_float_int (this.SuperHandle, Selector.GetHandle ("loadVideoByURL:startSeconds:suggestedQuality:"), videoURL, startSeconds, (int)suggestedQuality);
			}
		}
		
		[Export ("loadWithPlayerParams:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LoadWithPlayerParams (global::System.IntPtr additionalPlayerParams)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadWithPlayerParams:"), additionalPlayerParams);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithPlayerParams:"), additionalPlayerParams);
			}
		}
		
		[Export ("loadWithPlaylistId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LoadWithPlaylistId (global::System.IntPtr playlistId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadWithPlaylistId:"), playlistId);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithPlaylistId:"), playlistId);
			}
		}
		
		[Export ("loadWithPlaylistId:playerVars:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LoadWithPlaylistIdPlayerVars (global::System.IntPtr playlistId, global::System.IntPtr playerVars)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("loadWithPlaylistId:playerVars:"), playlistId, playerVars);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithPlaylistId:playerVars:"), playlistId, playerVars);
			}
		}
		
		[Export ("loadWithVideoId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LoadWithVideoId (global::System.IntPtr videoId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadWithVideoId:"), videoId);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithVideoId:"), videoId);
			}
		}
		
		[Export ("loadWithVideoId:playerVars:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LoadWithVideoIdPlayerVars (global::System.IntPtr videoId, global::System.IntPtr playerVars)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("loadWithVideoId:playerVars:"), videoId, playerVars);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithVideoId:playerVars:"), videoId, playerVars);
			}
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
		public virtual global::System.IntPtr Playlist ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("playlist"));
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playlist"));
			}
		}
		
		[Export ("playlistIndex")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int PlaylistIndex ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("playlistIndex"));
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playlistIndex"));
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
		public virtual void SeekToSecondsAllowSeekAhead (float seekToSeconds, bool allowSeekAhead)
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
		public virtual global::System.IntPtr VideoEmbedCode ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("videoEmbedCode"));
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("videoEmbedCode"));
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
		public virtual global::System.IntPtr VideoUrl ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("videoUrl"));
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("videoUrl"));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual YTPlayerViewDelegate Delegate {
			[Export ("delegate")]
			get {
				YTPlayerViewDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<YTPlayerViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret =  Runtime.GetNSObject<YTPlayerViewDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				return ret;
			}
			
			[Export ("setDelegate:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.IntPtr WebView {
			[Export ("webView")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("webView"));
				} else {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("webView"));
				}
			}
			
		}
		
	} /* class YTPlayerView */
}
