---
title: "Get administrativeUnit"
description: "Retrieve the properties and relationships of an administrativeUnit object."
author: "DougKirschner"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Get administrativeUnit

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve the properties and relationships of an [administrativeUnit](../resources/administrativeunit.md) object.

Since the **administrativeUnit** resource supports [extensions](/graph/extensibility-overview), you can also use the `GET` operation to get custom properties and extension data in an **administrativeUnit** instance.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | AdministrativeUnit.Read.All, Directory.Read.All, AdministrativeUnit.ReadWrite.All, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | AdministrativeUnit.Read.All, Directory.Read.All, AdministrativeUnit.ReadWrite.All, Directory.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /administrativeUnits/{id}
GET /directory/administrativeUnits/{id}
```
## Optional query parameters
This method supports the `$select` [OData query parameter](/graph/query-parameters) to help customize the response. Extension properties also support query parameters as follows:

| Extension type       | Comments                                                 |
|----------------------|----------------------------------------------------------|
| Schema extensions    | Returned only with `$select`. Supports `$filter` (`eq`). |
| Directory extensions | Returned by default. Supports `$filter` (`eq`).          |

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and [administrativeUnit](../resources/administrativeunit.md) object in the response body.
## Example
### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_administrativeunit"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/administrativeUnits/4d7ea995-bc0f-45c0-8c3e-132e93bf95f8
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var administrativeUnit = await graphClient.AdministrativeUnits["{administrativeUnit-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
Here is an example of the response. 
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.administrativeUnit"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#administrativeUnits/$entity",
    "id": "49eb93f2-a5a2-4567-ad66-76a3ebd01d84",
    "deletedDateTime": null,
    "displayName": "Seattle District Technical Schools",
    "description": "Seattle district technical schools administration",
    "visibility": null,
    "membershipRule": "(user.country -eq \"United States\")",
    "membershipType": "Dynamic",
    "membershipRuleProcessingState": "On"
}
```

## See also

- [Add custom data to resources using extensions](/graph/extensibility-overview)
- [Add custom data to users using open extensions (preview)](/graph/extensibility-open-users)
<!--
- [Add custom data to groups using schema extensions (preview)](/graph/extensibility-schema-groups)
-->


<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Get administrativeUnit",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
