using System;

namespace NativeLibrary
{

    [Native] // needed for enums defined as NSInteger in ObjC
    enum YTPlayerState {
        kYTPlayerStateUnstarted,
        kYTPlayerStateEnded,
        kYTPlayerStatePlaying,
        kYTPlayerStatePaused,
        kYTPlayerStateBuffering,
        kYTPlayerStateQueued,
        kYTPlayerStateUnknown
    }

    [Native] // needed for enums defined as NSInteger in ObjC
    enum YTPlaybackQuality
    {
        kYTPlaybackQualitySmall,
        kYTPlaybackQualityMedium,
        kYTPlaybackQualityLarge,
        kYTPlaybackQualityHD720,
        kYTPlaybackQualityHD1080,
        kYTPlaybackQualityHighRes,
        kYTPlaybackQualityAuto, /** Addition for YouTube Live Events. */
        kYTPlaybackQualityDefault,
        kYTPlaybackQualityUnknown /** This should never be returned. It is here for future proofing. */
    }

    [Native] // needed for enums defined as NSInteger in ObjC
    enum YTPlayerError
    {
        kYTPlayerErrorInvalidParam,
        kYTPlayerErrorHTML5Error,
        kYTPlayerErrorVideoNotFound, // Functionally equivalent error codes 100 and
                                     // 105 have been collapsed into |kYTPlayerErrorVideoNotFound|.
        kYTPlayerErrorNotEmbeddable, // Functionally equivalent error codes 101 and
                                     // 150 have been collapsed into |kYTPlayerErrorNotEmbeddable|.
        kYTPlayerErrorUnknown
    }


}

