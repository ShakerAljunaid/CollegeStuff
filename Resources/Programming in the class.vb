Public Class Programming_in_the_class

    Private Sub Programming_In_the_classl_BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Programming_In_the_classl_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Programming_In_the_classl_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

    End Sub

    Private Sub Programming_in_the_class_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'College_stuffDataSet._Programming_In_the_classl_' table. You can move, or remove it, as needed.
        Me.Programming_In_the_classl_TableAdapter.Fill(Me.College_stuffDataSet._Programming_In_the_classl_)

    End Sub
End Class