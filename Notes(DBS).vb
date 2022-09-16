Public Class Notes_DBS

    Private Sub Programming_NotesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Programming_NotesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Programming_NotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

    End Sub

    Private Sub ProImportant_notes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'College_stuffDataSet.Programming_Notes' table. You can move, or remove it, as needed.
        Me.Programming_NotesTableAdapter.Fill(Me.College_stuffDataSet.Programming_Notes)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.Programming_NotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        If MsgBox("Do you have picture ??", vbYesNo) = MsgBoxResult.Yes Then
            PhotoPictureBox.Visible = True
            Button6.Visible = True
            Button5.Visible = True
            CheckBox3.Checked = True
            PhotoPictureBox.BringToFront()
            OpenFileDialog1.Filter = "Images|*.GIF;*.TIF;*.JPG"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName = "" Then Exit Sub
            PhotoPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            PhotoPictureBox.Width = PhotoPictureBox.Height * PhotoPictureBox.Image.Width / PhotoPictureBox.Image.Height
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.Programming_NotesBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        PhotoPictureBox.Visible = False
        Button6.Visible = False
        Button5.Visible = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PhotoPictureBox.Width = PhotoPictureBox.Width * 2
        PhotoPictureBox.Height = PhotoPictureBox.Height * 2
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PhotoPictureBox.Width = PhotoPictureBox.Width / 2
        PhotoPictureBox.Height = PhotoPictureBox.Height / 2
    End Sub

    Private Sub ProImportant_notes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If MsgBox("Do you want to save the made changes???", vbYesNo) = MsgBoxResult.Yes Then
                Me.Validate()
                Me.Programming_NotesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

                Form1.Close()
                The_beginning.Close()
                DBS.Close()
            Else
                Form1.Close()
                The_beginning.Close()
                DBS.Close()

            End If
        Catch
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        DBS.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Programming_NotesBindingSource.Filter = "title like '%" + TextBox1.Text + "%'"

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            PhotoPictureBox.Visible = True
            Button6.Visible = True
            Button5.Visible = True
        End If
        If Not CheckBox3.Checked Then
            PhotoPictureBox.Visible = False
            Button6.Visible = False
            Button5.Visible = False
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Me.Validate()
        Me.Programming_NotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Me.Validate()
        Me.Programming_NotesBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        PhotoPictureBox.Visible = False
        Button6.Visible = False
        Button5.Visible = False
        CheckBox3.Checked = False
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        TitleRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        NoteRichTextBox1.RightToLeft = Windows.Forms.RightToLeft.Yes
        CommentRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        TipRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        HintRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.Yes
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        TitleRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        NoteRichTextBox1.RightToLeft = Windows.Forms.RightToLeft.No
        CommentRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        TipRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        HintRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.No
    End Sub
End Class