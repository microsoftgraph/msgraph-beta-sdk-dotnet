---
title: "Create device"
description: "Create a new device."
author: "myra-ramdenbourg"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Create device

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new device.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Directory.AccessAsUser.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported. |

The calling user must also be in one of the following [Azure AD roles](/azure/active-directory/roles/permissions-reference): *Global Administrator*, *Intune Administrator*, or *Windows 365 Administrator*.

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /devices

```
## Request headers
| Name       | Description|
|:---------------|:--------|
| Authorization  | Bearer {token}. Required. |

## Request body
In the request body, supply a JSON representation of [device](../resources/device.md) object.

Since the **device** resource supports [extensions](/graph/extensibility-overview), you can use the `POST` operation and add custom properties with your own data to the device instance while creating it.

## Response

If successful, this method returns `201 Created` response code and [device](../resources/device.md) object in the response body.

## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_device_from_devices"
}-->
```http
POST https://graph.microsoft.com/beta/devices
Content-type: application/json

{
  "accountEnabled": true,
  "alternativeSecurityIds": [
    {
      "type": 99,
      "identityProvider": "identityProvider-value",
      "key": "base64Y3YxN2E1MWFlYw=="
    }
  ],
  "approximateLastSignInDateTime": "2016-10-19T10:37:00Z",
  "deviceId": "deviceId-value",
  "deviceMetadata": "deviceMetadata-value",
  "deviceVersion": 99
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var device = new Device
{
	AccountEnabled = true,
	AlternativeSecurityIds = new List<AlternativeSecurityId>()
	{
		new AlternativeSecurityId
		{
			Type = 99,
			IdentityProvider = "identityProvider-value",
			Key = Convert.FromBase64String("base64Y3YxN2E1MWFlYw==")
		}
	},
	ApproximateLastSignInDateTime = DateTimeOffset.Parse("2016-10-19T10:37:00Z"),
	DeviceId = "deviceId-value",
	DeviceMetadata = "deviceMetadata-value",
	DeviceVersion = 99
};

await graphClient.Devices
	.Request()
	.AddAsync(device);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

