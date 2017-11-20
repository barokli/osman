using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for dbQueries
/// </summary>
public class dbQueries
{
    public static readonly string _s = WebConfigurationManager.ConnectionStrings["osmanConnectionString"].ConnectionString;

    public dbQueries()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public static void saveAnswer(int member_id, int question_id, DateTime date, bool correct, TimeSpan? time) //soru işareti nullable demek oluyor
    {
        SoruDBDataContext sorudb = new SoruDBDataContext();

        tx_answeredQuestionOS taq = new tx_answeredQuestionOS();
        taq.member_id = member_id;
        taq.question_id = question_id;
        taq.date = date;
        taq.correct = correct;
        taq.time = time;

        sorudb.tx_answeredQuestionOS.InsertOnSubmit(taq);
        sorudb.SubmitChanges();

    }

    public static bool answerCheck(int question_id, string answer)
    {
        SoruDBDataContext sorudb = new SoruDBDataContext();

        var correnctAnswer = sorudb.dt_questionOS.Where(p => p.id == question_id).Select(p => p.answer).FirstOrDefault();

        return correnctAnswer == answer;

    }

    public static DataTable first9Questions(int topic_id)
    {
        using (var connection = new SqlConnection(_s))
        {
            connection.Open();
            using (
                var command = new SqlCommand(@"

select * from
(select top 3 id from dt_questions where topic_id= @topic_id and difficulty = 1 order by NEWID()) a
union all 
select * from
(select top 3 id from dt_questions where topic_id= @topic_id and difficulty = 2 order by NEWID()) v
union all
select * from
(select top 3 id from dt_questions where topic_id= @topic_id and difficulty =3 order by NEWID()) n


", connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@topic_id", topic_id);
                SqlDataAdapter adp = new SqlDataAdapter(command);
                DataTable a = new DataTable();
                adp.Fill(a);
                return a;
            }

        }

    }
}