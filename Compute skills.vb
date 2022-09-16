Public Class Communication_skills

    Private Sub Communication_skillsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Communication_skillsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Communication_skillsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)

    End Sub

    Private Sub Compute_skills_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'College_stuffDataSet.Computer_ethics' table. You can move, or remove it, as needed.
        Me.Computer_ethicsTableAdapter.Fill(Me.College_stuffDataSet.Computer_ethics)
        'TODO: This line of code loads data into the 'College_stuffDataSet.Communication_skills' table. You can move, or remove it, as needed.
        Me.Communication_skillsTableAdapter.Fill(Me.College_stuffDataSet.Communication_skills)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Communication_skillsBindingSource.EndEdit()
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

    Private Sub CheckBox1_CheckedChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PicturePictureBox.Visible = True
            Panel1.Visible = True
        End If
        If Not CheckBox1.Checked Then
            PicturePictureBox.Visible = False
            Panel1.Visible = False


        End If
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PicturePictureBox.Width = PicturePictureBox.Width * 2
        PicturePictureBox.Height = PicturePictureBox.Height * 2
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PicturePictureBox.Width = PicturePictureBox.Width / 2
        PicturePictureBox.Height = PicturePictureBox.Height / 2
    End Sub

    Private Sub Compute_skills_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If MsgBox("Do you want to save the made changes???", vbYesNo) = MsgBoxResult.Yes Then
                Me.Validate()
                Me.Communication_skillsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
                Form1.Close()
                The_beginning.Close()
            Else
                Form1.Close()
                The_beginning.Close()
            End If
           

        Catch ex As Exception

        End Try


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.Communication_skillsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.College_stuffDataSet)
        Panel1.Visible = False
        PicturePictureBox.Visible = False
        CheckBox1.Checked = False

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Communication_skillsBindingSource.Filter = "title like '%" + TextBox1.Text + "%'"

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class