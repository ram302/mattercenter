// <copyright file="GlobalSuppressions.cs" company="Microsoft">
//     Copyright (c) . All rights reserved.
// </copyright>
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Legal.MatterCenter.Common.ErrorMessage.ShowMessage(System.String,Microsoft.Legal.MatterCenter.Common.ErrorMessage+MessageType)", Scope = "member", Target = "Microsoft.Legal.MatterCenter.UpdateView.UpdateView.#Main(System.String[])", Justification = "Value is Hard coded in the code.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Legal.MatterCenter.Common.ErrorMessage.ShowMessage(System.String,Microsoft.Legal.MatterCenter.Common.ErrorMessage+MessageType)", Scope = "member", Target = "Microsoft.Legal.MatterCenter.UpdateView.UpdateView.#UpdateFields(System.String, Microsoft.Legal.MatterCenter.Common.Client, Microsoft.SharePoint.Client.ClientContext, Microsoft.SharePoint.Client.List, Microsoft.SharePoint.Client.View)", Justification ="Value is hardcoded")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Legal.MatterCenter.UpdateView.UpdateView.#UpdateFields(System.String,Microsoft.Legal.MatterCenter.Common.Client, Microsoft.SharePoint.Client.ClientContext, Microsoft.SharePoint.Client.List, Microsoft.SharePoint.Client.View)", Justification ="Error message is shown on console")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Legal.MatterCenter.Common.ErrorMessage.ShowMessage(System.String,Microsoft.Legal.MatterCenter.Common.ErrorMessage+MessageType)", Scope = "member", Target = "Microsoft.Legal.MatterCenter.UpdateView.UpdateView.#UpdateFields(System.String,Microsoft.Legal.MatterCenter.Common.Client,Microsoft.SharePoint.Client.ClientContext,Microsoft.SharePoint.Client.List,Microsoft.SharePoint.Client.View)", Justification = "Value is Hard coded in the code.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Legal.MatterCenter.UpdateView.UpdateView.#UpdateFields(System.String,Microsoft.Legal.MatterCenter.Common.Client,Microsoft.SharePoint.Client.ClientContext,Microsoft.SharePoint.Client.List,Microsoft.SharePoint.Client.View)", Justification = "Error message is shown on console")]