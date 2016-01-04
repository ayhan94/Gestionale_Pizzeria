using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConnessioneODP;
using FF3D.Common;
using FF3D.Common.Helpers;
using System.Configuration;

namespace Gestionale_Pizzeria.Models.DAL
{
    public class SqlHelpers
    {
        //public static internalObject Exists(string table, string instance, string filter)
        //{
        //    internalObject r = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;
        //    StringBuilder sb = new StringBuilder();

        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        sb.Clear();
        //        string query = sb.AppendFormat("select count(*) from {0} ", table).ToString();
        //        if (filter != "")
        //            query += " where " + filter;
        //        if (c.EseguiQuerySingoloValoreNumericoIntero(query) > 0)
        //            r.exists = true;
        //        r.isok = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        r.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return r;
        //}

        //public static internalObject Count(string table, string instance, string filter, string fullQuery = "")
        //{
        //    internalObject r = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;
        //    StringBuilder sb = new StringBuilder();
        //    string query = "";

        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        sb.Clear();
        //        if (fullQuery == "")
        //        {
        //            query = sb.AppendFormat("select count(*) from {0} ", table).ToString();
        //            if (filter != "")
        //                query += " where " + filter;
        //        }
        //        else
        //            query = fullQuery;
        //        r.count = c.EseguiQuerySingoloValoreNumericoIntero(query);
        //        r.isok = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        r.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return r;
        //}

        //public static internalObject GetSingleString(string table, string instance, string item, string filter, string fullQuery = "")
        //{
        //    internalObject io = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;
        //    StringBuilder sb = new StringBuilder();

        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        sb.Clear();
        //        string query = sb.AppendFormat("select " + item + " from {0} ", table).ToString();
        //        if (filter != "")
        //            query += " where " + filter;
        //        if (fullQuery != "")
        //            query = fullQuery;

        //        io.str = c.EseguiQuerySingoloValore(query);
        //        io.isok = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        io.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return io;
        //}

        //public static internalObject GetSingleNumber(string table, string instance, string item, string filter, string fullQuery = "")
        //{
        //    internalObject io = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;
        //    StringBuilder sb = new StringBuilder();

        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        sb.Clear();
        //        string query = sb.AppendFormat("select " + item + " from {0} ", table).ToString();
        //        if (filter != "")
        //            query += " where " + filter;
        //        if (fullQuery != "")
        //            query = fullQuery;

        //        io.count = c.EseguiQuerySingoloValoreNumericoIntero(query);
        //        io.isok = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        io.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return io;
        //}

        //public static internalObject GetDataTable(string query, string instance)
        //{
        //    internalObject io = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;

        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        io.dt = c.EseguiQueryDT(query);

        //        if (io.dt != null)
        //        {
        //            io.isok = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        io.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return io;
        //}

        //public static internalObject GetDataTable(string table, string instance, string filter, string order, string take)
        //{
        //    internalObject io = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;
        //    string addFilter = string.Empty;
        //    string addTake = "*";
        //    string addOrder = string.Empty;
        //    if (take != "")
        //        addTake = take;
        //    if (filter != "")
        //        addFilter = " WHERE " + filter;
        //    if (order != "")
        //        addOrder = " ORDER BY " + order;

        //    string editedQuery = "select " + addTake + " from " + table + " " + addFilter + addOrder;
        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        io.dt = c.EseguiQueryDT(editedQuery);

        //        if (io.dt != null)
        //        {
        //            io.isok = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        io.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return io;
        //}

        //public static internalObject GetDataTable(string table, string instance, string filter, string order, string take, ConnessioneODP.ConnessioneODP c)
        //{
        //    internalObject io = new internalObject();
        //    string addFilter = string.Empty;
        //    string addTake = "*";
        //    string addOrder = string.Empty;
        //    if (take != "")
        //        addTake = take;
        //    if (filter != "")
        //        addFilter = " WHERE " + filter;
        //    if (order != "")
        //        addOrder = " ORDER BY " + order;
        //    string editedQuery = "select " + addTake + " from " + table + " " + addFilter + addOrder;
        //    try
        //    {
        //        io.dt = c.EseguiQueryDT(editedQuery);

        //        if (io.dt != null)
        //        {
        //            io.isok = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        io.message = ex.Message;
        //    }

        //    return io;
        //}

