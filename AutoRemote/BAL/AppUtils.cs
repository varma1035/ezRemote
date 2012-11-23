using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


/// <summary>
/// This Class is General Class for the application.
/// This Class hold all the application level variables, and application level methods like conversition of data, log,etc..
/// </summary>
public static class AppUtils
{
    public static string AppName = "";
    public static Random RandomGen = new Random();
    public static string datapath = @"C:\autoremote";

    public static string[] SplitString(string mainstr, string splitterstr)
    {
        string[] str = Regex.Split(mainstr, splitterstr, RegexOptions.IgnoreCase);
        return str;
    }

    public static string ReplaceProtocol(string absurl)
    {
        string strurl = absurl.Replace("http:", "");
        strurl = strurl.Replace("https:", "");
        return strurl;
    }

    public static string GetString(object objvalue)
    {
        if (objvalue == null)
        {
            return "";
        }
        if (objvalue == DBNull.Value)
        {
            return "";
        }
        return objvalue.ToString();
    }

    public static long GetLong(object objvalue)
    {
        long result;
        string value = GetString(objvalue);
        if (value == "")
        {
            return 0;
        }
        //return Convert.ToInt64(value);
        else
        {
            if (long.TryParse(objvalue.ToString(), out result) == true)
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }

    public static int GetInt(object objvalue)
    {
        int result = 0;
        string value = GetString(objvalue);
        if (value == "")
        {
            return 0;
        }
        else
        {

            if (int.TryParse(objvalue.ToString(), out result) == true)
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        //return Convert.ToInt32(value);

    }

    public static DateTime GetDate(object objvalue)
    {
        string value = GetString(objvalue);
        if (value == "")
        {
            return new DateTime(1, 1, 1);
        }
        return Convert.ToDateTime(value);
    }

    public static bool GetBoolean(object objvalue)
    {
        string value = GetString(objvalue);
        if (value == "")
        {
            return false;
        }
        return Convert.ToBoolean(value);
    }

    public static void Error(string error)
    {
        string log = AppUtils.datapath + @"\error.log";
        error = Environment.NewLine + DateTime.Now.ToString() + " [Error] " + error;
        File.AppendAllText(log, error);
        MessageBox.Show("There is an error arrived during execution.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static Dictionary<string, string> GetProperties(string path)
    {
        string fileData = "";
        using (StreamReader sr = new StreamReader(path))
        {
            fileData = sr.ReadToEnd().Replace("\r", "");
        }
        Dictionary<string, string> Properties = new Dictionary<string, string>();
        string[] kvp;
        string[] records = fileData.Split("\n".ToCharArray());
        foreach (string record in records)
        {
            kvp = record.Split("=".ToCharArray());
            Properties.Add(kvp[0], kvp[1]);
        }
        return Properties;
    }

    public static int GetRandom()
    {
        return RandomGen.Next();

    }

    public static bool IsFileLocked(string filepath)
    {
        FileInfo file = new FileInfo(filepath);
        FileStream stream = null;

        try
        {
            stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
        }
        catch (IOException)
        {
            //the file is unavailable because it is:
            //still being written to
            //or being processed by another thread
            //or does not exist (has already been processed)
            return true;
        }
        finally
        {
            if (stream != null)
                stream.Close();
        }

        //file is not locked
        return false;
    }

    public static string GetR4HTime(DateTime time)
    {
        string strtime = time.ToString("yyyy/MM/dd hh:mm:ss");
        return strtime;
    }
}

public class FileManager
{
    public string ReadAllText(string path)
    {
        StreamReader streamReader = new StreamReader(path);
        string data = streamReader.ReadToEnd();
        streamReader.Close();
        streamReader.Dispose();
        return data;
    }

    public bool IsFileInUse(FileInfo file)
    {
        FileStream stream = null;

        try
        {
            stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
        }
        catch (IOException)
        {
            //the file is unavailable because it is:
            //still being written to
            //or being processed by another thread
            //or does not exist (has already been processed)
            return true;
        }
        finally
        {
            if (stream != null)
                stream.Close();
        }

        //file is not locked
        return false;
    }
}


