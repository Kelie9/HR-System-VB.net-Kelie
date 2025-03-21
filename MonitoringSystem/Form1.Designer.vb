<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveOfAbsenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfApprovedLeavesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesPosistionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByPositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAllEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintEmployeesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintLeaveOfAbsenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnApplication = New System.Windows.Forms.Button()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManageEmployeesToolStripMenuItem, Me.LeaveOfAbsenceToolStripMenuItem, Me.ManageDepartmentToolStripMenuItem, Me.EmployeesPosistionToolStripMenuItem, Me.SearchEmployeeToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(985, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUsersToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ManageEmployeesToolStripMenuItem
        '
        Me.ManageEmployeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ListToolStripMenuItem})
        Me.ManageEmployeesToolStripMenuItem.Name = "ManageEmployeesToolStripMenuItem"
        Me.ManageEmployeesToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ManageEmployeesToolStripMenuItem.Text = "Employees"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'LeaveOfAbsenceToolStripMenuItem
        '
        Me.LeaveOfAbsenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewLeaveToolStripMenuItem, Me.ListOfApprovedLeavesToolStripMenuItem})
        Me.LeaveOfAbsenceToolStripMenuItem.Name = "LeaveOfAbsenceToolStripMenuItem"
        Me.LeaveOfAbsenceToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.LeaveOfAbsenceToolStripMenuItem.Text = "Leave of Absence"
        '
        'AddNewLeaveToolStripMenuItem
        '
        Me.AddNewLeaveToolStripMenuItem.Name = "AddNewLeaveToolStripMenuItem"
        Me.AddNewLeaveToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddNewLeaveToolStripMenuItem.Text = "Application Form"
        '
        'ListOfApprovedLeavesToolStripMenuItem
        '
        Me.ListOfApprovedLeavesToolStripMenuItem.Name = "ListOfApprovedLeavesToolStripMenuItem"
        Me.ListOfApprovedLeavesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ListOfApprovedLeavesToolStripMenuItem.Text = "List of Approved Leaves"
        '
        'ManageDepartmentToolStripMenuItem
        '
        Me.ManageDepartmentToolStripMenuItem.Name = "ManageDepartmentToolStripMenuItem"
        Me.ManageDepartmentToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.ManageDepartmentToolStripMenuItem.Text = "Manage Department"
        '
        'EmployeesPosistionToolStripMenuItem
        '
        Me.EmployeesPosistionToolStripMenuItem.Name = "EmployeesPosistionToolStripMenuItem"
        Me.EmployeesPosistionToolStripMenuItem.Size = New System.Drawing.Size(130, 20)
        Me.EmployeesPosistionToolStripMenuItem.Text = "Employee's Posistion"
        '
        'SearchEmployeeToolStripMenuItem
        '
        Me.SearchEmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByPositionToolStripMenuItem, Me.ByDepartmentToolStripMenuItem})
        Me.SearchEmployeeToolStripMenuItem.Name = "SearchEmployeeToolStripMenuItem"
        Me.SearchEmployeeToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.SearchEmployeeToolStripMenuItem.Text = "Search Employee"
        '
        'ByPositionToolStripMenuItem
        '
        Me.ByPositionToolStripMenuItem.Name = "ByPositionToolStripMenuItem"
        Me.ByPositionToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ByPositionToolStripMenuItem.Text = "By Position"
        '
        'ByDepartmentToolStripMenuItem
        '
        Me.ByDepartmentToolStripMenuItem.Name = "ByDepartmentToolStripMenuItem"
        Me.ByDepartmentToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ByDepartmentToolStripMenuItem.Text = "By Department"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAllEmployeesToolStripMenuItem, Me.PrintEmployeesDetailsToolStripMenuItem, Me.PrintLeaveOfAbsenceToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'PrintAllEmployeesToolStripMenuItem
        '
        Me.PrintAllEmployeesToolStripMenuItem.Name = "PrintAllEmployeesToolStripMenuItem"
        Me.PrintAllEmployeesToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.PrintAllEmployeesToolStripMenuItem.Text = "Print All Employee's"
        '
        'PrintEmployeesDetailsToolStripMenuItem
        '
        Me.PrintEmployeesDetailsToolStripMenuItem.Name = "PrintEmployeesDetailsToolStripMenuItem"
        Me.PrintEmployeesDetailsToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.PrintEmployeesDetailsToolStripMenuItem.Text = "Print Employee's Details"
        '
        'PrintLeaveOfAbsenceToolStripMenuItem
        '
        Me.PrintLeaveOfAbsenceToolStripMenuItem.Name = "PrintLeaveOfAbsenceToolStripMenuItem"
        Me.PrintLeaveOfAbsenceToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.PrintLeaveOfAbsenceToolStripMenuItem.Text = "Print Leave of Absence"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.MonitoringSystem.My.Resources.Resources._0_P6BWulLY_1aME7Tg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(985, 451)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnApplication
        '
        Me.btnApplication.BackColor = System.Drawing.Color.Brown
        Me.btnApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplication.ForeColor = System.Drawing.Color.White
        Me.btnApplication.Location = New System.Drawing.Point(0, 27)
        Me.btnApplication.Name = "btnApplication"
        Me.btnApplication.Size = New System.Drawing.Size(172, 119)
        Me.btnApplication.TabIndex = 2
        Me.btnApplication.Text = "Leave Application"
        Me.btnApplication.UseVisualStyleBackColor = False
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.Brown
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.White
        Me.btnReg.Location = New System.Drawing.Point(0, 152)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(172, 119)
        Me.btnReg.TabIndex = 3
        Me.btnReg.Text = "Register New Employee"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.Brown
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.White
        Me.btnHistory.Location = New System.Drawing.Point(178, 27)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(172, 119)
        Me.btnHistory.TabIndex = 4
        Me.btnHistory.Text = "Applied Leaves History"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.Color.Brown
        Me.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.ForeColor = System.Drawing.Color.White
        Me.btnList.Location = New System.Drawing.Point(178, 152)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(172, 119)
        Me.btnList.TabIndex = 5
        Me.btnList.Text = "List of Employee's"
        Me.btnList.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 475)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnApplication)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveOfAbsenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeesPosistionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByPositionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintAllEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewLeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfApprovedLeavesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintEmployeesDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintLeaveOfAbsenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnApplication As Button
    Friend WithEvents btnReg As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnList As Button
End Class
