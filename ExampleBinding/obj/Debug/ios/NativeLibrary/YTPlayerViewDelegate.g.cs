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
	[Protocol (Name = "YTPlayerViewDelegate", WrapperType = typeof (YTPlayerViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PlayerViewDidBecomeReady", Selector = "playerViewDidBecomeReady:", ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PlayerViewDidChangeToState", Selector = "playerView:didChangeToState:", ParameterType = new Type [] { typeof (IntPtr), typeof (NativeLibrary.YTPlayerState) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PlayerViewDidChangeToQuality", Selector = "playerView:didChangeToQuality:", ParameterType = new Type [] { typeof (IntPtr), typeof (NativeLibrary.YTPlaybackQuality) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PlayerViewReceivedError", Selector = "playerView:receivedError:", ParameterType = new Type [] { typeof (IntPtr), typeof (NativeLibrary.YTPlayerError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PlayerViewDidPlayTime", Selector = "playerView:didPlayTime:", ParameterType = new Type [] { typeof (IntPtr), typeof (float) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PlayerViewPreferredWebViewBackgroundColor", Selector = "playerViewPreferredWebViewBackgroundColor:", ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PlayerViewPreferredInitialLoadingView", Selector = "playerViewPreferredInitialLoadingView:", ReturnType = typeof (UIView), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	public interface IYTPlayerViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class YTPlayerViewDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PlayerViewDidBecomeReady (this IYTPlayerViewDelegate This, global::System.IntPtr playerView)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("playerViewDidBecomeReady:"), playerView);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PlayerViewDidChangeToState (this IYTPlayerViewDelegate This, global::System.IntPtr playerView, YTPlayerState state)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("playerView:didChangeToState:"), playerView, (int)state);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PlayerViewDidChangeToQuality (this IYTPlayerViewDelegate This, global::System.IntPtr playerView, YTPlaybackQuality quality)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("playerView:didChangeToQuality:"), playerView, (int)quality);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PlayerViewReceivedError (this IYTPlayerViewDelegate This, global::System.IntPtr playerView, YTPlayerError error)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("playerView:receivedError:"), playerView, (int)error);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PlayerViewDidPlayTime (this IYTPlayerViewDelegate This, global::System.IntPtr playerView, float playTime)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float (This.Handle, Selector.GetHandle ("playerView:didPlayTime:"), playerView, playTime);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PlayerViewPreferredWebViewBackgroundColor (this IYTPlayerViewDelegate This, global::System.IntPtr playerView)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("playerViewPreferredWebViewBackgroundColor:"), playerView);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIView PlayerViewPreferredInitialLoadingView (this IYTPlayerViewDelegate This, global::System.IntPtr playerView)
		{
			return  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("playerViewPreferredInitialLoadingView:"), playerView));
		}
		
	}
	
	internal sealed class YTPlayerViewDelegateWrapper : BaseWrapper, IYTPlayerViewDelegate {
		[Preserve (Conditional = true)]
		public YTPlayerViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace NativeLibrary {
	[Protocol()]
	[Register("YTPlayerViewDelegate", false)]
	[Model]
	public unsafe partial class YTPlayerViewDelegate : NSObject, IYTPlayerViewDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public YTPlayerViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected YTPlayerViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal YTPlayerViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("playerViewDidBecomeReady:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayerViewDidBecomeReady (global::System.IntPtr playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("playerView:didChangeToQuality:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayerViewDidChangeToQuality (global::System.IntPtr playerView, YTPlaybackQuality quality)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("playerView:didChangeToState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayerViewDidChangeToState (global::System.IntPtr playerView, YTPlayerState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("playerView:didPlayTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayerViewDidPlayTime (global::System.IntPtr playerView, float playTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("playerViewPreferredInitialLoadingView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView PlayerViewPreferredInitialLoadingView (global::System.IntPtr playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("playerViewPreferredWebViewBackgroundColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayerViewPreferredWebViewBackgroundColor (global::System.IntPtr playerView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("playerView:receivedError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayerViewReceivedError (global::System.IntPtr playerView, YTPlayerError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class YTPlayerViewDelegate */
}
