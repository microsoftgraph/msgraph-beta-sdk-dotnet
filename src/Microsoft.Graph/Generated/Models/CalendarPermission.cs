using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CalendarPermission : Entity, IParsable {
        /// <summary>List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CalendarRoleType?>? AllowedRoles {
            get { return BackingStore?.Get<List<CalendarRoleType?>?>("allowedRoles"); }
            set { BackingStore?.Set("allowedRoles", value); }
        }
#nullable restore
#else
        public List<CalendarRoleType?> AllowedRoles {
            get { return BackingStore?.Get<List<CalendarRoleType?>>("allowedRoles"); }
            set { BackingStore?.Set("allowedRoles", value); }
        }
#endif
        /// <summary>Represents a sharee or delegate who has access to the calendar. For the &apos;My Organization&apos; sharee, the address property is null. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.EmailAddress? EmailAddress {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EmailAddress?>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.EmailAddress EmailAddress {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EmailAddress>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#endif
        /// <summary>True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.</summary>
        public bool? IsInsideOrganization {
            get { return BackingStore?.Get<bool?>("isInsideOrganization"); }
            set { BackingStore?.Set("isInsideOrganization", value); }
        }
        /// <summary>True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The &apos;My organization&apos; user determines the permissions other people within your organization have to the given calendar. You cannot remove &apos;My organization&apos; as a sharee to a calendar.</summary>
        public bool? IsRemovable {
            get { return BackingStore?.Get<bool?>("isRemovable"); }
            set { BackingStore?.Set("isRemovable", value); }
        }
        /// <summary>Current permission level of the calendar sharee or delegate.</summary>
        public CalendarRoleType? Role {
            get { return BackingStore?.Get<CalendarRoleType?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CalendarPermission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CalendarPermission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedRoles", n => { AllowedRoles = n.GetCollectionOfEnumValues<CalendarRoleType>()?.ToList(); } },
                {"emailAddress", n => { EmailAddress = n.GetObjectValue<Microsoft.Graph.Beta.Models.EmailAddress>(Microsoft.Graph.Beta.Models.EmailAddress.CreateFromDiscriminatorValue); } },
                {"isInsideOrganization", n => { IsInsideOrganization = n.GetBoolValue(); } },
                {"isRemovable", n => { IsRemovable = n.GetBoolValue(); } },
                {"role", n => { Role = n.GetEnumValue<CalendarRoleType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<CalendarRoleType>("allowedRoles", AllowedRoles);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.EmailAddress>("emailAddress", EmailAddress);
            writer.WriteBoolValue("isInsideOrganization", IsInsideOrganization);
            writer.WriteBoolValue("isRemovable", IsRemovable);
            writer.WriteEnumValue<CalendarRoleType>("role", Role);
        }
    }
}
