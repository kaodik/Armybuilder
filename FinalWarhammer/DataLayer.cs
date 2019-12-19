using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace FinalWarhammer
{
    class DataLayer
    {

        //comm with the database
        private OleDbCommand comm;
        private OleDbConnection conn;
        private OleDbDataReader recruteReader;

        public DataLayer()
        {
            string connString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Warhammer.mdb";
            conn = new OleDbConnection(connString);//creating the object
            conn.Open();
        }

        public List<Recrute> getRecuitFromDB()
        {
            List<Recrute> allRecute = new List<Recrute>();

            string selectRec = "SELECT * FROM RECUIT";

            comm = new OleDbCommand(selectRec, conn);

            recruteReader = comm.ExecuteReader(CommandBehavior.CloseConnection);

            while (recruteReader.Read())
            {
                string id = recruteReader["RecuitID"].ToString();
                string rName = recruteReader["RecuitName"].ToString();
                string price = recruteReader["price"].ToString();
                string health = recruteReader["Health"].ToString();
                string speed = recruteReader["Speed"].ToString();
                string Attack = recruteReader["Attack"].ToString();
                string def = recruteReader["Defence"].ToString();
                string Picn = recruteReader["PicName"].ToString();

                Recrute r = new Recrute(id, rName, price, health, speed, Attack, def, Picn);

                allRecute.Add(r);
            }
            recruteReader.Close();
            return allRecute;
        }

        public void deleteRecruteFromDB(Recrute r)
        {
            conn.Open();
            string deleteRec = "DELETE FROM RECUIT WHERE RecuitID=?";

            comm = new OleDbCommand(deleteRec, conn);

            OleDbParameter pramID = new OleDbParameter("RecuitID", r.RecuitID);//placeing in to the placeholder of deleteStue var

            comm.Parameters.Add(pramID);//letting the them know about eachother

            comm.ExecuteNonQuery();

            conn.Close();
        }

        public void addNewRecrute(Recrute r)
        {
            try
            {
                conn.Open();

                string insertRec = "INSERT INTO RECUIT (RecuitName, price, Health, Speed, Attack, Defence) VALUES (?,?,?,?,?,?)";

                comm = new OleDbCommand(insertRec, conn);

                OleDbParameter paramN = new OleDbParameter("RecuitName", r.RecuitName);
                OleDbParameter paramP = new OleDbParameter("price", r.Price);
                OleDbParameter paramH = new OleDbParameter("Health", r.Health);
                OleDbParameter paramS = new OleDbParameter("Speed", r.Speed);
                OleDbParameter paramA = new OleDbParameter("Attack", r.Attack);
                OleDbParameter paramD = new OleDbParameter("Defence", r.Defence);

                comm.Parameters.Add(paramN);
                comm.Parameters.Add(paramP);
                comm.Parameters.Add(paramH);
                comm.Parameters.Add(paramS);
                comm.Parameters.Add(paramA);
                comm.Parameters.Add(paramD);

                comm.ExecuteNonQuery();

            }
            catch(Exception ex)
            {

            }

        }

        public string getNewRecordID()
        {
            string newID = "";

            //L@@K
            string selectNEWID = "SELECT @@Identity FROM RECUIT";
            comm = new OleDbCommand(selectNEWID, conn);
            recruteReader = comm.ExecuteReader(CommandBehavior.CloseConnection);

            recruteReader.Read();

            newID = recruteReader[0].ToString();

            recruteReader.Close();

            return newID;
        }

        public void addPic(Recrute r)
        {
            try
            {
                conn.Open();

                string insertPic = "INSERT INTO RECUIT (PicName) VALUES (?)";

                comm = new OleDbCommand(insertPic, conn);

                OleDbParameter paramPic = new OleDbParameter("PicName", r.PicName);

                comm.Parameters.Add(paramPic);

                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }

        

        public void editRecrute(Recrute r)
        {
            try
            {
                conn.Open();

                string updateRec = "UPDATE RECUIT SET " +
                    "RecuitName=?, " +
                    "price=?, " +
                    "Health=?, " +
                    "Speed=?, " +
                    "Attack=?, " +
                    "Defence=? " +
                    "WHERE RecuitID=?";

                comm = new OleDbCommand(updateRec, conn);

                OleDbParameter paramN = new OleDbParameter("RecuitName", r.RecuitName);
                OleDbParameter paramP = new OleDbParameter("price", r.Price);
                OleDbParameter paramH = new OleDbParameter("Health", r.Health);
                OleDbParameter paramS = new OleDbParameter("Speed", r.Speed);
                OleDbParameter paramA = new OleDbParameter("Attack", r.Attack);
                OleDbParameter paramD = new OleDbParameter("Defence", r.Defence);

                comm.Parameters.Add(paramN);
                comm.Parameters.Add(paramP);
                comm.Parameters.Add(paramH);
                comm.Parameters.Add(paramS);
                comm.Parameters.Add(paramA);
                comm.Parameters.Add(paramD);

                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {

            }

        }
    }
}
