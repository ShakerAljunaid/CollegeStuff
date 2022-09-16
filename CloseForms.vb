Imports System.Windows.Forms
Public Class CloseForms
    Dim form1 As Form1
    Dim cs As GIS

    Dim mal As Theoretical_GA
    Dim mf As GA

    Dim prp As Practical_DBS
    Dim ps As Theoretical_DBS
    Dim pr As DBS
    Dim prs As OOP_assignment

    Public Sub closeAllforms()
        form1.Close()
        cs.Close()

        mal.Close()
        mf.Close()
        prp.Close()
        ps.Close()
        pr.Close()
        prs.Close()

    End Sub



End Class
