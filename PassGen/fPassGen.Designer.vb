<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPassGen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TrackBarNivelSeg = New System.Windows.Forms.TrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lNivelSeg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bGenerar = New System.Windows.Forms.Button()
        Me.tbContrasGenerada = New System.Windows.Forms.TextBox()
        CType(Me.TrackBarNivelSeg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrackBarNivelSeg
        '
        Me.TrackBarNivelSeg.Location = New System.Drawing.Point(31, 27)
        Me.TrackBarNivelSeg.Maximum = 4
        Me.TrackBarNivelSeg.Name = "TrackBarNivelSeg"
        Me.TrackBarNivelSeg.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBarNivelSeg.Size = New System.Drawing.Size(45, 161)
        Me.TrackBarNivelSeg.TabIndex = 0
        Me.TrackBarNivelSeg.Value = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lNivelSeg)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TrackBarNivelSeg)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(103, 216)
        Me.Panel1.TabIndex = 1
        '
        'lNivelSeg
        '
        Me.lNivelSeg.AutoSize = True
        Me.lNivelSeg.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lNivelSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNivelSeg.ForeColor = System.Drawing.Color.Red
        Me.lNivelSeg.Location = New System.Drawing.Point(8, 8)
        Me.lNivelSeg.Name = "lNivelSeg"
        Me.lNivelSeg.Size = New System.Drawing.Size(68, 16)
        Me.lNivelSeg.TabIndex = 2
        Me.lNivelSeg.Text = "Muy Débil"
        Me.lNivelSeg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nivel de Seguridad"
        '
        'bGenerar
        '
        Me.bGenerar.Location = New System.Drawing.Point(140, 20)
        Me.bGenerar.Name = "bGenerar"
        Me.bGenerar.Size = New System.Drawing.Size(127, 23)
        Me.bGenerar.TabIndex = 2
        Me.bGenerar.Text = "Generar Contraseña"
        Me.bGenerar.UseVisualStyleBackColor = True
        '
        'tbContrasGenerada
        '
        Me.tbContrasGenerada.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContrasGenerada.Location = New System.Drawing.Point(121, 65)
        Me.tbContrasGenerada.Name = "tbContrasGenerada"
        Me.tbContrasGenerada.Size = New System.Drawing.Size(157, 31)
        Me.tbContrasGenerada.TabIndex = 3
        Me.tbContrasGenerada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fPassGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 241)
        Me.Controls.Add(Me.tbContrasGenerada)
        Me.Controls.Add(Me.bGenerar)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fPassGen"
        Me.ShowIcon = False
        Me.Text = "Generador de Contraseñas"
        CType(Me.TrackBarNivelSeg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrackBarNivelSeg As System.Windows.Forms.TrackBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lNivelSeg As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bGenerar As System.Windows.Forms.Button
    Friend WithEvents tbContrasGenerada As System.Windows.Forms.TextBox

End Class
