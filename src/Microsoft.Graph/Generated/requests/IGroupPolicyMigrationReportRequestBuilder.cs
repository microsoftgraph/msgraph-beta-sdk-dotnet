// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IGroupPolicyMigrationReportRequestBuilder.
    /// </summary>
    public partial interface IGroupPolicyMigrationReportRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IGroupPolicyMigrationReportRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IGroupPolicyMigrationReportRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for GroupPolicySettingMappings.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyMigrationReportGroupPolicySettingMappingsCollectionRequestBuilder"/>.</returns>
        IGroupPolicyMigrationReportGroupPolicySettingMappingsCollectionRequestBuilder GroupPolicySettingMappings { get; }

        /// <summary>
        /// Gets the request builder for UnsupportedGroupPolicyExtensions.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyMigrationReportUnsupportedGroupPolicyExtensionsCollectionRequestBuilder"/>.</returns>
        IGroupPolicyMigrationReportUnsupportedGroupPolicyExtensionsCollectionRequestBuilder UnsupportedGroupPolicyExtensions { get; }
    
        
    
    }
}