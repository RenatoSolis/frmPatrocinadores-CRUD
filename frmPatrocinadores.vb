Imports DevExpress.XtraGrid.Views.Grid
Public Class frmPatrocinadores
    Private patrocinadores As New Patrocinadores()
    Dim nombreCampoParaBusqueda As String
    '--------------------------------------------------------------------
    '03/06/2024-Renato Solis
    'Creación de formulario para el crud de patrocinadores 
    '--------------------------------------------------------------------
    Private Sub frmPatrocinadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub
    Public Sub CargarGrilla()

        ' Llama a la función RecuperarRegistrosPatrocinadores de la instancia de Patrocinadores para obtener los datos
        Dim dtPatrocinadores As DataTable = patrocinadores.RecuperarRegistrosPatrocinadores()

        ' Asigna el DataTable recuperado como DataSource del GridControl
        grdLista.DataSource = dtPatrocinadores

        ' Establece el nombre del campo para búsqueda
        nombreCampoParaBusqueda = "Nombre"

        ' Configura el orden de las columnas
        If vwLista.FocusedColumn Is Nothing Then
            nombreCampoParaBusqueda = "Nombre"
            vwLista.Columns("Nombre").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        Else
            vwLista.FocusedColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnAgregarRegistro_Click(sender As Object, e As EventArgs) Handles btnAgregarRegistro.Click
        Dim frm As New frmPatrocinador(New Patrocinadores(), False)
        If frm.ShowDialog() = DialogResult.OK Then
            CargarGrilla()
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        ' Obtiene la vista de la grilla
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grdLista.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim textoBusqueda As String = txtBusqueda.Text.Trim()

        ' Si el texto de búsqueda está vacío, restablecer la grilla
        If String.IsNullOrEmpty(textoBusqueda) Then
            view.ActiveFilter.Clear() ' Elimina cualquier filtro aplicado
            CargarGrilla()
            Return
        End If

        ' Aplicar el filtro a la columna "Nombre"
        view.ActiveFilter.Clear()
        view.ActiveFilter.Add(view.Columns("Nombre"),
                         New DevExpress.XtraGrid.Columns.ColumnFilterInfo("[Nombre] LIKE '%" & textoBusqueda & "%'"))

        ' Mover el enfoque a la primera fila que coincide con el filtro
        If view.RowCount > 0 Then
            view.FocusedRowHandle = 0
            view.SelectRow(0)
            view.MakeRowVisible(0)
        End If
    End Sub


    Private Sub btnModificarRegistro_Click(sender As Object, e As EventArgs) Handles btnModificarRegistro.Click
        If vwLista.SelectedRowsCount > 0 Then
            Dim filaSeleccionada As DataRow = vwLista.GetDataRow(vwLista.FocusedRowHandle)
            Dim patrocinador As New Patrocinadores()
            patrocinador.pPatrocinadorID = filaSeleccionada("PatrocinadorID")
            patrocinador.pNombre = filaSeleccionada("Nombre").ToString()
            patrocinador.pDenominacion = filaSeleccionada("Denominacion").ToString()
            patrocinador.pDescuentoEnCaja = filaSeleccionada("DescuentoEnCaja").ToString()

            Dim frm As New frmPatrocinador(patrocinador, True)
            If frm.ShowDialog() = DialogResult.OK Then
                CargarGrilla()
            End If
        Else
            MessageBox.Show("Por favor, seleccione un registro para modificar.")
        End If
    End Sub

    Private Sub btnEliminarRegistro_Click(sender As Object, e As EventArgs) Handles btnEliminarRegistro.Click
        If vwLista.SelectedRowsCount > 0 Then
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                Dim filaSeleccionada As DataRow = vwLista.GetDataRow(vwLista.FocusedRowHandle)
                Dim patrocinador As New Patrocinadores()
                patrocinador.pPatrocinadorID = Convert.ToInt32(filaSeleccionada("PatrocinadorID"))

                Try
                    patrocinador.Eliminar()
                    MessageBox.Show("Registro eliminado con éxito")
                    CargarGrilla()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el registro: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Por favor, seleccione un registro para eliminar.")
        End If
    End Sub

    Private Sub btnConsultarRegistro_Click(sender As Object, e As EventArgs) Handles btnConsultarRegistro.Click
        ' Verificar si hay un registro seleccionado en la grilla
        If vwLista.SelectedRowsCount > 0 Then
            ' Obtener los datos del registro seleccionado
            Dim filaSeleccionada As DataRow = vwLista.GetDataRow(vwLista.FocusedRowHandle)

            ' Extraer la información del registro
            Dim patrocinadorID As Integer = filaSeleccionada("PatrocinadorID")
            Dim nombre As String = filaSeleccionada("Nombre").ToString()
            Dim descuentoEnCaja As String = filaSeleccionada("DescuentoEnCaja").ToString()
            Dim denominacion As String = filaSeleccionada("Denominacion").ToString()

            ' Construir el mensaje a mostrar
            Dim mensaje As String = $"Nombre: {nombre}" & vbCrLf &
                                    $"Descuento en Caja: {descuentoEnCaja}" & vbCrLf &
                                    $"Denominación: {denominacion}"

            ' Mostrar el mensaje
            MessageBox.Show(mensaje, "Información del Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Mostrar un mensaje si no hay un registro seleccionado
            MessageBox.Show("Por favor, seleccione un registro para consultar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnOrdenarAZ_Click(sender As Object, e As EventArgs) Handles btnOrdenarAZ.Click
        ' Obtener la vista de la grilla
        Dim view As GridView = CType(grdLista.MainView, GridView)

        ' Limpiar cualquier ordenamiento existente
        view.ClearSorting()

        ' Establecer el ordenamiento por la columna "Nombre" de A a Z
        view.Columns("Nombre").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
    End Sub

    Private Sub btnOrdenarZA_Click(sender As Object, e As EventArgs) Handles btnOrdenarZA.Click
        ' Obtener la vista de la grilla
        Dim view As GridView = CType(grdLista.MainView, GridView)

        ' Limpiar cualquier ordenamiento existente
        view.ClearSorting()

        ' Establecer el ordenamiento por la columna "Nombre" de Z a A
        view.Columns("Nombre").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
    End Sub

    Private Sub btnPrimerRegistro_Click(sender As Object, e As EventArgs) Handles btnPrimerRegistro.Click
        ' Obtener la vista de la grilla
        Dim view As GridView = CType(grdLista.MainView, GridView)

        ' Verificar que hay filas en la grilla
        If view.RowCount > 0 Then
            ' Mover el enfoque a la primera fila
            view.FocusedRowHandle = 0
            view.SelectRow(0)
            view.MakeRowVisible(0)
        Else
            MessageBox.Show("No hay registros en la grilla.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorRegistro_Click(sender As Object, e As EventArgs) Handles btnAnteriorRegistro.Click
        ' Obtener la vista de la grilla
        Dim view As GridView = CType(grdLista.MainView, GridView)

        ' Verificar si hay filas en la grilla y si no estamos en la primera fila
        If view.RowCount > 0 AndAlso view.FocusedRowHandle > 0 Then
            ' Mover el enfoque a la fila anterior
            view.FocusedRowHandle -= 1
            view.MakeRowVisible(view.FocusedRowHandle)
        Else
            MessageBox.Show("Ya estás en el primer registro o no hay registros en la grilla.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSiguienteRegistro_Click(sender As Object, e As EventArgs) Handles btnSiguienteRegistro.Click
        ' Obtener la vista de la grilla
        Dim view As GridView = CType(grdLista.MainView, GridView)

        ' Verificar si hay filas en la grilla y si no estamos en la última fila
        If view.RowCount > 0 AndAlso view.FocusedRowHandle < view.RowCount - 1 Then
            ' Mover el enfoque a la fila siguiente
            view.FocusedRowHandle += 1
            view.MakeRowVisible(view.FocusedRowHandle)
        Else
            MessageBox.Show("Ya estás en el último registro o no hay registros en la grilla.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoRegistro_Click(sender As Object, e As EventArgs) Handles btnUltimoRegistro.Click
        ' Obtener la vista de la grilla
        Dim view As GridView = CType(grdLista.MainView, GridView)

        ' Verificar si hay filas en la grilla
        If view.RowCount > 0 Then
            ' Mover el enfoque a la última fila
            view.FocusedRowHandle = view.RowCount - 1
            view.MakeRowVisible(view.FocusedRowHandle)
        Else
            MessageBox.Show("No hay registros en la grilla.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
