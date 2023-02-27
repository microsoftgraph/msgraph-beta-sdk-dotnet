---
title: "Create programControl (deprecated)"
description: "In the Azure AD access reviews feature, create a new programControl object.  This links an access review to a program."
ms.localizationpriority: medium
doc_type: apiPageType
ms.prod: "governance"
author: "markwahl-msft"
---

# Create programControl (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

>[!CAUTION]
>This version of the access review API is deprecated and will stop returning data on May 19, 2023. Please use [access reviews API](/graph/api/resources/accessreviewsv2-overview?view=graph-rest-beta&preserve-view=true).
In the Azure AD [access reviews](../resources/accessreviews-root.md) feature, create a new [programControl](../resources/programcontrol.md) object.  This links an access review to a program.

Prior to making this request, the caller must have previously

- [created a program](program-create.md) or [retrieved a program](program-list.md), to have the value of `programId` to include in the request,
- [created an access review](accessreview-create.md) or [retrieved an access review](accessreview-get.md), to have the value of `controlId` to include in the request, and
- [retrieved the list of program control types](programcontroltype-list.md), to have the value of `controlTypeId` to include in the request.


## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)              |
|:--------------------------------------|:---------------------------------------------------------|
|Delegated (work or school account)     | ProgramControl.ReadWrite.All  |
|Delegated (personal Microsoft account) | Not supported. |
|Application                            |  ProgramControl.ReadWrite.All  |

The signed in user must also be in a directory role that permits them to create a **programControl**. 

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /programControls
```
## Request headers
| Name         | Type        | Description |
|:-------------|:------------|:------------|
| Authorization | string | Bearer \{token\}. Required. |

## Request body
In the request body, supply a JSON representation of a [programControl](../resources/programcontrol.md) object.

The following table shows the properties that are required when you create a program control.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
| `programId`              |`String`                | The programId of the program this control is going to become a part of.                             |
| `controlId`              |`String`                | The controlId of the control, in particular the identifier of an access review.                                                |
| `controlTypeId`          |`String`                | The programControlType identifies the type of program control - for example, a control linking to guest access reviews. |

## Response
If successful, this method returns a `201, Created` response code and a [programControl](../resources/programcontrol.md) object in the response body.


## Example
##### Request
In the request body, supply a JSON representation of the [programControl](../resources/programcontrol.md) object.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_programControl_from_programControls"
}-->
```http
POST https://graph.microsoft.com/beta/programControls
Content-type: application/json

{
    "controlId": "7e59d237-2fb0-4e5d-b7bb-d4f9f9129213",
    "controlTypeId": "6e4f3d20-c5c3-407f-9695-8460952bcc68",
    "programId": "7e59d237-2fb0-4e5d-b7bb-d4f9f9129213"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var programControl = new ProgramControl
{
	ControlId = "7e59d237-2fb0-4e5d-b7bb-d4f9f9129213",
	ControlTypeId = "6e4f3d20-c5c3-407f-9695-8460952bcc68",
	ProgramId = "7e59d237-2fb0-4e5d-b7bb-d4f9f9129213"
};

await graphClient.ProgramControls
	.Request()
	.AddAsync(programControl);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

