Public Class FrmMyPets
    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        Dim frm As New FrmAddMyPet()
        frm.ShowDialog()
    End Sub
End Class