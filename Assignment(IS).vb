Public Class DS_assignment_

    Private Sub Statistics_assignment__FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If MsgBox("Do you want to save the made changes???", vbYesNo) = MsgBoxResult.Yes Then
                Me.Validate()
                Me.Statistic_and_possibilities_Assignment_BindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
                Form1.Close()
                The_beginning.Close()
                Information_security.Close()
            Else
                Form1.Close()
                The_beginning.Close()
                Information_security.Close()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Statistic_and_possibilities_Assignment_BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Statistic_and_possibilities_Assignment_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Statistic_and_possibilities_Assignment_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

    End Sub

    Private Sub Statistics_assignment__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'College_stuffDataSet._statistic_and_possibilities_Assignment_' table. You can move, or remove it, as needed.
        Me.Statistic_and_possibilities_Assignment_TableAdapter.Fill(Me.College_stuffDataSet._statistic_and_possibilities_Assignment_)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Statistic_and_possibilities_Assignment_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
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
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PicturePictureBox.Width = PicturePictureBox.Width * 2
        PicturePictureBox.Height = PicturePictureBox.Height * 2
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PicturePictureBox.Width = PicturePictureBox.Width / 2
        PicturePictureBox.Height = PicturePictureBox.Height / 2
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox2.Visible = True
        GroupBox1.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Information_security.Show()
        Me.Hide()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.Statistic_and_possibilities_Assignment_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        CheckBox1.Checked = False

        PicturePictureBox.Visible = False
        Panel1.Visible = False
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        GroupBox2.Visible = True
        GroupBox1.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Statistic_and_possibilities_Assignment_BindingSource.Filter = "title2 like '%" + TextBox1.Text + "%'"

    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Close()
        Information_security.Close()
        The_beginning.Close()
        Form1.Close()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Me.Validate()
        Me.Statistic_and_possibilities_Assignment_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Me.Validate()
        Me.Statistic_and_possibilities_Assignment_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        CheckBox1.Checked = False

        PicturePictureBox.Visible = False
        Panel1.Visible = False
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Example1RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Example2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Example3RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Example4RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Example5RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution1RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution3RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution4RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution5RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution6RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution7RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        ImportantdefinitionRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        ExplantionRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Tips2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Comments2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Title2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.Yes
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Example1RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Example2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Example3RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Example4RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Example5RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution1RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution3RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution4RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution5RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution6RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution7RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        ImportantdefinitionRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        ExplantionRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Tips2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Comments2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Title2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.No
    End Sub
End Class