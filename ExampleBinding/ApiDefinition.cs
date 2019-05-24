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

    [BaseType(typeof(NSObject))]
    [Model][Protocol]
    interface YTPlayerViewDelegate {
        [Export("playerViewDidBecomeReady:")]
        void PlayerViewDidBecomeReady(IntPtr playerView);

        [Export("playerView:didChangeToState:")]
        void PlayerViewDidChangeToState (IntPtr playerView, YTPlayerState state);

        [Export("playerView:didChangeToQuality:")]
        void PlayerViewDidChangeToQuality (IntPtr playerView, YTPlaybackQuality quality);

        [Export("playerView:receivedError:")]
        void PlayerViewReceivedError (IntPtr playerView, YTPlayerError error);

        [Export("playerView:didPlayTime:")]
        void PlayerViewDidPlayTime (IntPtr playerView, float playTime);

        [Export("playerViewPreferredWebViewBackgroundColor:")]
        void PlayerViewPreferredWebViewBackgroundColor(IntPtr playerView);

        [Export("playerViewPreferredInitialLoadingView:")]
        UIView PlayerViewPreferredInitialLoadingView (IntPtr playerView);
        // obj-c returns nullable UIView * 
    }


    [BaseType(typeof(UIView<UIWebViewDelegate>))]
    interface YTPlayerView {
        [Export ("webView")]
        IntPtr WebView { get; }

        [Export("delegate")]
        YTPlayerViewDelegate Delegate { get; set; }

        Export("loadWithVideoId:")]
        bool LoadWithVideoId (IntPtr videoId);

        Export("loadWithPlaylistId:")]
        bool LoadWithPlaylistId (IntPtr playlistId);

        Export("loadWithVideoId:playerVars:")]
        bool LoadWithVideoIdPlayerVars (IntPtr videoId, IntPtr playerVars);

        Export("loadWithPlaylistId:playerVars:")]
        bool LoadWithPlaylistIdPlayerVars (IntPtr playlistId, IntPtr playerVars);

        Export("loadWithPlayerParams:")]
        bool LoadWithPlayerParams (IntPtr additionalPlayerParams);

        [Export("playVideo")]
        void PlayVideo ();

        [Export("pauseVideo")]
        void PauseVideo ();

        [Export("stopVideo")]
        void StopVideo ();

        Export("seekToSeconds:allowSeekAhead:")]
        void SeekToSecondsAllowSeekAhead (float seekToSeconds, bool allowSeekAhead);

        Export("cueVideoById:startSeconds:suggestedQuality:")]
        void CueVideoByIdStartSecondsSuggestedQuality (IntPtr videoId, float startSeconds, YTPlaybackQuality suggestedQuality);

        Export("cueVideoById:startSeconds:endSeconds:suggestedQuality:")]
        void CueVideoByIdStartSecondsEndSecondsSuggestedQuality (IntPtr videoId, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        Export("loadVideoById:startSeconds:suggestedQuality:")]
        void LoadVideoByIdStartSecondsSuggestedQuality (IntPtr videoId, float startSeconds, YTPlaybackQuality suggestedQuality);

        Export("loadVideoById:startSeconds:endSeconds:suggestedQuality:")]
        void LoadVideoByIdStartSecondsEndSecondsSuggestedQuality (IntPtr videoId, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        Export("cueVideoByURL:startSeconds:suggestedQuality:")]
        void CueVideoByURLStartSecondsSuggestedQuality (IntPtr videoURL, float startSeconds, YTPlaybackQuality suggestedQuality);

        Export("cueVideoByURL:startSeconds:endSeconds:suggestedQuality:")]
        void CueVideoByURLStartSecondsEndSecondsSuggestedQuality (IntPtr videoURL, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        Export("loadVideoByURL:startSeconds:suggestedQuality:")]
        void LoadVideoByURLStartSecondsSuggestedQuality (IntPtr videoURL, float startSeconds, YTPlaybackQuality suggestedQuality);

        Export("loadVideoByURL:startSeconds:endSeconds:suggestedQuality:")]
        void LoadVideoByURLStartSecondsEndSecondsSuggestedQuality (IntPtr videoURL, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        Export("cuePlaylistByPlaylistId:index:startSeconds:suggestedQuality:")]
        void CuePlaylistByPlaylistIdIndexStartSecondsSuggestedQuality (IntPtr playlistId, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

        Export("cuePlaylistByVideos:index:startSeconds:suggestedQuality:")]
        void CuePlaylistByVideosIdIndexStartSecondsSuggestedQuality (IntPtr videoIds, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

        Export("loadPlaylistByPlaylistId:index:startSeconds:suggestedQuality:")]
        void LoadPlaylistByPlaylistIdIndexStartSecondsSuggestedQuality (IntPtr playlistId, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

        Export("loadPlaylistByVideos:index:startSeconds:suggestedQuality:")]
        void LoadPlaylistByVideosIndexStartSecondsSuggestedQuality (IntPtr videoIds, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

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
        IntPtr AvailablePlaybackRates ();

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
        IntPtr AvailableQualityLevels ();

        [Export("duration")]
        NSTimeInterval Duration ();

        [Export("videoUrl")]
        IntPtr VideoUrl ();

        [Export("videoEmbedCode")]
        IntPtr VideoEmbedCode ();

        [Export("playlist")]
        IntPtr Playlist ();

        [Export("playlistIndex")]
        int PlaylistIndex ();

        [Export("removeWebView")]
        void RemoveWebView ();
    }


}

