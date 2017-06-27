<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestAutoCompleteExtender.aspx.cs" Inherits="TestAutoCompleteExtender.TestAutoCompleteExtender" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ></asp:ScriptManager>
    <div>
    <label>Test auto complete extender</label>
        <asp:TextBox runat="server" id="txt_testAutoComplete" AutoPostBack="true" OnTextChanged="txt_testAutoComplete_TextChanged" />
        <asp:AutoCompleteExtender  ID="aceForTxtBox" MinimumPrefixLength="0"
                                TargetControlID="txt_testAutoComplete" 
                                ServicePath="~/WebService/TestWebService.asmx" ServiceMethod="GetSampleData"
                                runat="server" CompletionInterval="0" CompletionSetCount="150"  UseContextKey="True">
                            </asp:AutoCompleteExtender>
    </div>
    </form>
</body>
</html>
