---
title: "servicePrincipal: Add owner"
description: "Add an owner for the service principal."
ms.localizationpriority: high
doc_type: apiPageType
ms.prod: "applications"
author: "sureshja"
---

# servicePrincipal: Add owner

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add an owner for the [servicePrincipal](../resources/serviceprincipal.md). Service principal owners can be users, the service principal itself, or other service principals.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Application.ReadWrite.All and Directory.Read.All, Application.ReadWrite.All and Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Application.ReadWrite.OwnedBy and Directory.Read.All, Application.ReadWrite.All and Directory.Read.All, Application.ReadWrite.OwnedBy and Directory.ReadWrite.All, Application.ReadWrite.All and Directory.ReadWrite.All  |

## HTTP request

You can address the service principal using either its **id** or **appId**. **id** and **appId** are referred to as the **Object ID** and **Application (Client) ID**, respectively, in the Azure portal.
<!-- { "blockType": "ignored" } -->
```http
POST /servicePrincipals/{id}/owners/$ref
POST /servicePrincipals(appId='{appId}')/owners/$ref
```
## Request headers
| Name       | Description|
|:-----------|:----------|
| Authorization | Bearer {token}. Required.  |

## Request body
In the request body, supply a JSON representation of a [directoryObject](../resources/directoryobject.md) object.

## Response

If successful, this method returns a `204 No Content` response code and a [directoryObject](../resources/directoryobject.md) object in the response body.

## Examples
### Request
Here is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_directoryobject_from_serviceprincipal"
}-->
```http
POST https://graph.microsoft.com/beta/servicePrincipals/{id}/owners/$ref
Content-type: application/json

{
    "@odata.id": "https://graph.microsoft.com/v1.0/directoryObjects/{id}"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var directoryObject = new DirectoryObject
{
	Id = "{id}"
};

await graphClient.ServicePrincipals["{servicePrincipal-id}"].Owners.References
	.Request()
	.AddAsync(directoryObject);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.

<!-- {
  "blockType": "response"
} -->
```http
HTTP/1.1 204 No Content
```
<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Create owner",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->



