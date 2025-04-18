// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ManagementTemplateStepDeployment : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The createdByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedByUserId
        {
            get { return BackingStore?.Get<string?>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#nullable restore
#else
        public string CreatedByUserId
        {
            get { return BackingStore?.Get<string>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ManagedTenants.GraphAPIErrorDetails? Error
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedTenants.GraphAPIErrorDetails?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ManagedTenants.GraphAPIErrorDetails Error
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedTenants.GraphAPIErrorDetails>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#endif
        /// <summary>The lastActionByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActionByUserId
        {
            get { return BackingStore?.Get<string?>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#nullable restore
#else
        public string LastActionByUserId
        {
            get { return BackingStore?.Get<string>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#endif
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>The status property</summary>
        public global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateDeploymentStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateDeploymentStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The templateStepVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateStepVersion? TemplateStepVersion
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateStepVersion?>("templateStepVersion"); }
            set { BackingStore?.Set("templateStepVersion", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateStepVersion TemplateStepVersion
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateStepVersion>("templateStepVersion"); }
            set { BackingStore?.Set("templateStepVersion", value); }
        }
#endif
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId
        {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId
        {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateStepDeployment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateStepDeployment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateStepDeployment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "error", n => { Error = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ManagedTenants.GraphAPIErrorDetails>(global::Microsoft.Graph.Beta.Models.ManagedTenants.GraphAPIErrorDetails.CreateFromDiscriminatorValue); } },
                { "lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                { "lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateDeploymentStatus>(); } },
                { "templateStepVersion", n => { TemplateStepVersion = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateStepVersion>(global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateStepVersion.CreateFromDiscriminatorValue); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
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
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ManagedTenants.GraphAPIErrorDetails>("error", Error);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateDeploymentStatus>("status", Status);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplateStepVersion>("templateStepVersion", TemplateStepVersion);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
#pragma warning restore CS0618
