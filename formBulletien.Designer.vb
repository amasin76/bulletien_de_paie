<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formBulletien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BunifuRating1 = New Bunifu.UI.WinForms.BunifuRating()
        Me.SuspendLayout()
        '
        'BunifuRating1
        '
        Me.BunifuRating1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuRating1.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuRating1.DisabledRatedFillColor = System.Drawing.Color.DarkGray
        Me.BunifuRating1.EmptyBorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuRating1.EmptyFillColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuRating1.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BunifuRating1.HoverFillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BunifuRating1.InnerRadius = 2.0!
        Me.BunifuRating1.Location = New System.Drawing.Point(349, 147)
        Me.BunifuRating1.Name = "BunifuRating1"
        Me.BunifuRating1.OuterRadius = 10.0!
        Me.BunifuRating1.RatedBorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BunifuRating1.RatedFillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BunifuRating1.ReadOnly = False
        Me.BunifuRating1.RightClickToClear = True
        Me.BunifuRating1.Size = New System.Drawing.Size(121, 22)
        Me.BunifuRating1.TabIndex = 0
        Me.BunifuRating1.Text = "BunifuRating1"
        Me.BunifuRating1.Value = 2
        '
        'formBulletien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BunifuRating1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formBulletien"
        Me.Text = "formBulletien"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuRating1 As Bunifu.UI.WinForms.BunifuRating
End Class
