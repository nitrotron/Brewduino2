<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RimsPanel.aspx.cs" Inherits="Brewduino2.RimsPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="helloWorld">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />

</head>
<body ng-controller="helloWorldCtrl">
    <form runat="server">
        <asp:ScriptManager runat="server" EnablePageMethods="true">
        </asp:ScriptManager>
    </form>
    <h1>Hello {{messageX}}!</h1>
    <input type="text" ng-model="messageX" placeholder="Enter your name">
    <p>
        {{prntArray}} {{currentRow}}
        <input type="text" ng-model="currentRow">
    </p>
    <div ng-click="changeArray()" class="btn btn-primary">submit</div>
    <div ng-click="fromServerArray()" class="btn btn-primary">Get From Server</div>
    <div ng-click="jumpToIt(1)"  class="btn btn-primary">Jump To It!</div>
    <div ng-click="jumpToItAgain()" class="btn btn-primary">Jump to just one</div>
    <div  ng-click="getStatus()" class="btn btn-primary">Get Status</div>
    <br />{{arduino}}

    <script src="Scripts/jquery-2.1.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/angular.js"></script>
    <script src="Scripts/hello-world.js"></script>

</body>
</html>
