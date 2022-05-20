﻿Imports System.Data.OleDb
Imports System.IO
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
    Dim bs As New BindingSource()
    Private Sub TabCunsulter_Paint(sender As Object, e As EventArgs) Handles TabAjoute.Paint
        Dim dataAdapter As New OleDbDataAdapter("SELECT * from Employe", cnx)
        Dim ds As New DataSet()
        Dim dsView As New DataView
        dataAdapter.Fill(ds, "Employe")
        cnx.Close()
        dsView = ds.Tables(0).DefaultView
        bs.DataSource = dsView
        Me.DataGridView1.DataSource = bs

        LrowsCount.Text = DataGridView1.Rows.Count - 1
    End Sub

    Private Sub Zsearch_TextChanged(sender As Object, e As EventArgs) Handles Zsearch.TextChanged

        bs.Filter = " Mat LIKE '" & Zsearch.Text & "' or Nom_Prenom LIKE '" & Zsearch.Text & "*' or Fonction LIKE '" & Zsearch.Text & "*' or Adresse LIKE '" & Zsearch.Text & "*' or Ville LIKE '" & Zsearch.Text & "*'  or Email LIKE '" & Zsearch.Text & "*'  or Telephone LIKE '" & Zsearch.Text & "*' "
        'Me.DataGridView1.DataSource = bs
        LrowsCount.Text = DataGridView1.Rows.Count - 1
    End Sub

    Private Sub BtableNext_Click(sender As Object, e As EventArgs) Handles BtableNext.Click
        bs.MoveNext()
    End Sub

    Private Sub BtableLast_Click(sender As Object, e As EventArgs) Handles BtableLast.Click
        bs.MoveLast()
    End Sub

    Private Sub BtablePrev_Click(sender As Object, e As EventArgs) Handles BtablePrev.Click
        bs.MovePrevious()
    End Sub

    Private Sub BtableFirst_Click(sender As Object, e As EventArgs) Handles BtableFirst.Click
        bs.MoveFirst()
    End Sub

    'Show employe details
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            selectedrow = DataGridView1.Rows(e.RowIndex)
            formEmployeDetails.ShowDialog()
        End If
    End Sub
    Public Shared Property selectedrow As DataGridViewRow

End Class