// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class InformationProtection : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The bitlocker property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Bitlocker? Bitlocker
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Bitlocker?>("bitlocker"); }
            set { BackingStore?.Set("bitlocker", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Bitlocker Bitlocker
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Bitlocker>("bitlocker"); }
            set { BackingStore?.Set("bitlocker", value); }
        }
#endif
        /// <summary>The dataLossPreventionPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DataLossPreventionPolicy>? DataLossPreventionPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DataLossPreventionPolicy>?>("dataLossPreventionPolicies"); }
            set { BackingStore?.Set("dataLossPreventionPolicies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DataLossPreventionPolicy> DataLossPreventionPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DataLossPreventionPolicy>>("dataLossPreventionPolicies"); }
            set { BackingStore?.Set("dataLossPreventionPolicies", value); }
        }
#endif
        /// <summary>The policy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.InformationProtectionPolicy? Policy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.InformationProtectionPolicy?>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.InformationProtectionPolicy Policy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.InformationProtectionPolicy>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
#endif
        /// <summary>The sensitivityLabels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.SensitivityLabel>? SensitivityLabels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SensitivityLabel>?>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.SensitivityLabel> SensitivityLabels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SensitivityLabel>>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#endif
        /// <summary>The sensitivityPolicySettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.SensitivityPolicySettings? SensitivityPolicySettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SensitivityPolicySettings?>("sensitivityPolicySettings"); }
            set { BackingStore?.Set("sensitivityPolicySettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.SensitivityPolicySettings SensitivityPolicySettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SensitivityPolicySettings>("sensitivityPolicySettings"); }
            set { BackingStore?.Set("sensitivityPolicySettings", value); }
        }
#endif
        /// <summary>The threatAssessmentRequests property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ThreatAssessmentRequest>? ThreatAssessmentRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ThreatAssessmentRequest>?>("threatAssessmentRequests"); }
            set { BackingStore?.Set("threatAssessmentRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ThreatAssessmentRequest> ThreatAssessmentRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ThreatAssessmentRequest>>("threatAssessmentRequests"); }
            set { BackingStore?.Set("threatAssessmentRequests", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.InformationProtection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.InformationProtection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.InformationProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "bitlocker", n => { Bitlocker = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Bitlocker>(global::Microsoft.Graph.Beta.Models.Bitlocker.CreateFromDiscriminatorValue); } },
                { "dataLossPreventionPolicies", n => { DataLossPreventionPolicies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DataLossPreventionPolicy>(global::Microsoft.Graph.Beta.Models.DataLossPreventionPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "policy", n => { Policy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.InformationProtectionPolicy>(global::Microsoft.Graph.Beta.Models.InformationProtectionPolicy.CreateFromDiscriminatorValue); } },
                { "sensitivityLabels", n => { SensitivityLabels = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SensitivityLabel>(global::Microsoft.Graph.Beta.Models.SensitivityLabel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sensitivityPolicySettings", n => { SensitivityPolicySettings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.SensitivityPolicySettings>(global::Microsoft.Graph.Beta.Models.SensitivityPolicySettings.CreateFromDiscriminatorValue); } },
                { "threatAssessmentRequests", n => { ThreatAssessmentRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ThreatAssessmentRequest>(global::Microsoft.Graph.Beta.Models.ThreatAssessmentRequest.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Bitlocker>("bitlocker", Bitlocker);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DataLossPreventionPolicy>("dataLossPreventionPolicies", DataLossPreventionPolicies);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.InformationProtectionPolicy>("policy", Policy);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SensitivityLabel>("sensitivityLabels", SensitivityLabels);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.SensitivityPolicySettings>("sensitivityPolicySettings", SensitivityPolicySettings);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ThreatAssessmentRequest>("threatAssessmentRequests", ThreatAssessmentRequests);
        }
    }
}
#pragma warning restore CS0618
