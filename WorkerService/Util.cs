using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService
{
  public static class Util
  {
    public class DBParamentro
    {
      public string Nome { get; set; }
      public object Valor { get; set; }
      public SqlDbType Tipo { get; set; }
      public ParameterDirection Direcao { get; set; }
      public int Tamanho { get; set; }
    }

    public static DataTable Query(System.Data.SqlClient.SqlConnection conn, string sSqlText)
    {
      if (conn.State == ConnectionState.Closed) { conn.Open(); }

      DbDataAdapter oSqlDataAdapter = new SqlDataAdapter(sSqlText, conn);
      DataSet oDataSet = new DataSet();
      DataTable oData = new DataTable();

      try
      {
        oSqlDataAdapter.SelectCommand.CommandTimeout = 0;
        oSqlDataAdapter.Fill(oDataSet);
        oData = oDataSet.Tables[0];

        oDataSet.Dispose();
        oSqlDataAdapter.Dispose();
      }
      catch (Exception Ex)
      {
        var erro = Ex.Message;
      }

      return oData;
    }

    public static bool Executar(System.Data.SqlClient.SqlConnection conn, string sSqlText, DBParamentro[] DBParamentro)
    {
      try
      {
        if (conn.State == ConnectionState.Closed) { conn.Open(); }

        SqlCommand oCommand = new SqlCommand();
        oCommand = conn.CreateCommand();
        oCommand.CommandTimeout = 0;

        oCommand.CommandType = CommandType.Text;
        oCommand.CommandText = sSqlText;

        if (DBParamentro != null)
        foreach (var param in DBParamentro)
        {
          var paramc = oCommand.Parameters.Add(param.Nome, param.Tipo);

          if (param.Direcao != 0)
            paramc.Direction = param.Direcao;
          if (param.Tamanho != 0)
            paramc.Size = param.Tamanho;
          paramc.Value = param.Valor;
        }

        oCommand.ExecuteNonQuery();

        return true;
      }
      catch (Exception Ex)
      {
        //_logger.LogError(Ex.Message);
        return false;
      }
    }

    public static DBParamentro DBParametro_Montar(string nome,
                                           object valor,
                                           SqlDbType tipo = SqlDbType.VarChar,
                                           ParameterDirection direcao = ParameterDirection.Input,
                                           int tamanho = 0)
    {
      DBParamentro oPar = new DBParamentro();

      oPar.Nome = nome;
      oPar.Valor = valor;
      oPar.Tipo = tipo;
      oPar.Direcao = direcao;

      if (tamanho > -1)
      {
        if ((tipo == SqlDbType.VarChar) && (tamanho == 0))
        { oPar.Tamanho = 100; }
        else
        { oPar.Tamanho = tamanho; }
      }

      return oPar;
    }
  }
}
