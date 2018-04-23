Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.SystemModule
Public Class MyController
	Inherits DevExpress.ExpressApp.ViewController

	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()
		RegisterActions(components) 

	End Sub

   Private Sub PopupWindowShowAction1_CustomizePopupWindowParams(ByVal sender As System.Object, ByVal e As DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventArgs) Handles PopupWindowShowAction1.CustomizePopupWindowParams
      Dim objectSpace As ObjectSpace = Application.CreateObjectSpace()
      Dim collectionSource As CollectionSourceBase = New CollectionSource(objectSpace, GetType(BusinessClass2))
      e.View = Application.CreateListView(Application.FindListViewId(GetType(BusinessClass2)), collectionSource, True)
   End Sub

   Private Sub SimpleAction1_Execute(ByVal sender As System.Object, ByVal e As DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs) Handles SimpleAction1.Execute
      Dim objectSpace As ObjectSpace = Application.CreateObjectSpace()
      Dim listViewId As String = Application.FindListViewId(GetType(BusinessClass2))
      e.ShowViewParameters.CreatedView = Application.CreateListView(listViewId, Application.CreateCollectionSource(objectSpace, GetType(BusinessClass2), listViewId), True)
      e.ShowViewParameters.TargetWindow = TargetWindow.NewWindow
      e.ShowViewParameters.Controllers.Add(Application.CreateController(Of DialogController)())
   End Sub

   Private Sub SimpleAction2_Execute(ByVal sender As System.Object, ByVal e As DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs) Handles SimpleAction2.Execute
      Dim objectSpace As ObjectSpace = Application.CreateObjectSpace()
      Dim obj As BusinessClass2 = objectSpace.CreateObject(Of BusinessClass2)()
      obj.Name = "an existing domain object"
      objectSpace.CommitChanges()

      e.ShowViewParameters.CreatedView = Application.CreateDetailView(objectSpace, obj)
      e.ShowViewParameters.TargetWindow = TargetWindow.NewModalWindow
      e.ShowViewParameters.Context = TemplateContext.PopupWindow
      e.ShowViewParameters.CreateAllControllers = True
      Dim defaultDialogController As DialogController = New DialogController()
      e.ShowViewParameters.Controllers.Add(defaultDialogController)
   End Sub

   Private Sub PopupWindowShowAction2_CustomizePopupWindowParams(ByVal sender As System.Object, ByVal e As DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventArgs) Handles PopupWindowShowAction2.CustomizePopupWindowParams
      Dim objectSpace As ObjectSpace = Application.CreateObjectSpace()
      Dim obj As BusinessClass2 = objectSpace.CreateObject(Of BusinessClass2)()
      obj.Name = "an existing domain object"
      objectSpace.CommitChanges()
      e.View = Application.CreateDetailView(objectSpace, obj)
   End Sub
End Class
