using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class CustomTaskExtension : CustomCalloutExtension, IParsable {
        /// <summary>The callback configuration for a custom extension.</summary>
        public Microsoft.Graph.Beta.Models.CustomExtensionCallbackConfiguration CallbackConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CustomExtensionCallbackConfiguration>("callbackConfiguration"); }
            set { BackingStore?.Set("callbackConfiguration", value); }
        }
        /// <summary>The unique identifier of the Azure AD user that created the custom task extension.Supports $filter(eq, ne) and $expand.</summary>
        public Microsoft.Graph.Beta.Models.User CreatedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.User>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
        /// <summary>When the custom task extension was created.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The unique identifier of the Azure AD user that modified the custom task extension last.Supports $filter(eq, ne) and $expand.</summary>
        public Microsoft.Graph.Beta.Models.User LastModifiedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.User>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
        /// <summary>When the custom extension was last modified.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new CustomTaskExtension and sets the default values.
        /// </summary>
        public CustomTaskExtension() : base() {
            OdataType = "#microsoft.graph.identityGovernance.customTaskExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomTaskExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomTaskExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"callbackConfiguration", n => { CallbackConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.CustomExtensionCallbackConfiguration>(Microsoft.Graph.Beta.Models.CustomExtensionCallbackConfiguration.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.User>(Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.User>(Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CustomExtensionCallbackConfiguration>("callbackConfiguration", CallbackConfiguration);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.User>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.User>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
