// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type VppTokenRevokeLicensesRequestBuilder.
    /// </summary>
    public partial class VppTokenRevokeLicensesRequestBuilder : BaseActionMethodRequestBuilder<IVppTokenRevokeLicensesRequest>, IVppTokenRevokeLicensesRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="VppTokenRevokeLicensesRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="notifyManagedDevices">A notifyManagedDevices parameter for the OData method call.</param>
        /// <param name="revokeUntrackedLicenses">A revokeUntrackedLicenses parameter for the OData method call.</param>
        public VppTokenRevokeLicensesRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool notifyManagedDevices,
            bool? revokeUntrackedLicenses)
            : base(requestUrl, client)
        {
            this.SetParameter("notifyManagedDevices", notifyManagedDevices, false);
            this.SetParameter("revokeUntrackedLicenses", revokeUntrackedLicenses, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IVppTokenRevokeLicensesRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new VppTokenRevokeLicensesRequest(functionUrl, this.Client, options);

            if (this.HasParameter("notifyManagedDevices"))
            {
                request.RequestBody.NotifyManagedDevices = this.GetParameter<bool>("notifyManagedDevices");
            }

            if (this.HasParameter("revokeUntrackedLicenses"))
            {
                request.RequestBody.RevokeUntrackedLicenses = this.GetParameter<bool?>("revokeUntrackedLicenses");
            }

            return request;
        }
    }
}
