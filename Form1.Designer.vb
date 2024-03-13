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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDontionAMt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.cboStudents = New System.Windows.Forms.ComboBox()
        Me.lstStudentDonations = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStudentTotal = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblClassTotal = New System.Windows.Forms.Label()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Name"
        '
        'txtDontionAMt
        '
        Me.txtDontionAMt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDontionAMt.Location = New System.Drawing.Point(41, 112)
        Me.txtDontionAMt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDontionAMt.Name = "txtDontionAMt"
        Me.txtDontionAMt.Size = New System.Drawing.Size(148, 27)
        Me.txtDontionAMt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Donation Amount"
        '
        'btnDonate
        '
        Me.btnDonate.Location = New System.Drawing.Point(482, 194)
        Me.btnDonate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(232, 35)
        Me.btnDonate.TabIndex = 4
        Me.btnDonate.Text = "Add Donation"
        Me.btnDonate.UseVisualStyleBackColor = True
        '
        'cboStudents
        '
        Me.cboStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudents.FormattingEnabled = True
        Me.cboStudents.Location = New System.Drawing.Point(41, 34)
        Me.cboStudents.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboStudents.Name = "cboStudents"
        Me.cboStudents.Size = New System.Drawing.Size(148, 28)
        Me.cboStudents.Sorted = True
        Me.cboStudents.TabIndex = 5
        '
        'lstStudentDonations
        '
        Me.lstStudentDonations.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstStudentDonations.ForeColor = System.Drawing.Color.Black
        Me.lstStudentDonations.FormattingEnabled = True
        Me.lstStudentDonations.ItemHeight = 20
        Me.lstStudentDonations.Location = New System.Drawing.Point(280, 37)
        Me.lstStudentDonations.Name = "lstStudentDonations"
        Me.lstStudentDonations.Size = New System.Drawing.Size(196, 124)
        Me.lstStudentDonations.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Student Total: "
        '
        'lblStudentTotal
        '
        Me.lblStudentTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudentTotal.Location = New System.Drawing.Point(482, 254)
        Me.lblStudentTotal.Name = "lblStudentTotal"
        Me.lblStudentTotal.Size = New System.Drawing.Size(160, 19)
        Me.lblStudentTotal.TabIndex = 8
        Me.lblStudentTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(316, 167)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(130, 38)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Donations:"
        '
        'lblClassTotal
        '
        Me.lblClassTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClassTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassTotal.Location = New System.Drawing.Point(316, 329)
        Me.lblClassTotal.Name = "lblClassTotal"
        Me.lblClassTotal.Size = New System.Drawing.Size(248, 39)
        Me.lblClassTotal.TabIndex = 11
        '
        'lblHighest
        '
        Me.lblHighest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighest.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighest.Location = New System.Drawing.Point(12, 96)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(246, 177)
        Me.lblHighest.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Highest Donors:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboStudents)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtDontionAMt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(482, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 159)
        Me.Panel1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(797, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.lblClassTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblStudentTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstStudentDonations)
        Me.Controls.Add(Me.btnDonate)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Donation Tracker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDontionAMt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDonate As Button
    Friend WithEvents cboStudents As ComboBox
    Friend WithEvents lstStudentDonations As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStudentTotal As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblClassTotal As Label
    Friend WithEvents lblHighest As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
End Class
