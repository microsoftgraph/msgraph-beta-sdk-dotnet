---
title: Create allowedUser for printerShare
description: Grant the specified user access to submit print jobs to the associated printer share.
author: braedenp-msft
ms.localizationpriority: medium
ms.prod: cloud-printing
doc_type: apiPageType
---

# Create allowedUser for printerShare

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Grant the specified user access to submit print jobs to the associated [printerShare](../resources/printershare.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

To use the Universal Print service, the user or app's tenant must have an active Universal Print subscription, in addition to the permissions listed in the following table. The signed in user must be a [Printer Administrator](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#printer-administrator).

|Permission type | Permissions (from least to most privileged) |
|:---------------|:--------------------------------------------|
|Delegated (work or school account)| PrinterShare.ReadWrite.All |
|Delegated (personal Microsoft account)|Not Supported.|
|Application|Not Supported.|

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /print/shares/{id}/allowedUsers/$ref
```
## Request headers
| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required. |
| Content-type  | application/json. Required.|

## Request body
In the request body, supply a reference to a user entity by using the `@odata.id` format, as shown in the following example.

## Response
If successful, this method returns a `204 No Content` response code.

## Example
### Request
The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_alloweduser_from_printers"
}-->
```http
POST https://graph.microsoft.com/beta/print/shares/{id}/allowedUsers/$ref
Content-type: application/json

{
  "@odata.id": "https://graph.microsoft.com/beta/users/{id}"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var user = new User
{
	AdditionalData = new Dictionary<string, object>()
	{
		{"@odata.id", "https://graph.microsoft.com/beta/users/{id}"}
	}
};

await graphClient.Print.Shares["{printerShare-id}"].AllowedUsers.References
	.Request()
	.AddAsync(user);

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
<!-- {
  "type": "#page.annotation",
  "description": "Create allowedUser",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
