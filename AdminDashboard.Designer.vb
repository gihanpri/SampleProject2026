<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Me.btnAdminUserManagement = New System.Windows.Forms.Button()
        Me.btnAdminCusMgt = New System.Windows.Forms.Button()
        Me.btnAdminOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdminUserManagement
        '
        Me.btnAdminUserManagement.Location = New System.Drawing.Point(27, 28)
        Me.btnAdminUserManagement.Name = "btnAdminUserManagement"
        Me.btnAdminUserManagement.Size = New System.Drawing.Size(134, 66)
        Me.btnAdminUserManagement.TabIndex = 0
        Me.btnAdminUserManagement.Text = "USER MANAGMENT"
        Me.btnAdminUserManagement.UseVisualStyleBackColor = True
        '
        'btnAdminCusMgt
        '
        Me.btnAdminCusMgt.Location = New System.Drawing.Point(185, 28)
        Me.btnAdminCusMgt.Name = "btnAdminCusMgt"
        Me.btnAdminCusMgt.Size = New System.Drawing.Size(165, 66)
        Me.btnAdminCusMgt.TabIndex = 1
        Me.btnAdminCusMgt.Text = "CUSTOMER MANAGEMENT"
        Me.btnAdminCusMgt.UseVisualStyleBackColor = True
        '
        'btnAdminOrder
        '
        Me.btnAdminOrder.Location = New System.Drawing.Point(380, 30)
        Me.btnAdminOrder.Name = "btnAdminOrder"
        Me.btnAdminOrder.Size = New System.Drawing.Size(189, 63)
        Me.btnAdminOrder.TabIndex = 2
        Me.btnAdminOrder.Text = "ORDER"
        Me.btnAdminOrder.UseVisualStyleBackColor = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 290)
        Me.Controls.Add(Me.btnAdminOrder)
        Me.Controls.Add(Me.btnAdminCusMgt)
        Me.Controls.Add(Me.btnAdminUserManagement)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdminUserManagement As Button
    Friend WithEvents btnAdminCusMgt As Button
    Friend WithEvents btnAdminOrder As Button
End Class
