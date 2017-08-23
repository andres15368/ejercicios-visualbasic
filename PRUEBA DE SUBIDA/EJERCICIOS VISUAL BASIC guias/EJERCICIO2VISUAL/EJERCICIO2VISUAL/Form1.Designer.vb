<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMULARIO
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
        Me.bolectura = New System.Windows.Forms.RadioButton()
        Me.BoEscritura = New System.Windows.Forms.RadioButton()
        Me.bdhColorTexto = New System.Windows.Forms.HScrollBar()
        Me.IsLista = New System.Windows.Forms.ListBox()
        Me.ctDato = New System.Windows.Forms.TextBox()
        Me.btAñadir = New System.Windows.Forms.Button()
        Me.CVcursiva = New System.Windows.Forms.CheckBox()
        Me.barrademenu = New System.Windows.Forms.MenuStrip()
        Me.mnuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.itOpcionesColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.itOPcionesSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.itAyudaAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.barrademenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'bolectura
        '
        Me.bolectura.AutoSize = True
        Me.bolectura.Location = New System.Drawing.Point(20, 84)
        Me.bolectura.Name = "bolectura"
        Me.bolectura.Size = New System.Drawing.Size(166, 20)
        Me.bolectura.TabIndex = 0
        Me.bolectura.Text = "caja de texto solo lectura"
        Me.bolectura.UseVisualStyleBackColor = True
        '
        'BoEscritura
        '
        Me.BoEscritura.AutoSize = True
        Me.BoEscritura.Checked = True
        Me.BoEscritura.Location = New System.Drawing.Point(20, 118)
        Me.BoEscritura.Name = "BoEscritura"
        Me.BoEscritura.Size = New System.Drawing.Size(161, 20)
        Me.BoEscritura.TabIndex = 2
        Me.BoEscritura.TabStop = True
        Me.BoEscritura.Text = "Caja de lectura/escritura"
        Me.BoEscritura.UseVisualStyleBackColor = True
        '
        'bdhColorTexto
        '
        Me.bdhColorTexto.Location = New System.Drawing.Point(9, 159)
        Me.bdhColorTexto.Maximum = 255
        Me.bdhColorTexto.Name = "bdhColorTexto"
        Me.bdhColorTexto.Size = New System.Drawing.Size(310, 19)
        Me.bdhColorTexto.TabIndex = 3
        Me.bdhColorTexto.TabStop = True
        '
        'IsLista
        '
        Me.IsLista.FormattingEnabled = True
        Me.IsLista.ItemHeight = 16
        Me.IsLista.Location = New System.Drawing.Point(199, 20)
        Me.IsLista.Name = "IsLista"
        Me.IsLista.Size = New System.Drawing.Size(120, 84)
        Me.IsLista.TabIndex = 4
        '
        'ctDato
        '
        Me.ctDato.Location = New System.Drawing.Point(20, 27)
        Me.ctDato.Name = "ctDato"
        Me.ctDato.Size = New System.Drawing.Size(161, 23)
        Me.ctDato.TabIndex = 5
        '
        'btAñadir
        '
        Me.btAñadir.Location = New System.Drawing.Point(199, 118)
        Me.btAñadir.Name = "btAñadir"
        Me.btAñadir.Size = New System.Drawing.Size(120, 38)
        Me.btAñadir.TabIndex = 6
        Me.btAñadir.Text = "AÑADIR"
        Me.btAñadir.UseVisualStyleBackColor = True
        '
        'CVcursiva
        '
        Me.CVcursiva.AutoSize = True
        Me.CVcursiva.Location = New System.Drawing.Point(20, 58)
        Me.CVcursiva.Name = "CVcursiva"
        Me.CVcursiva.Size = New System.Drawing.Size(78, 20)
        Me.CVcursiva.TabIndex = 7
        Me.CVcursiva.Text = "CURSIVA"
        Me.CVcursiva.UseVisualStyleBackColor = True
        '
        'barrademenu
        '
        Me.barrademenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpciones, Me.mnuAyuda})
        Me.barrademenu.Location = New System.Drawing.Point(0, 0)
        Me.barrademenu.Name = "barrademenu"
        Me.barrademenu.Size = New System.Drawing.Size(331, 24)
        Me.barrademenu.TabIndex = 8
        '
        'mnuOpciones
        '
        Me.mnuOpciones.Checked = True
        Me.mnuOpciones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itOpcionesColor, Me.itOPcionesSalir})
        Me.mnuOpciones.Name = "mnuOpciones"
        Me.mnuOpciones.Size = New System.Drawing.Size(69, 20)
        Me.mnuOpciones.Text = "&Opciones"
        '
        'itOpcionesColor
        '
        Me.itOpcionesColor.Name = "itOpcionesColor"
        Me.itOpcionesColor.Size = New System.Drawing.Size(200, 22)
        Me.itOpcionesColor.Text = "&Color de la caja de texto"
        '
        'itOPcionesSalir
        '
        Me.itOPcionesSalir.Checked = True
        Me.itOPcionesSalir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.itOPcionesSalir.Name = "itOPcionesSalir"
        Me.itOPcionesSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.itOPcionesSalir.Size = New System.Drawing.Size(200, 22)
        Me.itOPcionesSalir.Text = "- &Salir                  "
        '
        'mnuAyuda
        '
        Me.mnuAyuda.Checked = True
        Me.mnuAyuda.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itAyudaAcercaDe})
        Me.mnuAyuda.Name = "mnuAyuda"
        Me.mnuAyuda.Size = New System.Drawing.Size(53, 20)
        Me.mnuAyuda.Text = "Ay&uda"
        '
        'itAyudaAcercaDe
        '
        Me.itAyudaAcercaDe.Name = "itAyudaAcercaDe"
        Me.itAyudaAcercaDe.Size = New System.Drawing.Size(152, 22)
        Me.itAyudaAcercaDe.Text = "&Acerca de…"
        '
        'dlgColor
        '
        Me.dlgColor.AllowFullOpen = False
        '
        'FORMULARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 220)
        Me.Controls.Add(Me.CVcursiva)
        Me.Controls.Add(Me.btAñadir)
        Me.Controls.Add(Me.ctDato)
        Me.Controls.Add(Me.IsLista)
        Me.Controls.Add(Me.bdhColorTexto)
        Me.Controls.Add(Me.BoEscritura)
        Me.Controls.Add(Me.bolectura)
        Me.Controls.Add(Me.barrademenu)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.barrademenu
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FORMULARIO"
        Me.Text = "CONTROLES"
        Me.barrademenu.ResumeLayout(False)
        Me.barrademenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bolectura As RadioButton
    Friend WithEvents BoEscritura As RadioButton
    Friend WithEvents bdhColorTexto As HScrollBar
    Friend WithEvents IsLista As ListBox
    Friend WithEvents ctDato As TextBox
    Friend WithEvents btAñadir As Button
    Friend WithEvents CVcursiva As CheckBox
    Friend WithEvents barrademenu As MenuStrip
    Friend WithEvents mnuOpciones As ToolStripMenuItem
    Friend WithEvents itOpcionesColor As ToolStripMenuItem
    Friend WithEvents itOPcionesSalir As ToolStripMenuItem
    Friend WithEvents mnuAyuda As ToolStripMenuItem
    Friend WithEvents itAyudaAcercaDe As ToolStripMenuItem
    Friend WithEvents dlgColor As ColorDialog
End Class
