Imports System.Data.SqlClient
Public class Patrocinadores

#Region "Atributos"
    Private PatrocinadorID As Integer
    Private Nombre As String
    Private DescuentoEnCaja As String
    Private Denominacion As String
#End Region

#Region "Propiedades"
    Public property pPatrocinadorID() as Integer
       get
           return PatrocinadorID
       end get

       set(byval value as Integer)
           PatrocinadorID = value
       end set
   end property

   public property pNombre() as String
       get
           return Nombre
       end get

       set(byval value as String)
           Nombre = value
       end set
   end Property

    Public Property pDescuentoEnCaja() As String
        Get
            Return DescuentoEnCaja
        End Get

        Set(ByVal value As String)
            DescuentoEnCaja = value
        End Set
    End Property
    Public Property pDenominacion() As String
        Get
            Return Denominacion
        End Get

        Set(ByVal value As String)
            Denominacion = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Sub Insertar()
       Try
            If validaObjeto() Then
                Util.gServidor.Ejecutar("spInsertarPatrocinadores", Me.Nombre, Me.DescuentoEnCaja, Me.Denominacion)
                'Me.PatrocinadorID = Util.gServidor.Ejecutar("spInsertarPatrocinadores", Me.Nombre, Me.DescuentoEnCaja, Me.Denominacion)
            End If

        Catch ex As Exception
            Throw ex
       End Try
   End Sub

   Public Sub Actualizar()
       Try
       If validaObjeto() Then
                Util.gServidor.Ejecutar("spActualizarPatrocinadores", Me.PatrocinadorID, Me.Nombre, Me.DescuentoEnCaja, Me.Denominacion)
            End If
       Catch ex As Exception
       Throw ex
       End Try
   End Sub

    Public Sub Eliminar()
        '--------------------------------------------------------------------
        '07/06/2024-Renato Solis
        'Modificacion al eliminar para manejo de errores
        '--------------------------------------------------------------------
        Try
            ' Validar que el ID sea válido
            If pPatrocinadorID <= 0 Then
                Throw New ApplicationException("El ID del patrocinador no es válido.")
            End If

            ' Llamar al procedimiento almacenado para eliminar
            Util.gServidor.Ejecutar("spEliminarPatrocinadores", pPatrocinadorID)
        Catch ex As SqlException
            ' Manejo específico para excepciones de SQL
            Throw New Exception("Error al eliminar el patrocinador: " & ex.Message, ex)
        Catch ex As Exception
            ' Manejo general para otras excepciones
            Throw New Exception("Error inesperado al eliminar el patrocinador: " & ex.Message, ex)
        End Try
        'Try
        'If validaObjeto() Then
        '         Util.gServidor.Ejecutar("spEliminarPatrocinadores", Me.PatrocinadorID)
        '     End If
        'Catch ex As Exception
        'Throw ex
        'End Try
    End Sub

    Public Function RecuperarRegistro(ByVal vCodigo As Integer) As Patrocinadores
        Try
            Dim dtPatrocinadores As New Data.DataTable("Patrocinadores")
            dtPatrocinadores = Util.gServidor.TraerDataTable("spConsultarPatrocinadores", vCodigo)
            If dtPatrocinadores.Rows.Count > 0 Then
                Dim vPatrocinadores As New Patrocinadores
                vPatrocinadores.pPatrocinadorID = dtPatrocinadores.Rows(0).Item("PatrocinadorID")
                vPatrocinadores.pNombre = dtPatrocinadores.Rows(0).Item("Nombre")
                If vPatrocinadores.pDescuentoEnCaja Is Nothing Then
                    vPatrocinadores.pDescuentoEnCaja = "N"
                Else
                    vPatrocinadores.pDescuentoEnCaja = dtPatrocinadores.Rows(0).Item("DescuentoEnCaja")
                End If

                Return vPatrocinadores
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function RecuperaRegistros() As System.Data.DataTable
        Try
            Dim dtPatrocinadores As New Data.DataTable("Patrocinadores")
            dtPatrocinadores = Util.gServidor.TraerDataTable("spConsultarPatrocinadores", 0)
            Return dtPatrocinadores
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function RecuperarRegistrosPatrocinadores() As DataTable
        Try
            Dim dtPatrocinadores As New Data.DataTable("Patrocinadores")
            dtPatrocinadores = Util.gServidor.TraerDataTable("spConsultarPatrocinadores")
            Return dtPatrocinadores
        Catch ex As Exception
            Throw ex
        End Try
    End Function

   Private Function validaObjeto() As Boolean
        If Me.Nombre = "" Or Me.DescuentoEnCaja = "" Then
            Throw New ApplicationException("Error al validar Patrocinadores..")
            Return False
        Else
            Return True
        End If

   End Function

   #End Region
end class
