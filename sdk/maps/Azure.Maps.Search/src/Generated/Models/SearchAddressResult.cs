// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Maps.Search;

namespace Azure.Maps.Search.Models
{
    /// <summary> This object is returned from a successful Search calls. </summary>
    public partial class SearchAddressResult
    {
        /// <summary> Initializes a new instance of <see cref="SearchAddressResult"/>. </summary>
        internal SearchAddressResult()
        {
            Results = new ChangeTrackingList<SearchAddressResultItem>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchAddressResult"/>. </summary>
        /// <param name="summary"> Summary object for a Search API response. </param>
        /// <param name="results"> A list of Search API results. </param>
        internal SearchAddressResult(SearchSummary summary, IReadOnlyList<SearchAddressResultItem> results)
        {
            Summary = summary;
            Results = results;
        }
        /// <summary> A list of Search API results. </summary>
        public IReadOnlyList<SearchAddressResultItem> Results { get; }
    }
}
