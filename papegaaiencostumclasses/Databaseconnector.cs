using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace papegaaiencostumclasses
{
    class Databaseconnector
    {
        MySqlConnection con = new MySqlConnection("server = localhost; user id = root; password=ascent;persistsecurityinfo=True;database=datanallyspapegaaien");





        public static void insertondersoort(Vogelondersoort onder)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; password=ascent;persistsecurityinfo=True;database=datanallyspapegaaien");

            con.Open();
            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO ondersoort(naam) VALUES(?naam)";
            comm.Parameters.Add("?naam", MySqlDbType.VarChar).Value=onder.Naam;
            comm.ExecuteNonQuery();
            con.Close();
        }
        public static void insertpersoon(Persoon persoon)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; password=ascent;persistsecurityinfo=True;database=datanallyspapegaaien");

            con.Open();
            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO personen(naam, achternaam, straatnaam, straatnr, postcode, telnr, email, gsmnr, rekeningnr, xtranotities) VALUES(?naam, ?achternaam, ?straatnaam, ?straatnr, ?postcode, ?telnr, ?email, ?gsmnr, ?rekeningnr, ?xtranotities)";
            comm.Parameters.Add("?naam", MySqlDbType.VarChar).Value = persoon.Naam;
            comm.Parameters.Add("?achternaam", MySqlDbType.VarChar).Value = persoon.Achternaam;
            comm.Parameters.Add("?straatnaam", MySqlDbType.VarChar).Value = persoon.straatnaam;
            comm.Parameters.Add("?straatnr", MySqlDbType.Int64).Value = persoon.Straatnummer;
            comm.Parameters.Add("?postcode", MySqlDbType.Int64).Value = persoon.Postcode;
            comm.Parameters.Add("?telnr", MySqlDbType.VarChar).Value = persoon.telenr;
            comm.Parameters.Add("?email", MySqlDbType.VarChar).Value = persoon.email;
            comm.Parameters.Add("?gsmnr", MySqlDbType.VarChar).Value = persoon.gsmnr;
            comm.Parameters.Add("?rekeningnr", MySqlDbType.VarChar).Value = persoon.rekeningr;
            comm.Parameters.Add("?xtranotities", MySqlDbType.VarChar).Value = persoon.extranotities;

            comm.ExecuteNonQuery();
            con.Close();
        }
        public static void identificationsysteminsertwithoutcites(ID id)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; password=ascent;persistsecurityinfo=True;database=datanallyspapegaaien");

            con.Open();
            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO identificationsystem(ringnr, regin) VALUES(?ringnr, ?regin)";
            comm.Parameters.Add("?ringnr", MySqlDbType.VarChar).Value = id.ringnr;
            comm.Parameters.Add("?regin", MySqlDbType.Int64).Value = id.registratienrin;
            comm.ExecuteNonQuery();
            con.Close();
        }
        public static void identificationsysteminsertwithcites(ID id)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; password=ascent;persistsecurityinfo=True;database=datanallyspapegaaien");

            con.Open();
            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO identificationsystem(ringnr, regin, citesnr) VALUES(?ringnr, ?regin, ?citesnr)";
            comm.Parameters.Add("?ringnr", MySqlDbType.VarChar).Value = id.ringnr;
            comm.Parameters.Add("?regin", MySqlDbType.Int64).Value = id.registratienrin;
            comm.Parameters.Add("?citesnr", MySqlDbType.VarChar).Value = id.CITESNR;
            comm.ExecuteNonQuery();
            con.Close();
        }
        public static void intervogelsoortall(Vogelsoort vogel)
        {
            MySqlConnection myConnection = new MySqlConnection("server = localhost; user id = root; password=ascent;persistsecurityinfo=True;database=datanallyspapegaaien");
            myConnection.Open();

            MySqlCommand myCommand = myConnection.CreateCommand();
            MySqlTransaction myTrans;

            // Start a local transaction
            myTrans = myConnection.BeginTransaction();
            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            myCommand.Connection = myConnection;
            myCommand.Transaction = myTrans;
            Int64 papeid = new Int64();
            try
            {
                try
                {
                    MySqlDataReader reader = null;
                    string selectCmd = "LAST_INSERT_ID() FROM  vogelsoort";

                    MySqlCommand command = new MySqlCommand(selectCmd,myConnection);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                       string idpape= reader.ToString();
                        papeid = Convert.ToInt32(idpape);
                    }
                }
                catch (Exception ex)
                {
                   
                }

                foreach (Vogelondersoort onder in vogel.ondersoorten)
                {
                    Int64 papidnew = new Int64();
                    papidnew = (papeid++);
                    myCommand.CommandText = "INSERT INTO ondersoort (naam) VALUES ('?ondersoortnaam')";
                    myCommand.Parameters.Add("?ondersoortnaam", MySqlDbType.VarChar).Value = onder.Naam;
                    myCommand.ExecuteNonQuery();

                    myCommand.CommandText = "INSERT INTO hoofdtoonder (Id, idondersoorten) VALUES ( @lastparrot, LAST_INSERT_ID() from ondersoort)";
                    myCommand.Parameters.Add("@lastparrot", MySqlDbType.Int32).Value = papidnew;

                    myCommand.ExecuteNonQuery();
                }
                myCommand.CommandText = "INSERT INTO vogelsoort (naam, idsublistsoorten) VALUES ( @vogelsoortnaam, LAST_INSERT_ID() from hooftoonder)";
                myCommand.Parameters.Add("@vogelsoortnaam", MySqlDbType.Int32).Value = vogel.Soortnaam;

                myCommand.ExecuteNonQuery();

                myTrans.Commit();
            }
            catch (Exception e)
            {
                try
                {
                    myTrans.Rollback();
                }
                catch (MySqlException ex)
                {
                    if (myTrans.Connection != null)
                    {
                        Console.WriteLine("An exception of type " + ex.GetType() +
                        " was encountered while attempting to roll back the transaction.");
                    }
                }

                Console.WriteLine("An exception of type " + e.GetType() +
                " was encountered while inserting the data.");
                Console.WriteLine("Neither record was written to database.");
            }
            finally
            {
                myConnection.Close();
            }
        }
    }

    }

