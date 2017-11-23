using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

public class DatabaseCon
{
	
	private DatabaseCon _Instance;
	public SqlConnection Connection;

	public DatabaseCon Instancia
	{
		get {
			if (_Instance == null)
				_Instance = new DatabaseCon();
			return _Instance;
		}

	}


	private DatabaseCon()
	{
		Connection = new SqlConnection();
	}
}
