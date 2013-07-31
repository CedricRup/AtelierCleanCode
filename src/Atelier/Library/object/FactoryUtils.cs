

using System;
using System.Data;
using System.Data.SqlClient;

public class FactoryUtils {

	private FactoryUtils() {
	}

	public static Object getValueFromRs(IDataReader rs, String columnName) {
		Object val = null;
		try {
			
			val = rs[columnName];
			if ("".Equals(val))
			{
				val = null;
			}
		}
			
		catch (SqlException sqle) {
			val = null;
		}
		return val;
	}

	public static long getLongValueFromRs(IDataReader rs, String columnName) {
		long val = 0;
		try {
			if (rs[columnName] as string != null) {
				val = (long) (rs.GetInt64(rs.GetOrdinal(columnName)));
			}
		}
		catch (SqlException sqle) {
		}
		return val;
	}

	public static Byte getByteValueFromRs(IDataReader rs, String columnName) {
		Byte val = 0;
		try {
			if (rs.GetString(rs.GetOrdinal(columnName)) != null) {
				val = rs.GetByte(rs.GetOrdinal(columnName));
			}
		}
		catch (SqlException sqle) {
			
		}
		return val;
	}

}
