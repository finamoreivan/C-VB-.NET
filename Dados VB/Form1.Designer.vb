<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Cubilete = New System.Windows.Forms.PictureBox()
        Me.Dado1 = New System.Windows.Forms.PictureBox()
        Me.Dado2 = New System.Windows.Forms.PictureBox()
        Me.Dado3 = New System.Windows.Forms.PictureBox()
        Me.Dado4 = New System.Windows.Forms.PictureBox()
        Me.Dado5 = New System.Windows.Forms.PictureBox()
        Me.Tirar = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cubilete
        '
        Me.Cubilete.BackColor = System.Drawing.Color.Transparent
        Me.Cubilete.Location = New System.Drawing.Point(460, 12)
        Me.Cubilete.Name = "Cubilete"
        Me.Cubilete.Size = New System.Drawing.Size(326, 277)
        Me.Cubilete.TabIndex = 1
        Me.Cubilete.TabStop = False
        '
        'Dado1
        '
        Me.Dado1.BackgroundImage = Global.Dados_VB.My.Resources.Resources.dado6
        Me.Dado1.Location = New System.Drawing.Point(98, 110)
        Me.Dado1.Name = "Dado1"
        Me.Dado1.Size = New System.Drawing.Size(94, 95)
        Me.Dado1.TabIndex = 2
        Me.Dado1.TabStop = False
        '
        'Dado2
        '
        Me.Dado2.BackgroundImage = Global.Dados_VB.My.Resources.Resources.dado6
        Me.Dado2.Location = New System.Drawing.Point(237, 180)
        Me.Dado2.Name = "Dado2"
        Me.Dado2.Size = New System.Drawing.Size(94, 95)
        Me.Dado2.TabIndex = 3
        Me.Dado2.TabStop = False
        '
        'Dado3
        '
        Me.Dado3.BackgroundImage = Global.Dados_VB.My.Resources.Resources.dado6
        Me.Dado3.Location = New System.Drawing.Point(360, 238)
        Me.Dado3.Name = "Dado3"
        Me.Dado3.Size = New System.Drawing.Size(94, 95)
        Me.Dado3.TabIndex = 4
        Me.Dado3.TabStop = False
        '
        'Dado4
        '
        Me.Dado4.BackgroundImage = Global.Dados_VB.My.Resources.Resources.dado6
        Me.Dado4.Location = New System.Drawing.Point(98, 238)
        Me.Dado4.Name = "Dado4"
        Me.Dado4.Size = New System.Drawing.Size(94, 95)
        Me.Dado4.TabIndex = 5
        Me.Dado4.TabStop = False
        '
        'Dado5
        '
        Me.Dado5.BackgroundImage = Global.Dados_VB.My.Resources.Resources.dado6
        Me.Dado5.Location = New System.Drawing.Point(237, 321)
        Me.Dado5.Name = "Dado5"
        Me.Dado5.Size = New System.Drawing.Size(94, 95)
        Me.Dado5.TabIndex = 6
        Me.Dado5.TabStop = False
        '
        'Tirar
        '
        Me.Tirar.AutoSize = True
        Me.Tirar.BackColor = System.Drawing.Color.Red
        Me.Tirar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tirar.ForeColor = System.Drawing.Color.White
        Me.Tirar.Location = New System.Drawing.Point(162, 12)
        Me.Tirar.Name = "Tirar"
        Me.Tirar.Size = New System.Drawing.Size(292, 20)
        Me.Tirar.TabIndex = 7
        Me.Tirar.Text = "Click en el cubilete para tirar >>>>>"
        Me.Tirar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(658, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 54)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dados_VB.My.Resources.Resources.mesa
        Me.ClientSize = New System.Drawing.Size(784, 503)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tirar)
        Me.Controls.Add(Me.Dado5)
        Me.Controls.Add(Me.Dado4)
        Me.Controls.Add(Me.Dado3)
        Me.Controls.Add(Me.Dado2)
        Me.Controls.Add(Me.Dado1)
        Me.Controls.Add(Me.Cubilete)
        Me.Name = "Form1"
        Me.Text = "Generala VB"
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cubilete As PictureBox
    Friend WithEvents Dado1 As PictureBox
    Friend WithEvents Dado2 As PictureBox
    Friend WithEvents Dado3 As PictureBox
    Friend WithEvents Dado4 As PictureBox
    Friend WithEvents Dado5 As PictureBox
    Friend WithEvents Tirar As Label
    Friend WithEvents Button1 As Button
End Class
