﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmemployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.cbowtype = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbodeaprtment = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtposition = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtdrate = New System.Windows.Forms.TextBox()
        Me.dtpdhired = New System.Windows.Forms.DateTimePicker()
        Me.txtpmethod = New System.Windows.Forms.ComboBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtbplace = New System.Windows.Forms.RichTextBox()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpdbirth = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.rdofemale = New System.Windows.Forms.RadioButton()
        Me.txtemerg = New System.Windows.Forms.TextBox()
        Me.rdomale = New System.Windows.Forms.RadioButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnempnew = New System.Windows.Forms.Button()
        Me.btnempsave = New System.Windows.Forms.Button()
        Me.emptitle = New System.Windows.Forms.Label()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Brown
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Bodoni MT Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(181, 471)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(89, 58)
        Me.btnclose.TabIndex = 28
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.cbowtype)
        Me.GroupBox10.Controls.Add(Me.Label3)
        Me.GroupBox10.Controls.Add(Me.cbodeaprtment)
        Me.GroupBox10.Controls.Add(Me.Label1)
        Me.GroupBox10.Controls.Add(Me.txtposition)
        Me.GroupBox10.Controls.Add(Me.Label37)
        Me.GroupBox10.Controls.Add(Me.Label36)
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.txtdrate)
        Me.GroupBox10.Controls.Add(Me.dtpdhired)
        Me.GroupBox10.Controls.Add(Me.txtpmethod)
        Me.GroupBox10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(12, 347)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox10.Size = New System.Drawing.Size(853, 116)
        Me.GroupBox10.TabIndex = 26
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Work Information"
        '
        'cbowtype
        '
        Me.cbowtype.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbowtype.FormattingEnabled = True
        Me.cbowtype.Items.AddRange(New Object() {"Regular", "Casual"})
        Me.cbowtype.Location = New System.Drawing.Point(667, 61)
        Me.cbowtype.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbowtype.Name = "cbowtype"
        Me.cbowtype.Size = New System.Drawing.Size(164, 24)
        Me.cbowtype.TabIndex = 12
        Me.cbowtype.Text = "Regular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(568, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Work Status :"
        '
        'cbodeaprtment
        '
        Me.cbodeaprtment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodeaprtment.FormattingEnabled = True
        Me.cbodeaprtment.Location = New System.Drawing.Point(362, 59)
        Me.cbodeaprtment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbodeaprtment.Name = "cbodeaprtment"
        Me.cbodeaprtment.Size = New System.Drawing.Size(193, 24)
        Me.cbodeaprtment.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Department :"
        '
        'txtposition
        '
        Me.txtposition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposition.FormattingEnabled = True
        Me.txtposition.Location = New System.Drawing.Point(362, 27)
        Me.txtposition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(193, 24)
        Me.txtposition.TabIndex = 2
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(14, 29)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(81, 16)
        Me.Label37.TabIndex = 7
        Me.Label37.Text = "Daily Rate :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(266, 31)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(67, 16)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Position :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(14, 64)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(91, 16)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "Pay Method :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(568, 35)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(83, 16)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Date Hired :"
        '
        'txtdrate
        '
        Me.txtdrate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrate.Location = New System.Drawing.Point(107, 25)
        Me.txtdrate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdrate.MaxLength = 3
        Me.txtdrate.Name = "txtdrate"
        Me.txtdrate.Size = New System.Drawing.Size(139, 22)
        Me.txtdrate.TabIndex = 2
        '
        'dtpdhired
        '
        Me.dtpdhired.CustomFormat = "yyyy-MM-dd"
        Me.dtpdhired.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdhired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdhired.Location = New System.Drawing.Point(666, 27)
        Me.dtpdhired.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpdhired.Name = "dtpdhired"
        Me.dtpdhired.Size = New System.Drawing.Size(165, 22)
        Me.dtpdhired.TabIndex = 1
        '
        'txtpmethod
        '
        Me.txtpmethod.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpmethod.FormattingEnabled = True
        Me.txtpmethod.Items.AddRange(New Object() {"Weekly", "Monthly"})
        Me.txtpmethod.Location = New System.Drawing.Point(107, 56)
        Me.txtpmethod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpmethod.Name = "txtpmethod"
        Me.txtpmethod.Size = New System.Drawing.Size(139, 24)
        Me.txtpmethod.TabIndex = 0
        Me.txtpmethod.Text = "Weekly"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.txtcode)
        Me.GroupBox9.Controls.Add(Me.Label20)
        Me.GroupBox9.Controls.Add(Me.txtbplace)
        Me.GroupBox9.Controls.Add(Me.txtaddress)
        Me.GroupBox9.Controls.Add(Me.Label21)
        Me.GroupBox9.Controls.Add(Me.dtpdbirth)
        Me.GroupBox9.Controls.Add(Me.Label22)
        Me.GroupBox9.Controls.Add(Me.txtlname)
        Me.GroupBox9.Controls.Add(Me.txtcontact)
        Me.GroupBox9.Controls.Add(Me.txtfname)
        Me.GroupBox9.Controls.Add(Me.Label24)
        Me.GroupBox9.Controls.Add(Me.txtmname)
        Me.GroupBox9.Controls.Add(Me.rdofemale)
        Me.GroupBox9.Controls.Add(Me.txtemerg)
        Me.GroupBox9.Controls.Add(Me.rdomale)
        Me.GroupBox9.Controls.Add(Me.Label25)
        Me.GroupBox9.Controls.Add(Me.Label26)
        Me.GroupBox9.Controls.Add(Me.Label27)
        Me.GroupBox9.Controls.Add(Me.txtstatus)
        Me.GroupBox9.Controls.Add(Me.Label28)
        Me.GroupBox9.Controls.Add(Me.Label29)
        Me.GroupBox9.Controls.Add(Me.Label30)
        Me.GroupBox9.Controls.Add(Me.Label31)
        Me.GroupBox9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox9.Size = New System.Drawing.Size(853, 257)
        Me.GroupBox9.TabIndex = 25
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Personal Information"
        '
        'txtcode
        '
        Me.txtcode.Enabled = False
        Me.txtcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(104, 27)
        Me.txtcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcode.Multiline = True
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(111, 26)
        Me.txtcode.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 16)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Employee Id"
        '
        'txtbplace
        '
        Me.txtbplace.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbplace.Location = New System.Drawing.Point(111, 168)
        Me.txtbplace.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbplace.Name = "txtbplace"
        Me.txtbplace.Size = New System.Drawing.Size(265, 81)
        Me.txtbplace.TabIndex = 17
        Me.txtbplace.Text = ""
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(102, 97)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(274, 27)
        Me.txtaddress.TabIndex = 17
        Me.txtaddress.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(14, 177)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 16)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Place of Birth"
        '
        'dtpdbirth
        '
        Me.dtpdbirth.CustomFormat = "yyyy-MM-dd"
        Me.dtpdbirth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdbirth.Location = New System.Drawing.Point(666, 132)
        Me.dtpdbirth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpdbirth.Name = "dtpdbirth"
        Me.dtpdbirth.Size = New System.Drawing.Size(165, 22)
        Me.dtpdbirth.TabIndex = 12
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(568, 141)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 16)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Date of Birth"
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(371, 62)
        Me.txtlname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtlname.Multiline = True
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(182, 26)
        Me.txtlname.TabIndex = 0
        '
        'txtcontact
        '
        Me.txtcontact.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(382, 131)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcontact.MaxLength = 11
        Me.txtcontact.Multiline = True
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(162, 26)
        Me.txtcontact.TabIndex = 0
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(104, 60)
        Me.txtfname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfname.Multiline = True
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(171, 26)
        Me.txtfname.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(14, 141)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 16)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Sex"
        '
        'txtmname
        '
        Me.txtmname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(666, 62)
        Me.txtmname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmname.Multiline = True
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(165, 24)
        Me.txtmname.TabIndex = 0
        '
        'rdofemale
        '
        Me.rdofemale.AutoSize = True
        Me.rdofemale.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdofemale.Location = New System.Drawing.Point(167, 137)
        Me.rdofemale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdofemale.Name = "rdofemale"
        Me.rdofemale.Size = New System.Drawing.Size(74, 20)
        Me.rdofemale.TabIndex = 6
        Me.rdofemale.TabStop = True
        Me.rdofemale.Text = "Female"
        Me.rdofemale.UseVisualStyleBackColor = True
        '
        'txtemerg
        '
        Me.txtemerg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemerg.Location = New System.Drawing.Point(666, 168)
        Me.txtemerg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtemerg.MaxLength = 11
        Me.txtemerg.Multiline = True
        Me.txtemerg.Name = "txtemerg"
        Me.txtemerg.Size = New System.Drawing.Size(165, 25)
        Me.txtemerg.TabIndex = 0
        '
        'rdomale
        '
        Me.rdomale.AutoSize = True
        Me.rdomale.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdomale.Location = New System.Drawing.Point(102, 137)
        Me.rdomale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdomale.Name = "rdomale"
        Me.rdomale.Size = New System.Drawing.Size(57, 20)
        Me.rdomale.TabIndex = 6
        Me.rdomale.TabStop = True
        Me.rdomale.Text = "Male"
        Me.rdomale.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(266, 137)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(110, 16)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Contact Number"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(14, 72)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 16)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "First Name"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(399, 108)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 16)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Civil Status"
        '
        'txtstatus
        '
        Me.txtstatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.FormattingEnabled = True
        Me.txtstatus.Items.AddRange(New Object() {"Married", "Single", "Widow"})
        Me.txtstatus.Location = New System.Drawing.Point(484, 100)
        Me.txtstatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(164, 24)
        Me.txtstatus.TabIndex = 2
        Me.txtstatus.Text = "Single"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(290, 72)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 16)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Last Name"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(14, 108)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(58, 16)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Address"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(428, 177)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(220, 16)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "Contact no. [ case of emergency ]"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(568, 70)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(92, 16)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Middle Name"
        '
        'btnempnew
        '
        Me.btnempnew.BackColor = System.Drawing.Color.Brown
        Me.btnempnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempnew.Font = New System.Drawing.Font("Bodoni MT Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnempnew.ForeColor = System.Drawing.Color.White
        Me.btnempnew.Location = New System.Drawing.Point(92, 471)
        Me.btnempnew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnempnew.Name = "btnempnew"
        Me.btnempnew.Size = New System.Drawing.Size(89, 58)
        Me.btnempnew.TabIndex = 23
        Me.btnempnew.Text = "Clear"
        Me.btnempnew.UseVisualStyleBackColor = False
        '
        'btnempsave
        '
        Me.btnempsave.BackColor = System.Drawing.Color.Brown
        Me.btnempsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempsave.Font = New System.Drawing.Font("Bodoni MT Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnempsave.ForeColor = System.Drawing.Color.White
        Me.btnempsave.Location = New System.Drawing.Point(4, 471)
        Me.btnempsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnempsave.Name = "btnempsave"
        Me.btnempsave.Size = New System.Drawing.Size(85, 58)
        Me.btnempsave.TabIndex = 24
        Me.btnempsave.Text = "Save"
        Me.btnempsave.UseVisualStyleBackColor = False
        '
        'emptitle
        '
        Me.emptitle.AutoSize = True
        Me.emptitle.Font = New System.Drawing.Font("Bahnschrift Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emptitle.Location = New System.Drawing.Point(12, 9)
        Me.emptitle.Name = "emptitle"
        Me.emptitle.Size = New System.Drawing.Size(391, 42)
        Me.emptitle.TabIndex = 20
        Me.emptitle.Text = "Register New Employee"
        '
        'frmemployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(878, 533)
        Me.Controls.Add(Me.emptitle)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.btnempnew)
        Me.Controls.Add(Me.btnempsave)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmemployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees Registration Form"
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents cbodeaprtment As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtposition As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtdrate As System.Windows.Forms.TextBox
    Friend WithEvents dtpdhired As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpmethod As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtbplace As System.Windows.Forms.RichTextBox
    Friend WithEvents txtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtpdbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents rdofemale As System.Windows.Forms.RadioButton
    Friend WithEvents txtemerg As System.Windows.Forms.TextBox
    Friend WithEvents rdomale As System.Windows.Forms.RadioButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnempnew As System.Windows.Forms.Button
    Friend WithEvents btnempsave As System.Windows.Forms.Button
    Friend WithEvents emptitle As System.Windows.Forms.Label
    Friend WithEvents cbowtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
