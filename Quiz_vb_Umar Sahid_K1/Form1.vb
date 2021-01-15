Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listStudio()
    End Sub

    Private Sub listStudio()
        selectStudio.Items.Add("Studio 1")
        selectStudio.Items.Add("Studio 2")
        selectStudio.Items.Add("Studio 3")
        selectStudio.Items.Add("Studio 4")
    End Sub

    Private Sub judulFilm()
        If (selectStudio.Text = "Studio 1") Then
            selectFilm.Text = "RUMAH KENTANG THE BEGINING"
            jamTayang.Text = "13:15 WIB"
            htmFilm.Text = 15000
        ElseIf (selectStudio.Text = "Studio 2") Then
            selectFilm.Text = "The Cave"
            jamTayang.Text = "17:45 WIB"
            htmFilm.Text = 25000
        ElseIf (selectStudio.Text = "Studio 3") Then
            selectFilm.Text = "Brahms: The Boy II"
            jamTayang.Text = "20:30 WIB"
            htmFilm.Text = 30000
        ElseIf (selectStudio.Text = "Studio 4") Then
            selectFilm.Text = "Rambo: Last Blood"
            jamTayang.Text = "12:00"
            htmFilm.Text = 35000
        End If

    End Sub

    Private Sub totalBiaya()
        Dim hargaTiket As Single
        Dim hargaPopCorn As Single
        Dim hargaSoftDrink As Single
        If (popCorn.Checked = True) Then
            hargaPopCorn = 10000 * jumlahPopCorn.Text
        End If
        If (softDrink.Checked = True) Then
            hargaSoftDrink = 7000 * jumlahSoftDrink.Text
        End If
        hargaTiket = CDec(jumlahTiket.Text) * CDec(htmFilm.Text)
        jumlahBiaya.Text = (hargaTiket + (hargaPopCorn) + (hargaSoftDrink)).ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        judulFilm()
        totalBiaya()
    End Sub

    Private Sub selectStudio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectStudio.SelectedIndexChanged
        judulFilm()
    End Sub
End Class
