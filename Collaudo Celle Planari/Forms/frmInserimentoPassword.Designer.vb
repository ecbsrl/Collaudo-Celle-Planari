<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInserimentoPassword
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.labDescrizione = New System.Windows.Forms.Label()
        Me.chkNascondiCaratteri = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(215, 106)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 50)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulla.Location = New System.Drawing.Point(105, 106)
        Me.btnAnnulla.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(100, 50)
        Me.btnAnnulla.TabIndex = 6
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(10, 40)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(400, 26)
        Me.tbPassword.TabIndex = 5
        '
        'labDescrizione
        '
        Me.labDescrizione.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDescrizione.Location = New System.Drawing.Point(10, 10)
        Me.labDescrizione.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrizione.Name = "labDescrizione"
        Me.labDescrizione.Size = New System.Drawing.Size(400, 20)
        Me.labDescrizione.TabIndex = 4
        Me.labDescrizione.Text = "Descrizione"
        Me.labDescrizione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkNascondiCaratteri
        '
        Me.chkNascondiCaratteri.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNascondiCaratteri.Location = New System.Drawing.Point(10, 76)
        Me.chkNascondiCaratteri.Margin = New System.Windows.Forms.Padding(5)
        Me.chkNascondiCaratteri.Name = "chkNascondiCaratteri"
        Me.chkNascondiCaratteri.Size = New System.Drawing.Size(400, 20)
        Me.chkNascondiCaratteri.TabIndex = 8
        Me.chkNascondiCaratteri.Text = "Nascondi caratteri"
        Me.chkNascondiCaratteri.UseVisualStyleBackColor = True
        '
        'frmInserimentoPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 172)
        Me.Controls.Add(Me.chkNascondiCaratteri)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.labDescrizione)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInserimentoPassword"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inserimento password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnAnnulla As System.Windows.Forms.Button
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents labDescrizione As System.Windows.Forms.Label
    Friend WithEvents chkNascondiCaratteri As System.Windows.Forms.CheckBox
End Class
