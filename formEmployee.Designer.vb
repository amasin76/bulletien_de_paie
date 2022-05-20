<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.MTabControl1 = New Bulletien_De_Paie.MTabControl()
        Me.TabAjoute = New System.Windows.Forms.TabPage()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.LcnxState = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Znen = New System.Windows.Forms.TextBox()
        Me.Zdem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Zemail = New System.Windows.Forms.TextBox()
        Me.Ztel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Zvil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Zadrs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Zfn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Znpr = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Zmat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelAction = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Bajoute = New System.Windows.Forms.Button()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabConsulter = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelGrid = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LrowsCount = New System.Windows.Forms.Label()
        Me.BtableLast = New System.Windows.Forms.Button()
        Me.BtableNext = New System.Windows.Forms.Button()
        Me.BtableFirst = New System.Windows.Forms.Button()
        Me.BtablePrev = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeedbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employee_dbDataSet = New Bulletien_De_Paie.employee_dbDataSet()
        Me.PanelBoxes = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Zsearch = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Bannuler_sr = New System.Windows.Forms.Button()
        Me.Brechercher = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EmployeTableAdapter = New Bulletien_De_Paie.employee_dbDataSetTableAdapters.EmployeTableAdapter()
        Me.MTabControl1.SuspendLayout()
        Me.TabAjoute.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.PanelAction.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.TabConsulter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeedbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBoxes.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MTabControl1
        '
        Me.MTabControl1.ButtonBackColor = System.Drawing.Color.WhiteSmoke
        Me.MTabControl1.ButtonForeColor = System.Drawing.Color.Black
        Me.MTabControl1.Controls.Add(Me.TabAjoute)
        Me.MTabControl1.Controls.Add(Me.TabConsulter)
        Me.MTabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MTabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTabControl1.ItemSize = New System.Drawing.Size(130, 30)
        Me.MTabControl1.LineBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.MTabControl1.LineForeColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MTabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.MTabControl1.Name = "MTabControl1"
        Me.MTabControl1.SelectedIndex = 0
        Me.MTabControl1.Size = New System.Drawing.Size(930, 672)
        Me.MTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MTabControl1.TabIndex = 0
        Me.MTabControl1.TabStyle = Bulletien_De_Paie.MTabControl.Style.Line
        '
        'TabAjoute
        '
        Me.TabAjoute.Controls.Add(Me.PanelMain)
        Me.TabAjoute.Controls.Add(Me.PanelAction)
        Me.TabAjoute.Controls.Add(Me.PanelTitle)
        Me.TabAjoute.Location = New System.Drawing.Point(4, 34)
        Me.TabAjoute.Margin = New System.Windows.Forms.Padding(0)
        Me.TabAjoute.Name = "TabAjoute"
        Me.TabAjoute.Size = New System.Drawing.Size(922, 634)
        Me.TabAjoute.TabIndex = 0
        Me.TabAjoute.Text = "Ajouter"
        Me.TabAjoute.ToolTipText = "Ajouter Employee"
        Me.TabAjoute.UseVisualStyleBackColor = True
        '
        'PanelMain
        '
        Me.PanelMain.Controls.Add(Me.LcnxState)
        Me.PanelMain.Controls.Add(Me.Label24)
        Me.PanelMain.Controls.Add(Me.Label23)
        Me.PanelMain.Controls.Add(Me.Label22)
        Me.PanelMain.Controls.Add(Me.Label21)
        Me.PanelMain.Controls.Add(Me.Label20)
        Me.PanelMain.Controls.Add(Me.Label19)
        Me.PanelMain.Controls.Add(Me.Znen)
        Me.PanelMain.Controls.Add(Me.Zdem)
        Me.PanelMain.Controls.Add(Me.Label2)
        Me.PanelMain.Controls.Add(Me.Zemail)
        Me.PanelMain.Controls.Add(Me.Ztel)
        Me.PanelMain.Controls.Add(Me.Label3)
        Me.PanelMain.Controls.Add(Me.Zvil)
        Me.PanelMain.Controls.Add(Me.Label4)
        Me.PanelMain.Controls.Add(Me.Zadrs)
        Me.PanelMain.Controls.Add(Me.Label5)
        Me.PanelMain.Controls.Add(Me.Zfn)
        Me.PanelMain.Controls.Add(Me.Label6)
        Me.PanelMain.Controls.Add(Me.Znpr)
        Me.PanelMain.Controls.Add(Me.Label25)
        Me.PanelMain.Controls.Add(Me.Label7)
        Me.PanelMain.Controls.Add(Me.Zmat)
        Me.PanelMain.Controls.Add(Me.Label8)
        Me.PanelMain.Controls.Add(Me.Label9)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(0, 49)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(922, 481)
        Me.PanelMain.TabIndex = 5
        '
        'LcnxState
        '
        Me.LcnxState.AutoSize = True
        Me.LcnxState.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LcnxState.Location = New System.Drawing.Point(805, 48)
        Me.LcnxState.Name = "LcnxState"
        Me.LcnxState.Size = New System.Drawing.Size(0, 21)
        Me.LcnxState.TabIndex = 9
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(691, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(120, 21)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Base Donnees :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label23.Location = New System.Drawing.Point(10, 445)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(158, 13)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "[ ] : les conditions de champs"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label22.Location = New System.Drawing.Point(10, 424)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(117, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = " *  :  champs optional"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(429, 379)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 21)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "CV * [ pdf ]"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(429, 97)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(174, 21)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Photo * [ max : 256ko ]"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(143, 21)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Entrez les donnes"
        '
        'Znen
        '
        Me.Znen.Location = New System.Drawing.Point(181, 371)
        Me.Znen.Name = "Znen"
        Me.Znen.Size = New System.Drawing.Size(183, 29)
        Me.Znen.TabIndex = 2
        '
        'Zdem
        '
        Me.Zdem.Location = New System.Drawing.Point(181, 336)
        Me.Zdem.Name = "Zdem"
        Me.Zdem.Size = New System.Drawing.Size(183, 29)
        Me.Zdem.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matricule "
        '
        'Zemail
        '
        Me.Zemail.Location = New System.Drawing.Point(180, 265)
        Me.Zemail.Name = "Zemail"
        Me.Zemail.Size = New System.Drawing.Size(183, 29)
        Me.Zemail.TabIndex = 2
        '
        'Ztel
        '
        Me.Ztel.Location = New System.Drawing.Point(181, 301)
        Me.Ztel.Name = "Ztel"
        Me.Ztel.Size = New System.Drawing.Size(183, 29)
        Me.Ztel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nom / Prenom "
        '
        'Zvil
        '
        Me.Zvil.Location = New System.Drawing.Point(181, 229)
        Me.Zvil.Name = "Zvil"
        Me.Zvil.Size = New System.Drawing.Size(183, 29)
        Me.Zvil.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fonction "
        '
        'Zadrs
        '
        Me.Zadrs.Location = New System.Drawing.Point(181, 194)
        Me.Zadrs.Multiline = True
        Me.Zadrs.Name = "Zadrs"
        Me.Zadrs.Size = New System.Drawing.Size(183, 29)
        Me.Zadrs.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Adresse "
        '
        'Zfn
        '
        Me.Zfn.Location = New System.Drawing.Point(181, 159)
        Me.Zfn.Name = "Zfn"
        Me.Zfn.Size = New System.Drawing.Size(183, 29)
        Me.Zfn.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ville "
        '
        'Znpr
        '
        Me.Znpr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Znpr.Location = New System.Drawing.Point(181, 124)
        Me.Znpr.Name = "Znpr"
        Me.Znpr.Size = New System.Drawing.Size(183, 29)
        Me.Znpr.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 273)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 21)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Telephone "
        '
        'Zmat
        '
        Me.Zmat.Location = New System.Drawing.Point(181, 89)
        Me.Zmat.Name = "Zmat"
        Me.Zmat.Size = New System.Drawing.Size(183, 29)
        Me.Zmat.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Date d'embauche "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nombre d'enfant "
        '
        'PanelAction
        '
        Me.PanelAction.Controls.Add(Me.Button3)
        Me.PanelAction.Controls.Add(Me.Button2)
        Me.PanelAction.Controls.Add(Me.Bajoute)
        Me.PanelAction.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAction.Location = New System.Drawing.Point(0, 530)
        Me.PanelAction.Name = "PanelAction"
        Me.PanelAction.Size = New System.Drawing.Size(922, 104)
        Me.PanelAction.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(621, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(205, 61)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Actualiser"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(359, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 61)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Bajoute
        '
        Me.Bajoute.Location = New System.Drawing.Point(97, 22)
        Me.Bajoute.Name = "Bajoute"
        Me.Bajoute.Size = New System.Drawing.Size(205, 61)
        Me.Bajoute.TabIndex = 0
        Me.Bajoute.Text = "Ajouter"
        Me.Bajoute.UseVisualStyleBackColor = True
        '
        'PanelTitle
        '
        Me.PanelTitle.Controls.Add(Me.Label1)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(922, 49)
        Me.PanelTitle.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Saisi d'un nouveau employe"
        '
        'TabConsulter
        '
        Me.TabConsulter.Controls.Add(Me.Panel3)
        Me.TabConsulter.Controls.Add(Me.Panel2)
        Me.TabConsulter.Controls.Add(Me.Panel1)
        Me.TabConsulter.Location = New System.Drawing.Point(4, 34)
        Me.TabConsulter.Margin = New System.Windows.Forms.Padding(0)
        Me.TabConsulter.Name = "TabConsulter"
        Me.TabConsulter.Size = New System.Drawing.Size(922, 634)
        Me.TabConsulter.TabIndex = 1
        Me.TabConsulter.Text = "Consulter"
        Me.TabConsulter.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PanelGrid)
        Me.Panel3.Controls.Add(Me.PanelBoxes)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(922, 481)
        Me.Panel3.TabIndex = 9
        '
        'PanelGrid
        '
        Me.PanelGrid.AutoScroll = True
        Me.PanelGrid.Controls.Add(Me.Label13)
        Me.PanelGrid.Controls.Add(Me.LrowsCount)
        Me.PanelGrid.Controls.Add(Me.BtableLast)
        Me.PanelGrid.Controls.Add(Me.BtableNext)
        Me.PanelGrid.Controls.Add(Me.BtableFirst)
        Me.PanelGrid.Controls.Add(Me.BtablePrev)
        Me.PanelGrid.Controls.Add(Me.DataGridView1)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrid.Location = New System.Drawing.Point(0, 57)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(922, 424)
        Me.PanelGrid.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Location = New System.Drawing.Point(767, 311)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 21)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Result(s) :"
        '
        'LrowsCount
        '
        Me.LrowsCount.AutoSize = True
        Me.LrowsCount.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LrowsCount.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LrowsCount.Location = New System.Drawing.Point(860, 311)
        Me.LrowsCount.Name = "LrowsCount"
        Me.LrowsCount.Size = New System.Drawing.Size(0, 21)
        Me.LrowsCount.TabIndex = 2
        '
        'BtableLast
        '
        Me.BtableLast.Location = New System.Drawing.Point(204, 305)
        Me.BtableLast.Name = "BtableLast"
        Me.BtableLast.Size = New System.Drawing.Size(52, 32)
        Me.BtableLast.TabIndex = 1
        Me.BtableLast.Text = ">>"
        Me.BtableLast.UseVisualStyleBackColor = True
        '
        'BtableNext
        '
        Me.BtableNext.Location = New System.Drawing.Point(146, 305)
        Me.BtableNext.Name = "BtableNext"
        Me.BtableNext.Size = New System.Drawing.Size(52, 32)
        Me.BtableNext.TabIndex = 1
        Me.BtableNext.Text = ">"
        Me.BtableNext.UseVisualStyleBackColor = True
        '
        'BtableFirst
        '
        Me.BtableFirst.Location = New System.Drawing.Point(30, 305)
        Me.BtableFirst.Name = "BtableFirst"
        Me.BtableFirst.Size = New System.Drawing.Size(52, 32)
        Me.BtableFirst.TabIndex = 1
        Me.BtableFirst.Text = "<<"
        Me.BtableFirst.UseVisualStyleBackColor = True
        '
        'BtablePrev
        '
        Me.BtablePrev.Location = New System.Drawing.Point(88, 305)
        Me.BtablePrev.Name = "BtablePrev"
        Me.BtablePrev.Size = New System.Drawing.Size(52, 32)
        Me.BtablePrev.TabIndex = 1
        Me.BtablePrev.Text = "<"
        Me.BtablePrev.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DataGridView1.DataSource = Me.EmployeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(30, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(849, 279)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Mat"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mat"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nom_Prenom"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom_Prenom"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fonction"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fonction"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Adresse"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Adresse"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ville"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ville"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Telephone"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telephone"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DEM"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DEM"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Enfants"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Enfants"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Photo"
        Me.DataGridViewImageColumn1.HeaderText = "Photo"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CV"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CV"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "dateRec"
        Me.DataGridViewTextBoxColumn11.HeaderText = "dateRec"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'EmployeBindingSource
        '
        Me.EmployeBindingSource.DataMember = "Employe"
        Me.EmployeBindingSource.DataSource = Me.EmployeedbDataSetBindingSource
        '
        'EmployeedbDataSetBindingSource
        '
        Me.EmployeedbDataSetBindingSource.DataSource = Me.Employee_dbDataSet
        Me.EmployeedbDataSetBindingSource.Position = 0
        '
        'Employee_dbDataSet
        '
        Me.Employee_dbDataSet.DataSetName = "employee_dbDataSet"
        Me.Employee_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelBoxes
        '
        Me.PanelBoxes.Controls.Add(Me.Label10)
        Me.PanelBoxes.Controls.Add(Me.Zsearch)
        Me.PanelBoxes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBoxes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelBoxes.Location = New System.Drawing.Point(0, 0)
        Me.PanelBoxes.Name = "PanelBoxes"
        Me.PanelBoxes.Size = New System.Drawing.Size(922, 57)
        Me.PanelBoxes.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 21)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Search"
        '
        'Zsearch
        '
        Me.Zsearch.Location = New System.Drawing.Point(88, 12)
        Me.Zsearch.Name = "Zsearch"
        Me.Zsearch.Size = New System.Drawing.Size(280, 29)
        Me.Zsearch.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Bannuler_sr)
        Me.Panel2.Controls.Add(Me.Brechercher)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 530)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(922, 104)
        Me.Panel2.TabIndex = 8
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(621, 22)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(205, 61)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Actualiser"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Bannuler_sr
        '
        Me.Bannuler_sr.Location = New System.Drawing.Point(359, 22)
        Me.Bannuler_sr.Name = "Bannuler_sr"
        Me.Bannuler_sr.Size = New System.Drawing.Size(205, 61)
        Me.Bannuler_sr.TabIndex = 0
        Me.Bannuler_sr.Text = "Annuler"
        Me.Bannuler_sr.UseVisualStyleBackColor = True
        '
        'Brechercher
        '
        Me.Brechercher.Location = New System.Drawing.Point(97, 22)
        Me.Brechercher.Name = "Brechercher"
        Me.Brechercher.Size = New System.Drawing.Size(205, 61)
        Me.Brechercher.TabIndex = 0
        Me.Brechercher.Text = "Rechercher"
        Me.Brechercher.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(922, 49)
        Me.Panel1.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(360, 30)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Afficher un ou plusieurs employees"
        '
        'EmployeTableAdapter
        '
        Me.EmployeTableAdapter.ClearBeforeFill = True
        '
        'formEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 672)
        Me.Controls.Add(Me.MTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formEmployee"
        Me.Text = "formEmployee"
        Me.MTabControl1.ResumeLayout(False)
        Me.TabAjoute.ResumeLayout(False)
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.PanelAction.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.TabConsulter.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelGrid.ResumeLayout(False)
        Me.PanelGrid.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeedbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBoxes.ResumeLayout(False)
        Me.PanelBoxes.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MTabControl1 As MTabControl
    Friend WithEvents TabAjoute As TabPage
    Friend WithEvents TabConsulter As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelAction As Panel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Bajoute As Button
    Friend WithEvents Znen As TextBox
    Friend WithEvents Zdem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Ztel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Zvil As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Zadrs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Zfn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Znpr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Zmat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Zsearch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Bannuler_sr As Button
    Friend WithEvents Brechercher As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents LcnxState As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Zemail As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents PanelBoxes As Panel
    Friend WithEvents PanelGrid As Panel
    Friend WithEvents MatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomPrenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FonctionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnfantsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents CVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateRecDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EmployeedbDataSetBindingSource As BindingSource
    Friend WithEvents Employee_dbDataSet As employee_dbDataSet
    Friend WithEvents EmployeBindingSource As BindingSource
    Friend WithEvents EmployeTableAdapter As employee_dbDataSetTableAdapters.EmployeTableAdapter
    Friend WithEvents BtableNext As Button
    Friend WithEvents BtablePrev As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents BtableLast As Button
    Friend WithEvents BtableFirst As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents LrowsCount As Label
End Class