Public Class Theoretical_DBS

    Private Sub Programming_theorical_BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Programming_theorical_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

    End Sub


    Private Sub Programming_theorical_BindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Programming_theorical_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Programming_theorical_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

    End Sub

    Private Sub Programming_stuff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'College_stuffDataSet._Programming_theorical_' table. You can move, or remove it, as needed.
        Me.Programming_theorical_TableAdapter.Fill(Me.College_stuffDataSet._Programming_theorical_)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        progb2.Visible = True
        progb1.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Question2RichTextBox.Visible = True
            Solution2RichTextBox.Visible = True
            Label4.Visible = True


        End If
        If Not CheckBox1.Checked Then
            Question2RichTextBox.Visible = False
            Solution2RichTextBox.Visible = False
            Label4.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Question3RichTextBox.Visible = True
            Solution3RichTextBox.Visible = True
            Label2.Visible = True

        End If
        If Not CheckBox2.Checked Then
            Question3RichTextBox.Visible = False
            Solution3RichTextBox.Visible = False
            Label2.Visible = False
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        DBS.Show()
        Me.Hide()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.Programming_theorical_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        CheckBox3.Checked = False
        PicturePictureBox.Visible = False
        Panel1.Visible = False
    End Sub

    Private Sub Programming_stuff_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If MsgBox("Do you want to save the made changes???", vbYesNo) = MsgBoxResult.Yes Then
                Me.Validate()
                Me.Programming_theorical_BindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

                Form1.Close()
                The_beginning.Close()
                DBS.Close()
            Else
                Form1.Close()
                The_beginning.Close()
                DBS.Close()

            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.Programming_theorical_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        If MsgBox("Do you have picture ??", vbYesNo) = MsgBoxResult.Yes Then
            PicturePictureBox.Visible = True
            Panel1.Visible = True
            CheckBox3.Checked = True
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

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            PicturePictureBox.Visible = True
            Panel1.Visible = True
        End If
        If Not CheckBox3.Checked Then
            PicturePictureBox.Visible = False
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PicturePictureBox.Width = PicturePictureBox.Width / 2
        PicturePictureBox.Height = PicturePictureBox.Height / 2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        progb2.Visible = False
        progb1.Visible = True


    End Sub

    Private Sub CheckBox3_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        progb2.Visible = True
        progb1.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Programming_theorical_BindingSource.Filter = "title2 like '%" + TextBox1.Text + "%'"
    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Close()
        Form1.Close()
        The_beginning.Close()
        DBS.Close()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Me.Validate()
        Me.Programming_theorical_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
    End Sub

    Private Sub Solution3RichTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Solution3RichTextBox.TextChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Me.Validate()
        Me.Programming_theorical_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        CheckBox3.Checked = False
        PicturePictureBox.Visible = False
        Panel1.Visible = False
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Title2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        ExplanationRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Comments2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Question1RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Question2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Question3RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution1RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution3RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution4RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.Yes
        Tips2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Solution4RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Title2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        ExplanationRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Comments2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Question1RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Question2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Question3RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution1RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution3RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution4RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.No
        Tips2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Solution4RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
    End Sub
End Class