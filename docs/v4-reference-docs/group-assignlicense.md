---
title: "group: assignLicense"
description: "Add or remove licenses on the group. Licenses assigned to the group will be assigned to all users in the group."
ms.localizationpriority: medium
author: "psaffaie"
ms.prod: "groups"
doc_type: "apiPageType"
---

# group: assignLicense

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add or remove licenses on the group. Licenses assigned to the group will be assigned to all users in the group. To learn more about group-based licensing, see [What is group-based licensing in Azure Active Directory](/azure/active-directory/fundamentals/active-directory-licensing-whatis-azure-portal).

To get the subscriptions available in the directory, perform a [GET subscribedSkus request](subscribedsku-list.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)  |
| :------------------------------------- | :------------------------------------------- |
| Delegated (work or school account)     | Group.ReadWrite.All, Directory.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported.                               |
| Application                            | Group.ReadWrite.All, Directory.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /groups/{id}/assignLicense
```

## Request headers

| Header        | Value                       |
| :------------ | :-------------------------- |
| Authorization | Bearer {token}. Required.   |
| Content-Type  | application/json. Required. |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter      | Type                                                          | Description                                                                                                                                                                                                                                                                    |
| :------------- | :------------------------------------------------------------ | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| addLicenses    | [assignedLicense](../resources/assignedlicense.md) collection | A collection of [assignedLicense](../resources/assignedlicense.md) objects that specify the licenses to add. You can disable servicePlans associated with a license by setting the **disabledPlans** property on an [assignedLicense](../resources/assignedlicense.md) object. |
| removeLicenses | Guid collection                                               | A collection of skuIds that identify the licenses to remove.                                                                                                                                                                                                                   |

## Response

If successful, this method returns a `202 Accepted` response code and a target [group](../resources/group.md) object in the response body.

## Examples

### Example 1: Add licenses to the group

The following example adds licenses to the group.

#### Request

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "group_assignlicense"
}-->

```http
POST https://graph.microsoft.com/beta/groups/1132b215-826f-42a9-8cfe-1643d19d17fd/assignLicense
Content-type: application/json

{
  "addLicenses": [
    {
      "disabledPlans": [
        "113feb6c-3fe4-4440-bddc-54d774bf0318",
        "14ab5db5-e6c4-4b20-b4bc-13e36fd2227f"
      ],
      "skuId": "b05e124f-c7cc-45a0-a6aa-8cf78c946968"
    },
    {
      "disabledPlans": [
        "a413a9ff-720c-4822-98ef-2f37c2a21f4c"
      ],
      "skuId": "c7df2760-2c81-4ef7-b578-5b5392b571df"
    }
  ],
  "removeLicenses": []
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var addLicenses = new List<AssignedLicense>()
{
	new AssignedLicense
	{
		DisabledPlans = new List<Guid>()
		{
			Guid.Parse("113feb6c-3fe4-4440-bddc-54d774bf0318"),
			Guid.Parse("14ab5db5-e6c4-4b20-b4bc-13e36fd2227f")
		},
		SkuId = Guid.Parse("b05e124f-c7cc-45a0-a6aa-8cf78c946968")
	},
	new AssignedLicense
	{
		DisabledPlans = new List<Guid>()
		{
			Guid.Parse("a413a9ff-720c-4822-98ef-2f37c2a21f4c")
		},
		SkuId = Guid.Parse("c7df2760-2c81-4ef7-b578-5b5392b571df")
	}
};

var removeLicenses = new List<Guid>()
{
};

await graphClient.Groups["{group-id}"]
	.AssignLicense(addLicenses,removeLicenses)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The response is the updated group object.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.group"
} -->

```http
HTTP/1.1 202 Accepted
Content-type: application/json
location: https://graph.microsoft.com/v2/e8e96c2a-d787-4eb1-98d7-9e57c965f1de/directoryObjects/1132b215-826f-42a9-8cfe-1643d19d17fd/Microsoft.DirectoryServices.Group

{
  "id": "1132b215-826f-42a9-8cfe-1643d19d17fd",
  "createdDateTime": "2021-03-12T11:15:03Z",
  "groupTypes": [],
  "securityEnabled": true,
}
```

### Example 2: Remove licenses from the group

The following example removes licenses from the group.

#### Request

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "group_removelicense"
}-->

```http
POST https://graph.microsoft.com/beta/groups/1132b215-826f-42a9-8cfe-1643d19d17fd/assignLicense
Content-type: application/json

{
  "addLicenses": [],
  "removeLicenses": [
    "c7df2760-2c81-4ef7-b578-5b5392b571df",
    "b05e124f-c7cc-45a0-a6aa-8cf78c946968"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var addLicenses = new List<AssignedLicense>()
{
};

var removeLicenses = new List<Guid>()
{
	Guid.Parse("c7df2760-2c81-4ef7-b578-5b5392b571df"),
	Guid.Parse("b05e124f-c7cc-45a0-a6aa-8cf78c946968")
};

await graphClient.Groups["{group-id}"]
	.AssignLicense(addLicenses,removeLicenses)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The response is the updated group object.

> **Note:** The response object shown here might be shortened for readability..

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.group"
} -->

```http
HTTP/1.1 202 Accepted
Content-type: application/json
location: https://graph.microsoft.com/v2/e8e96c2a-d787-4eb1-98d7-9e57c965f1de/directoryObjects/1132b215-826f-42a9-8cfe-1643d19d17fd/Microsoft.DirectoryServices.Group

{
  "id": "1132b215-826f-42a9-8cfe-1643d19d17fd",
  "createdDateTime": "2021-03-12T11:15:03Z",
  "groupTypes": [],
  "securityEnabled": true,
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "group: assignLicense",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