        //public static internalObject GetDataTablePaginated(string table, string instance, string filter, string order, string take, int page, int itemsPerPage)
        //{
        //    internalObject io = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;
        //    string addFilter = string.Empty;
        //    string addTake = "*";
        //    string addOrder = string.Empty;
        //    if (take != "")
        //        addTake = take;
        //    if (filter != "")
        //        addFilter = " WHERE " + filter;
        //    string editedQuery = "SELECT * FROM (SELECT t." + addTake + ", Row_Number() OVER (ORDER BY " + order + ") MyRow from " + table + " t " + addFilter + ") where MyRow BETWEEN " + ((page * itemsPerPage) + 1) + " and " + (page + 1) * itemsPerPage;
        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        io.dt = c.EseguiQueryDT(editedQuery);

        //        if (io.dt != null)
        //        {
        //            io.isok = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        io.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return io;
        //}

        //public static internalObject InsertSingle(string table, string instance, colvalObject cv)
        //{
        //    internalObject r = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;
        //    StringBuilder sb = new StringBuilder();
        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        sb.Clear();
        //        string query = sb.AppendFormat("insert into {0} ({1}) values ({2})", table, CreateColumns(cv.columns), CreateValues(cv.values, cv.types)).ToString();
        //        c.EseguiQuerySenzaRitorno(query);
        //        r.isok = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        r.isok = false;
        //        r.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return r;
        //}

        //public static internalObject Delete(string table, string instance, colvalObject fi, string where = " where ")
        //{
        //    internalObject re = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;
        //    StringBuilder sb = new StringBuilder();
        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        sb.Clear();
        //        string query = sb.AppendFormat("delete from {0} {1} {2}", table, where, UpdateValues(fi.columns, fi.values, fi.types, "and")).ToString();
        //        c.EseguiQuerySenzaRitorno(query);
        //        re.isok = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        re.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return re;
        //}

        //public static internalObject Update(string table, string instance, colvalObject nv, colvalObject fi, string where = " where ")
        //{
        //    internalObject r = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;
        //    StringBuilder sb = new StringBuilder();
        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        sb.Clear();
        //        string query = sb.AppendFormat("update {0} SET {1} {2} {3}", table, UpdateValues(nv.columns, nv.values, nv.types, ","), where, UpdateValues(fi.columns, fi.values, fi.types, "and")).ToString();
        //        c.EseguiQuerySenzaRitorno(query);
        //        r.isok = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        r.isok = false;
        //        r.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return r;
        //}

        //public static internalObject InsertMultiple(List<string> table, string instance, List<colvalObject> cv)
        //{
        //    internalObject r = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;
        //    StringBuilder sb = new StringBuilder();
        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        c.BeginTransaction();

        //        for (int i = 0; i < table.Count; i++)
        //        {
        //            sb.Clear();
        //            string query = sb.AppendFormat("insert into {0} ({1}) values ({2})", table[i], CreateColumns(cv[i].columns), CreateValues(cv[i].values, cv[i].types)).ToString();
        //            c.EseguiQuerySenzaRitorno(query);
        //        }
        //        c.CommitTransaction();
        //        r.isok = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        c.RollbackTransaction();
        //        r.isok = false;
        //        r.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return r;
        //}

        //public static internalObject Multiple(string instance, List<multipleObject> m)
        //{
        //    internalObject r = new internalObject();
        //    ConnessioneODP.ConnessioneODP c = null;
        //    int id = 0;
        //    StringBuilder sb = new StringBuilder();
        //    try
        //    {
        //        c = new ConnessioneODP.ConnessioneODP(instance);
        //        c.BeginTransaction();
        //        string query = "";
        //        for (int i = 0; i < m.Count; i++)
        //        {
        //            sb.Clear(); //String Builder
        //            switch (m[i].action)
        //            {
        //                case multipleType.insert:
        //                    query = sb.AppendFormat("insert into {0} ({1}) values ({2})", m[i].table, CreateColumns(m[i].nv.columns), CreateValues(m[i].nv.values, m[i].nv.types)).ToString();
        //                    break;

        //                case multipleType.update:
        //                    string where = "";
        //                    if (m[i].fi.columns.Count > 0)
        //                        where = " where ";
        //                    query = sb.AppendFormat("update {0} set {1} {2} {3}", m[i].table, UpdateValues(m[i].nv.columns, m[i].nv.values, m[i].nv.types, ","), where, UpdateValues(m[i].fi.columns, m[i].fi.values, m[i].fi.types, m[i].separator)).ToString();
        //                    break;

