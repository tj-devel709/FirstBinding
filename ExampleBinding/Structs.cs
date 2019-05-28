using System;

namespace NativeLibrary
{
    //[Native] // needed for enums defined as NSInteger in ObjC
    public enum YTPlayerState
    {
        Unstarted,
        Ended,
        Playing,
        Paused,
        Buffering,
        Queued,
        Unknown
    }

    //[Native] // needed for enums defined as NSInteger in ObjC
    public enum YTPlaybackQuality
    {
        Small,
        Medium,
        Large,
        HD720,
        HD1080,
        HighRes,
        Auto, /** Addition for YouTube Live Events. */
        Default,
        Unknown /** This should never be returned. It is here for future proofing. */
    }

    //[Native] // needed for enums defined as NSInteger in ObjC
    public enum YTPlayerError
    {
        InvalidParam,
        HTML5Error,
        VideoNotFound, // Functionally equivalent error codes 100 and
                                     // 105 have been collapsed into |kYTPlayerErrorVideoNotFound|.
        NotEmbeddable, // Functionally equivalent error codes 101 and
                                     // 150 have been collapsed into |kYTPlayerErrorNotEmbeddable|.
        Unknown
    }



}

