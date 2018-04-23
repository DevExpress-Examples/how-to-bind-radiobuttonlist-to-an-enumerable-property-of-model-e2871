﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.Web.Mvc
Imports System.ComponentModel
Imports System.Web.Mvc

Public Class MyEditorsBinder
	Inherits DevExpressEditorsBinder
	Protected Overrides Function GetPropertyValue(ByVal controllerContext As ControllerContext, ByVal bindingContext As ModelBindingContext, ByVal propertyDescriptor As PropertyDescriptor, ByVal propertyBinder As IModelBinder) As Object
		If propertyDescriptor.PropertyType Is GetType(CommonMeals) Then
			Dim tc As TypeConverter = propertyDescriptor.Converter
			Return tc.ConvertFrom(EditorExtension.GetValue(Of String)(propertyDescriptor.Name))
		End If

		Return MyBase.GetPropertyValue(controllerContext, bindingContext, propertyDescriptor, propertyBinder)
	End Function
End Class

