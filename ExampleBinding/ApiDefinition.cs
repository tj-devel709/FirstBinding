using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace NativeLibrary
{
    // The first step to creating a binding is to add your native library ("libNativeLibrary.a")
    // to the project by right-clicking (or Control-clicking) the folder containing this source
    // file and clicking "Add files..." and then simply select the native library (or libraries)
    // that you want to bind.
    //
    // When you do that, you'll notice that MonoDevelop generates a code-behind file for each
    // native library which will contain a [LinkWith] attribute. VisualStudio auto-detects the
    // architectures that the native library supports and fills in that information for you,
    // however, it cannot auto-detect any Frameworks or other system libraries that the
    // native library may depend on, so you'll need to fill in that information yourself.
    //
    // Once you've done that, you're ready to move on to binding the API...
    //
    //
    // Here is where you'd define your API definition for the native Objective-C library.
    //


    // For example, to bind the following Objective-C class:
    //
    //     @interface Widget : NSObject {
    //     }
    //
    // The C# binding would look like this:
    //
    //     [BaseType (typeof (NSObject))]
    //     interface Widget {
    //     }
    //


    // To bind Objective-C properties, such as:
    //
    //     @property (nonatomic, readwrite, assign) CGPoint center;
    //
    // You would add a property definition in the C# interface like so:
    //
    //     [Export ("center")]
    //     CGPoint Center { get; set; }
    //


    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, int index);
    //


    // Objective-C "constructors" such as:
    //
    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
    //
    // Can be bound as:
    //
    //     [Export ("initWithElmo:")]
    //     IntPtr Constructor (ElmoMuppet elmo);
    //
    // For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_types
    //

    interface IYTPlayerViewDelegate { }

    [BaseType(typeof(NSObject))]
    [Model][Protocol]
    interface YTPlayerViewDelegate {
        [Export("playerViewDidBecomeReady:")]
        void PlayerViewDidBecomeReady(YTPlayerView playerView);

        [Export("playerView:didChangeToState:")]
        void PlayerViewDidChangeToState (YTPlayerView playerView, YTPlayerState state);

        [Export("playerView:didChangeToQuality:")]
        void PlayerViewDidChangeToQuality (YTPlayerView playerView, YTPlaybackQuality quality);

        [Export("playerView:receivedError:")]
        void PlayerViewReceivedError (YTPlayerView playerView, YTPlayerError error);

        [Export("playerView:didPlayTime:")]
        void PlayerViewDidPlayTime (YTPlayerView playerView, float playTime);

        [Export("playerViewPreferredWebViewBackgroundColor:")]
        UIColor PlayerViewPreferredWebViewBackgroundColor(YTPlayerView playerView);

        [Export("playerViewPreferredInitialLoadingView:")]
        UIView PlayerViewPreferredInitialLoadingView (YTPlayerView playerView);
    }


    [BaseType(typeof(UIView))]
    interface YTPlayerView : IUIWebViewDelegate
    {
        [Export ("webView", ArgumentSemantic.Strong), NullAllowed] // wrap for strong-typed version? 
        UIWebView WebView { get; }

        [Wrap ("WeakDelegate"), NullAllowed]
        IYTPlayerViewDelegate Delegate { get; set; }

        [Export("delegate", ArgumentSemantic.Weak), NullAllowed]
        NSObject WeakDelegate { get; set; } // return type is id but inherits from YTPlayerViewDelegate?

        [Export("loadWithVideoId:")]
        bool LoadWithVideoId (string videoId);

        [Export("loadWithPlaylistId:")]
        bool LoadWithPlaylistId (string playlistId);

        [Export("loadWithVideoId:playerVars:")]
        bool LoadWithVideoId (string videoId, NSDictionary playerVars);

        [Export("loadWithPlaylistId:playerVars:")]
        bool LoadWithPlaylistId (string playlistId, NSDictionary playerVars);

        [Export("loadWithPlayerParams:")]
        bool LoadWithPlayerParams (NSDictionary additionalPlayerParams);

        [Export("playVideo")]
        void PlayVideo ();

        [Export("pauseVideo")]
        void PauseVideo ();

        [Export("stopVideo")]
        void StopVideo ();

        [Export("seekToSeconds:allowSeekAhead:")]
        void SeekToSeconds (float seekToSeconds, bool allowSeekAhead);

        [Export("cueVideoById:startSeconds:suggestedQuality:")]
        void CueVideoById (string videoId, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("cueVideoById:startSeconds:endSeconds:suggestedQuality:")]
        void CueVideoById (string videoId, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadVideoById:startSeconds:suggestedQuality:")]
        void LoadVideoById (string videoId, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadVideoById:startSeconds:endSeconds:suggestedQuality:")]
        void LoadVideoById (string videoId, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        [Export("cueVideoByURL:startSeconds:suggestedQuality:")]
        void CueVideoByURL (string videoURL, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("cueVideoByURL:startSeconds:endSeconds:suggestedQuality:")]
        void CueVideoByURL (string videoURL, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadVideoByURL:startSeconds:suggestedQuality:")]
        void LoadVideoByURL (string videoURL, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadVideoByURL:startSeconds:endSeconds:suggestedQuality:")]
        void LoadVideoByURL (string videoURL, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        [Export("cuePlaylistByPlaylistId:index:startSeconds:suggestedQuality:")]
        void CuePlaylistByPlaylistId (string playlistId, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("cuePlaylistByVideos:index:startSeconds:suggestedQuality:")]
        void CuePlaylistByVideosId (string[] videoIds, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadPlaylistByPlaylistId:index:startSeconds:suggestedQuality:")]
        void LoadPlaylistByPlaylistId (string playlistId, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadPlaylistByVideos:index:startSeconds:suggestedQuality:")]
        void LoadPlaylistByVideos (string[] videoIds, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("nextVideo")]
        void NextVideo ();

        [Export("previousVideo")]
        void PreviousVideo ();

        [Export("playVideoAt:")]
        void PlayVideoAt (int index);

        [Export("playbackRate")]
        float PlaybackRate ();

        [Export("setPlaybackRate:")]
        void SetPlaybackRate(float suggestedRate);

        [Export("availablePlaybackRates")]
        NSNumber[] AvailablePlaybackRates (); // should return nint[] 

        [Export("setLoop:")]
        void SetLoop(bool loop);

        [Export("setShuffle:")]
        void SetShuffle(bool shuffle);

        [Export("videoLoadedFraction")]
        float VideoLoadedFraction ();

        [Export("playerState")]
        YTPlayerState PlayerState ();

        [Export("currentTime")]
        float CurrentTime ();

        [Export("playbackQuality")]
        YTPlaybackQuality PlaybackQuality ();

        [Export("setPlaybackQuality:")]
        void SetPlaybackQuality (YTPlaybackQuality suggestedQuality);

        [Export("availableQualityLevels")]
        string[] AvailableQualityLevels ();

        [Export("duration")]
        double Duration ();

        [Export("videoUrl")] 
        NSUrl VideoUrl (); 

        [Export("videoEmbedCode")]
        string VideoEmbedCode ();

        [Export("playlist")]
        string[] Playlist ();

        [Export("playlistIndex")]
        nint PlaylistIndex ();

        [Export("removeWebView")]
        void RemoveWebView ();
    }
}

