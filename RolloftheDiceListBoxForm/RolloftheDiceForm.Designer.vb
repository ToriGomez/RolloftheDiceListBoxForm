<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RolloftheDiceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolloftheDiceListBox = New System.Windows.Forms.ListBox()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.RolloftheDiceToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(1124, 52)
        Me.TopMenuStrip.TabIndex = 4
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'MenuTopMenuItem
        '
        Me.MenuTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RollTopMenuItem, Me.ClearTopMenuItem, Me.ExitTopMenuItem})
        Me.MenuTopMenuItem.Name = "MenuTopMenuItem"
        Me.MenuTopMenuItem.Size = New System.Drawing.Size(119, 48)
        Me.MenuTopMenuItem.Text = "&Menu"
        '
        'RollTopMenuItem
        '
        Me.RollTopMenuItem.Name = "RollTopMenuItem"
        Me.RollTopMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.RollTopMenuItem.Text = "&Roll"
        Me.RollTopMenuItem.ToolTipText = "Shortcut to Roll Control."
        '
        'ClearTopMenuItem
        '
        Me.ClearTopMenuItem.Name = "ClearTopMenuItem"
        Me.ClearTopMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.ClearTopMenuItem.Text = "&Clear"
        Me.ClearTopMenuItem.ToolTipText = "Shortcut to Clear Control."
        '
        'ExitTopMenuItem
        '
        Me.ExitTopMenuItem.Name = "ExitTopMenuItem"
        Me.ExitTopMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.ExitTopMenuItem.Text = "&Exit"
        Me.ExitTopMenuItem.ToolTipText = "Shortcut to Exit Control."
        '
        'HelpTopMenuItem
        '
        Me.HelpTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuItem})
        Me.HelpTopMenuItem.Name = "HelpTopMenuItem"
        Me.HelpTopMenuItem.Size = New System.Drawing.Size(104, 48)
        Me.HelpTopMenuItem.Text = "&Help"
        '
        'AboutTopMenuItem
        '
        Me.AboutTopMenuItem.Name = "AboutTopMenuItem"
        Me.AboutTopMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.AboutTopMenuItem.Text = "&About"
        Me.AboutTopMenuItem.ToolTipText = "Program Description."
        '
        'RolloftheDiceListBox
        '
        Me.RolloftheDiceListBox.Font = New System.Drawing.Font("Consolas", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RolloftheDiceListBox.FormattingEnabled = True
        Me.RolloftheDiceListBox.ItemHeight = 32
        Me.RolloftheDiceListBox.Location = New System.Drawing.Point(56, 106)
        Me.RolloftheDiceListBox.Name = "RolloftheDiceListBox"
        Me.RolloftheDiceListBox.Size = New System.Drawing.Size(978, 388)
        Me.RolloftheDiceListBox.TabIndex = 1
        Me.RolloftheDiceToolTip.SetToolTip(Me.RolloftheDiceListBox, "Display of the rolled dice.")
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(203, 540)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(249, 156)
        Me.RollButton.TabIndex = 0
        Me.RollButton.Text = "&Roll"
        Me.RolloftheDiceToolTip.SetToolTip(Me.RollButton, "Enter Roll to see results of two dice rolled 1000 times.")
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(495, 540)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(249, 156)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.RolloftheDiceToolTip.SetToolTip(Me.ClearButton, "Enter Clear to reset the rolled dice.")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(785, 540)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(249, 156)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "&Exit"
        Me.RolloftheDiceToolTip.SetToolTip(Me.ExitButton, "Enter Exit to close the program.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RolloftheDiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 769)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.RolloftheDiceListBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "RolloftheDiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roll of the Dice"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents MenuTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents RollTopMenuItem As ToolStripMenuItem
    Friend WithEvents ClearTopMenuItem As ToolStripMenuItem
    Friend WithEvents ExitTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents RolloftheDiceListBox As ListBox
    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents RolloftheDiceToolTip As ToolTip
End Class
