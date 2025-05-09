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
    public partial class AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource : global::Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemResource, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Display name of the access package to which access is granted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessPackageDisplayName
        {
            get { return BackingStore?.Get<string?>("accessPackageDisplayName"); }
            set { BackingStore?.Set("accessPackageDisplayName", value); }
        }
#nullable restore
#else
        public string AccessPackageDisplayName
        {
            get { return BackingStore?.Get<string>("accessPackageDisplayName"); }
            set { BackingStore?.Set("accessPackageDisplayName", value); }
        }
#endif
        /// <summary>Identifier of the access package to which access is granted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessPackageId
        {
            get { return BackingStore?.Get<string?>("accessPackageId"); }
            set { BackingStore?.Set("accessPackageId", value); }
        }
#nullable restore
#else
        public string AccessPackageId
        {
            get { return BackingStore?.Get<string>("accessPackageId"); }
            set { BackingStore?.Set("accessPackageId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource"/> and sets the default values.
        /// </summary>
        public AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource() : base()
        {
            OdataType = "#microsoft.graph.accessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemAccessPackageAssignmentPolicyResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackageDisplayName", n => { AccessPackageDisplayName = n.GetStringValue(); } },
                { "accessPackageId", n => { AccessPackageId = n.GetStringValue(); } },
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
            writer.WriteStringValue("accessPackageDisplayName", AccessPackageDisplayName);
            writer.WriteStringValue("accessPackageId", AccessPackageId);
        }
    }
}
#pragma warning restore CS0618
