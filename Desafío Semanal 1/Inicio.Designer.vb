<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.bIniciar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bIniciar
        '
        Me.bIniciar.BackColor = System.Drawing.Color.Blue
        Me.bIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bIniciar.ForeColor = System.Drawing.Color.Yellow
        Me.bIniciar.Location = New System.Drawing.Point(674, 337)
        Me.bIniciar.Name = "bIniciar"
        Me.bIniciar.Size = New System.Drawing.Size(130, 35)
        Me.bIniciar.TabIndex = 0
        Me.bIniciar.Text = "Iniciar Aventura"
        Me.bIniciar.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.Blue
        Me.bSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.ForeColor = System.Drawing.Color.Yellow
        Me.bSalir.Location = New System.Drawing.Point(674, 378)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(130, 35)
        Me.bSalir.TabIndex = 1
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(825, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bIniciar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Dungeon and Dragons"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bIniciar As Button
    Friend WithEvents bSalir As Button
End Class
