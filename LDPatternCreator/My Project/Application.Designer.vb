﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    'HINWEIS: Diese Datei wird automatisch generiert und darf nicht direkt bearbeitet werden. Wenn Sie Änderungen vornehmen möchten,
    ' oder bei in dieser Datei auftretenden Buildfehlern wechseln Sie zum Projekt-Designer.
    ' (Wechseln Sie dazu zu den Projekteigenschaften, oder doppelklicken Sie auf den Knoten "Mein Projekt" im
    ' Projektmappen-Explorer). Nehmen Sie auf der Registerkarte "Anwendung" entsprechende Änderungen vor.
    '
    Partial Friend Class MyApplication
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = false
            Me.EnableVisualStyles = true
            Me.SaveMySettingsOnExit = true
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.LDPatternCreator.MainForm
        End Sub
    End Class
End Namespace
