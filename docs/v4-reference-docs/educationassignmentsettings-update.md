---
title: "Update educationAssignmentSettings"
description: "Update the properties of an educationAssignmentSettings object."
author: "dipakboyed"
ms.localizationpriority: medium
ms.prod: "education"
doc_type: apiPageType
---

# Update educationAssignmentSettings
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of an [educationAssignmentSettings](../resources/educationassignmentsettings.md) object. Only Teachers can update these settings.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|EduAssignments.ReadWriteBasic, EduAssignments.ReadWrite|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /education/classes/{id}/assignmentSettings
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [educationAssignmentSettings](../resources/educationassignmentsettings.md) object.

The following table shows the properties that are required when you update the [educationAssignmentSettings](../resources/educationassignmentsettings.md).

|Property|Type|Description|
|:---|:---|:---|
|submissionAnimationDisabled|Boolean|Indicates whether turn-in celebration animation will be shown. A value of `true` indicates that the animation will not be shown. Default value is `false`.|



## Response

If successful, this method returns a `200 OK` response code and an updated [educationAssignmentSettings](../resources/educationassignmentsettings.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_educationassignmentsettings"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/education/classes/{id}/assignmentSettings
Content-Type: application/json

{
  "submissionAnimationDisabled": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var educationAssignmentSettings = new EducationAssignmentSettings
{
	SubmissionAnimationDisabled = true
};

await graphClient.Education.Classes["{educationClass-id}"].AssignmentSettings
	.Request()
	.UpdateAsync(educationAssignmentSettings);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.educationAssignmentSettings"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "submissionAnimationDisabled": true
}
```

