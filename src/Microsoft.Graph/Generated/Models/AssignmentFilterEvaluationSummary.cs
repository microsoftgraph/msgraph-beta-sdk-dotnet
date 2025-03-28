// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Represent result summary for assignment filter evaluation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AssignmentFilterEvaluationSummary : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The admin defined name for assignment filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentFilterDisplayName
        {
            get { return BackingStore?.Get<string?>("assignmentFilterDisplayName"); }
            set { BackingStore?.Set("assignmentFilterDisplayName", value); }
        }
#nullable restore
#else
        public string AssignmentFilterDisplayName
        {
            get { return BackingStore?.Get<string>("assignmentFilterDisplayName"); }
            set { BackingStore?.Set("assignmentFilterDisplayName", value); }
        }
#endif
        /// <summary>Unique identifier for the assignment filter object</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentFilterId
        {
            get { return BackingStore?.Get<string?>("assignmentFilterId"); }
            set { BackingStore?.Set("assignmentFilterId", value); }
        }
#nullable restore
#else
        public string AssignmentFilterId
        {
            get { return BackingStore?.Get<string>("assignmentFilterId"); }
            set { BackingStore?.Set("assignmentFilterId", value); }
        }
#endif
        /// <summary>The time the assignment filter was last modified.</summary>
        public DateTimeOffset? AssignmentFilterLastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("assignmentFilterLastModifiedDateTime"); }
            set { BackingStore?.Set("assignmentFilterLastModifiedDateTime", value); }
        }
        /// <summary>Supported platform types.</summary>
        public global::Microsoft.Graph.Beta.Models.DevicePlatformType? AssignmentFilterPlatform
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DevicePlatformType?>("assignmentFilterPlatform"); }
            set { BackingStore?.Set("assignmentFilterPlatform", value); }
        }
        /// <summary>Represents type of the assignment filter.</summary>
        public global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilterType? AssignmentFilterType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilterType?>("assignmentFilterType"); }
            set { BackingStore?.Set("assignmentFilterType", value); }
        }
        /// <summary>A collection of filter types and their corresponding evaluation results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AssignmentFilterTypeAndEvaluationResult>? AssignmentFilterTypeAndEvaluationResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AssignmentFilterTypeAndEvaluationResult>?>("assignmentFilterTypeAndEvaluationResults"); }
            set { BackingStore?.Set("assignmentFilterTypeAndEvaluationResults", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AssignmentFilterTypeAndEvaluationResult> AssignmentFilterTypeAndEvaluationResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AssignmentFilterTypeAndEvaluationResult>>("assignmentFilterTypeAndEvaluationResults"); }
            set { BackingStore?.Set("assignmentFilterTypeAndEvaluationResults", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The time assignment filter was evaluated.</summary>
        public DateTimeOffset? EvaluationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("evaluationDateTime"); }
            set { BackingStore?.Set("evaluationDateTime", value); }
        }
        /// <summary>Supported evaluation results for filter.</summary>
        public global::Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationResult? EvaluationResult
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationResult?>("evaluationResult"); }
            set { BackingStore?.Set("evaluationResult", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationSummary"/> and sets the default values.
        /// </summary>
        public AssignmentFilterEvaluationSummary()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignmentFilterDisplayName", n => { AssignmentFilterDisplayName = n.GetStringValue(); } },
                { "assignmentFilterId", n => { AssignmentFilterId = n.GetStringValue(); } },
                { "assignmentFilterLastModifiedDateTime", n => { AssignmentFilterLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "assignmentFilterPlatform", n => { AssignmentFilterPlatform = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.DevicePlatformType>(); } },
                { "assignmentFilterType", n => { AssignmentFilterType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilterType>(); } },
                { "assignmentFilterTypeAndEvaluationResults", n => { AssignmentFilterTypeAndEvaluationResults = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AssignmentFilterTypeAndEvaluationResult>(global::Microsoft.Graph.Beta.Models.AssignmentFilterTypeAndEvaluationResult.CreateFromDiscriminatorValue)?.AsList(); } },
                { "evaluationDateTime", n => { EvaluationDateTime = n.GetDateTimeOffsetValue(); } },
                { "evaluationResult", n => { EvaluationResult = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationResult>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assignmentFilterDisplayName", AssignmentFilterDisplayName);
            writer.WriteStringValue("assignmentFilterId", AssignmentFilterId);
            writer.WriteDateTimeOffsetValue("assignmentFilterLastModifiedDateTime", AssignmentFilterLastModifiedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.DevicePlatformType>("assignmentFilterPlatform", AssignmentFilterPlatform);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilterType>("assignmentFilterType", AssignmentFilterType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AssignmentFilterTypeAndEvaluationResult>("assignmentFilterTypeAndEvaluationResults", AssignmentFilterTypeAndEvaluationResults);
            writer.WriteDateTimeOffsetValue("evaluationDateTime", EvaluationDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AssignmentFilterEvaluationResult>("evaluationResult", EvaluationResult);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