        //                case multipleType.delete:
        //                    query = sb.AppendFormat("delete from {0} where {1}", m[i].table, UpdateValues(m[i].fi.columns, m[i].fi.values, m[i].fi.types, m[i].separator)).ToString();
        //                    break;

        //                case multipleType.easyq:
        //                case multipleType.easyQWithIntReturn:
        //                    query = m[i].easyq;
        //                    break;

        //                case multipleType.customInsert:

        //                    m[i].nv.columns.Add("IDTESTATA");
        //                    m[i].nv.types.Add(typeof(int));
        //                    m[i].nv.values.Add(id.ToString());

        //                    query = sb.AppendFormat("insert into {0} ({1}) values ({2})", m[i].table, CreateColumns(m[i].nv.columns), CreateValues(m[i].nv.values, m[i].nv.types)).ToString();
        //                    break;
        //            }

        //            if (m[i].action == multipleType.easyQWithIntReturn)
        //            {
        //                id = c.EseguiQuerySingoloValoreNumericoIntero(query) - 1;  //otteniamo l'id incrementale dell'ultimo elemento inserito
        //            }
        //            else
        //            {
        //                c.EseguiQuerySenzaRitorno(query);
        //            }
        //        }
        //        c.CommitTransaction();
        //        r.isok = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        c.RollbackTransaction();
        //        r.message = ex.Message;
        //    }
        //    finally
        //    {
        //        if (c != null)
        //        {
        //            c.Close();
        //            c.Dispose();
        //        }
        //    }
        //    return r;
        //}

        //public static internalObject Multiple(string instance, List<multipleObject> m, ConnessioneODP.ConnessioneODP c)
        //{
        //    internalObject r = new internalObject();
        //    int id = 0;
        //    StringBuilder sb = new StringBuilder();
        //    try
        //    {
        //        string query = "";
        //        for (int i = 0; i < m.Count; i++)
        //        {
        //            sb.Clear(); //String Builder
        //            switch (m[i].action)
        //            {
        //                case multipleType.insert:
        //                    query = sb.AppendFormat("insert into {0} ({1}) values ({2})", m[i].table, CreateColumns(m[i].nv.columns), CreateValues(m[i].nv.values, m[i].nv.types)).ToString();
        //                    break;

        //                case multipleType.update:
        //                    string where = "";
        //                    if (m[i].fi.columns.Count > 0)
        //                        where = " where ";
        //                    query = sb.AppendFormat("update {0} set {1} {2} {3}", m[i].table, UpdateValues(m[i].nv.columns, m[i].nv.values, m[i].nv.types, ","), where, UpdateValues(m[i].fi.columns, m[i].fi.values, m[i].fi.types, m[i].separator)).ToString();
        //                    break;

        //                case multipleType.delete:
        //                    query = sb.AppendFormat("delete from {0} where {1}", m[i].table, UpdateValues(m[i].fi.columns, m[i].fi.values, m[i].fi.types, m[i].separator)).ToString();
        //                    break;

        //                case multipleType.easyq:
        //                case multipleType.easyQWithIntReturn:
        //                    query = m[i].easyq;
        //                    break;

        //                case multipleType.customInsert:

        //                    m[i].nv.columns.Add("IDTESTATA");
        //                    m[i].nv.types.Add(typeof(int));
        //                    m[i].nv.values.Add(id.ToString());

        //                    query = sb.AppendFormat("insert into {0} ({1}) values ({2})", m[i].table, CreateColumns(m[i].nv.columns), CreateValues(m[i].nv.values, m[i].nv.types)).ToString();
        //                    break;
        //            }

        //            if (m[i].action == multipleType.easyQWithIntReturn)
        //            {
        //                id = c.EseguiQuerySingoloValoreNumericoIntero(query) - 1;  //otteniamo l'id incrementale dell'ultimo elemento inserito
        //            }
        //            else
        //            {
        //                c.EseguiQuerySenzaRitorno(query);
        //            }
        //        }

        //        r.isok = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        r.message = ex.Message;
        //    }

        //    return r;
        //}

        private static string CreateColumns(List<string> cols)
        {
            string c = string.Empty;
            foreach (string s in cols)
            {
                if (c != string.Empty)
                    c += ", ";
                c += s;
            }
            return c;
        }

