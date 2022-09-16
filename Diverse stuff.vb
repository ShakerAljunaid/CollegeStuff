Public Class Diverse_stuff

    Private Sub Diverse_stuffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Diverse_stuffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Diverse_stuffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

    End Sub

    Private Sub Diverse_stuff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'College_stuffDataSet.Diverse_stuff' table. You can move, or remove it, as needed.
        Me.Diverse_stuffTableAdapter.Fill(Me.College_stuffDataSet.Diverse_stuff)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.Diverse_stuffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        Try
            If MsgBox("Do you have picture ??", vbYesNo) = MsgBoxResult.Yes Then
                PicturePictureBox.Visible = True
                Panel1.Visible = True

                CheckBox1.Checked = True

                PicturePictureBox.BringToFront()
                OpenFileDialog1.Filter = "Images|*.GIF;*.TIF;*.JPG"
                OpenFileDialog1.ShowDialog()
                If OpenFileDialog1.FileName = "" Then Exit Sub
                PicturePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
                PicturePictureBox.Width = PicturePictureBox.Height * PicturePictureBox.Image.Width / PicturePictureBox.Image.Height

            End If
        Catch

            MsgBox("<<<Your stuff were saved>>>")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PicturePictureBox.Visible = True
            Panel1.Visible = True
        End If
        If Not CheckBox1.Checked Then
            PicturePictureBox.Visible = False
            Panel1.Visible = False


        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PicturePictureBox.Width = PicturePictureBox.Width * 2
        PicturePictureBox.Height = PicturePictureBox.Height * 2
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PicturePictureBox.Width = PicturePictureBox.Width / 2
        PicturePictureBox.Height = PicturePictureBox.Height / 2
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        PicturePictureBox.Visible = False
        Panel1.Visible = False
        CheckBox1.Checked = False
        Me.Validate()
        Me.Diverse_stuffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Diverse_stuffBindingSource.Filter = " title2 like '%" + TextBox1.Text + "%'"


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        The_beginning.Show()
        Me.Hide()

    End Sub

    Private Sub Diverse_stuff_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If MsgBox("Do you want to save the made changes???", vbYesNo) = MsgBoxResult.Yes Then
                Me.Validate()
                Me.Diverse_stuffBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
                The_beginning.Close()
            Else

                The_beginning.Close()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem1.Click
        Me.Close()
        The_beginning.Close()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Me.Validate()
        Me.Diverse_stuffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        PicturePictureBox.Visible = False
        Panel1.Visible = False
        CheckBox1.Checked = False
        Me.Validate()
        Me.Diverse_stuffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Title2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        InformationRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        NewRichTextBox1.RightToLeft = Windows.Forms.RightToLeft.Yes
        NewRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        New2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        The_subjectTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.Yes
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Title2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No

        InformationRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        NewRichTextBox1.RightToLeft = Windows.Forms.RightToLeft.No
        NewRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        New2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        The_subjectTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.No
    End Sub
End Class