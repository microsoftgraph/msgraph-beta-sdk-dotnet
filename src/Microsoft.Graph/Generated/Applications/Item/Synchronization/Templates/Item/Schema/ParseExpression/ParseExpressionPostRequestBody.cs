// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Applications.Item.Synchronization.Templates.Item.Schema.ParseExpression
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ParseExpressionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The expression property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Expression
        {
            get { return BackingStore?.Get<string?>("expression"); }
            set { BackingStore?.Set("expression", value); }
        }
#nullable restore
#else
        public string Expression
        {
            get { return BackingStore?.Get<string>("expression"); }
            set { BackingStore?.Set("expression", value); }
        }
#endif
        /// <summary>The targetAttributeDefinition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AttributeDefinition? TargetAttributeDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AttributeDefinition?>("targetAttributeDefinition"); }
            set { BackingStore?.Set("targetAttributeDefinition", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AttributeDefinition TargetAttributeDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AttributeDefinition>("targetAttributeDefinition"); }
            set { BackingStore?.Set("targetAttributeDefinition", value); }
        }
#endif
        /// <summary>The testInputObject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ExpressionInputObject? TestInputObject
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ExpressionInputObject?>("testInputObject"); }
            set { BackingStore?.Set("testInputObject", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ExpressionInputObject TestInputObject
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ExpressionInputObject>("testInputObject"); }
            set { BackingStore?.Set("testInputObject", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Applications.Item.Synchronization.Templates.Item.Schema.ParseExpression.ParseExpressionPostRequestBody"/> and sets the default values.
        /// </summary>
        public ParseExpressionPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Applications.Item.Synchronization.Templates.Item.Schema.ParseExpression.ParseExpressionPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Applications.Item.Synchronization.Templates.Item.Schema.ParseExpression.ParseExpressionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Applications.Item.Synchronization.Templates.Item.Schema.ParseExpression.ParseExpressionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "expression", n => { Expression = n.GetStringValue(); } },
                { "targetAttributeDefinition", n => { TargetAttributeDefinition = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AttributeDefinition>(global::Microsoft.Graph.Beta.Models.AttributeDefinition.CreateFromDiscriminatorValue); } },
                { "testInputObject", n => { TestInputObject = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ExpressionInputObject>(global::Microsoft.Graph.Beta.Models.ExpressionInputObject.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("expression", Expression);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AttributeDefinition>("targetAttributeDefinition", TargetAttributeDefinition);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ExpressionInputObject>("testInputObject", TestInputObject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
