// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type BusinessFlowRecordDecisionsRequestBuilder.
    /// </summary>
    public partial class BusinessFlowRecordDecisionsRequestBuilder : BaseActionMethodRequestBuilder<IBusinessFlowRecordDecisionsRequest>, IBusinessFlowRecordDecisionsRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="BusinessFlowRecordDecisionsRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="reviewResult">A reviewResult parameter for the OData method call.</param>
        /// <param name="justification">A justification parameter for the OData method call.</param>
        public BusinessFlowRecordDecisionsRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string reviewResult,
            string justification)
            : base(requestUrl, client)
        {
            this.SetParameter("reviewResult", reviewResult, true);
            this.SetParameter("justification", justification, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IBusinessFlowRecordDecisionsRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new BusinessFlowRecordDecisionsRequest(functionUrl, this.Client, options);

            if (this.HasParameter("reviewResult"))
            {
                request.RequestBody.ReviewResult = this.GetParameter<string>("reviewResult");
            }

            if (this.HasParameter("justification"))
            {
                request.RequestBody.Justification = this.GetParameter<string>("justification");
            }

            return request;
        }
    }
}