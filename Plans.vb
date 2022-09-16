Public Class Plans

    Private Sub PlansBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlansBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlansBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

    End Sub

    Private Sub Plans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'College_stuffDataSet.Plans' table. You can move, or remove it, as needed.
        Me.PlansTableAdapter.Fill(Me.College_stuffDataSet.Plans)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.PlansBindingSource.EndEdit()
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

    Private Sub IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        The_beginning.Close()
        College.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        PlansBindingSource.Filter = "title2 like '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Hide()

        The_beginning.Show()
    End Sub

    Private Sub Plans_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If MsgBox("Do you want to save the made changes???", vbYesNo) = MsgBoxResult.Yes Then
                Me.Validate()
                Me.PlansBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

                The_beginning.Close()
            Else

                The_beginning.Close()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Me.Validate()
        Me.PlansBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Me.Validate()
        Me.PlansBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        CheckBox1.Checked = False
        PicturePictureBox.Visible = False
        Panel1.Visible = False
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.PlansBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        CheckBox1.Checked = False
        PicturePictureBox.Visible = False
        Panel1.Visible = False
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        PlanRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        The_notes_about_the_plansRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        ResultRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Title2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        I_was_supposed_to_do2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        I_did2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        I_will_do2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        Comment2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        BenfitsRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        EffectsRichTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        The_expected_periodTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.Yes


    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        PlanRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        The_notes_about_the_plansRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        ResultRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Title2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        I_was_supposed_to_do2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        I_did2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        I_will_do2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        Comment2RichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        BenfitsRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        EffectsRichTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        The_expected_periodTextBox.RightToLeft = Windows.Forms.RightToLeft.No
        TextBox1.RightToLeft = Windows.Forms.RightToLeft.No
    End Sub
End Class