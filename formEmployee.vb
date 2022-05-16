Imports System.Data.OleDb
Public Class formEmployee

    Private Sub TabAjoute_Enter(sender As Object, e As EventArgs) Handles TabAjoute.Enter
        Try
            cnx.Close()
            cnx.Open()
            LcnxState.Text = "Connected"
            LcnxState.ForeColor = Color.Lime
        Catch ex As Exception
            LcnxState.Text = "Not Connected"
            LcnxState.ForeColor = Color.Red
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.None)
        End Try
        cnx.Close()

        cnx.Open()
        cmd = New OleDb.OleDbCommand("SELECT * from Employe", cnx)
        cmd.Connection = cnx
        Dim maxId As Object
        Dim strId As String
        Dim initId As Integer

        'cmd.CommandText = "SELECT Max(Mat) as MaxId from Employe"
        cmd.CommandText = "select Mat from Employe order by CDate(dateRec) desc"

        maxId = cmd.ExecuteScalar
        If maxId Is DBNull.Value Then
            initId = 1
        Else
            strId = CType(maxId.Remove(0, 1), String)
            initId = CType(strId, String)
            initId = initId + 1
            Zmat.Enabled = False
        End If
        Zmat.Text = "E" & initId.ToString()
        Znpr.Focus()
        cnx.Close()
    End Sub

    Private Sub Bajoute_Click(sender As Object, e As EventArgs) Handles Bajoute.Click
        cnx.Open()

        Dim commad As String

        commad = "INSERT INTO Employe (`Mat`, `Nom_Prenom`, `Fonction`, `Adresse`, `Ville`, `Email`, `Telephone`, `DEM`, `Enfants`)
                    values (@Mat, @Nom_Prenom, @Fonction, @Adresse, @Ville, @Email, @Telephone, @DEM, @Enfants)"
        Dim cmd As OleDbCommand = New OleDbCommand(commad, cnx)
        cmd.Parameters.Add("@Mat", OleDbType.VarChar).Value = Zmat.Text
        cmd.Parameters.Add("@Nom_Prenom", OleDbType.VarWChar).Value = Znpr.Text
        cmd.Parameters.Add("@Fonction", OleDbType.VarChar).Value = Zfn.Text
        cmd.Parameters.Add("@Adresse", OleDbType.VarChar).Value = Zadrs.Text
        cmd.Parameters.Add("@Ville", OleDbType.VarChar).Value = Zvil.Text
        cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = Zemail.Text
        cmd.Parameters.Add("@Telephone", OleDbType.VarChar).Value = Ztel.Text
        cmd.Parameters.Add("@DEM", OleDbType.VarChar).Value = Zdem.Text
        cmd.Parameters.Add("@Enfants", OleDbType.VarChar).Value = Znen.Text
        MsgBox("Record saved")

        Dim nbrId As Integer
        nbrId = Convert.ToInt32((Zmat.Text).Remove(0, 1)) + 1

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cnx.Close()
            Zmat.Clear()
            Znpr.Clear()
            Zfn.Clear()
            Zadrs.Clear()
            Zvil.Clear()
            Zemail.Clear()
            Ztel.Clear()
            Zdem.Clear()
            Znen.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Zmat.Text = "E" & nbrId.ToString()
    End Sub


    'Consulter Tab
    Private Sub Brechercher_Click(sender As Object, e As EventArgs) Handles Brechercher.Click
        cnx.Open()

        If Zmat_sr.Text = "" Then
            cmd = New OleDb.OleDbCommand("SELECT * FROM Employe WHERE Nom_Prenom = '" & Znpr_sr.Text.Replace("'", "''") & "'", cnx)

        Else
            cmd = New OleDb.OleDbCommand("SELECT * FROM Employe WHERE Mat = '" & Zmat_sr.Text & "'", cnx)
        End If

        Dim r As OleDbDataReader

        r = cmd.ExecuteReader

        r.Read()
        If Not r.HasRows Then
            MsgBox("No Employee trouve")
        Else
            Zmat_sr.Text = r("Mat")
            Znpr_sr.Text = r("Nom_Prenom")
            Zfn_sr.Text = r("Fonction")
            Zadrs_rs.Text = r("Adresse")
            Zvil_sr.Text = r("Ville")
            Ztel_sr.Text = r("Telephone")
            Zdem_sr.Text = r("DEM")
            Znen_sr.Text = r("Enfants")
        End If
        cnx.Close()
    End Sub

    Private Sub Bannuler_sr_Click(sender As Object, e As EventArgs) Handles Bannuler_sr.Click
        Zmat_sr.Clear()
        Znpr_sr.Clear()
        Zfn_sr.Clear()
        Zadrs_rs.Clear()
        Zvil_sr.Clear()
        Ztel_sr.Clear()
        Zdem_sr.Clear()
        Znen_sr.Clear()
    End Sub
End Class