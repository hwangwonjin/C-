using Bboard.Manager;
using Bboard.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    내용 : BackEnd
 */

namespace Bboard
{
    internal class Ex001
    {
        public void Run()
        {
            DatabaseInfo dbInfo = new DatabaseInfo();
            dbInfo.Name = "RoadbookDB";
            dbInfo.IP = "127.0.0.1";
            dbInfo.Port = "1433";
            dbInfo.UserId = "sa";
            dbInfo.UserPassword = "1234";

            MsSqlManager ms = new MsSqlManager();
            ms.open(dbInfo);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***************************");
            sb.AppendLine("1. SELECT");
            sb.AppendLine("2. INSERT");
            sb.AppendLine("3. UPDATE");
            sb.AppendLine("4. DELETE");
            sb.AppendLine("0. QUIT");
            sb.AppendLine("****************************");

            while(true)
            {
                Console.WriteLine(sb.ToString());
                string input = Console.ReadLine();

                if(input == "0")
                {
                    ms.Close();

                    Console.WriteLine("BYE");
                    break;
                }
                else
                {
                    string index = string.Empty;
                    string title = string.Empty;
                    string summary = string.Empty;
                    string createUserNm = string.Empty;
                    string tags = string.Empty;
                    string createDate = string.Empty;

                    StringBuilder sbSQL = new StringBuilder();

                    switch(input)
                    {
                        // 
                        case "1":   // SELECT
                            DataTable dt = ms.Select("SELECT IDX," +
                                "SUMMERY, CREATE_DT, CREATE_USER_NM, TAGS," +
                                "LIKE_CNT, CATEGORY_IDX FROM TB_CONTENTS");

                            if(dt.Rows.Count > 0 )
                            {
                                string[] columns =
                                    new string[dt.Columns.Count];

                                for(int idx = 0;  idx < dt.Columns.Count; idx++)
                                {
                                    columns[idx] = dt.Columns[idx].ToString();

                                    Console.WriteLine(dt.Columns[idx]);
                                }

                                Console.WriteLine();

                                for(int idx = 0;idx < dt.Rows.Count; idx++)
                                {
                                    for(int idx_j = 0; idx_j < dt.Columns.Count;idx_j++) 
                                    {
                                        Console.WriteLine(dt.Rows[idx][columns[idx_j]]);
                                    }

                                    Console.WriteLine() ;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No Data!!");
                            }

                            break;

                        case "2":       // INSERT
                            Console.Write("TITLE : ");
                            title = Console.ReadLine();
                            Console.Write("SUMMERY : ");
                            summary = Console.ReadLine();
                            Console.Write("CREATE_USER_NM : ");
                            createUserNm = Console.ReadLine();
                            Console.Write("TAGS : ");
                            tags = Console.ReadLine();

                            createDate = DateTime.Now.ToString("yyyy-MM-dd");

                            sbSQL.Append("INSERT TB_CONTENTS ( TITLE, SUMMERY, CREATE_DT," +
                                "CREATE_USER_NM, TAGS, CATEGORY_IDX ) ");
                            sbSQL.Append(string.Format(" VALUES ('{0}', '{1}', '{2}'," +
                                "'{3}', '{4}', '{5}' )", title, summary, createDate, createUserNm, tags, 2
                                )
                            );

                        ms.Insert(sbSQL.ToString());

                        break;

                        case "3":       // UPDATE
                            ms.open(dbInfo);

                            Console.Write("Changed IDX : ");
                            index = Console.ReadLine();
                            Console.Write("TITLE : ");
                            title = Console.ReadLine();
                            Console.Write("SUMMERY : ");
                            summary = Console.ReadLine();

                            sbSQL.Append(" UPDATE TB_CONTENTS SET ");
                            sbSQL.Append(string.Format(" TITLE = '{0}', SUMMERY = '{1}' ",
                                title, summary));
                            sbSQL.Append(string.Format(" WHERE IDX = {0}", index));

                        ms.Update(sbSQL.ToString()); 
                        break;

                        case "4":   // DELETE
                            ms.open(dbInfo);

                            Console.Write("DELETE IDX = ");
                            index = Console.ReadLine();

                            sbSQL.Append(" DELELTE FROM TB_CONTENTS ");
                            sbSQL.Append(string.Format("WHERE IDX = {0}", index));

                            ms.Update(sbSQL.ToString());
                            break;

                        default:
                            Console.WriteLine("Invalid");

                            break;
                    }
                }
            }
        }
    }
}
