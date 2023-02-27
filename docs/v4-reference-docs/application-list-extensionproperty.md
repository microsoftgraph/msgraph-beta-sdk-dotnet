---
title: "List extensionProperties (directory extensions)"
description: "Retrieve a list of directory extension definitions."
ms.localizationpriority: medium
author: "sureshja"
ms.prod: "extensions"
doc_type: "apiPageType"
---

# List extensionProperties (directory extensions)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the list of directory extension definitions, represented by [extensionProperty](../resources/extensionproperty.md) objects on an [application](../resources/application.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Application.Read.All, Directory.Read.All, Application.ReadWrite.All, Directory.ReadWrite.All|
|Delegated (personal Microsoft account) | Application.Read.All, Application.ReadWrite.All    |
|Application | Application.Read.All, Application.ReadWrite.OwnedBy, Application.ReadWrite.All, Directory.ReadWrite.All |

> [!NOTE]
> The *Application.ReadWrite.OwnedBy* permission allows an app to call `GET /applications` and `GET /servicePrincipals` to list all applications and service principals in the tenant. This scope of access has been allowed for the permission.
## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /applications/{application ObjectId}/extensionProperties
```

## Optional query parameters

This method supports the `$select` and `$filter` (`eq` on **name**) OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

| Name       | Description|
|:-----------|:----------|
| Authorization  | Bearer {token}. Required.  |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [extensionProperty](../resources/extensionproperty.md) objects in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_extensionproperties"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/applications/fd918e4b-c821-4efb-b50a-5eddd23afc6f/extensionProperties
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var extensionProperties = await graphClient.Applications["{application-id}"].ExtensionProperties
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.extensionProperty",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#applications('fd918e4b-c821-4efb-b50a-5eddd23afc6f')/extensionProperties",
    "value": [
        {
            "id": "da38c7b1-133e-4a79-abcd-e2fd586ce621",
            "deletedDateTime": null,
            "appDisplayName": "",
            "name": "extension_25883231668a43a780b25685c3f874bc_jobGroup",
            "dataType": "String",
            "isSyncedFromOnPremises": false,
            "targetObjects": [
                "User"
            ]
        },
        {
            "id": "1f0f15e3-925d-40f0-8fc8-9d3ad135bce0",
            "deletedDateTime": null,
            "appDisplayName": "",
            "name": "extension_25883231668a43a780b25685c3f874bc_cpiminternal_useAccountEnabledForPhone",
            "dataType": "String",
            "isSyncedFromOnPremises": false,
            "targetObjects": [
                "User"
            ]
        }
    ]
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "List extensionProperties",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->



