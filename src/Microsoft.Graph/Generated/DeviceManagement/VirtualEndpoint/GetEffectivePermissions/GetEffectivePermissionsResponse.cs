// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.GetEffectivePermissions
{
    [Obsolete("This class is obsolete. Use GetEffectivePermissionsGetResponse instead.")]
    #pragma warning disable CS1591
    public class GetEffectivePermissionsResponse : Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.GetEffectivePermissions.GetEffectivePermissionsGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.GetEffectivePermissions.GetEffectivePermissionsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.GetEffectivePermissions.GetEffectivePermissionsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.GetEffectivePermissions.GetEffectivePermissionsResponse();
        }
    }
}
