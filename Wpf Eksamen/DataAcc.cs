using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Wpf_Eksamen
{
    class DataAcc
    {

        public List<Client> Getinfo()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CleanITDB")))
            {
                List<Client> output = connection.Query<Client>($"SELECT * FROM Privat ").ToList();
                return output;
            }
        }

        public void InsertPrivat(string navn, string efternavn, string adresse, int postnummer, string telefon)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CleanITDB")))
            {
                List<Client> privat = new List<Client>();

                privat.Add(new Client { Navn = navn, EfterNavn = efternavn, Adresse = adresse, PostNummer = postnummer, Telefon = telefon });

                connection.Execute("dbo.Adder @Navn, @EfterNavn, @Adresse, @PostNummer, @Telefon", privat);
            }
        }
    }

}

