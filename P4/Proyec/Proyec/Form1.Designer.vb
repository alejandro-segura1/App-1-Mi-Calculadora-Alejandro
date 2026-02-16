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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Sumar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Restar = New System.Windows.Forms.Button()
        Me.Multiplicar = New System.Windows.Forms.Button()
        Me.Dividir = New System.Windows.Forms.Button()
        Me.Uno = New System.Windows.Forms.Button()
        Me.Dos = New System.Windows.Forms.Button()
        Me.Tres = New System.Windows.Forms.Button()
        Me.Seis = New System.Windows.Forms.Button()
        Me.Cinco = New System.Windows.Forms.Button()
        Me.Cuatro = New System.Windows.Forms.Button()
        Me.Nueve = New System.Windows.Forms.Button()
        Me.Ocho = New System.Windows.Forms.Button()
        Me.Siete = New System.Windows.Forms.Button()
        Me.Cero = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Punto = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(38, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(38, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero 2:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(198, 173)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "0"
        '
        'Sumar
        '
        Me.Sumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sumar.Location = New System.Drawing.Point(807, 41)
        Me.Sumar.Name = "Sumar"
        Me.Sumar.Size = New System.Drawing.Size(129, 50)
        Me.Sumar.TabIndex = 4
        Me.Sumar.Text = "Sumar"
        Me.Sumar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(38, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(192, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "0"
        '
        'Restar
        '
        Me.Restar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Restar.Location = New System.Drawing.Point(807, 101)
        Me.Restar.Name = "Restar"
        Me.Restar.Size = New System.Drawing.Size(129, 50)
        Me.Restar.TabIndex = 7
        Me.Restar.Text = "Restar"
        Me.Restar.UseVisualStyleBackColor = True
        '
        'Multiplicar
        '
        Me.Multiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplicar.Location = New System.Drawing.Point(807, 161)
        Me.Multiplicar.Name = "Multiplicar"
        Me.Multiplicar.Size = New System.Drawing.Size(129, 50)
        Me.Multiplicar.TabIndex = 8
        Me.Multiplicar.Text = "Multiplicar"
        Me.Multiplicar.UseVisualStyleBackColor = True
        '
        'Dividir
        '
        Me.Dividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dividir.Location = New System.Drawing.Point(807, 226)
        Me.Dividir.Name = "Dividir"
        Me.Dividir.Size = New System.Drawing.Size(129, 50)
        Me.Dividir.TabIndex = 9
        Me.Dividir.Text = "Dividir"
        Me.Dividir.UseVisualStyleBackColor = True
        '
        'Uno
        '
        Me.Uno.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uno.Location = New System.Drawing.Point(514, 198)
        Me.Uno.Name = "Uno"
        Me.Uno.Size = New System.Drawing.Size(74, 62)
        Me.Uno.TabIndex = 10
        Me.Uno.Text = "1"
        Me.Uno.UseVisualStyleBackColor = True
        '
        'Dos
        '
        Me.Dos.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dos.Location = New System.Drawing.Point(608, 198)
        Me.Dos.Name = "Dos"
        Me.Dos.Size = New System.Drawing.Size(74, 62)
        Me.Dos.TabIndex = 11
        Me.Dos.Text = "2"
        Me.Dos.UseVisualStyleBackColor = True
        '
        'Tres
        '
        Me.Tres.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tres.Location = New System.Drawing.Point(706, 198)
        Me.Tres.Name = "Tres"
        Me.Tres.Size = New System.Drawing.Size(74, 62)
        Me.Tres.TabIndex = 12
        Me.Tres.Text = "3"
        Me.Tres.UseVisualStyleBackColor = True
        '
        'Seis
        '
        Me.Seis.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seis.Location = New System.Drawing.Point(706, 118)
        Me.Seis.Name = "Seis"
        Me.Seis.Size = New System.Drawing.Size(74, 62)
        Me.Seis.TabIndex = 15
        Me.Seis.Text = "6"
        Me.Seis.UseVisualStyleBackColor = True
        '
        'Cinco
        '
        Me.Cinco.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cinco.Location = New System.Drawing.Point(608, 118)
        Me.Cinco.Name = "Cinco"
        Me.Cinco.Size = New System.Drawing.Size(74, 62)
        Me.Cinco.TabIndex = 14
        Me.Cinco.Text = "5"
        Me.Cinco.UseVisualStyleBackColor = True
        '
        'Cuatro
        '
        Me.Cuatro.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuatro.Location = New System.Drawing.Point(514, 118)
        Me.Cuatro.Name = "Cuatro"
        Me.Cuatro.Size = New System.Drawing.Size(74, 62)
        Me.Cuatro.TabIndex = 13
        Me.Cuatro.Text = "4"
        Me.Cuatro.UseVisualStyleBackColor = True
        '
        'Nueve
        '
        Me.Nueve.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nueve.Location = New System.Drawing.Point(706, 41)
        Me.Nueve.Name = "Nueve"
        Me.Nueve.Size = New System.Drawing.Size(74, 62)
        Me.Nueve.TabIndex = 18
        Me.Nueve.Text = "9"
        Me.Nueve.UseVisualStyleBackColor = True
        '
        'Ocho
        '
        Me.Ocho.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ocho.Location = New System.Drawing.Point(608, 41)
        Me.Ocho.Name = "Ocho"
        Me.Ocho.Size = New System.Drawing.Size(74, 62)
        Me.Ocho.TabIndex = 17
        Me.Ocho.Text = "8"
        Me.Ocho.UseVisualStyleBackColor = True
        '
        'Siete
        '
        Me.Siete.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Siete.Location = New System.Drawing.Point(514, 41)
        Me.Siete.Name = "Siete"
        Me.Siete.Size = New System.Drawing.Size(74, 62)
        Me.Siete.TabIndex = 16
        Me.Siete.Text = "7"
        Me.Siete.UseVisualStyleBackColor = True
        '
        'Cero
        '
        Me.Cero.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cero.Location = New System.Drawing.Point(608, 279)
        Me.Cero.Name = "Cero"
        Me.Cero.Size = New System.Drawing.Size(74, 62)
        Me.Cero.TabIndex = 19
        Me.Cero.Text = "0"
        Me.Cero.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.Location = New System.Drawing.Point(807, 291)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(129, 50)
        Me.Borrar.TabIndex = 20
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Punto
        '
        Me.Punto.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Punto.Location = New System.Drawing.Point(706, 279)
        Me.Punto.Name = "Punto"
        Me.Punto.Size = New System.Drawing.Size(74, 62)
        Me.Punto.TabIndex = 21
        Me.Punto.Text = "."
        Me.Punto.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton1.Location = New System.Drawing.Point(44, 310)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(93, 20)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Numero 1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton2.Location = New System.Drawing.Point(44, 333)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(93, 20)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Numero 2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(979, 390)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Punto)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Cero)
        Me.Controls.Add(Me.Nueve)
        Me.Controls.Add(Me.Ocho)
        Me.Controls.Add(Me.Siete)
        Me.Controls.Add(Me.Seis)
        Me.Controls.Add(Me.Cinco)
        Me.Controls.Add(Me.Cuatro)
        Me.Controls.Add(Me.Tres)
        Me.Controls.Add(Me.Dos)
        Me.Controls.Add(Me.Uno)
        Me.Controls.Add(Me.Dividir)
        Me.Controls.Add(Me.Multiplicar)
        Me.Controls.Add(Me.Restar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Sumar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "A"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Sumar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Restar As Button
    Friend WithEvents Multiplicar As Button
    Friend WithEvents Dividir As Button
    Friend WithEvents Uno As Button
    Friend WithEvents Dos As Button
    Friend WithEvents Tres As Button
    Friend WithEvents Seis As Button
    Friend WithEvents Cinco As Button
    Friend WithEvents Cuatro As Button
    Friend WithEvents Nueve As Button
    Friend WithEvents Ocho As Button
    Friend WithEvents Siete As Button
    Friend WithEvents Cero As Button
    Friend WithEvents Borrar As Button
    Friend WithEvents Punto As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
