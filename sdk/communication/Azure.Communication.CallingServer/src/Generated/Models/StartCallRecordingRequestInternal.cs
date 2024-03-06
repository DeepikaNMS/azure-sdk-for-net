// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallingServer
{
    /// <summary> The request payload start for call recording operation with call locator. </summary>
    internal partial class StartCallRecordingRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="StartCallRecordingRequestInternal"/>. </summary>
        /// <param name="callLocator"> The call locator. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callLocator"/> is null. </exception>
        public StartCallRecordingRequestInternal(CallLocatorInternal callLocator)
        {
            if (callLocator == null)
            {
                throw new ArgumentNullException(nameof(callLocator));
            }

            CallLocator = callLocator;
            ChannelAffinity = new ChangeTrackingList<ChannelAffinityInternal>();
        }

        /// <summary> Initializes a new instance of <see cref="StartCallRecordingRequestInternal"/>. </summary>
        /// <param name="callLocator"> The call locator. </param>
        /// <param name="recordingStateCallbackUri"> The uri to send notifications to. </param>
        /// <param name="recordingContentType"> The content type of call recording. </param>
        /// <param name="recordingChannelType"> The channel type of call recording. </param>
        /// <param name="recordingFormatType"> The format type of call recording. </param>
        /// <param name="channelAffinity"> The channel affinity of call recording. </param>
        internal StartCallRecordingRequestInternal(CallLocatorInternal callLocator, string recordingStateCallbackUri, RecordingContent? recordingContentType, RecordingChannel? recordingChannelType, RecordingFormat? recordingFormatType, IList<ChannelAffinityInternal> channelAffinity)
        {
            CallLocator = callLocator;
            RecordingStateCallbackUri = recordingStateCallbackUri;
            RecordingContentType = recordingContentType;
            RecordingChannelType = recordingChannelType;
            RecordingFormatType = recordingFormatType;
            ChannelAffinity = channelAffinity;
        }

        /// <summary> The call locator. </summary>
        public CallLocatorInternal CallLocator { get; }
        /// <summary> The uri to send notifications to. </summary>
        public string RecordingStateCallbackUri { get; set; }
        /// <summary> The content type of call recording. </summary>
        public RecordingContent? RecordingContentType { get; set; }
        /// <summary> The channel type of call recording. </summary>
        public RecordingChannel? RecordingChannelType { get; set; }
        /// <summary> The format type of call recording. </summary>
        public RecordingFormat? RecordingFormatType { get; set; }
        /// <summary> The channel affinity of call recording. </summary>
        public IList<ChannelAffinityInternal> ChannelAffinity { get; }
    }
}
