using PuntoVenta.Model.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PuntoVenta.Model.Data
{
    public class EmpleadoData
    {
        String connectionString;

        public EmpleadoData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Empleado Insert(Empleado empleado)
        {
            SqlCommand cmdEmpleado = new SqlCommand();
            cmdEmpleado.CommandText = "Empleado_Insert_Proc";
            cmdEmpleado.CommandType = CommandType.StoredProcedure;
            cmdEmpleado.Parameters.Add(new SqlParameter("@activo", empleado.Activo));
            cmdEmpleado.Parameters.Add(new SqlParameter("@apellidos", empleado.Apellidos));
            cmdEmpleado.Parameters.Add(new SqlParameter("@ciudad", empleado.Ciudad));
            cmdEmpleado.Parameters.Add(new SqlParameter("@fk_comp", empleado.Compania.Id));
            cmdEmpleado.Parameters.Add(new SqlParameter("@fk_depto", empleado.Departamento.Id));
            cmdEmpleado.Parameters.Add(new SqlParameter("@direccion", empleado.Direccion));
            cmdEmpleado.Parameters.Add(new SqlParameter("@email", empleado.Email));
            cmdEmpleado.Parameters.Add(new SqlParameter("@estado_civil", empleado.EstadoCivil));
            cmdEmpleado.Parameters.Add(new SqlParameter("@login_name", empleado.LoginName));
            cmdEmpleado.Parameters.Add(new SqlParameter("@nacionalidad", empleado.Nacionalidad));
            cmdEmpleado.Parameters.Add(new SqlParameter("@nombre", empleado.Nombre));
            cmdEmpleado.Parameters.Add(new SqlParameter("@nombre_banco_cuenta", empleado.NombreBancoCuenta));
            cmdEmpleado.Parameters.Add(new SqlParameter("@numero_cuenta_bancaria", empleado.NumeroCuentaBancaria));
            cmdEmpleado.Parameters.Add(new SqlParameter("@numero_identificacion", empleado.NumeroIdenficacion));
            cmdEmpleado.Parameters.Add(new SqlParameter("@password", empleado.Password));
            cmdEmpleado.Parameters.Add(new SqlParameter("@photo", empleado.Photo));
            cmdEmpleado.Parameters.Add(new SqlParameter("@fk_puesto_trabajo", empleado.PuestoTrabajo.Id));
            cmdEmpleado.Parameters.Add(new SqlParameter("@telefono", empleado.Telefono));
            SqlParameter parIdEmpleado = new SqlParameter("@id", SqlDbType.Int);
            parIdEmpleado.Direction = ParameterDirection.Output;

            cmdEmpleado.Parameters.Add(parIdEmpleado);

            //SqlCommand2
            SqlCommand cmdEmpleadoGrupoAcceso = new SqlCommand();
            cmdEmpleadoGrupoAcceso.CommandText = "Empleado_Grupos_Acceso_Insert_Proc";
            cmdEmpleadoGrupoAcceso.CommandType = CommandType.StoredProcedure;
            SqlConnection connection = new SqlConnection(this.connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdEmpleado.Connection = connection;
                cmdEmpleadoGrupoAcceso.Connection = connection;
                cmdEmpleado.Transaction = transaction;
                cmdEmpleadoGrupoAcceso.Transaction = transaction;

                cmdEmpleado.ExecuteNonQuery();
                empleado.Id = Int32.Parse(cmdEmpleado.Parameters["@id_emp"].Value.ToString());

                foreach (GruposAcceso item in empleado.GruposAcceso)
                {
                    cmdEmpleadoGrupoAcceso.Parameters.Add(new SqlParameter("@id_emp", empleado.Id));
                    cmdEmpleadoGrupoAcceso.Parameters.Add(new SqlParameter("@id_grupos_acceso", item.Id));
                    cmdEmpleadoGrupoAcceso.ExecuteNonQuery();
                    cmdEmpleadoGrupoAcceso.Parameters.Clear();
                }
                transaction.Commit();
            }
            catch (SqlException sqle)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw sqle;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return empleado;
        }


        public Empleado Update(Empleado empleado)
        {
            SqlCommand cmdEmpleado = new SqlCommand();
            cmdEmpleado.CommandText = "Empleado_Update_Proc";
            cmdEmpleado.CommandType = CommandType.StoredProcedure;
            cmdEmpleado.Parameters.Add(new SqlParameter("@activo", empleado.Activo));
            cmdEmpleado.Parameters.Add(new SqlParameter("@apellidos", empleado.Apellidos));
            cmdEmpleado.Parameters.Add(new SqlParameter("@ciudad", empleado.Ciudad));
            cmdEmpleado.Parameters.Add(new SqlParameter("@fk_comp", empleado.Compania.Id));
            cmdEmpleado.Parameters.Add(new SqlParameter("@fk_depto", empleado.Departamento.Id));
            cmdEmpleado.Parameters.Add(new SqlParameter("@direccion", empleado.Direccion));
            cmdEmpleado.Parameters.Add(new SqlParameter("@email", empleado.Email));
            cmdEmpleado.Parameters.Add(new SqlParameter("@estado_civil", empleado.EstadoCivil));
            cmdEmpleado.Parameters.Add(new SqlParameter("@login_name", empleado.LoginName));
            cmdEmpleado.Parameters.Add(new SqlParameter("@nacionalidad", empleado.Nacionalidad));
            cmdEmpleado.Parameters.Add(new SqlParameter("@nombre", empleado.Nombre));
            cmdEmpleado.Parameters.Add(new SqlParameter("@nombre_banco_cuenta", empleado.NombreBancoCuenta));
            cmdEmpleado.Parameters.Add(new SqlParameter("@numero_cuenta_bancaria", empleado.NumeroCuentaBancaria));
            cmdEmpleado.Parameters.Add(new SqlParameter("@numero_identificacion", empleado.NumeroIdenficacion));
            cmdEmpleado.Parameters.Add(new SqlParameter("@password", empleado.Password));
            cmdEmpleado.Parameters.Add(new SqlParameter("@photo", empleado.Photo));
            cmdEmpleado.Parameters.Add(new SqlParameter("@fk_puesto_trabajo", empleado.PuestoTrabajo.Id));
            cmdEmpleado.Parameters.Add(new SqlParameter("@telefono", empleado.Telefono));

            //SqlCommand2
            SqlCommand cmdEmpleadoGrupoAcceso = new SqlCommand();
            cmdEmpleadoGrupoAcceso.CommandText = "Empleado_Grupos_Acceso_Insert_Proc";
            cmdEmpleadoGrupoAcceso.CommandType = CommandType.StoredProcedure;
            SqlConnection connection = new SqlConnection(this.connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdEmpleado.Connection = connection;
                cmdEmpleadoGrupoAcceso.Connection = connection;
                cmdEmpleado.Transaction = transaction;
                cmdEmpleadoGrupoAcceso.Transaction = transaction;

                cmdEmpleado.ExecuteNonQuery();

                foreach (GruposAcceso item in empleado.GruposAcceso)
                {
                    cmdEmpleadoGrupoAcceso.Parameters.Add(new SqlParameter("@id_emp", empleado.Id));
                    cmdEmpleadoGrupoAcceso.Parameters.Add(new SqlParameter("@id_grupos_acceso", item.Id));
                    cmdEmpleadoGrupoAcceso.ExecuteNonQuery();
                    cmdEmpleadoGrupoAcceso.Parameters.Clear();
                }
                transaction.Commit();
            }
            catch (SqlException sqle)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw sqle;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return empleado;
        }

        public List<Empleado> GetEmpleadoByLastName(String lastName)
        {
            SqlCommand cmdEmpleado = new SqlCommand();
            cmdEmpleado.CommandText = "Empleado_Get_By_LastName_Proc";
            cmdEmpleado.CommandType = CommandType.StoredProcedure;
            cmdEmpleado.Parameters.Add(new SqlParameter("@apellido_empleado", lastName));
            cmdEmpleado.Connection = new SqlConnection(connectionString);

            SqlDataAdapter daEmpleados = new SqlDataAdapter(cmdEmpleado);
            DataSet dsEmpleados = new DataSet();
            daEmpleados.Fill(dsEmpleados, "Empleado");

            Dictionary<Int32, Empleado> dictionary = new Dictionary<int, Empleado>();
            Empleado empleado = null;
            foreach (DataRow row in dsEmpleados.Tables["Empleado"].Rows)
            {
                Int32 id = Int32.Parse(row["idEmpleado"].ToString());
                if (dictionary.ContainsKey(id) == false)
                {
                    empleado = new Empleado();
                    empleado.Id = id;
                    empleado.Activo = Boolean.Parse(row["empleadoActivo"].ToString());
                    empleado.Apellidos = row["apellidosEmpleados"].ToString();
                    empleado.Ciudad = row["empleadoCiudad"].ToString();
                    empleado.Compania.Id = Int32.Parse(row["idCompania"].ToString());
                    empleado.Compania.Nombre = row["nombreCompania"].ToString();
                    empleado.Departamento.Id = Int32.Parse(row["idDepto"].ToString());
                    empleado.Departamento.Nombre = row["nombreDepto"].ToString();
                    empleado.Direccion = row["direccionEmpleado"].ToString();
                    empleado.Email = row["empleadoEmail"].ToString();
                    empleado.EstadoCivil = row["estado_civil"].ToString();
                    empleado.LoginName = row["login_name"].ToString();
                    empleado.Nacionalidad = row["nacionalidad"].ToString();
                    empleado.Nombre = row["nombreEmpleado"].ToString();
                    empleado.NombreBancoCuenta = row["nombreBanco"].ToString();
                    empleado.NumeroCuentaBancaria = Int32.Parse(row["numeroCuentaCompCuentaBancaria"].ToString());
                    empleado.NumeroIdenficacion = Int32.Parse(row["numero_identificacion"].ToString());
                    empleado.PuestoTrabajo.Id = Int32.Parse(row["idPuestoTrabajo"].ToString());
                    empleado.PuestoTrabajo.Nombre = row["nombrePuestoTrabajo"].ToString();
                    empleado.Telefono = row["empleadoTelefono"].ToString();
                    dictionary.Add(id, empleado);

                }
                //agregar grupos de acceso
                int grupoAccesoId = Int32.Parse(row["idGrupoAccesso"].ToString());
                if (grupoAccesoId > 0)
                {
                    GruposAcceso gruposAcceso = new GruposAcceso();
                    gruposAcceso.Id = grupoAccesoId;
                    gruposAcceso.NombreGrupo = row["nombre_grupo"].ToString();
                    gruposAcceso.Comentario = row["comentario"].ToString();
                    empleado.GruposAcceso.Add(gruposAcceso);

                }//if
            }//foreach

            return dictionary.Values.ToList<Empleado>();
        }//GetByLastName

        public List<Empleado> GetAllEmpleados()
        {
            SqlCommand cmdEmpleado = new SqlCommand();
            cmdEmpleado.CommandText = "Empleado_Get_All_Proc";
            cmdEmpleado.CommandType = CommandType.StoredProcedure;
            cmdEmpleado.Connection = new SqlConnection(connectionString);

            SqlDataAdapter daEmpleados = new SqlDataAdapter(cmdEmpleado);
            DataSet dsEmpleados = new DataSet();
            daEmpleados.Fill(dsEmpleados, "Empleado");

            Dictionary<Int32, Empleado> dictionary = new Dictionary<int, Empleado>();
            Empleado empleado = null;
            foreach (DataRow row in dsEmpleados.Tables["Empleado"].Rows)
            {
                Int32 id = Int32.Parse(row["idEmpleado"].ToString());
                if (dictionary.ContainsKey(id) == false)
                {
                    empleado = new Empleado();
                    empleado.Id = id;
                    empleado.Activo = Boolean.Parse(row["empleadoActivo"].ToString());
                    empleado.Apellidos = row["apellidosEmpleados"].ToString();
                    empleado.Ciudad = row["empleadoCiudad"].ToString();
                    empleado.Compania.Id = Int32.Parse(row["idCompania"].ToString());
                    empleado.Compania.Nombre = row["nombreCompania"].ToString();
                    empleado.Departamento.Id = Int32.Parse(row["idDepto"].ToString());
                    empleado.Departamento.Nombre = row["nombreDepto"].ToString();
                    empleado.Direccion = row["direccionEmpleado"].ToString();
                    empleado.Email = row["empleadoEmail"].ToString();
                    empleado.EstadoCivil = row["estado_civil"].ToString();
                    empleado.LoginName = row["login_name"].ToString();
                    empleado.Nacionalidad = row["nacionalidad"].ToString();
                    empleado.Nombre = row["nombreEmpleado"].ToString();
                    empleado.NombreBancoCuenta = row["nombreBanco"].ToString();
                    empleado.NumeroCuentaBancaria = Int32.Parse(row["numeroCuentaCompCuentaBancaria"].ToString());
                    empleado.NumeroIdenficacion = Int32.Parse(row["numero_identificacion"].ToString());
                    empleado.PuestoTrabajo.Id = Int32.Parse(row["idPuestoTrabajo"].ToString());
                    empleado.PuestoTrabajo.Nombre = row["nombrePuestoTrabajo"].ToString();
                    empleado.Telefono = row["empleadoTelefono"].ToString();
                    dictionary.Add(id, empleado);

                }
                //agregar grupos de acceso
                int grupoAccesoId = Int32.Parse(row["idGrupoAccesso"].ToString());
                if (grupoAccesoId > 0)
                {
                    GruposAcceso gruposAcceso = new GruposAcceso();
                    gruposAcceso.Id = grupoAccesoId;
                    gruposAcceso.NombreGrupo = row["nombre_grupo"].ToString();
                    gruposAcceso.Comentario = row["comentario"].ToString();
                    empleado.GruposAcceso.Add(gruposAcceso);

                }//if
            }//foreach

            return dictionary.Values.ToList<Empleado>();
        }//GetAllEmpleados

        public void delete(int id)
        {
            SqlCommand cmdEmpleado = new SqlCommand();
            cmdEmpleado.CommandText = "Empleado_Delete_Proc";
            cmdEmpleado.CommandType = CommandType.StoredProcedure;
            cmdEmpleado.Parameters.Add(new SqlParameter("@id", id));
            SqlConnection connection = new SqlConnection(this.connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdEmpleado.Connection = connection;
                cmdEmpleado.Transaction = transaction;

                cmdEmpleado.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (SqlException sqle)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw sqle;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }//fin delete
    }
}
