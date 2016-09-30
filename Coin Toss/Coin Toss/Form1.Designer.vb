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
        Me.btnPutin = New System.Windows.Forms.Button()
        Me.btnAmerica = New System.Windows.Forms.Button()
        Me.btnFlip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPutin
        '
        Me.btnPutin.BackgroundImage = CType(resources.GetObject("btnPutin.BackgroundImage"), System.Drawing.Image)
        Me.btnPutin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPutin.Location = New System.Drawing.Point(12, 12)
        Me.btnPutin.Name = "btnPutin"
        Me.btnPutin.Size = New System.Drawing.Size(245, 231)
        Me.btnPutin.TabIndex = 3
        Me.btnPutin.UseVisualStyleBackColor = True
        '
        'btnAmerica
        '
        Me.btnAmerica.BackgroundImage = CType(resources.GetObject("btnAmerica.BackgroundImage"), System.Drawing.Image)
        Me.btnAmerica.Location = New System.Drawing.Point(263, 12)
        Me.btnAmerica.Name = "btnAmerica"
        Me.btnAmerica.Size = New System.Drawing.Size(304, 305)
        Me.btnAmerica.TabIndex = 5
        Me.btnAmerica.UseVisualStyleBackColor = True
        '
        'btnFlip
        '
        Me.btnFlip.Location = New System.Drawing.Point(108, 327)
        Me.btnFlip.Name = "btnFlip"
        Me.btnFlip.Size = New System.Drawing.Size(75, 23)
        Me.btnFlip.TabIndex = 6
        Me.btnFlip.Text = "Flip"
        Me.btnFlip.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 392)
        Me.Controls.Add(Me.btnFlip)
        Me.Controls.Add(Me.btnAmerica)
        Me.Controls.Add(Me.btnPutin)
        Me.Name = "Form1"
        Me.Text = "Coin Toss"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPutin As System.Windows.Forms.Button
    Friend WithEvents btnAmerica As System.Windows.Forms.Button
    Friend WithEvents btnFlip As System.Windows.Forms.Button

End Class
