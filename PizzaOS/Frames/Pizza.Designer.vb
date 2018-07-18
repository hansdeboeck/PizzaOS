<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pizza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pizza))
        Me.TimerUUR = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMIN = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSEC = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PizzaNotify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PizzaMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AfsluitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstellingenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PizzaLogBox = New System.Windows.Forms.RichTextBox()
        Me.PizzaMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerMIN
        '
        '
        'BackgroundWorker1
        '
        '
        'PizzaNotify
        '
        Me.PizzaNotify.ContextMenuStrip = Me.PizzaMenu
        Me.PizzaNotify.Icon = CType(resources.GetObject("PizzaNotify.Icon"), System.Drawing.Icon)
        Me.PizzaNotify.Text = "PizzaOS"
        Me.PizzaNotify.Visible = True
        '
        'PizzaMenu
        '
        Me.PizzaMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfsluitenToolStripMenuItem, Me.InstellingenToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.PizzaMenu.Name = "PizzaMenu"
        Me.PizzaMenu.Size = New System.Drawing.Size(136, 70)
        '
        'AfsluitenToolStripMenuItem
        '
        Me.AfsluitenToolStripMenuItem.Name = "AfsluitenToolStripMenuItem"
        Me.AfsluitenToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AfsluitenToolStripMenuItem.Text = "Afsluiten"
        '
        'InstellingenToolStripMenuItem
        '
        Me.InstellingenToolStripMenuItem.Name = "InstellingenToolStripMenuItem"
        Me.InstellingenToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.InstellingenToolStripMenuItem.Text = "Instellingen"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'PizzaLogBox
        '
        Me.PizzaLogBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PizzaLogBox.Location = New System.Drawing.Point(0, 0)
        Me.PizzaLogBox.Name = "PizzaLogBox"
        Me.PizzaLogBox.Size = New System.Drawing.Size(587, 319)
        Me.PizzaLogBox.TabIndex = 1
        Me.PizzaLogBox.Text = ""
        '
        'Pizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 319)
        Me.Controls.Add(Me.PizzaLogBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pizza"
        Me.Text = "Pizza"
        Me.PizzaMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TimerUUR As Timer
    Friend WithEvents TimerMIN As Timer
    Friend WithEvents TimerSEC As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PizzaNotify As NotifyIcon
    Friend WithEvents PizzaMenu As ContextMenuStrip
    Friend WithEvents AfsluitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstellingenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PizzaLogBox As RichTextBox
End Class
