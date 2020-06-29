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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Служител на смяна"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Анна Николова", "Атанас Иванов", "Венета Огнянова", "Владимир Петков", "Вяра Джамбазова"})
        Me.ComboBox1.Location = New System.Drawing.Point(49, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(190, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'PlayersBindingSource
        '
        Me.PlayersBindingSource.AllowNew = True
        Me.PlayersBindingSource.DataMember = "players"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Игра"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Тенис на маса", "Флипер", "Билярд", "Боулинг", "Въздупен хокей", "Мини футбол", "Дартс", "3D симулатор"})
        Me.ComboBox2.Location = New System.Drawing.Point(49, 137)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(190, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(343, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 43)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Касова бележка"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(49, 221)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 179)
        Me.TextBox1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(621, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Форма за служители"
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
