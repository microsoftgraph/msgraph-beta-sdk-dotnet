---
title: "Create externalGroupMember"
description: "Create a new externalGroupMember object."
author: "snlraju-msft"
ms.localizationpriority: medium
ms.prod: "search"
doc_type: apiPageType
---

# Create externalGroupMember

Namespace: microsoft.graph.externalConnectors

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [externalGroupMember](../resources/externalconnectors-externalgroupmember.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | ExternalItem.ReadWrite.OwnedBy, ExternalItem.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | ExternalItem.ReadWrite.OwnedBy, ExternalItem.ReadWrite.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
POST /external/connections/{connectionsId}/groups/{externalGroupId}/members
```

## Request headers

| Name          | Description                 |
|:--------------|:----------------------------|
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply a JSON representation of the **externalGroupMember** object.

You can specify the following properties when creating an **externalGroupMember**.

| Property       | Type                    | Description                                              |
|:---------------|:------------------------|:---------------------------------------------------------|
| id             | String                  | The unique `id` of the member. It would be the objectId in case of Azure Active Directory users or groups and the externalGroupId in case of external groups. Required.                                   |
| type           | microsoft.graph.externalConnectors.externalGroupMemberType | The type of member added to the external group. Possible values are: `user` or `group` when the identitySource is `azureActiveDirectory` and just `group` when the identitySource is `external`. Required. |
| identitySource | microsoft.graph.externalConnectors.identitySourceType      | The identity source that the member belongs to. Possible values are: `azureActiveDirectory`, `external`. Required.                                                                                       |

## Response

If successful, this method returns a `201 Created` response code and an **externalGroupMember** object in the response body.

## Examples

### Example 1: Add an Azure Active Directory user as a member

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_externalgroupmember_from__1",
  "sampleKeys": ["31bea3d537902000", "contosohr"]
}
-->

``` http
POST https://graph.microsoft.com/beta/external/connections/contosohr/groups/31bea3d537902000/members
Content-Type: application/json

{
  "id": "e811976d-83df-4cbd-8b9b-5215b18aa874",
  "type": "user",
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var identity = new Microsoft.Graph.ExternalConnectors.Identity
{
	Id = "e811976d-83df-4cbd-8b9b-5215b18aa874",
	Type = Microsoft.Graph.ExternalConnectors.IdentityType.User
};

await graphClient.External.Connections["{externalConnectors.externalConnection-id}"].Groups["{externalConnectors.externalGroup-id}"].Members
	.Request()
	.AddAsync(identity);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.externalConnectors.externalGroupMember"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "id": "e811976d-83df-4cbd-8b9b-5215b18aa874",
  "type": "user",
}
```

### Example 2: Add an Azure Active Directory group as a member

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_externalgroupmember_from__2",
  "sampleKeys": ["31bea3d537902000", "contosohr"]
}
-->

``` http
POST https://graph.microsoft.com/beta/external/connections/contosohr/groups/31bea3d537902000/members
Content-Type: application/json

{
  "id": "e5477431-1038-484e-bf69-1dfedb97a110",
  "type": "externalGroup",
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var identity = new Microsoft.Graph.ExternalConnectors.Identity
{
	Id = "e5477431-1038-484e-bf69-1dfedb97a110",
	Type = Microsoft.Graph.ExternalConnectors.IdentityType.ExternalGroup
};

await graphClient.External.Connections["{externalConnectors.externalConnection-id}"].Groups["{externalConnectors.externalGroup-id}"].Members
	.Request()
	.AddAsync(identity);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.externalConnectors.externalGroupMember"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "id": "e5477431-1038-484e-bf69-1dfedb97a110",
  "type": "externalGroup",
}
```

### Example 3: Add another external group as a member

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_externalgroupmember_from__3",
  "sampleKeys": ["31bea3d537902000", "contosohr"]
}
-->

``` http
POST https://graph.microsoft.com/beta/external/connections/contosohr/groups/31bea3d537902000/members
Content-Type: application/json

{
  "id": "1431b9c38ee647f6a",
  "type": "externalGroup",
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var identity = new Microsoft.Graph.ExternalConnectors.Identity
{
	Id = "1431b9c38ee647f6a",
	Type = Microsoft.Graph.ExternalConnectors.IdentityType.ExternalGroup
};

await graphClient.External.Connections["{externalConnectors.externalConnection-id}"].Groups["{externalConnectors.externalGroup-id}"].Members
	.Request()
	.AddAsync(identity);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.externalConnectors.externalGroupMember"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "id": "14m1b9c38qe647f6a",
  "type": "externalGroup",
}
```
