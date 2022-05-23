﻿Public Class Form1
    Private currentBtn As Button
    Private leftBorderBtn As Panel
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_menu("Accueil")
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel
        leftBorderBtn.Size = New Size(7, 72)
        SidePanel.Controls.Add(leftBorderBtn)
    End Sub

    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = Color.FromArgb(55, 55, 55)
            currentBtn.ForeColor = Color.White
            'currentBtn.IconColor = Color.White

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y + 100)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(39, 39, 39)
            currentBtn.ForeColor = Color.FromArgb(167, 160, 167)
            'currentBtn.IconColor = Color.White
        End If
    End Sub

    Private Sub addForm(frm As Form)
        PanelContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub change_menu(menu As String)
        Dim Accueil As New formAccueil
        Dim Employee As New formEmploye2
        Dim Bulletien As New formBulletien
        Dim Conge As New formConge
        Dim Stats As New formStats
        Select Case menu
            Case "Accueil"
                addForm(Accueil)
            Case "Employee"
                addForm(Employee)
            Case "Bulletien"
                addForm(Bulletien)
            Case "Conge"
                addForm(Conge)
            Case "Stats"
                addForm(Stats)
        End Select
    End Sub

    Private Sub Bac_Click(sender As Object, e As EventArgs) Handles Bac.Click
        ActiveButton(sender, RgbColors.color3)
        change_menu("Accueil")
    End Sub

    Private Sub Bem_Click(sender As Object, e As EventArgs) Handles Bem.Click
        ActiveButton(sender, RgbColors.color3)
        change_menu("Employee")
    End Sub

    Private Sub Bbu_Click(sender As Object, e As EventArgs) Handles Bbu.Click
        ActiveButton(sender, RgbColors.color3)
        change_menu("Bulletien")
    End Sub

    Private Sub Bco_Click(sender As Object, e As EventArgs) Handles Bco.Click
        ActiveButton(sender, RgbColors.color3)
        change_menu("Conge")
    End Sub

    Private Sub Bst_Click(sender As Object, e As EventArgs) Handles Bst.Click
        ActiveButton(sender, RgbColors.color3)
        change_menu("Stats")
    End Sub

    'Colse / Max / Min Buttons
    Private Sub Bclose_Click(sender As Object, e As EventArgs) Handles Bclose.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure want to quit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.None)

        If response = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Bmax_Click(sender As Object, e As EventArgs) Handles Bmax.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Bmin_Click(sender As Object, e As EventArgs) Handles Bmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
