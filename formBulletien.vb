Imports System.Data.OleDb
Imports System.Globalization
Public Class formBulletien
    'Saisi Bulletien
    Dim qry As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Public Sub SearchEmploye()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("SELECT Nom_Prenom FROM Employe", cnx)
        da.Fill(dt)
        Dim r As DataRow
        Znpr.AutoCompleteCustomSource.Clear()
        For Each r In dt.Rows
            Znpr.AutoCompleteCustomSource.Add(r.Item(0).ToString)
        Next
        Znpr.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Znpr.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub

    Private Sub TabControl1_Enter(sender As Object, e As EventArgs) Handles TabControl1.Enter
        cnx.Close()
        cnx.Open()
        Call SearchEmploye()

        'Load months list
        Dim i As Integer = 1
        Dim months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames
        For Each month As String In months
            If Not String.IsNullOrEmpty(month) Then
                Lmonth.Items.Add(month)
                i += 1
            End If
        Next
        Lmonth.SelectedText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Date.Today.Month)
        'Load +10 years list
        Zyear.SelectedText = Date.Now.Year
    End Sub

    Private Sub Znpr_TextChanged(sender As Object, e As EventArgs) Handles Znpr.TextChanged
        qry = "SELECT Mat, Nom_Prenom, Fonction, DEM, Enfants FROM Employe WHERE Nom_Prenom = @npr "
        cmd = New OleDbCommand(qry, cnx)
        cmd.Parameters.Add("@npr", OleDbType.VarWChar).Value = Znpr.Text
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.Read Then
            Zmat.Text = dr("Mat")
            Zfn.Text = dr("Fonction")
            Znen.Text = dr("Enfants")
            Zseniority.Text = Date.Now.Year - Convert.ToDateTime(dr("DEM")).ToString("yyyy")
        End If
        Zmat.Enabled = False
    End Sub

    Private Sub Zfn_TextChanged(sender As Object, e As EventArgs) Handles Zfn.TextChanged
        Console.WriteLine("BIO")
    End Sub

    Private Sub Zth_TextChanged(sender As Object, e As EventArgs) Handles Zth.TextChanged

    End Sub
End Class