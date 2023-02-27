---
title: "Get extensionProperty (directory extension)"
description: "Read a directory extension definition."
author: "keylimesoda"
ms.localizationpriority: medium
ms.prod: "extensions"
doc_type: apiPageType
---

# Get extensionProperty (directory extension)
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read a directory extension definition represented by an [extensionProperty](../resources/extensionproperty.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Application.Read.All, Directory.Read.All, Application.ReadWrite.All |
|Delegated (personal Microsoft account) | Application.Read.All, Application.ReadWrite.All    |
|Application | Application.Read.All, Application.ReadWrite.OwnedBy, Application.ReadWrite.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /applications/{application ObjectId}/extensionProperties/{extensionPropertyId}
```

## Optional query parameters
This method supports the `$select` OData query parameter to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [extensionProperty](../resources/extensionproperty.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_extensionproperty"
}
-->
``` http
GET https://graph.microsoft.com/beta/applications/fd918e4b-c821-4efb-b50a-5eddd23afc6f/extensionProperties/1f0f15e3-925d-40f0-8fc8-9d3ad135bce0
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var extensionProperty = await graphClient.Applications["{application-id}"].ExtensionProperties["{extensionProperty-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.extensionProperty"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#applications('fd918e4b-c821-4efb-b50a-5eddd23afc6f')/extensionProperties/$entity",
    "id": "1f0f15e3-925d-40f0-8fc8-9d3ad135bce0",
    "deletedDateTime": null,
    "appDisplayName": "b2c-extensions-app. Do not modify. Used by AADB2C for storing user data.",
    "name": "extension_25883231668a43a780b25685c3f874bc_cpiminternal_useAccountEnabledForPhone",
    "dataType": "String",
    "isSyncedFromOnPremises": false,
    "targetObjects": [
        "User"
    ]
}
```

