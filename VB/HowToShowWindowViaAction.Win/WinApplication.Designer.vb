Imports Microsoft.VisualBasic
Imports System
Namespace HowToShowWindowViaAction.Win
	Partial Public Class HowToShowWindowViaActionWindowsFormsApplication
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
        Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
        Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
        Me.module3 = New HowToShowWindowViaAction.[Module].HowToShowWindowViaActionModule()
        Me.module4 = New HowToShowWindowViaAction.[Module].Win.HowToShowWindowViaActionWindowsFormsModule()
        Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
        Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
        Me.module7 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'module5
        '
        Me.module5.AllowValidationDetailsAccess = true
        Me.module5.IgnoreWarningAndInformationRules = false
        '
        'sqlConnection1
        '
        Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=HowToShowWindowViaAction;Integrated Security="& _ 
    "SSPI;Pooling=false"
        Me.sqlConnection1.FireInfoMessageEventOnUserErrors = false
        '
        'HowToShowWindowViaActionWindowsFormsApplication
        '
        Me.ApplicationName = "HowToShowWindowViaAction"
        Me.Connection = Me.sqlConnection1
        Me.Modules.Add(Me.module1)
        Me.Modules.Add(Me.module2)
        Me.Modules.Add(Me.module6)
        Me.Modules.Add(Me.module3)
        Me.Modules.Add(Me.module4)
        Me.Modules.Add(Me.module5)
        Me.Modules.Add(Me.module7)
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub

		#End Region

		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
		Private module3 As HowToShowWindowViaAction.Module.HowToShowWindowViaActionModule
		Private module4 As HowToShowWindowViaAction.Module.Win.HowToShowWindowViaActionWindowsFormsModule
		Private module5 As DevExpress.ExpressApp.Validation.ValidationModule
		Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
		Private module7 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
		Private sqlConnection1 As System.Data.SqlClient.SqlConnection
	End Class
End Namespace
