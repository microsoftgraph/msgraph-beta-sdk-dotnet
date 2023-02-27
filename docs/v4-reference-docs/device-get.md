---
title: "Get device"
description: "Get the properties and relationships of a device object."
author: "sandeo-MSFT"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Get device

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the properties and relationships of a device object.

Since the **device** resource supports [extensions](/graph/extensibility-overview), you can also use the `GET` operation to get custom properties and extension data in a **device** instance.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Device.Read.All, Directory.Read.All, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Device.Read.All, Device.ReadWrite.All, Directory.Read.All, Directory.ReadWrite.All |

The calling user must also be in one of the following [Azure AD roles](/azure/active-directory/roles/permissions-reference):

* Global Administrator
* Users
* Directory Readers
* Directory Writers
* Compliance Administrator
* Device Managers
* Application Administrator
* Security Reader
* Security Administrator
* Privileged Role Administrator
* Cloud Application Administrator
* Customer LockBox Access Approver
* Dynamics 365 Administrator
* Power BI Administrator
* Desktop Analytics Administrator
* Microsoft Managed Desktop Administrator
* Teams Communications Administrator
* Teams Communications Support Engineer
* Teams Communications Support Specialist
* Teams Administrator
* Compliance Data Administrator
* Security Operator
* Kaizala Administrator
* Global Reader
* Directory Reviewer
* Windows 365 Administrator

## HTTP request

You can address the device using either its **id** or **deviceId**.
<!-- { "blockType": "ignored" } -->
```http
GET /devices/{id}
GET /devices(deviceId='{deviceId}')
```

## Optional query parameters
This method supports the `$select` [OData query parameter](/graph/query-parameters) to help customize the response.
## Request headers
| Name       | Description|
|:-----------|:------|
| Authorization  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and [device](../resources/device.md) object in the response body.
## Examples

### Example 1: Get a device

#### Request
The following example shows a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_device"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/devices/000005c3-b7a6-4c61-89fc-80bf5ccfc366
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var device = await graphClient.Devices["{device-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following example shows a response for a device with no **hostNames**. 

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.device"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "@odata.context": "https://graph.microsoft.com/v1.0/$metadata#devices/$entity",
  "@odata.id": "https://graph.microsoft.com/v2/72f988bf-86f1-41af-91ab-2d7cd011db47/directoryObjects/000005c3-b7a6-4c61-89fc-80bf5ccfc366/Microsoft.DirectoryServices.Device",
  "accountEnabled": true,
  "approximateLastSignInDateTime": "2021-08-26T21:15:01Z",
  "deviceId": "000005c3-b7a6-4c61-89fc-80bf5ccfc366",
  "deviceMetadata": null,
  "deviceVersion": 2,
  "hostNames": []
}
```

The following example shows a response for a device with **hostNames**. 

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.device"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "accountEnabled": true,
  "approximateLastSignInDateTime": "2016-10-19T10:37:00Z",
  "deviceId": "deviceId-value",
  "deviceMetadata": "deviceMetadata-value",
  "deviceVersion": 99,
  "hostnames":["hostname1.contoso.onmicrosoft.com", "hostname1"]
}
```

### Example 2: Get a device and return only its id and extensionAttributes properties

#### Request

The following request retrieves the **id** and **extensionAttributes** property of a device.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_device_select"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/devices/6a59ea83-02bd-468f-a40b-f2c3d1821983?$select=id,extensionAttributes
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var device = await graphClient.Devices["{device-id}"]
	.Request()
	.Select("id,extensionAttributes")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.device"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#devices(id,extensionAttributes)/$entity",
    "id": "6a59ea83-02bd-468f-a40b-f2c3d1821983",
    "extensionAttributes": {
        "extensionAttribute1": null,
        "extensionAttribute2": null,
        "extensionAttribute3": null,
        "extensionAttribute4": null,
        "extensionAttribute5": null,
        "extensionAttribute6": null,
        "extensionAttribute7": null,
        "extensionAttribute8": null,
        "extensionAttribute9": null,
        "extensionAttribute10": null,
        "extensionAttribute11": null,
        "extensionAttribute12": null,
        "extensionAttribute13": null,
        "extensionAttribute14": null,
        "extensionAttribute15": null
    }
}
```

## See also

- [Add custom data to resources using extensions](/graph/extensibility-overview)
- [Add custom data to users using open extensions (preview)](/graph/extensibility-open-users)
- [Add custom data to groups using schema extensions (preview)](/graph/extensibility-schema-groups)


<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Get device",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
