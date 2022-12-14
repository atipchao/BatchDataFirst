using BatchDataFirst.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchDataFirst
{
    class Program
    {
        public static MyContext _db = new MyContext();        

        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            //Setup input
            string ws_path = ConfigurationSettings.AppSettings["INPUT_PATH"];
            string ws_input_file = ConfigurationSettings.AppSettings["INPUT_FILE"];
            string inputData = File.ReadAllText(ws_path + ws_input_file);
            string[] allFields;
            int rowCnt = 0;
            int rowInserted = 0;
            int errCnt = 0;

            foreach (string row in inputData.Split('\n'))
            {
                rowCnt++;
                if (!string.IsNullOrEmpty(row))
                {
                    am_ant_sys _am_ant_sys = new am_ant_sys();
                    allFields = row.Split('|');
                    //Console.WriteLine(row);
                    _am_ant_sys.am_dom_status = allFields[0].ToString().Trim();
                    _am_ant_sys.ant_dir_ind = allFields[1].ToString().Trim();
                    _am_ant_sys.ant_mode = allFields[2].ToString().Trim();
                    _am_ant_sys.ant_sys_id = allFields[3].ToString().Trim();
                    _am_ant_sys.application_id = allFields[4].ToString().Trim();
                    _am_ant_sys.aug_count = allFields[5].ToString().Trim();
                    // .. keep going till you get all 39 fields populated 
                    try
                    {
                        _db.am_ant_sys.Add(_am_ant_sys);
                        _db.SaveChanges();
                        rowInserted++;
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.ToString());
                        errCnt++;
                    }
                    finally
                    {

                    }
                }
            }
            //All is done with all records, let's drop the DATABASE connection
            _db.Dispose();
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.WriteLine("FIN..");
            Console.WriteLine("EXIT");
        }
    }
}
