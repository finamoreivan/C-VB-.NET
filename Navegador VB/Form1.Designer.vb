<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bRojo = New System.Windows.Forms.Button()
        Me.bVerde = New System.Windows.Forms.Button()
        Me.bAzul = New System.Windows.Forms.Button()
        Me.bVer = New System.Windows.Forms.Button()
        Me.bIr = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'tBuscar
        '
        Me.tBuscar.Location = New System.Drawing.Point(151, 14)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(329, 20)
        Me.tBuscar.TabIndex = 0
        '
        'bBuscar
        '
        Me.bBuscar.Location = New System.Drawing.Point(151, 49)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(138, 23)
        Me.bBuscar.TabIndex = 1
        Me.bBuscar.Text = "Buscar en Google"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Escriba"
        '
        'bRojo
        '
        Me.bRojo.BackColor = System.Drawing.Color.Red
        Me.bRojo.CausesValidation = False
        Me.bRojo.ForeColor = System.Drawing.Color.White
        Me.bRojo.Location = New System.Drawing.Point(504, 14)
        Me.bRojo.Name = "bRojo"
        Me.bRojo.Size = New System.Drawing.Size(75, 23)
        Me.bRojo.TabIndex = 3
        Me.bRojo.Text = "Rojo"
        Me.bRojo.UseVisualStyleBackColor = False
        '
        'bVerde
        '
        Me.bVerde.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bVerde.ForeColor = System.Drawing.Color.White
        Me.bVerde.Location = New System.Drawing.Point(504, 43)
        Me.bVerde.Name = "bVerde"
        Me.bVerde.Size = New System.Drawing.Size(75, 23)
        Me.bVerde.TabIndex = 4
        Me.bVerde.Text = "Verde"
        Me.bVerde.UseVisualStyleBackColor = False
        '
        'bAzul
        '
        Me.bAzul.BackColor = System.Drawing.Color.Blue
        Me.bAzul.ForeColor = System.Drawing.Color.White
        Me.bAzul.Location = New System.Drawing.Point(504, 72)
        Me.bAzul.Name = "bAzul"
        Me.bAzul.Size = New System.Drawing.Size(75, 23)
        Me.bAzul.TabIndex = 5
        Me.bAzul.Text = "Azul"
        Me.bAzul.UseVisualStyleBackColor = False
        '
        'bVer
        '
        Me.bVer.Location = New System.Drawing.Point(596, 14)
        Me.bVer.Name = "bVer"
        Me.bVer.Size = New System.Drawing.Size(75, 23)
        Me.bVer.TabIndex = 6
        Me.bVer.Text = "Ver"
        Me.bVer.UseVisualStyleBackColor = True
        '
        'bIr
        '
        Me.bIr.Location = New System.Drawing.Point(340, 49)
        Me.bIr.Name = "bIr"
        Me.bIr.Size = New System.Drawing.Size(140, 23)
        Me.bIr.TabIndex = 7
        Me.bIr.Text = "Ir a la URL"
        Me.bIr.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 96)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(768, 366)
        Me.WebBrowser1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 474)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.bIr)
        Me.Controls.Add(Me.bVer)
        Me.Controls.Add(Me.bAzul)
        Me.Controls.Add(Me.bVerde)
        Me.Controls.Add(Me.bRojo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.tBuscar)
        Me.Name = "Form1"
        Me.Text = "Busqueda en Google - VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tBuscar As TextBox
    Friend WithEvents bBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents bRojo As Button
    Friend WithEvents bVerde As Button
    Friend WithEvents bAzul As Button
    Friend WithEvents bVer As Button
    Friend WithEvents bIr As Button
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
