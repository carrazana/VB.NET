Module BDHelper
    'alejandro
    'Private string_conexion As String = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ConsultorioOdontologico;Data Source=ALEJANDRO\sqlexpress"
    'nico
    'Private string_conexion As String = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CONSULTORIO_ODONTOLOGICO;Data Source=NICO-PC\SQLEXPRESS"
    'PABLO
    'Private string_conexion As String = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CONSULTORIO_ODONTOLOGICO;Data Source=CARRAZANA"
    'conexion en la facu
    'Private string_conexion As String = "Provider=SQLOLEDB.1;Password=avisuales1;Persist Security Info=True;User ID=avisuales1;Initial Catalog=TP_ODONTOLOGICO;Data Source=MAQUIS"
    'ANGEL
    Private string_conexion As String = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ConsultorioOdontologicoFInal;Data Source=ANGEL\ANGELPC"

    Private valor As Integer

    Public Sub Main()
        frmInicioSistema.ShowDialog()
    End Sub

    Private Function EjecutarSQL(ByVal strSql As String) As Integer
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql

            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Private Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        Dim tabla As New DataTable
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql

            tabla.Load(cmd.ExecuteReader())

            Return tabla
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function
    'combos

    Public Function GetTipoDocumentos() As DataTable
        Dim strSQL As String = "SELECT id,descripcion FROM tipoDocumentos"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function getLocalidades() As DataTable
        Dim strSQL As String = "SELECT id,descripcion FROM localidades"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function getCargos() As DataTable
        Dim strSQL As String = "SELECT id,descripcion FROM cargos"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function getEspecializaciones() As DataTable
        Dim strSQL As String = "SELECT id,descripcion FROM especializaciones"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    'EMPLEADOS

    Public Function GetEmpleados() As DataTable
        Dim strSQL As String = "SELECT e.codigoEmpleado, e.nombre, e.apellido, d.descripcion as 'Tipo Documento', e.documento, e.fechaNac as 'Fecha Nacimiento', e.telefono, e.celular, l.descripcion as 'Localidad', e.calle, e.numero, e.piso, e.depto, exh.horaIngreso as 'Hora Ingreso', exh.horaSalida as 'Hora Salida', c.descripcion as 'Cargo', esp.descripcion as 'Especializacion' FROM empleados e,tipoDocumentos d, localidades l, cargos c, empleadoXhorario exh, empleadoXcargos exc, empleadoXespecializacion exe, especializaciones esp where e.idTipoDoc=d.id and e.idLocalidad=l.id and e.codigoEmpleado=exh.codEmpleado and e.codigoEmpleado= exc.codEmpleado and exc.idCargo=c.id and e.codigoEmpleado= exe.codEmpleado and exe.codEspecializacion=esp.id"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function BuscarEmpleados(ByVal QueBuscar As String, ByVal Buscar As String) As DataTable
        Dim strSQL As String = "SELECT e.codigoEmpleado, e.nombre, e.apellido, d.descripcion as 'Tipo Documento', e.documento, e.fechaNac as 'Fecha Nacimiento', e.telefono, e.celular, l.descripcion as 'Localidad', e.calle, e.numero, e.piso, e.depto, exh.horaIngreso as 'Hora Ingreso', exh.horaSalida as 'Hora Salida', c.descripcion as 'Cargo', esp.descripcion as 'Especializacion' FROM empleados e,tipoDocumentos d, localidades l, cargos c, empleadoXhorario exh, empleadoXcargos exc, empleadoXespecializacion exe, especializaciones esp where e.idTipoDoc=d.id and e.idLocalidad=l.id and e.codigoEmpleado=exh.codEmpleado and e.codigoEmpleado= exc.codEmpleado and exc.idCargo=c.id and e.codigoEmpleado= exe.codEmpleado and exe.codEspecializacion=esp.id and " & QueBuscar & "= '" & Buscar & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function getBuscador() As DataTable
        Dim strSQL As String = "SELECT id,descripcion FROM buscador"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Sub guardarEmpleado(ByVal codigoEmpleado As String, ByVal Nombre As String, ByVal Apellido As String, ByVal tipoDoc As String, ByVal nroDocumento As String, ByVal fechaNac As Date, ByVal calle As String, ByVal numero As String, ByVal piso As String, ByVal depto As String, ByVal idLocalidad As String, ByVal telefono As String, ByVal celular As String)
        Dim strSQL As String = "INSERT INTO empleados(codigoEmpleado, nombre, apellido,idTipoDoc,documento, fechaNac, calle, numero, piso, depto, idLocalidad, telefono, celular) values (" & codigoEmpleado & ",'" & Nombre & "','" & Apellido & "'," & tipoDoc & "," & nroDocumento & ",'" & fechaNac & "','" & calle & "'," & numero & ",'" & piso & "','" & depto & "'," & idLocalidad & ",'" & telefono & "','" & celular & "')"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Function getCodigoEmpleado() As DataTable

        Dim strSQL As String = "select isnull(max(codigoEmpleado)+1,1) as ultimo from empleados"

        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function cargarEmpleado(ByVal codigoEmpleado As String) As DataTable
        Dim strSQL As String = "SELECT e.codigoEmpleado, e.nombre, e.apellido, e.idTipoDoc, e.documento, e.fechaNac, e.telefono, e.celular, e.idLocalidad, e.calle, e.numero, e.piso, e.depto, exh.horaIngreso as 'Hora Ingreso', exh.horaSalida as 'Hora Salida', c.id as 'Cargo', esp.id as 'Especializacion' FROM empleados e,tipoDocumentos d, localidades l, cargos c, empleadoXhorario exh, empleadoXcargos exc, empleadoXespecializacion exe, especializaciones esp where e.idTipoDoc=d.id and e.idLocalidad=l.id and e.codigoEmpleado=exh.codEmpleado and e.codigoEmpleado= exc.codEmpleado and exc.idCargo=c.id and e.codigoEmpleado= exe.codEmpleado and exe.codEspecializacion=esp.id and e.codigoEmpleado=  " & codigoEmpleado
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function existenciaEmpleado(ByVal codigoEmpleado As String) As DataTable
        Dim strSQL As String = "select * from empleados where codigoEmpleado=  " & codigoEmpleado
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Sub modificarEmpleado(ByVal codigoEmpleado As String, ByVal txtNombre As String, ByVal txtApellido As String, ByVal tipoDoc As String, ByVal nroDocumento As String, ByVal fechaNac As Date, ByVal calle As String, ByVal numero As String, ByVal piso As String, ByVal depto As String, ByVal idLocalidad As String, ByVal telefono As String, ByVal celular As String)
        Dim strSQL As String = "UPDATE empleados set codigoEmpleado= " & codigoEmpleado & ", nombre= '" & txtNombre & "', apellido='" & txtApellido & "', idTipoDoc= " & tipoDoc & ", fechaNac='" & fechaNac & "', calle='" & calle & "', numero=" & numero & ", piso='" & piso & "', depto='" & depto & "', idLocalidad=" & idLocalidad & ",telefono='" & telefono & "', celular='" & celular & "' where codigoEmpleado=" & codigoEmpleado
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub borrarEmpleado(ByVal codigoEmpleado As String)
        Dim striSQL As String = "delete from empleados where codigoEmpleado = " & codigoEmpleado
        BDHelper.EjecutarSQL(striSQL)
    End Sub

    Public Sub guardarEmpleadoXhorario(ByVal codigoEmpleado As String, ByVal horaIngreso As String, ByVal horaSalida As String)
        Dim strSQL As String = "INSERT INTO empleadoXhorario (codEmpleado, horaIngreso, horaSalida) values (" & codigoEmpleado & ",'" & horaIngreso & "','" & horaSalida & "')"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub guardarEmpleadoXcargos(ByVal codigoEmpleado As String, ByVal idCargo As String)
        Dim strSQL As String = "INSERT INTO empleadoXcargos (codEmpleado, idCargo) values (" & codigoEmpleado & "," & idCargo & ")"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub guardarEmpleadoXespecializacion(ByVal codigoEmpleado As String, ByVal codEspecializacion As String)
        Dim strSQL As String = "INSERT INTO empleadoXespecializacion (codEmpleado, codEspecializacion) values (" & codigoEmpleado & "," & codEspecializacion & ")"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub modificarEmpleadoXhorario(ByVal codigoEmpleado As String, ByVal horaIngreso As String, ByVal horaSalida As String)
        Dim strSQL As String = "UPDATE empleadoXhorario set codEmpleado= " & codigoEmpleado & ", horaIngreso= '" & horaIngreso & "', horaSalida='" & horaSalida & "' where codEmpleado=" & codigoEmpleado
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub modificarEmpleadoXcargos(ByVal codigoEmpleado As String, ByVal idCargo As String)
        Dim strSQL As String = "UPDATE empleadoXcargos set codEmpleado= " & codigoEmpleado & ", idCargo= " & idCargo & " where codEmpleado=" & codigoEmpleado
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub modificarEmpleadoXespecializacion(ByVal codigoEmpleado As String, ByVal codEspecializacion As String)
        Dim strSQL As String = "UPDATE empleadoXespecializacion set codEmpleado= " & codigoEmpleado & ", codEspecializacion= " & codEspecializacion & " where codEmpleado=" & codigoEmpleado
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub borrarEmpleadoXhorario(ByVal codigoEmpleado As String)
        Dim striSQL As String = "delete from empleadoXhorario where codEmpleado = " & codigoEmpleado
        BDHelper.EjecutarSQL(striSQL)
    End Sub

    Public Sub borrarEmpleadoXcargo(ByVal codigoEmpleado As String)
        Dim striSQL As String = "delete from empleadoXcargos where codEmpleado = " & codigoEmpleado
        BDHelper.EjecutarSQL(striSQL)
    End Sub

    Public Sub borrarEmpleadoXespecializacion(ByVal codigoEmpleado As String)
        Dim striSQL As String = "delete from empleadoXespecializacion where codEmpleado = " & codigoEmpleado
        BDHelper.EjecutarSQL(striSQL)
    End Sub

    Public Function borrarEmpleadoXturno(ByVal codigoEmpleado As String) As DataTable
        Dim striSQL As String = "SELECT        empleados.* FROM            turnos INNER JOIN   empleados ON turnos.codEmpleado = empleados.codigoEmpleado  WHERE        (empleados.codigoEmpleado = "
        striSQL &= codigoEmpleado & ")"

        Return BDHelper.ConsultaSQL(striSQL)
    End Function


    'ABM GENERICO
    Public Function getIdGenerico(ByVal tabla As String) As DataTable

        Dim strSQL As String = "select isnull(max(id)+1,1) as ultimo from " & tabla

        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Sub guardarGENERICO(ByVal tabla As String, ByVal id As String, ByVal descripcion As String)
        Dim strSQL As String = "INSERT INTO " & tabla & " (id, descripcion) values (" & id & ",'" & descripcion & "')"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub modificarGENERICO(ByVal tabla As String, ByVal id As String, ByVal descripcion As String)
        Dim strSQL As String = "UPDATE " & tabla & " set id= " & id & ", descripcion= '" & descripcion & "' where id=" & id
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub borrarGENERICO(ByVal tabla As String, ByVal id As String)
        Dim striSQL As String = "delete from " & tabla & " where id = " & id
        BDHelper.EjecutarSQL(striSQL)
    End Sub

    Public Function cargarGENERICO(ByVal tabla As String, ByVal id As String, ByVal descripcion As String) As DataTable
        Dim strSQL As String = "select " & id & ", " & descripcion & " from " & tabla
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function BuscarGENERICO(ByVal tabla As String, ByVal QueBuscar As String, ByVal Buscar As String) As DataTable
        Dim strSQL As String = "select id, descripcion from " & tabla & " where " & QueBuscar & "= '" & Buscar & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    '**************************
    '  nico
    '  Pacientes
    Public Sub guardarPacientes(ByVal tipoDoc As String, ByVal nroDoc As String, ByVal nombre As String, ByVal apellido As String, ByVal nroHistorial As String, ByVal fechaNac As Date, ByVal calle As String, ByVal numero As String, ByVal piso As String, ByVal depto As String, ByVal idLocalidad As String, ByVal telefono As String, ByVal celular As String)
        Dim strSQL As String = "insert into pacientes(idTipoDoc,nroDoc,nombre,apellido,nroHistorial,telefono,idLocalidad,fechaNacimiento,celular,calle,nroCalle,piso,departamento) values (" & tipoDoc & "," & nroDoc & ",'" & nombre & "','" & apellido & "','" & nroHistorial & "','" & telefono & "'," & idLocalidad & ",'" & fechaNac & "','" & celular & "','" & calle & "'," & numero & ",'" & piso & "','" & depto & "')"
        BDHelper.EjecutarSQL(strSQL)
    End Sub
    Public Sub modificarPacientes(ByVal tipoDoc As String, ByVal nroDoc As String, ByVal nombre As String, ByVal apellido As String, ByVal nroHistorial As String, ByVal fechaNac As Date, ByVal calle As String, ByVal numero As String, ByVal piso As String, ByVal depto As String, ByVal idLocalidad As String, ByVal telefono As String, ByVal celular As String)
        Dim strSQL As String = "UPDATE pacientes set idTipoDoc =" & tipoDoc & ", nroDoc ='" & nroDoc & "', nombre ='" & nombre & "', apellido ='" & apellido & "', nroHistorial ='" & nroHistorial & "', telefono ='" & telefono & "',idLocalidad =" & idLocalidad & ", fechaNacimiento ='" & fechaNac & "', celular ='" & celular & "', calle ='" & calle & "',nroCalle ='" & numero & "', piso ='" & piso & "', departamento ='" & depto & "' where nroDoc = " & nroDoc
        BDHelper.EjecutarSQL(strSQL)
    End Sub
    Public Function BuscarPacientes(ByVal QueBuscar As String, ByVal Buscar As String) As DataTable
        Dim strSQL As String = "SELECT tp.descripcion as 'TipoDocumento', p.nroDoc, p.nombre, p.apellido, p.nroHistorial as 'Numero Historial', p.telefono, l.descripcion as 'Localidad', p.fechaNacimiento, p.celular, p.calle, p.nroCalle,p.piso,p.departamento from pacientes p, tipoDocumentos tp, localidades l where p.idTipoDoc = tp.id and p.idLocalidad = l.id and " & QueBuscar & "= '" & Buscar & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function getPacientes() As DataTable
        Dim strSQL As String = "SELECT tp.descripcion as 'TipoDocumento', p.nroDoc, p.nombre, p.apellido, p.nroHistorial as 'Numero Historial', p.telefono, l.descripcion as 'Localidad', p.fechaNacimiento, p.celular, p.calle, p.nroCalle,p.piso,p.departamento from pacientes p, tipoDocumentos tp, localidades l where p.idTipoDoc = tp.id and p.idLocalidad = l.id"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Sub borrarPacientes(ByVal nroDoc As String)
        Dim striSQL As String = "delete from pacientes where nroDoc = " & nroDoc
        BDHelper.EjecutarSQL(striSQL)
    End Sub

    Public Function cargarPacientes(ByVal nroDoc As String) As DataTable
        Dim strSQL As String = "select * from pacientes where nroDoc =  " & nroDoc
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function getCodigoPacientes() As DataTable
        Dim strSQL As String = "select isnull(max(nroHistorial)+1,1) as ultimo from pacientes"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function actualizar() As Data.DataTable
        Dim strSQL As String = "SELECT tp.descripcion as 'TipoDocumento', p.nroDoc, p.nombre, p.apellido, p.nroHistorial as 'Numero Historial', p.telefono, l.descripcion as 'Localidad', p.fechaNacimiento, p.celular, p.calle, p.nroCalle,p.piso,p.departamento from pacientes p, tipoDocumentos tp, localidades l where p.idTipoDoc = tp.id and p.idLocalidad = l.id"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function leerTabla(ByVal nombreTabla) As Data.DataTable
        Dim strSQL As String = "select * from " & nombreTabla
        Return ConsultaSQL(strSQL)
    End Function

    Public Function borrarPacienteXTurno(ByVal idtipoDoc As Integer, ByVal nroDoc As Integer, ByVal nroHistorial As Integer) As Data.DataTable
        Dim strSQL As String = "SELECT        turnos.nroDocPaciente, turnos.idTipoDocPaciente, pacientes.nroHistorial FROM            pacientes INNER JOIN "
        strSQL &= "  turnos On pacientes.nroDoc = turnos.nroDocPaciente And pacientes.idTipoDoc = turnos.idTipoDocPaciente INNER JOIN "
        strSQL &= "   intervencion ON pacientes.nroHistorial = intervencion.nroHistorial   WHERE        (turnos.idTipoDocPaciente = " & idtipoDoc & ") AND (turnos.nroDocPaciente = '" & nroDoc & "') AND (pacientes.nroHistorial = '" & nroHistorial & "')"
        Return ConsultaSQL(strSQL)
    End Function

    Public Function obtenerDNI(ByVal descripcion As String) As Data.DataTable
        Dim strSQL As String = "SELECT        id FROM            tipoDocumentos WHERE        (descripcion = '" & descripcion & "') "
        Return ConsultaSQL(strSQL)
    End Function

    '***************************

    'Proveedores

    Public Function borrarProveedorXCompra(ByVal codigoProveedor As String) As DataTable
        Dim strSQL As String = "SELECT        compraInsumos.codProveedor FROM            proveedores INNER JOIN compraInsumos ON proveedores.idProveedores = compraInsumos.codProveedor   "
        strSQL &= "WHERE        (compraInsumos.codProveedor = " & codigoProveedor & ")"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function existenciaProveedor(ByVal codigoProveedor As String) As DataTable
        Dim strSQL As String = "select * from proveedores where idProveedores=  " & codigoProveedor
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function getProveedores() As DataTable
        Dim strSQL As String = "SELECT P.idProveedores AS ID, P.nombre AS Nombre, P.nombre_responsable AS 'Nombre Responsable', P.telefono AS Telefono, P.mail AS Mail, P.calle AS Calle, P.numero AS Numero, P.departamento AS Departamento, P.piso AS Piso, L.descripcion AS Localidad"
        strSQL &= " FROM proveedores P, localidades L"
        strSQL &= " WHERE P.idLocalidad = L.id"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function getCodigoProveedor() As DataTable
        Dim strSQL As String = "select isnull(max(idProveedores)+1,1) as ultimo from proveedores"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function


    Public Function buscarProveedores(ByVal QueBuscar As String, ByVal Buscar As String) As DataTable
        Dim strSQL As String = "SELECT P.idProveedores AS ID, P.nombre AS Nombre, P.nombre_responsable AS 'Nombre Responsable', P.telefono AS Telefono, P.mail AS Mail, P.calle AS Calle, P.numero AS Numero, P.departamento AS Departamento, P.piso AS Piso, L.descripcion AS Localidad"
        strSQL &= " FROM proveedores P, localidades L"
        strSQL &= " where P.idLocalidad = L.id AND " & QueBuscar & "='" & Buscar & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Sub borrarProveedor(ByVal id As String)
        Dim striSQL As String = "delete from proveedores where idProveedores = " & id
        BDHelper.EjecutarSQL(striSQL)
    End Sub

    Public Sub guardarProveedor(ByVal ID As String, ByVal nombre As String, ByVal nombre_responsable As String, ByVal telefono As String, ByVal mail As String, ByVal calle As String, ByVal numero As String, ByVal departamento As String, ByVal piso As String, ByVal idLocalidad As String)
        Dim strSQL As String = "INSERT INTO proveedores(idProveedores, nombre,nombre_responsable,telefono,mail,calle,numero,departamento,piso,idLocalidad) values ('" & ID & "','" & nombre & "','" & nombre_responsable & "','" & telefono & "','" & mail & "','" & calle & "','" & numero & "','" & departamento & "','" & piso & "','" & idLocalidad & "')"
        BDHelper.EjecutarSQL(strSQL)
    End Sub
  
    Public Function cargarProveedor(ByVal id As String) As DataTable
        Dim strSQL As String = "SELECT        proveedores.* FROM            proveedores"
        strSQL &= " WHERE idProveedores =  " & id
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function leo_tabla(ByVal nombre_tabla As String) As Data.DataTable
        Dim strSQL As String = "SELECT * FROM " & nombre_tabla
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Sub modificarProveedores(ByVal id As String, ByVal nombre As String, ByVal nombre_responsable As String, ByVal telefono As String, ByVal mail As String, ByVal calle As String, ByVal numero As String, ByVal departamento As String, ByVal piso As String, ByVal idLocalidad As String)
        Dim strSQL As String = "UPDATE Proveedores set nombre= '" & nombre & "', nombre_responsable= '" & nombre_responsable & "', telefono= '" & telefono & "', mail= '" & mail & "',calle = '" & calle & "', numero= '" & numero & "', departamento= '" & departamento & "', piso= '" & piso & "' where idProveedores =" & id
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    'Stock
    Public Function idProveedor(ByVal nombre As String)
        Dim strSQL As String = "SELECT idProveedores, nombre FROM proveedores WHERE nombre = '" & nombre & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function idInsumo(ByVal desc As String)
        Dim strSQL As String = "SELECT id, descripcion FROM insumos WHERE descripcion ='" & desc & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function
    Public Function idInsumoStock(ByVal id As String)
        Dim strSQL As String = "SELECT codInsumo, cantidad FROM stock WHERE codInsumo =" & id
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function buscarInsumosStock(ByVal QueBuscar As String, ByVal Buscar As String) As DataTable
        Dim strSQL As String = "SELECT I.descripcion as 'Insumo', S.cantidad FROM insumos I, stock S where I.id = S.codInsumo AND I." & QueBuscar & "='" & Buscar & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function
    Public Function getStock()
        Dim strSQL As String = "SELECT I.descripcion as Insumo, S.cantidad, S.puntoReposicion FROM insumos I, stock S where I.id = S.codInsumo"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function
    Public Sub borrarStock(ByVal cod1 As Integer)
        Dim strSQL As String = "delete from stock where codInsumo = " & cod1
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub guardarStock(ByVal id_insumo As Integer, ByVal cantidad As Integer, ByVal puntoReposicion As String)
        Dim strSQL As String = "INSERT INTO stock( codInsumo, cantidad, puntoReposicion) values(" & id_insumo & "," & cantidad & ",'" & puntoReposicion & "')"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub modificarStock(ByVal id_insumo As Integer, ByVal cantidad As Integer, ByVal puntoReposicion As String)
        Dim strSQL As String = "UPDATE stock set codInsumo= " & id_insumo & ", cantidad= " & cantidad & ",puntoReposicion='" & puntoReposicion & "' where codInsumo=" & id_insumo
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Function cargarStock(ByVal desc As String) As DataTable
        Dim strSQL As String = "SELECT I.descripcion, S.cantidad FROM insumos I, stock S where I.id = S.codInsumo AND I.descripcion ='" & desc & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function buscarProveedorxInsumo(ByVal nombre_prov As String, ByVal desc_insumo As String) As DataTable
        Dim strSQL As String = "SELECT P.nombre, I.descripcion, S.cantidad FROM proveedores P, insumos I, stock S where P.idProveedores = S.codProveedor AND  I.id = S.codInsumo AND P.nombre ='" & nombre_prov & "' AND I.descripcion= '" & desc_insumo & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    'Turnos

    Public Function getHorariosProfesional(ByVal codEmpleado As String)
        Dim consulta = "SELECT empleados.codigoEmpleado, empleadoXhorario.horaIngreso, empleadoXhorario.horaSalida  FROM empleados INNER JOIN  empleadoXhorario ON empleados.codigoEmpleado = empleadoXhorario.codEmpleado WHERE   (empleados.codigoEmpleado = '"
        consulta &= codEmpleado & "')"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function getTurnosDados(ByVal codEmpleado As String, ByVal fecha As Date)
        Dim consulta = "SELECT  codEmpleado, fecha, hora  FROM   turnos  WHERE   (codEmpleado = '"
        consulta &= codEmpleado & "') And (fecha = '"
        consulta &= fecha & "')"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function getIDdocumento(ByVal tipoDocumento As String)
        Dim consulta = "SELECT  id FROM            tipoDocumentos            WHERE        (descripcion = '"
        consulta &= tipoDocumento & "')"
        Return BDHelper.ConsultaSQL(consulta).Rows(0)("id")
    End Function

    Public Function getTurnos() As DataTable
        Dim strSQL As String = "SELECT T.nroDocPaciente AS 'Numero Documento', E.Apellido as 'Profesional', T.fecha, T.hora from Turnos T, Empleados E where T.codEmpleado=E.codigoEmpleado"
   
        Return BDHelper.ConsultaSQL(strSQL)
    End Function
    Public Sub borrarTurnos(ByVal hora As String, ByVal fecha As Date)
        Dim striSQL As String = "delete from turnos where hora = '" & hora & "' and fecha='" & fecha & "'"
        BDHelper.EjecutarSQL(striSQL)
    End Sub

    Public Sub guardarTurnos(ByVal codEmpleado As String, ByVal idtipoDocPaciente As String, ByVal nroDocumento As String, ByVal Fecha As Date, ByVal hora As String)
        Dim strSQL As String = "INSERT INTO turnos(codEmpleado, idTipoDocPaciente, nroDocPaciente, fecha, hora) values ('" & codEmpleado & "','" & idTipoDocPaciente & "','" & nroDocumento & "','" & Fecha & "','" & hora & "')"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub modificarTurnos(ByVal codEmpleado As String, ByVal idtipoDocPaciente As String, ByVal nroDocumento As String, ByVal Fecha As Date, ByVal hora As String)
        Dim strSQL As String = "UPDATE turnos set codEmpleado= " & codEmpleado & ",idTipoDocPaciente=" & idtipoDocPaciente & ", nroDocPaciente= " & nroDocumento & ", fecha= '" & Fecha & "', hora= '" & hora & "'"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Function existenciaTurno(ByVal fecha As Date, ByVal hora As String) As DataTable
        Dim strSQL As String = "select * from turnos where fecha=  '" & fecha & "' and hora= '" & hora & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function buscarTurno(ByVal QueBuscar As String, ByVal Buscar As String) As DataTable
        Dim strSQL As String = "SELECT T.nroDocPaciente AS 'Numero Documento', E.Apellido as 'Profesional', T.fecha, T.hora from Turnos T, Empleados E where T.codEmpleado=E.codigoEmpleado AND " & QueBuscar & "='" & Buscar & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function cantidadMinutos(ByVal codEmpleado As String) As Integer
        Dim strSQL As String = "SELECT SUM(DATEDIFF(minute,e.horaIngreso, e.horaSalida)) as 'minutos' FROM empleadoXhorario e WHERE e.codEmpleado = " & codEmpleado
        Return BDHelper.ConsultaSQL(strSQL).Rows(0)("minutos")
    End Function

    Public Function cantidadTurnos(ByVal codEmpleado As String, ByVal minutos As Integer) As DataTable
        Dim strSQL As String = "SELECT " & minutos & "/30 as 'tiempo'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function sumaHora(ByVal codEmpleado As String, ByVal minutos As Integer) As DataTable
        Dim strSQL As String = "select DATEADD([minute], " & minutos & ", e.horaIngreso) as 'suma' FROM empleadoXhorario e WHERE e.codEmpleado = " & codEmpleado
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    'Compra Insumo

    Public Function buscarCompra(ByVal QueBuscar As String, ByVal Buscar As String) As DataTable
        Dim strSQL As String = "SELECT C.codProveedor as 'Codigo Proveedor', P.nombre as 'Nombre Proveedor', C.fechaHora, C.montoTotal FROM proveedores P, compraInsumos C where P.idProveedores = C.codProveedor AND " & QueBuscar & "='" & Buscar & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function getCompra()
        Dim strSQL As String = "SELECT C.codProveedor as 'Codigo Proveedor', P.nombre as 'Nombre Proveedor', C.fechaHora, C.montoTotal FROM proveedores P, compraInsumos C where P.idProveedores = C.codProveedor "
        Return BDHelper.ConsultaSQL(strSQL)
    End Function
    Public Function getDetalleCompra()
        Dim strSQL As String = "SELECT D.codProveedor, P.nombre, I.descripcion, D.cantidad, D.PrecioUnitario, D.fechaHora FROM proveedores P, insumos I, detalleCompraInsumos D, compraInsumos C where P.idProveedores = D.codProveedor And I.id = D.codInsumo And C.codProveedor=D.codProveedor and C.fechaHora=D.fechaHora "
        Return BDHelper.ConsultaSQL(strSQL)
    End Function
    Public Sub borrarCompra(ByVal cod1 As Integer, ByVal fechaHora As Date)
        Dim strSQL As String = "delete from compraInsumos where codProveedor = " & cod1 & " AND fechaHora = '" & fechaHora & "'"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub borrarDetalleCompra(ByVal cod1 As Integer, ByVal fechaHora As Date)
        Dim strSQL As String = "delete from detalleCompraInsumos where codProveedor = " & cod1 & " AND fechaHora = '" & fechaHora & "' "
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub guardarCompra(ByVal id_prov As Integer, ByVal fechaHora As Date, ByVal montoTotal As Integer)
        Dim strSQL As String = "INSERT INTO compraInsumos(codProveedor, fechaHora, montoTotal) values(" & id_prov & ",'" & fechaHora & "'," & montoTotal & ")"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub guardarDetalleCompra(ByVal id_prov As Integer, ByVal id_insumo As Integer, ByVal cantidad As Integer, ByVal fechaHora As Date, ByVal precioUnitario As Integer)
        Dim strSQL As String = "INSERT INTO detalleCompraInsumos(codProveedor, codInsumo, cantidad, fechaHora, precioUnitario) values(" & id_prov & "," & id_insumo & "," & cantidad & ",'" & fechaHora & "'," & precioUnitario & ")"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub modificarCompra(ByVal id_prov As Integer, ByVal fechaHora As Date, ByVal montoTotal As Integer)
        Dim strSQL As String = "UPDATE compraInsumos set codProveedor= " & id_prov & ", fechaHora= '" & fechaHora & "', montoTotal= " & montoTotal
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub modificarDetalleCompra(ByVal id_prov As Integer, ByVal id_insumo As Integer, ByVal cantidad As Integer, ByVal fechaHora As Date, ByVal precioUnitario As Integer)
        Dim strSQL As String = "UPDATE detalleCompraInsumos set codProveedor= " & id_prov & ", codInsumo= " & id_insumo & ", cantidad= " & cantidad & ",fechaHora='" & fechaHora & "',precioUnitario=" & precioUnitario
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Function cargarCompra(ByVal codProveedor As Integer, ByVal fechaHora As Date) As DataTable
        Dim strSQL As String = "SELECT D.codProveedor, P.nombre, D.codInsumo, D.cantidad, D.PrecioUnitario, D.fechaHora, C.montoTotal FROM proveedores P, insumos I, detalleCompraInsumos D, compraInsumos C where P.idProveedores = D.codProveedor And I.id = D.codInsumo And C.codProveedor=D.codProveedor and C.fechaHora=D.fechaHora and D.codProveedor = " & codProveedor & " AND D.fechaHora ='" & fechaHora & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function getStock(ByVal idInsumo As Integer, ByVal idProveedor As Integer)
        Dim strSQL As String = "SELECT P.nombre, I.descripcion, isNull(S.cantidad,0) as cantidad FROM proveedores P, insumos I, stock S where P.idProveedores = S.codProveedor AND  I.id = S.codInsumo and S.codInsumo=" & idInsumo & "and S.codProveedor=" & idProveedor
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    'Intervencion

    Public Function obtenerDatosIntervencionPacienteXnombre(nombre As String)
        Dim consulta = "SELECT        intervencion.codIntervencion, intervencion.nroHistorial, intervencion.fechaHora, intervencion.codTratamiento, tratamientos.descripcion, intervencion.observaciones, intervencion.montonTotal, pacientes.nombre, pacientes.apellido"
        consulta &= " FROM            intervencion INNER JOIN"
        consulta &= "                pacientes ON intervencion.nroHistorial = pacientes.nroHistorial INNER JOIN"
        consulta &= "                tratamientos ON intervencion.codTratamiento = tratamientos.id WHERE (pacientes.nombre = '" & nombre & "')"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function getIntervenciones() As DataTable
        Dim consulta = "SELECT        intervencion.codIntervencion, intervencion.nroHistorial, intervencion.fechaHora, intervencion.codTratamiento, tratamientos.descripcion, intervencion.observaciones, intervencion.montonTotal, pacientes.nombre, pacientes.apellido "
        consulta &= " FROM            intervencion INNER JOIN pacientes ON intervencion.nroHistorial = pacientes.nroHistorial INNER JOIN"
        consulta &= " tratamientos ON intervencion.codTratamiento = tratamientos.id"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function obtenerDatosIntervencionPacienteXapellido(apellido As String)
        Dim consulta = "SELECT        intervencion.codIntervencion, intervencion.nroHistorial, intervencion.fechaHora, intervencion.codTratamiento, tratamientos.descripcion, intervencion.observaciones, intervencion.montonTotal, pacientes.nombre, pacientes.apellido"
        consulta &= " FROM            intervencion INNER JOIN pacientes ON intervencion.nroHistorial = pacientes.nroHistorial INNER JOIN"
        consulta &= "                 tratamientos ON intervencion.codTratamiento = tratamientos.id WHERE  (pacientes.apellido = '" & apellido & "')"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function obtenerDatosIntervencionPacienteXnroDoc(nroDocumento As String)
        Dim consulta = "SELECT        intervencion.codIntervencion, intervencion.nroHistorial, intervencion.fechaHora, intervencion.codTratamiento, tratamientos.descripcion, intervencion.observaciones, intervencion.montonTotal, pacientes.nombre, pacientes.apellido "
        consulta &= " FROM            intervencion INNER JOIN"
        consulta &= "                pacientes ON intervencion.nroHistorial = pacientes.nroHistorial INNER JOIN"
        consulta &= "                tratamientos ON intervencion.codTratamiento = tratamientos.id"
        consulta &= " WHERE        (pacientes.nroDoc = " & nroDocumento & ")"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function obtenerNroHistorialXNombre(ByVal nombre As String)
        Dim consulta = "SELECT        nombre, apellido, nroHistorial  FROM pacientes WHERE        (nombre = '"
        consulta &= nombre & "')"

        Return BDHelper.ConsultaSQL(consulta)

    End Function

    Public Function obtenerNroHistorialXApellido(ByVal apellido As String)
        Dim consulta = "SELECT    nombre, apellido, nroHistorial FROM pacientes WHERE        (apellido = '"
        consulta &= apellido & "')"

        Return BDHelper.ConsultaSQL(consulta)

    End Function

    Public Function obtenerNroHistorialXNroDoc(ByVal nroDoc As String)
        Dim consulta = "SELECT  nombre, apellido, nroHistorial FROM pacientes WHERE        (nroDoc = "
        consulta &= nroDoc & ")"

        Return BDHelper.ConsultaSQL(consulta)

    End Function

    Public Function obtenerCodIntervencionPaciente(nroHistorial As Int64)
        Dim consulta = "Select I.codIntervencion FROM intervencion I WHERE "
        consulta &= "I.nroHistorial = " & nroHistorial
        Return BDHelper.ConsultaSQL(consulta).Rows(0)(0)
    End Function

    Public Function obtenerInsumosIntervencionPaciente(codIntervencion As Long)
        Dim consulta = "SELECT        insumos.id, insumos.descripcion, insumosXintervencion.cantidadInsumos AS 'cantidad', detalleCompraInsumos.precioUnitario as precio"
        consulta &= " FROM            insumosXintervencion INNER JOIN"
        consulta &= "  insumos ON insumosXintervencion.codInsumo = insumos.id INNER JOIN"
        consulta &= "  detalleCompraInsumos ON insumosXintervencion.codInsumo = detalleCompraInsumos.codInsumo WHERE "
        consulta &= "(insumosXintervencion.codIntervencion = " & codIntervencion & ")"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Sub insertarIntervencion(nroHistorial As String, codTratamiento As String, fechaHora As Date, monto As String, observacion As String)
        Dim consulta = "INSERT INTO intervencion (nroHistorial, codTratamiento, fechaHora, montonTotal, observaciones) "
        consulta &= "VALUES "
        consulta &= "(" & nroHistorial
        consulta &= ", " & codTratamiento
        consulta &= ", '" & fechaHora & "'"
        consulta &= "," & monto
        consulta &= ",'" & observacion & "')"

        ConsultaSQL(consulta)
    End Sub

    Public Function obtenerUltimoCodIntervencion()
        Dim consulta = "select Max(intervencion.codIntervencion) from intervencion"
        Return BDHelper.ConsultaSQL(consulta).Rows(0)(0)
    End Function

    Public Sub insertarInsumoEnIntervencion(codIntervencion As Integer, codInsumo As Integer, cantidadInsumo As Integer)
        Dim consulta = "INSERT INTO insumosXintervencion(codIntervencion, codInsumo, cantidadInsumos) VALUES ("
        consulta &= codIntervencion & ", "
        consulta &= codInsumo & ", "
        consulta &= cantidadInsumo & ")"
        BDHelper.ConsultaSQL(consulta)
    End Sub

    Public Function eliminarpruba()
        Dim consulta = "DELETE FROM intervencion WHERE (idTipoDoc = 1) AND (nroDoc = 123456) AND (codTratamiento = 6)"
        Return consulta
    End Function

    Public Sub eliminarIntervencion(codIntervencion As String)
        Dim consulta = "DELETE FROM intervencion WHERE "
        consulta &= "(codIntervencion = " & codIntervencion & ")"
        EjecutarSQL(consulta)
    End Sub

    Public Sub modificarTratamiento(nroHistorial As String, montoTotal As String, codTratamiento As String, observacion As String, fechaHora As Date, nroIntervencion As String)
        Dim consulta = "UPDATE intervencion SET fechaHora = '"
        consulta &= fechaHora & "', codTratamiento = "
        consulta &= codTratamiento & ", montonTotal = "
        consulta &= montoTotal & ", observaciones = '"
        consulta &= observacion & "'" & "  WHERE(nroHistorial = "
        consulta &= nroHistorial & ") AND (codIntervencion = "
        consulta &= nroIntervencion & ")"
        ConsultaSQL(consulta)
    End Sub

    Public Function modificarInsumosTratamiento(codIntervencion As Integer, codInsumo As Integer, cantInsumos As Integer)
        Dim consulta = "UPDATE       insumosXintervencion"
        codInsumo = ""
        consulta &= codInsumo & " , cantidadInsumos = "
        consulta &= cantInsumos & " WHERE        (codIntervencion = "
        consulta &= codIntervencion & ")"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Sub eliminarInsumoXIntervencion(codIntervencion As Integer)
        Dim consulta = "DELETE FROM insumosXintervencion WHERE        (codIntervencion = "
        consulta &= codIntervencion & ")"
        BDHelper.ConsultaSQL(consulta)
    End Sub

    Public Function obtenerInsumos()
        Dim consulta = "SELECT insumos.id, insumos.descripcion, detalleCompraInsumos.precioUnitario as precio"
        consulta &= " FROM  insumos INNER JOIN"
        consulta &= "  detalleCompraInsumos ON insumos.id = detalleCompraInsumos.codInsumo"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function altaInsumo(nombre As String, descripcion As String, precio As Int32)
        Dim consulta = "INSERT INTO insumos (nombre, descripcion, precio) VALUES        ('"
        consulta &= nombre & "', '"
        consulta &= descripcion & "', "
        consulta &= precio & ")"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function eliminarInsumo(nombre As String)
        Dim consulta = "DELETE FROM insumos WHERE        (nombre = '"
        consulta &= nombre & "')"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function obtenerInsumosXTratamiento(codTratamiento As Int16)
        Dim consulta = "SELECT        insumosXTratamiento.codInsumo, insumos.nombre, insumos.descripcion, insumos.precio, insumosXTratamiento.cantidadInsumos "
        consulta &= "FROM insumosXTratamiento INNER JOIN insumos ON insumosXTratamiento.codInsumo = insumos.id"
        consulta &= "WHERE        (insumosXTratamiento.codTratamiento = "
        consulta &= codTratamiento & ")"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function obtenerTratamientos()
        Dim consulta = "SELECT * FROM tratamientos"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function eliminarTratamiento(id As String)
        Dim consulta = "DELETE FROM tratamientos WHERE (id = "
        consulta &= id & ")"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Sub modificarInsumo(id As Integer, nombre As String, descripcion As String, precio As Integer)
        Dim consulta = "UPDATE       insumos SET                nombre = '"
        consulta &= nombre & "', descripcion = '"
        consulta &= descripcion & "', precio = "
        consulta &= precio & " WHERE        (id = "
        consulta &= id & ")"
        BDHelper.ConsultaSQL(consulta)
    End Sub

    Public Function altaTratamiento(nombre As String, descripcion As String, precio As Integer, duracion As String)
        Dim consulta = "INSERT INTO tratamientos (nombre, descripcion, costo, duracion) VALUES ('"
        consulta &= nombre & "', '"
        consulta &= descripcion & "', "
        consulta &= precio & ", "
        consulta &= duracion & ")"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function modificarTratamientoConsulta(id As Integer, nombre As String, descripcion As String, duracion As Integer, precio As Integer)
        Dim consulta = "UPDATE       tratamientos SET   nombre = '"
        consulta &= nombre & "', descripcion = '"
        consulta &= descripcion & "', costo = "
        consulta &= precio & ", duracion= "
        consulta &= duracion & " WHERE        (id = "
        consulta &= id & ")"
        Return BDHelper.ConsultaSQL(consulta)
    End Function

    Public Function verificarExistenciaTratamiento(ByVal codTratamiento As String)
        Dim consulta = "SELECT        codTratamiento FROM intervencion WHERE        (codTratamiento = "
        consulta &= codTratamiento & ")"

        If (BDHelper.ConsultaSQL(consulta).Rows.Count > 0) Then
            Return 1
        Else
            Return 0
        End If
    End Function


    'Tratamientos
    Public Function getIdTratamiento() As DataTable

        Dim strSQL As String = "select isnull(max(id)+1,1) as ultimo from tratamientos"

        Return BDHelper.ConsultaSQL(strSQL)
    End Function
    Public Sub guardarTratamiento(ByVal id As String, ByVal descripcion As String, ByVal costo As String)
        Dim strSQL As String = "INSERT INTO tratamientos (id, descripcion, costo) values (" & id & ",'" & descripcion & "'," & costo & ")"
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub modificarTratamiento(ByVal id As String, ByVal descripcion As String, ByVal costo As String)
        Dim strSQL As String = "UPDATE tratamientos set id= " & id & ", descripcion= '" & descripcion & "' ,costo= " & costo & " where id=" & id
        BDHelper.EjecutarSQL(strSQL)
    End Sub

    Public Sub borrarTratamiento(ByVal id As String)
        Dim striSQL As String = "delete from tratamientos where id = " & id
        BDHelper.EjecutarSQL(striSQL)
    End Sub

    Public Function cargarTratamiento() As DataTable
        Dim strSQL As String = "select id, descripcion, costo from tratamientos"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Function BuscarTratamiento(ByVal QueBuscar As String, ByVal Buscar As String) As DataTable
        Dim strSQL As String = "select id, descripcion from tratamientos where " & QueBuscar & "= '" & Buscar & "'"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

End Module
