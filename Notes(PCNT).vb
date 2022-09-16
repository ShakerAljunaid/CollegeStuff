Public Class Notes_PCNT

    Private Sub Logic_design_NotesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logic_design_NotesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Logic_design_NotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

    End Sub

    Private Sub Logic_notes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'College_stuffDataSet.Logic_design_Notes' table. You can move, or remove it, as needed.
        Me.Logic_design_NotesTableAdapter.Fill(Me.College_stuffDataSet.Logic_design_Notes)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.Logic_design_NotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

        If MsgBox("Do you have picture ??", vbYesNo) = MsgBoxResult.Yes Then
            PhotoPictureBox.Visible = True
            Panel1.Visible = True

            CheckBox1.Checked = True

            PhotoPictureBox.BringToFront()
            OpenFileDialog1.Filter = "Images|*.GIF;*.TIF;*.JPG"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName = "" Then Exit Sub
            PhotoPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            PhotoPictureBox.Width = PhotoPictureBox.Height * PhotoPictureBox.Image.Width / PhotoPictureBox.Image.Height

        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        PhotoPictureBox.Visible = False
        Panel1.Visible = False
        CheckBox1.Checked = False
        Me.Validate()
        Me.Logic_design_NotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PhotoPictureBox.Visible = True
            Panel1.Visible = True
        End If
        If Not CheckBox1.Checked Then
            PhotoPictureBox.Visible = False
            Panel1.Visible = False


        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PhotoPictureBox.Width = PhotoPictureBox.Width * 2
        PhotoPictureBox.Height = PhotoPictureBox.Height * 2
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PhotoPictureBox.Width = PhotoPictureBox.Width / 2
        PhotoPictureBox.Height = PhotoPictureBox.Height / 2
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Me.Validate()
        Me.Logic_design_NotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
    End Sub

    Private Sub Logic_notes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If MsgBox("Do you want to save the made changes???", vbYesNo) = MsgBoxResult.Yes Then
                Me.Validate()
                Me.Logic_design_NotesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
                Form1.Close()
                The_beginning.Close()
                PCNt.Close()
            Else
                Form1.Close()
                The_beginning.Close()
                PCNt.Close()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Logic_design_NotesBindingSource.Filter = "title like '%" + TextBox1.Text + "%'"

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Hide()
        PCNt.Show()

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        PhotoPictureBox.Visible = False
        Panel1.Visible = False
        CheckBox1.Checked = False
        Me.Validate()
        Me.Logic_design_NotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        TitleRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        NoteRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        HintRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        CommentRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        TipRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.Yes
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        TitleRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        NoteRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        HintRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        CommentRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        TipRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.No
    End Sub

End Class