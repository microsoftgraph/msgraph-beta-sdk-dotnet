// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Microsoft.Graph.Beta.Requests;

public class CustomBatchRequestBuilder: Core.Requests.BatchRequestBuilder
{
    /// <summary>
    /// Constructs a new BatchRequestBuilder.
    /// </summary>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public CustomBatchRequestBuilder(IRequestAdapter requestAdapter): base(requestAdapter)
    {
        _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
    }

    /// <summary>
    /// Sends out the <see cref="BatchRequestContent"/> using the POST method
    /// </summary>
    /// <param name="batchRequestContent">The <see cref="BatchRequestContent"/> for the request</param>
    /// <param name="cancellationToken"><see cref="CancellationToken"/> to use for cancelling requests</param>
    /// <param name="errorMappings">The error mappings for using to handle errors in batch request</param>
    /// <returns></returns>
    public new Task<BatchResponseContent> PostAsync(BatchRequestContent batchRequestContent, CancellationToken cancellationToken = default, Dictionary<string, ParsableFactory<IParsable>> errorMappings = null)
    {
        var batchErrorMappings = errorMappings ?? new Dictionary<string, ParsableFactory<IParsable>> {
            {"4XX", ODataError.CreateFromDiscriminatorValue},
            {"5XX", ODataError.CreateFromDiscriminatorValue},
        };

        return base.PostAsync(batchRequestContent, cancellationToken, batchErrorMappings);
    }

    /// <summary>
    /// Sends out the <see cref="BatchRequestContentCollection"/> using the POST method
    /// </summary>
    /// <param name="batchRequestContentCollection">The <see cref="BatchRequestContentCollection"/> for the request</param>
    /// <param name="cancellationToken"><see cref="CancellationToken"/> to use for cancelling requests</param>
    /// <param name="errorMappings">The error mappings for using to handle errors in batch request</param>
    /// <returns></returns>
    public new Task<BatchResponseContentCollection> PostAsync(BatchRequestContentCollection batchRequestContentCollection, CancellationToken cancellationToken = default, Dictionary<string, ParsableFactory<IParsable>> errorMappings = null)
    {
        var batchErrorMappings = errorMappings ?? new Dictionary<string, ParsableFactory<IParsable>> {
            {"4XX", ODataError.CreateFromDiscriminatorValue},
            {"5XX", ODataError.CreateFromDiscriminatorValue},
        };

        return base.PostAsync(batchRequestContentCollection, cancellationToken, batchErrorMappings);
    }
}
