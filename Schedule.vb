Public Class Schedule

    Private Sub Weekly_scheduleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Weekly_scheduleBindingNavigatorSaveItem.Click
      
        If MsgBox("Are you sure that you want to change??? ", vbYesNo) = MsgBoxResult.Yes Then
            Me.Validate()
            Me.Weekly_scheduleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        End If


    End Sub

    Private Sub Schedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'College_stuffDataSet.Weekly_schedule' table. You can move, or remove it, as needed.
        Me.Weekly_scheduleTableAdapter.Fill(Me.College_stuffDataSet.Weekly_schedule)

    End Sub


    Private Sub CLOSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Close()
        The_beginning.Close()
        College.Close()


    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If MsgBox("Are you sure that you want to change??? ", vbYesNo) = MsgBoxResult.Yes Then
            Me.Validate()
            Me.Weekly_scheduleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        End If
    End Sub
End Class