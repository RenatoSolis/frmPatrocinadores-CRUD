<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatrocinadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatrocinadores))
        Me.grdLista = New DevExpress.XtraGrid.GridControl()
        Me.vwLista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDenominacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtBusqueda = New DevExpress.XtraEditors.MRUEdit()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUltimoRegistro = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSiguienteRegistro = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAnteriorRegistro = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrimerRegistro = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOrdenarZA = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOrdenarAZ = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsultarRegistro = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminarRegistro = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModificarRegistro = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregarRegistro = New DevExpress.XtraEditors.SimpleButton()
        Me.colDescuentoEnCaja = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vwLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdLista
        '
        Me.grdLista.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdLista.Location = New System.Drawing.Point(0, 89)
        Me.grdLista.MainView = Me.vwLista
        Me.grdLista.Name = "grdLista"
        Me.grdLista.Size = New System.Drawing.Size(706, 321)
        Me.grdLista.TabIndex = 0
        Me.grdLista.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vwLista})
        '
        'vwLista
        '
        Me.vwLista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombre, Me.colDescuentoEnCaja, Me.colDenominacion})
        Me.vwLista.GridControl = Me.grdLista
        Me.vwLista.Name = "vwLista"
        Me.vwLista.OptionsBehavior.AllowIncrementalSearch = True
        Me.vwLista.OptionsBehavior.Editable = False
        Me.vwLista.OptionsNavigation.UseTabKey = False
        Me.vwLista.OptionsSelection.InvertSelection = True
        Me.vwLista.OptionsView.ColumnAutoWidth = False
        Me.vwLista.OptionsView.ShowGroupPanel = False
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        Me.colNombre.Width = 294
        '
        'colDenominacion
        '
        Me.colDenominacion.Caption = "Denominación"
        Me.colDenominacion.FieldName = "Denominacion"
        Me.colDenominacion.Name = "colDenominacion"
        Me.colDenominacion.Visible = True
        Me.colDenominacion.VisibleIndex = 2
        Me.colDenominacion.Width = 292
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.txtBusqueda)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 51)
        Me.Panel1.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(69, 17)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(54, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(122, 14)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBusqueda.Size = New System.Drawing.Size(173, 20)
        Me.txtBusqueda.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.ImageOptions.Image = CType(resources.GetObject("btnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(301, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(90, 23)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "&Buscar"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.btnUltimoRegistro)
        Me.Panel2.Controls.Add(Me.btnSiguienteRegistro)
        Me.Panel2.Controls.Add(Me.btnAnteriorRegistro)
        Me.Panel2.Controls.Add(Me.btnPrimerRegistro)
        Me.Panel2.Controls.Add(Me.btnOrdenarZA)
        Me.Panel2.Controls.Add(Me.btnOrdenarAZ)
        Me.Panel2.Controls.Add(Me.btnConsultarRegistro)
        Me.Panel2.Controls.Add(Me.btnEliminarRegistro)
        Me.Panel2.Controls.Add(Me.btnModificarRegistro)
        Me.Panel2.Controls.Add(Me.btnAgregarRegistro)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(706, 38)
        Me.Panel2.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(457, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(43, 38)
        Me.btnSalir.TabIndex = 11
        '
        'btnUltimoRegistro
        '
        Me.btnUltimoRegistro.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUltimoRegistro.ImageOptions.Image = CType(resources.GetObject("btnUltimoRegistro.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUltimoRegistro.Location = New System.Drawing.Point(411, 0)
        Me.btnUltimoRegistro.Name = "btnUltimoRegistro"
        Me.btnUltimoRegistro.Size = New System.Drawing.Size(46, 38)
        Me.btnUltimoRegistro.TabIndex = 9
        '
        'btnSiguienteRegistro
        '
        Me.btnSiguienteRegistro.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSiguienteRegistro.ImageOptions.Image = CType(resources.GetObject("btnSiguienteRegistro.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSiguienteRegistro.Location = New System.Drawing.Point(365, 0)
        Me.btnSiguienteRegistro.Name = "btnSiguienteRegistro"
        Me.btnSiguienteRegistro.Size = New System.Drawing.Size(46, 38)
        Me.btnSiguienteRegistro.TabIndex = 8
        '
        'btnAnteriorRegistro
        '
        Me.btnAnteriorRegistro.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnteriorRegistro.ImageOptions.Image = CType(resources.GetObject("btnAnteriorRegistro.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAnteriorRegistro.Location = New System.Drawing.Point(319, 0)
        Me.btnAnteriorRegistro.Name = "btnAnteriorRegistro"
        Me.btnAnteriorRegistro.Size = New System.Drawing.Size(46, 38)
        Me.btnAnteriorRegistro.TabIndex = 7
        '
        'btnPrimerRegistro
        '
        Me.btnPrimerRegistro.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrimerRegistro.ImageOptions.Image = CType(resources.GetObject("btnPrimerRegistro.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrimerRegistro.Location = New System.Drawing.Point(273, 0)
        Me.btnPrimerRegistro.Name = "btnPrimerRegistro"
        Me.btnPrimerRegistro.Size = New System.Drawing.Size(46, 38)
        Me.btnPrimerRegistro.TabIndex = 6
        '
        'btnOrdenarZA
        '
        Me.btnOrdenarZA.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOrdenarZA.ImageOptions.Image = CType(resources.GetObject("btnOrdenarZA.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOrdenarZA.Location = New System.Drawing.Point(227, 0)
        Me.btnOrdenarZA.Name = "btnOrdenarZA"
        Me.btnOrdenarZA.Size = New System.Drawing.Size(46, 38)
        Me.btnOrdenarZA.TabIndex = 5
        '
        'btnOrdenarAZ
        '
        Me.btnOrdenarAZ.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOrdenarAZ.ImageOptions.Image = CType(resources.GetObject("btnOrdenarAZ.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOrdenarAZ.Location = New System.Drawing.Point(181, 0)
        Me.btnOrdenarAZ.Name = "btnOrdenarAZ"
        Me.btnOrdenarAZ.Size = New System.Drawing.Size(46, 38)
        Me.btnOrdenarAZ.TabIndex = 4
        '
        'btnConsultarRegistro
        '
        Me.btnConsultarRegistro.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnConsultarRegistro.ImageOptions.Image = CType(resources.GetObject("btnConsultarRegistro.ImageOptions.Image"), System.Drawing.Image)
        Me.btnConsultarRegistro.Location = New System.Drawing.Point(135, 0)
        Me.btnConsultarRegistro.Name = "btnConsultarRegistro"
        Me.btnConsultarRegistro.Size = New System.Drawing.Size(46, 38)
        Me.btnConsultarRegistro.TabIndex = 3
        '
        'btnEliminarRegistro
        '
        Me.btnEliminarRegistro.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminarRegistro.ImageOptions.Image = CType(resources.GetObject("btnEliminarRegistro.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminarRegistro.Location = New System.Drawing.Point(92, 0)
        Me.btnEliminarRegistro.Name = "btnEliminarRegistro"
        Me.btnEliminarRegistro.Size = New System.Drawing.Size(43, 38)
        Me.btnEliminarRegistro.TabIndex = 2
        '
        'btnModificarRegistro
        '
        Me.btnModificarRegistro.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModificarRegistro.ImageOptions.Image = CType(resources.GetObject("btnModificarRegistro.ImageOptions.Image"), System.Drawing.Image)
        Me.btnModificarRegistro.Location = New System.Drawing.Point(46, 0)
        Me.btnModificarRegistro.Name = "btnModificarRegistro"
        Me.btnModificarRegistro.Size = New System.Drawing.Size(46, 38)
        Me.btnModificarRegistro.TabIndex = 1
        '
        'btnAgregarRegistro
        '
        Me.btnAgregarRegistro.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgregarRegistro.ImageOptions.Image = CType(resources.GetObject("btnAgregarRegistro.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregarRegistro.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregarRegistro.Name = "btnAgregarRegistro"
        Me.btnAgregarRegistro.Size = New System.Drawing.Size(46, 38)
        Me.btnAgregarRegistro.TabIndex = 0
        '
        'colDescuentoEnCaja
        '
        Me.colDescuentoEnCaja.Caption = "Descuento en Caja"
        Me.colDescuentoEnCaja.FieldName = "DescuentoEnCaja"
        Me.colDescuentoEnCaja.Name = "colDescuentoEnCaja"
        Me.colDescuentoEnCaja.Visible = True
        Me.colDescuentoEnCaja.VisibleIndex = 1
        Me.colDescuentoEnCaja.Width = 103
        '
        'frmPatrocinadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 410)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdLista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPatrocinadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patrocinadores"
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vwLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdLista As DevExpress.XtraGrid.GridControl
    Friend WithEvents vwLista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.MRUEdit
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDenominacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnAgregarRegistro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsultarRegistro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarRegistro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModificarRegistro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAnteriorRegistro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrimerRegistro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOrdenarZA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOrdenarAZ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUltimoRegistro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSiguienteRegistro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colDescuentoEnCaja As DevExpress.XtraGrid.Columns.GridColumn
End Class
