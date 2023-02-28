---
title: "Get serviceAnnouncementAttachment"
description: "Read the properties and relationships of a serviceAnnouncementAttachment object."
author: "payiAzure"
ms.localizationpriority: medium
ms.prod: "service-communications"
doc_type: apiPageType
---

# Get serviceAnnouncementAttachment
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [serviceAnnouncementAttachment](../resources/serviceannouncementattachment.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|ServiceMessage.Read.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|ServiceMessage.Read.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /admin/serviceAnnouncement/messages/{serviceUpdateMessageId}/attachments/{serviceAnnouncementAttachmentId}
```

## Optional query parameters
This method supports the [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [serviceAnnouncementAttachment](../resources/serviceannouncementattachment.md) object in the response body.

## Examples

### Example 1: Get an attachment with message ID

The following request returns a [serviceAnnouncementAttachment](../resources/serviceannouncementattachment.md) resource.

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_serviceannouncementattachment_props_relationships",
  "sampleKeys" : ["MC54091", "30356a46-ffad-47e1-acf6-40a99b1538c1"]
}
-->
``` http
GET https://graph.microsoft.com/beta/admin/serviceAnnouncement/messages/MC54091/attachments/30356a46-ffad-47e1-acf6-40a99b1538c1
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var serviceAnnouncementAttachment = await graphClient.Admin.ServiceAnnouncement.Messages["{serviceUpdateMessage-id}"].Attachments["{serviceAnnouncementAttachment-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.serviceAnnouncementAttachment"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": {
    "@odata.context": "https://graph.microsoft-ppe.com/beta/$metadata#admin/serviceAnnouncement/messages('MC54091')/attachments/$entity",
    "contentType": "application/csv",
    "isInline": false,
    "lastModifiedDateTime": "2021-09-21T04:07:15.9720778Z",
    "name": "An attachment for a Data Privacy message regarding your organization is available within Message Center. The contents of this attachment can be accessed within Message Center by a Global Administrator or someone designated as a Message Center Privacy Reader. Please sign in to Admin Center to view the details of this message in the Microsoft 365 Message center.",
    "size": 44583,
    "id": "30356a46-ffad-47e1-acf6-40a99b1538c1"
  }
}
```

### Example 2: Return a file stream of an attachment content for a message

#### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_serviceannouncementattachment_as_file_stream",
  "sampleKeys" : ["MC54091", "30356a46-ffad-47e1-acf6-40a99b1538c1"]
}
-->
``` http
GET https://graph.microsoft.com/beta/admin/serviceAnnouncement/messages/MC54091/attachments/30356a46-ffad-47e1-acf6-40a99b1538c1/content
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var stream = await graphClient.Admin.ServiceAnnouncement.Messages["{serviceUpdateMessage-id}"].Attachments["{serviceAnnouncementAttachment-id}"].Content
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.serviceAnnouncementAttachment"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": "An attachment for a Data Privacy message regarding your organization is available within Message Center. The contents of this attachment can be accessed within Message Center by a Global Administrator or someone designated as a Message Center Privacy Reader. Please sign in to Admin Center to view the details of this message in the Microsoft 365 Message center."
}
```
