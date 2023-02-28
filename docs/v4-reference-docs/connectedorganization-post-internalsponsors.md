---
title: "Add connected organization internal sponsor"
description: "Add a user or group to the connected organization's internal sponsors."
ms.localizationpriority: medium
author: "markwahl-msft"
ms.prod: "governance"
doc_type: apiPageType
---

# Add connected organization internal sponsor

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add a user or a group to the connected organization's internal sponsors. The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | EntitlementManagement.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | EntitlementManagement.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /identityGovernance/entitlementManagement/connectedOrganizations/{id}/internalSponsors/$ref
```
## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required. |
| Content-type | application/json. Required. |

## Request body
In the request body, supply a JSON representation of the reference to the [user](../resources/user.md) or [group](../resources/group.md) object to be added, as an `@odata.id` property with the full URI of the user or group.

## Response
If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Example

### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_internalsponsor_from_connectedorganization"
}
-->
``` http
POST https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/connectedOrganizations/{id}/internalSponsors/$ref
Content-type: application/json

{
  "@odata.id": "https://graph.microsoft.com/beta/users/{id}"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var directoryObject = new DirectoryObject
{
	Id = "{id}"
};

await graphClient.IdentityGovernance.EntitlementManagement.ConnectedOrganizations["{connectedOrganization-id}"].InternalSponsors.References
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
  "description": "Create connected organization internal sponsor",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