        //private static string CreateValues(List<string> values, List<Type> t)
        //{
        //    string c = string.Empty;
        //    for (int i = 0; i < values.Count; i++)
        //    {
        //        if (c != string.Empty)
        //            c += ", ";
        //        //get types
        //        if (t[i] == typeof(string))
        //            c += FunzioniBase.V(values[i]);
        //        if (t[i] == typeof(int))
        //            c += values[i];
        //        if (t[i] == typeof(double))
        //            c += values[i].Replace(",", ".");
        //        if (t[i] == typeof(DateTime))
        //            c += FunzioniBase.ORACLEdataOra(values[i]);
        //    }
        //    return c;
        //}

        private static string UpdateValues(List<string> cols, List<string> values, List<Type> t, string separator)
        {
            string c = string.Empty;

            for (int i = 0; i < values.Count; i++)
            {
                string generated = string.Empty;
                if (c != string.Empty)
                    generated += " " + separator + " ";
                //get types
                if (t[i] == typeof(string))
                    generated += cols[i] + "=" + FunzioniBase.V(values[i]);
                else if (t[i] == typeof(int))
                    generated += cols[i] + "=" + values[i];
                else if (t[i] == typeof(float))
                    generated += cols[i] + "=" + values[i];
                else if (t[i] == typeof(double))
                    generated += cols[i] + "=" + values[i].Replace(".", ",");
                else if (t[i] == typeof(Nullable))
                    generated += cols[i] + " " + values[i];
                else if (t[i] == typeof(DateTime))
                {
                    DateTime td = Convert.ToDateTime(values[i]);
                    TimeZone localZone = TimeZone.CurrentTimeZone;
                    TimeSpan currentOffset = localZone.GetUtcOffset(td);
                    td = td.Add(currentOffset);
                    //c += cols[i] + "=convert(datetime," + Help.V(td.ToString()) + ")";
                    //c += cols[i] + "=convert(datetime," + Help.V(values[i]) + ")";
                    //c += cols[i] + "=convert(datetime," + Help.V(td.ToString("dd-MMM-yy", new CultureInfo(CultureInfo.CurrentCulture.Name))) + ")";
                    string dF = "yyyy-MM-dd HH:mm:ss";
                    try
                    {
                        dF = ConfigurationManager.AppSettings["dateFormat"];
                    }
                    catch { }
                    if (td != DateTime.MinValue && td.Year != 1 && td.Year != 1900)
                    {
                        generated += cols[i] + "=" + FunzioniBase.ORACLEdataOra(td.ToString(dF));
                    }
                    else
                    {
                        generated += cols[i] + "=null";
                    }
                }
                c += generated;
            }

            return c;
        }

        //    public static internalObject GetDynamic(string table, string instance, string filter, string order, string take, string fullQuery = "")
        //    {
        //        internalObject io = new internalObject();
        //        StringBuilder sb = new StringBuilder();
        //        ConnessioneODP.ConnessioneODP c = null;
        //        string editedQuery = string.Empty;

        //        if (fullQuery == "")
        //        {
        //            string addFilter = string.Empty;
        //            string addTake = "*";
        //            string addOrder = string.Empty;
        //            if (take != "")
        //                addTake = take;
        //            if (filter != "")
        //                addFilter = " WHERE " + filter;
        //            if (order != "")
        //                addOrder = " ORDER BY " + order;
        //            editedQuery = "select " + addTake + " from " + table + " " + addFilter + addOrder;
        //        }
        //        else
        //            editedQuery = fullQuery;

        //        try
        //        {
        //            c = new ConnessioneODP.ConnessioneODP(instance);
        //            io.dt = c.EseguiQueryDT(editedQuery);

        //            if (io.dt != null)
        //            {
        //                foreach (DataRow r in io.dt.Rows)
        //                {
        //                    var x = new ExpandoObject() as IDictionary<string, Object>;
        //                    foreach (DataColumn col in io.dt.Columns)
        //                    {
        //                        string cName = col.ColumnName.ToLower();
        //                        x.Add(cName, r[cName].ToString());
        //                    }
        //                    io.dynObj.Add((ExpandoObject)x);
        //                }
        //                io.isok = true;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            io.message = ex.Message;
        //        }
        //        finally
        //        {
        //            if (c != null)
        //            {
        //                c.Close();
        //                c.Dispose();
        //            }
        //        }

        //        return io;
        //    }
    }
}
