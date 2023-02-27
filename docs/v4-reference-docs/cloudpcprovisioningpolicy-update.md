---
title: "Update cloudPcProvisioningPolicy"
description: "Update the properties of a cloudPcProvisioningPolicy object."
author: "AshleyYangSZ"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# Update cloudPcProvisioningPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [cloudPcProvisioningPolicy](../resources/cloudpcprovisioningpolicy.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|CloudPC.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
PATCH /deviceManagement/virtualEndpoint/provisioningPolicies/{id}
```

## Request headers

| Name          | Description                |
| :------------ | :------------------------  |
| Authorization | Bearer {token}. Required.  |
| Content-Type  | application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [cloudPcProvisioningPolicy](../resources/cloudpcprovisioningpolicy.md) object.

The following table shows the properties that can be updated for the [cloudPcProvisioningPolicy](../resources/cloudpcprovisioningpolicy.md).

|Property|Type|Description|
|:---|:---|:---|
|description|String|The provisioning policy description.|
|displayName|String|The display name for the provisioning policy. |
|domainJoinConfiguration|[cloudPcDomainJoinConfiguration](../resources/cloudpcdomainjoinconfiguration.md)|Specifies how Cloud PCs will join Azure Active Directory.|
|enableSingleSignOn|Boolean|`True` if the provisioned Cloud PC can be accessed by single sign-on. `False` indicates that the provisioned Cloud PC doesn't support this feature. Default value is `false`. Windows 365 users can use single sign-on to authenticate to Azure Active Directory (Azure AD) with passwordless options (for example, FIDO keys) to access their Cloud PC. Optional.|
|imageDisplayName|String|The display name for the OS image you're provisioning.|
|imageId|String|The ID of the OS image you want to provision on Cloud PCs. The format for a gallery type image is: {publisher_offer_sku}. Supported values for each of the parameters are as follows: <ul><li>publisher: Microsoftwindowsdesktop.</li> <li>offer: windows-ent-cpc.</li> <li>sku: 21h1-ent-cpc-m365, 21h1-ent-cpc-os, 20h2-ent-cpc-m365, 20h2-ent-cpc-os, 20h1-ent-cpc-m365, 20h1-ent-cpc-os, 19h2-ent-cpc-m365 and 19h2-ent-cpc-os.</li></ul>|
|imageType|cloudPcProvisioningPolicyImageType|The type of OS image (custom or gallery) you want to provision on Cloud PCs. Possible values are: `gallery`, `custom`.|
|onPremisesConnectionId|String|The ID of the cloudPcOnPremisesConnection. To ensure that Cloud PCs have network connectivity and that they domain join, choose a connection with a virtual network that’s validated by the Cloud PC service.|
|windowsSettings|[cloudPcWindowsSettings](../resources/cloudpcwindowssettings.md)|The Windows operation system settings for the provisioned Cloud PCs with this provisioning policy, such as operation system language setting.|

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_provisioningpolicy"
}
-->

``` http
PATCH https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/provisioningPolicies/{id}
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.cloudPcProvisioningPolicy",
  "displayName": "HR provisioning policy",
  "description": "Provisioning policy for India HR employees",
  "onPremisesConnectionId": "4e47d0f6-6f77-44f0-8893-c0fe1701ffff",
  "imageId": "Image ID value",
  "imageDisplayName": "Image Display Name value",
  "imageType": "custom",
  "windowsSettings": {
    "language": "en-US"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcProvisioningPolicy = new CloudPcProvisioningPolicy
{
	DisplayName = "HR provisioning policy",
	Description = "Provisioning policy for India HR employees",
	OnPremisesConnectionId = "4e47d0f6-6f77-44f0-8893-c0fe1701ffff",
	ImageId = "Image ID value",
	ImageDisplayName = "Image Display Name value",
	ImageType = CloudPcProvisioningPolicyImageType.Custom,
	WindowsSettings = new CloudPcWindowsSettings
	{
		Language = "en-US"
	}
};

await graphClient.DeviceManagement.VirtualEndpoint.ProvisioningPolicies["{cloudPcProvisioningPolicy-id}"]
	.Request()
	.UpdateAsync(cloudPcProvisioningPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
}
-->
``` http
HTTP/1.1 204 No Content
```
