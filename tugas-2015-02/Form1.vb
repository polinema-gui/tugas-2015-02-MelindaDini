Public Class Form1

    Dim nilai1, nilai2 As Long
    Dim hasil As Integer
    Dim operasi, txtnilai1, txtnilai2, txtnilai3 As String
   
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "0"
            ButtonHasil.Text = txtnilai1
        Else
            txtnilai2 = txtnilai2 + "0"
            ButtonHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "1"
            ButtonHasil.Text = txtnilai1
        Else
            txtnilai2 = txtnilai2 + "1"
            ButtonHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "2"
            ButtonHasil.Text = txtnilai1
        Else
            txtnilai2 = txtnilai2 + "2"
            ButtonHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "3"
            ButtonHasil.Text = txtnilai1
        Else
            txtnilai2 = txtnilai2 + "3"
            ButtonHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "4"
            ButtonHasil.Text = txtnilai1
        Else
            txtnilai2 = txtnilai2 + "4"
            ButtonHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "5"
            ButtonHasil.Text = txtnilai1
        Else
            txtnilai2 = txtnilai2 + "5"
            ButtonHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "6"
            ButtonHasil.Text = txtnilai1
        Else
            txtnilai2 = txtnilai2 + "6"
            ButtonHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "7"
            ButtonHasil.Text = txtnilai1
        Else
            txtnilai2 = txtnilai2 + "7"
            ButtonHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "8"
            ButtonHasil.Text = txtnilai1
        Else
            txtnilai2 = txtnilai2 + "8"
            ButtonHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "9"
            ButtonHasil.Text = txtnilai1
        Else
            txtnilai2 = txtnilai2 + "9"
            ButtonHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        operasi = ""
        txtnilai1 = ""
        txtnilai2 = ""
        ButtonHasil.Clear()
    End Sub

    Private Sub kurang_Click(sender As Object, e As EventArgs) Handles kurang.Click
        operasi = "-"
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        operasi = "+"
    End Sub

    Private Sub SamaDengan_Click(sender As Object, e As EventArgs) Handles SamaDengan.Click
        nilai1 = Val(txtnilai1)
        nilai2 = Val(txtnilai2)
        If operasi = "+" Then
            hasil = nilai1 + nilai2
            ButtonHasil.Text = hasil
        ElseIf operasi = "-" Then
            hasil = nilai1 - nilai2
            ButtonHasil.Text = hasil
        End If

        operasi = ""
        txtnilai1 = ""
        txtnilai2 = ""
        txtnilai1 = Str(hasil)
    End Sub
End Class


