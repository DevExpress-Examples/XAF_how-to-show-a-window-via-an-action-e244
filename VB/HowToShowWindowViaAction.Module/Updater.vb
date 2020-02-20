Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.BaseImpl

Namespace HowToShowWindowViaAction.Module
    Public Class Updater
        Inherits ModuleUpdater
        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            Dim bo2 As BusinessClass2  = ObjectSpace.CreateObject(Of BusinessClass2)()
            bo2.Name = "test name"
            ObjectSpace.CommitChanges()
            MyBase.UpdateDatabaseAfterUpdateSchema()
        End Sub
    End Class
End Namespace
