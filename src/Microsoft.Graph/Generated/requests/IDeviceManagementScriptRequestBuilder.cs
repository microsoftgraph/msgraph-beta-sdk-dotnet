// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDeviceManagementScriptRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementScriptRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceManagementScriptRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceManagementScriptRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptAssignmentsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementScriptAssignmentsCollectionRequestBuilder Assignments { get; }

        /// <summary>
        /// Gets the request builder for DeviceRunStates.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptDeviceRunStatesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementScriptDeviceRunStatesCollectionRequestBuilder DeviceRunStates { get; }

        /// <summary>
        /// Gets the request builder for GroupAssignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptGroupAssignmentsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementScriptGroupAssignmentsCollectionRequestBuilder GroupAssignments { get; }

        /// <summary>
        /// Gets the request builder for RunSummary.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptRunSummaryWithReferenceRequestBuilder"/>.</returns>
        IDeviceManagementScriptRunSummaryWithReferenceRequestBuilder RunSummary { get; }

        /// <summary>
        /// Gets the request builder for UserRunStates.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptUserRunStatesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementScriptUserRunStatesCollectionRequestBuilder UserRunStates { get; }
    
        /// <summary>
        /// Gets the request builder for DeviceManagementScriptAssign.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptAssignRequestBuilder"/>.</returns>
        IDeviceManagementScriptAssignRequestBuilder Assign(
            IEnumerable<DeviceManagementScriptGroupAssignment> deviceManagementScriptGroupAssignments = null,
            IEnumerable<DeviceManagementScriptAssignment> deviceManagementScriptAssignments = null);
    
    }
}
