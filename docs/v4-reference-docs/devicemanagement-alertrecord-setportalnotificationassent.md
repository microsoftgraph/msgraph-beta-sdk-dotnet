---
title: "alertRecord: setPortalNotificationAsSent"
description: "Set a single portal notification status to published."
author: "zhishending"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# alertRecord: setPortalNotificationAsSent

Namespace: microsoft.graph.deviceManagement

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Set the status of the notification associated with the specified [alertRecord](../resources/devicemanagement-alertrecord.md) on the Microsoft EndPoint Manager admin center as sent, by setting the **isPortalNotificationSent** property of the [portal notification](../resources/devicemanagement-portalnotification.md) to `true`.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|CloudPC.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /deviceManagement/monitoring/alertRecords/{alertRecordId}/setPortalNotificationAsSent
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "alertrecordthis.setportalnotificationassent"
}
-->
``` http
POST https://graph.microsoft.com/beta/deviceManagement/monitoring/alertRecords/6c46a7ba-e78a-45e5-a81c-179ab8fd3e8e/setPortalNotificationAsSent
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.DeviceManagement.Monitoring.AlertRecords["{deviceManagement.alertRecord-id}"]
	.SetPortalNotificationAsSent()
	.Request()
	.PostAsync();

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
