// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.UpdateRequest
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UpdateRequestPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The assignmentState property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentState
        {
            get { return BackingStore?.Get<string?>("assignmentState"); }
            set { BackingStore?.Set("assignmentState", value); }
        }
#nullable restore
#else
        public string AssignmentState
        {
            get { return BackingStore?.Get<string>("assignmentState"); }
            set { BackingStore?.Set("assignmentState", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The decision property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Decision
        {
            get { return BackingStore?.Get<string?>("decision"); }
            set { BackingStore?.Set("decision", value); }
        }
#nullable restore
#else
        public string Decision
        {
            get { return BackingStore?.Get<string>("decision"); }
            set { BackingStore?.Set("decision", value); }
        }
#endif
        /// <summary>The reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason
        {
            get { return BackingStore?.Get<string?>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#nullable restore
#else
        public string Reason
        {
            get { return BackingStore?.Get<string>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#endif
        /// <summary>The schedule property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.GovernanceSchedule? Schedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GovernanceSchedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.GovernanceSchedule Schedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GovernanceSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.UpdateRequest.UpdateRequestPostRequestBody"/> and sets the default values.
        /// </summary>
        public UpdateRequestPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.UpdateRequest.UpdateRequestPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.UpdateRequest.UpdateRequestPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.PrivilegedAccess.Item.Resources.Item.RoleAssignmentRequests.Item.UpdateRequest.UpdateRequestPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignmentState", n => { AssignmentState = n.GetStringValue(); } },
                { "decision", n => { Decision = n.GetStringValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "schedule", n => { Schedule = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.GovernanceSchedule>(global::Microsoft.Graph.Beta.Models.GovernanceSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assignmentState", AssignmentState);
            writer.WriteStringValue("decision", Decision);
            writer.WriteStringValue("reason", Reason);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.GovernanceSchedule>("schedule", Schedule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
