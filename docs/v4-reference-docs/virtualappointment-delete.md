---
title: "Delete virtualAppointment"
description: "Delete a virtualAppointment object."
author: "benmicrosoft"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# Delete virtualAppointment

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Delete a [virtualAppointment](../resources/virtualappointment.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)                                            |
|:---------------------------------------|:---------------------------------------------------------------------------------------|
| Delegated (work or school account)     | VirtualAppointment.ReadWrite, OnlineMeetings.ReadWrite                                  |
| Delegated (personal Microsoft account) | Not supported.                                                                         |
| Application                            | VirtualAppointment.ReadWrite.All

> [!NOTE]
> Virtual appointment will transition from online meeting permissions to more specific virtual appointment permissions during the preview period. This will give developers more granular control over virtual appointment permissions. We'll provide additional details on when online meeting permissions will no longer be supported before the preview period ends.

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
DELETE /me/onlineMeetings/{onlineMeetingId}/virtualAppointment
DELETE /users/{userId}/onlineMeetings/{onlineMeetingId}/virtualAppointment
```

## Request headers
| Name            | Description               |
| :-------------- | :------------------------ |
| Authorization   | Bearer {token}. Required. |
| Accept-Language | Language. Optional.       |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_virtualappointment",
  "sampleKeys": ["MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZi"]
}
-->
``` http
DELETE https://graph.microsoft.com/beta/me/onlineMeeting/MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZi/virtualAppointment
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.OnlineMeeting.MSpkYzE3Njc0Yy04MWQ5LTRhZGItYmZi.VirtualAppointment
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
<!-- {
  "blockType": "response",
  "truncated": true
}
-->
``` http
HTTP/1.1 204 No Content
```

