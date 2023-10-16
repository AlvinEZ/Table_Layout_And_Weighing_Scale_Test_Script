<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.mnuSaveLayout = New System.Windows.Forms.MenuItem()
        Me.mnuLoadDefault = New System.Windows.Forms.MenuItem()
        Me.mnuDelete = New System.Windows.Forms.MenuItem()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboFloor = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(609, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "TextBox"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 426)
        Me.Panel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(690, 381)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(611, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(611, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Top"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(611, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Left"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(611, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Height"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(611, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Width"
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(673, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 8
        '
        'txtTop
        '
        Me.txtTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTop.Location = New System.Drawing.Point(673, 118)
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(100, 20)
        Me.txtTop.TabIndex = 9
        '
        'txtLeft
        '
        Me.txtLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLeft.Location = New System.Drawing.Point(673, 165)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtLeft.TabIndex = 10
        '
        'txtHeight
        '
        Me.txtHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHeight.Location = New System.Drawing.Point(673, 209)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 11
        '
        'txtWidth
        '
        Me.txtWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWidth.Location = New System.Drawing.Point(673, 254)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(609, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSaveLayout, Me.mnuLoadDefault, Me.mnuDelete})
        '
        'mnuSaveLayout
        '
        Me.mnuSaveLayout.Index = 0
        Me.mnuSaveLayout.Text = "Save Layout"
        '
        'mnuLoadDefault
        '
        Me.mnuLoadDefault.Index = 1
        Me.mnuLoadDefault.Text = "Load Default Layout"
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "Delete"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(690, 415)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(611, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Floor"
        '
        'cboFloor
        '
        Me.cboFloor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFloor.FormattingEnabled = True
        Me.cboFloor.Items.AddRange(New Object() {"DineIn", "TakeAway"})
        Me.cboFloor.Location = New System.Drawing.Point(673, 28)
        Me.cboFloor.Name = "cboFloor"
        Me.cboFloor.Size = New System.Drawing.Size(100, 21)
        Me.cboFloor.TabIndex = 16
        '
        'cboType
        '
        Me.cboType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"LongTable", "Table"})
        Me.cboType.Location = New System.Drawing.Point(673, 295)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(100, 21)
        Me.cboType.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(611, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Type"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboFloor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtLeft)
        Me.Controls.Add(Me.txtTop)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtTop As TextBox
    Friend WithEvents txtLeft As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ContextMenu1 As ContextMenu
    Friend WithEvents mnuSaveLayout As MenuItem
    Friend WithEvents mnuLoadDefault As MenuItem
    Friend WithEvents mnuDelete As MenuItem
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cboFloor As ComboBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label7 As Label
End Class
