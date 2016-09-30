Public Class Form1

    Private Sub btnFlip_Click(sender As Object, e As EventArgs) Handles btnFlip.Click
        Dim intSideUp As Integer   ' To indicate which side is up
        Dim rand As New Random     ' Random number generator

        ' Get a random number in the range of 0 through 1
        ' 0 means Putin up, and 1 means America up
        intSideUp = rand.Next(2)

        ' Display the side that is up.
        If intSideUp = 0 Then
            ' 0 means Putin is up, so display Putin image and hide the America image.
            btnPutin.Visible = True
            btnAmerica.Visible = False
        Else
            ' 1 means America is up, so display America image and hide Putin image.
            btnPutin.Visible = False
            btnAmerica.Visible = True
        End If
    End Sub
End Class
