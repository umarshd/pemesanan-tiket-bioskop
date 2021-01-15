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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selectStudio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.selectFilm = New System.Windows.Forms.TextBox()
        Me.jamTayang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.htmFilm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jumlahTiket = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.popCorn = New System.Windows.Forms.CheckBox()
        Me.jumlahPopCorn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jumlahSoftDrink = New System.Windows.Forms.TextBox()
        Me.softDrink = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.jumlahBiaya = New System.Windows.Forms.TextBox()
        Me.printTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Studio"
        '
        'selectStudio
        '
        Me.selectStudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectStudio.FormattingEnabled = True
        Me.selectStudio.Location = New System.Drawing.Point(243, 75)
        Me.selectStudio.Name = "selectStudio"
        Me.selectStudio.Size = New System.Drawing.Size(121, 28)
        Me.selectStudio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Judul Film"
        '
        'selectFilm
        '
        Me.selectFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectFilm.Location = New System.Drawing.Point(243, 123)
        Me.selectFilm.Name = "selectFilm"
        Me.selectFilm.Size = New System.Drawing.Size(362, 26)
        Me.selectFilm.TabIndex = 3
        '
        'jamTayang
        '
        Me.jamTayang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jamTayang.Location = New System.Drawing.Point(243, 165)
        Me.jamTayang.Name = "jamTayang"
        Me.jamTayang.Size = New System.Drawing.Size(362, 26)
        Me.jamTayang.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jam Tayang"
        '
        'htmFilm
        '
        Me.htmFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.htmFilm.Location = New System.Drawing.Point(243, 205)
        Me.htmFilm.Name = "htmFilm"
        Me.htmFilm.Size = New System.Drawing.Size(362, 26)
        Me.htmFilm.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Harga Tiket Masuk"
        '
        'jumlahTiket
        '
        Me.jumlahTiket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlahTiket.Location = New System.Drawing.Point(243, 247)
        Me.jumlahTiket.Name = "jumlahTiket"
        Me.jumlahTiket.Size = New System.Drawing.Size(362, 26)
        Me.jumlahTiket.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Jumlah Tiket Dibeli"
        '
        'popCorn
        '
        Me.popCorn.AutoSize = True
        Me.popCorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.popCorn.Location = New System.Drawing.Point(243, 312)
        Me.popCorn.Name = "popCorn"
        Me.popCorn.Size = New System.Drawing.Size(94, 24)
        Me.popCorn.TabIndex = 10
        Me.popCorn.Text = "Pop Corn"
        Me.popCorn.UseVisualStyleBackColor = True
        '
        'jumlahPopCorn
        '
        Me.jumlahPopCorn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlahPopCorn.Location = New System.Drawing.Point(560, 306)
        Me.jumlahPopCorn.Name = "jumlahPopCorn"
        Me.jumlahPopCorn.Size = New System.Drawing.Size(45, 26)
        Me.jumlahPopCorn.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Jumlah :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(428, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Jumlah :"
        '
        'jumlahSoftDrink
        '
        Me.jumlahSoftDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlahSoftDrink.Location = New System.Drawing.Point(560, 338)
        Me.jumlahSoftDrink.Name = "jumlahSoftDrink"
        Me.jumlahSoftDrink.Size = New System.Drawing.Size(45, 26)
        Me.jumlahSoftDrink.TabIndex = 14
        '
        'softDrink
        '
        Me.softDrink.AutoSize = True
        Me.softDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.softDrink.Location = New System.Drawing.Point(243, 344)
        Me.softDrink.Name = "softDrink"
        Me.softDrink.Size = New System.Drawing.Size(99, 24)
        Me.softDrink.TabIndex = 13
        Me.softDrink.Text = "Soft Drink"
        Me.softDrink.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(501, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 37)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Proses"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'jumlahBiaya
        '
        Me.jumlahBiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlahBiaya.Location = New System.Drawing.Point(432, 374)
        Me.jumlahBiaya.Name = "jumlahBiaya"
        Me.jumlahBiaya.Size = New System.Drawing.Size(173, 26)
        Me.jumlahBiaya.TabIndex = 17
        '
        'printTotal
        '
        Me.printTotal.AutoSize = True
        Me.printTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printTotal.Location = New System.Drawing.Point(239, 380)
        Me.printTotal.Name = "printTotal"
        Me.printTotal.Size = New System.Drawing.Size(87, 20)
        Me.printTotal.TabIndex = 18
        Me.printTotal.Text = "Total Biaya"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(725, 478)
        Me.Controls.Add(Me.printTotal)
        Me.Controls.Add(Me.jumlahBiaya)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.jumlahSoftDrink)
        Me.Controls.Add(Me.softDrink)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.jumlahPopCorn)
        Me.Controls.Add(Me.popCorn)
        Me.Controls.Add(Me.jumlahTiket)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.htmFilm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.jamTayang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.selectFilm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.selectStudio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pembelian Tiket Nonton Film"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents selectStudio As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents selectFilm As System.Windows.Forms.TextBox
    Friend WithEvents jamTayang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents htmFilm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents jumlahTiket As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents popCorn As System.Windows.Forms.CheckBox
    Friend WithEvents jumlahPopCorn As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents jumlahSoftDrink As System.Windows.Forms.TextBox
    Friend WithEvents softDrink As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents jumlahBiaya As System.Windows.Forms.TextBox
    Friend WithEvents printTotal As System.Windows.Forms.Label

End Class
