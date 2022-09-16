Public Class Folders

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupBox1.Visible = True
        GroupBox1.BringToFront()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupBox2.Visible = True
        GroupBox2.BringToFront()


    End Sub

    Private Sub Folders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Object oriented programming(OOP)\The main book\E-books\CSharp.2010.for.Programmers.4nd.Edition.pdf"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click


        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Computer architecture\The main book\E-books\Computer Organization And Aritecture-8th ed.pdf"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click


        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Free course\The main book\E-books"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Data structure\The main book\E-books"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        
            'Create a reference to the path you want to open
            Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Visual programming\The main book\E-books\Visual Basic text book.pdf"

            'And open the folder using the Explorer.exe Process
            Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click


        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Operating system\The main book\E-books\operating_system_concepts-textbox.pdf"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click


        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Object oriented programming(OOP)"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        
            'Create a reference to the path you want to open
            Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Operating system"

            'And open the folder using the Explorer.exe Process
            Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click



        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Computer architecture"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click



        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Free course"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        
            'Create a reference to the path you want to open
            Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Data structure"

            'And open the folder using the Explorer.exe Process
            Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click


        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Visual programming"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click


        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Object oriented programming(OOP)\The main book\Slides"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click


        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Visual programming\The main book\Slides"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click


        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Operating system\The main book\Power point"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click


        'Create a reference to the path you want to open
        Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Computer architecture\The main book\Slides"

        'And open the folder using the Explorer.exe Process
        Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        
            'Create a reference to the path you want to open
            Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Data structure\The main book\Slides"

            'And open the folder using the Explorer.exe Process
            Process.Start("Explorer.exe", Path)

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If MessageBox.Show("Do you want to open a folder?", "Caption", MessageBoxButtons.OKCancel) = DialogResult.OK Then

            'Create a reference to the path you want to open
            Dim Path As String = "C:\Users\Shaker Al-junaid\Desktop\Curricula\Free course\The main book\Slides"

            'And open the folder using the Explorer.exe Process
            Process.Start("Explorer.exe", Path)
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupBox3.Visible = True
        GroupBox3.BringToFront()

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub

    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupBox3.Visible = True
        GroupBox3.BringToFront()
    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class