Partial Class MyController

	<System.Diagnostics.DebuggerNonUserCode()> _
	Public Sub New(ByVal Container As System.ComponentModel.IContainer)
		MyClass.New()

		'Required for Windows.Forms Class Composition Designer support
		Container.Add(Me)

	End Sub

	'Component overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Component Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Component Designer
	'It can be modified using the Component Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Me.SimpleAction1 = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
      Me.SimpleAction2 = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
      Me.PopupWindowShowAction1 = New DevExpress.ExpressApp.Actions.PopupWindowShowAction(Me.components)
      Me.PopupWindowShowAction2 = New DevExpress.ExpressApp.Actions.PopupWindowShowAction(Me.components)
      '
      'SimpleAction1
      '
      Me.SimpleAction1.Caption = "SimpleAction1"
      Me.SimpleAction1.Id = "SimpleAction1"
      '
      'SimpleAction2
      '
      Me.SimpleAction2.Caption = "SimpleAction2"
      Me.SimpleAction2.Id = "SimpleAction2"
      '
      'PopupWindowShowAction1
      '
      Me.PopupWindowShowAction1.AcceptButtonCaption = Nothing
      Me.PopupWindowShowAction1.CancelButtonCaption = Nothing
      Me.PopupWindowShowAction1.Caption = "PopupWindowShowAction1"
      Me.PopupWindowShowAction1.Id = "PopupWindowShowAction1"
      '
      'PopupWindowShowAction2
      '
      Me.PopupWindowShowAction2.AcceptButtonCaption = Nothing
      Me.PopupWindowShowAction2.CancelButtonCaption = Nothing
      Me.PopupWindowShowAction2.Caption = "PopupWindowShowAction2"
      Me.PopupWindowShowAction2.Id = "PopupWindowShowAction2"
      '
      'MyController
      '
      Me.TargetObjectType = GetType(HowToShowWindowViaAction.[Module].BusinessClass1)

   End Sub
   Friend WithEvents SimpleAction1 As DevExpress.ExpressApp.Actions.SimpleAction
   Friend WithEvents SimpleAction2 As DevExpress.ExpressApp.Actions.SimpleAction
   Friend WithEvents PopupWindowShowAction1 As DevExpress.ExpressApp.Actions.PopupWindowShowAction
   Friend WithEvents PopupWindowShowAction2 As DevExpress.ExpressApp.Actions.PopupWindowShowAction

End Class
