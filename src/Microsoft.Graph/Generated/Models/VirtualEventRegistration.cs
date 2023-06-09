using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class VirtualEventRegistration : Entity, IParsable {
        /// <summary>Total capacity of the virtual event.</summary>
        public int? Capacity {
            get { return BackingStore?.Get<int?>("capacity"); }
            set { BackingStore?.Set("capacity", value); }
        }
        /// <summary>Registration questions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VirtualEventRegistrationQuestion>? Questions {
            get { return BackingStore?.Get<List<VirtualEventRegistrationQuestion>?>("questions"); }
            set { BackingStore?.Set("questions", value); }
        }
#nullable restore
#else
        public List<VirtualEventRegistrationQuestion> Questions {
            get { return BackingStore?.Get<List<VirtualEventRegistrationQuestion>>("questions"); }
            set { BackingStore?.Set("questions", value); }
        }
#endif
        /// <summary>Information of attendees who have registered for the virtual event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VirtualEventRegistrant>? Registrants {
            get { return BackingStore?.Get<List<VirtualEventRegistrant>?>("registrants"); }
            set { BackingStore?.Set("registrants", value); }
        }
#nullable restore
#else
        public List<VirtualEventRegistrant> Registrants {
            get { return BackingStore?.Get<List<VirtualEventRegistrant>>("registrants"); }
            set { BackingStore?.Set("registrants", value); }
        }
#endif
        /// <summary>Registration URL of the virtual event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistrationWebUrl {
            get { return BackingStore?.Get<string?>("registrationWebUrl"); }
            set { BackingStore?.Set("registrationWebUrl", value); }
        }
#nullable restore
#else
        public string RegistrationWebUrl {
            get { return BackingStore?.Get<string>("registrationWebUrl"); }
            set { BackingStore?.Set("registrationWebUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEventRegistration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEventRegistration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"capacity", n => { Capacity = n.GetIntValue(); } },
                {"questions", n => { Questions = n.GetCollectionOfObjectValues<VirtualEventRegistrationQuestion>(VirtualEventRegistrationQuestion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"registrants", n => { Registrants = n.GetCollectionOfObjectValues<VirtualEventRegistrant>(VirtualEventRegistrant.CreateFromDiscriminatorValue)?.ToList(); } },
                {"registrationWebUrl", n => { RegistrationWebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("capacity", Capacity);
            writer.WriteCollectionOfObjectValues<VirtualEventRegistrationQuestion>("questions", Questions);
            writer.WriteCollectionOfObjectValues<VirtualEventRegistrant>("registrants", Registrants);
            writer.WriteStringValue("registrationWebUrl", RegistrationWebUrl);
        }
    }
}
