Imports System
Imports System.Windows
Public Class Curricula

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim path As String
        path = Application.StartupPath & "\.."
        System.Diagnostics.Process.Start(path & "Logic design/[001099].jpg")

    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Close()
        College.Close()
        The_beginning.Close()

    End Sub
End Class