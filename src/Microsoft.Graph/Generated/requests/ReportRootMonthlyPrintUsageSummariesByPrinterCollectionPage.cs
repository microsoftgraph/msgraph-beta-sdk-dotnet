// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    /// <summary>
    /// The type ReportRootMonthlyPrintUsageSummariesByPrinterCollectionPage.
    /// </summary>
    public partial class ReportRootMonthlyPrintUsageSummariesByPrinterCollectionPage : CollectionPage<PrintUsageByPrinter>, IReportRootMonthlyPrintUsageSummariesByPrinterCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IReportRootMonthlyPrintUsageSummariesByPrinterCollectionRequest"/> instance.
        /// </summary>
        public IReportRootMonthlyPrintUsageSummariesByPrinterCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ReportRootMonthlyPrintUsageSummariesByPrinterCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
