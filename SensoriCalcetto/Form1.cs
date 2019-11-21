using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensoriCalcetto
{
    public partial class Form1 : Form
    {
        private List<Player> lstGiocatori;
        private int idPartita;
        Client client = new Client();
        public Form1()
        {
            InitializeComponent();
            btnStart.Enabled = false;
            lstGiocatori = client.GetPlayers();
            List<string> lstNomi = nomiGiocatori(lstGiocatori);
            cmbAttaccante1.DataSource = new BindingSource(lstNomi, string.Empty);
            cmbAttaccante2.DataSource = new BindingSource(lstNomi, string.Empty);
            cmbDifensore1.DataSource = new BindingSource(lstNomi, string.Empty);
            cmbDifensore2.DataSource = new BindingSource(lstNomi, string.Empty);
        }
        private List<string> nomiGiocatori(List<Player> lstGiocatori)
        {
            List<String> lstnomi = new List<string>();
            lstnomi.Add("");
            foreach(Player p in lstGiocatori)
            {
                lstnomi.Add(p.nome);
            }
            return lstnomi;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            idPartita = r.Next(0,99999);
            cmbAttaccante1.Enabled = false;
            cmbAttaccante2.Enabled = false;
            cmbDifensore1.Enabled = false;
            cmbDifensore2.Enabled = false;
            string json = "[{\"idPartita\":"+idPartita+",\"idGiocatore\":"+getIdByName(cmbAttaccante1.Text)+ ",\"ruolo\":\"Attaccante\",\"idSquadra\":1},{\"idPartita\":" + idPartita + ",\"idGiocatore\":" + getIdByName(cmbDifensore1.Text) + ",\"ruolo\":\"Difensore\",\"idSquadra\":1},{\"idPartita\":" + idPartita + ",\"idGiocatore\":" + getIdByName(cmbAttaccante2.Text) + ",\"ruolo\":\"Attaccante\",\"idSquadra\":2},{\"idPartita\":" + idPartita + ",\"idGiocatore\":" + getIdByName(cmbDifensore2.Text) + ",\"ruolo\":\"Difensore\",\"idSquadra\":2}]";
            client.SendData(json, "http://192.168.101.57:3000/giocatore");
            ShowComponents(true);
            btnStart.Enabled = false;
        }
        private int getIdByName(string name)
        {
            Player i = lstGiocatori.Find(x => x.nome == name);
            return i.id;
        }

        private void CheckPlayers(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(cmbAttaccante1.Text) && !String.IsNullOrWhiteSpace(cmbAttaccante2.Text) && !String.IsNullOrWhiteSpace(cmbDifensore1.Text) && !String.IsNullOrWhiteSpace(cmbDifensore2.Text))
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
        }

        private void ShowComponents(bool show)
        {
            lbl.Visible = show;
            lblPunteggio1.Visible = show;
            lblPunteggio2.Visible = show;
            lblRisultato.Visible = show;
            btnGol1.Visible = show;
            btnGol2.Visible = show;
            btnGolMancato1.Visible = show;
            btnGolMancato2.Visible = show;
            btnRollataAtt1.Visible = show;
            btnRollataAtt2.Visible = show;
            btnRollataDif1.Visible = show;
            btnRollataDif2.Visible = show;
            btnNuovaPartita.Visible = show;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowComponents(false);
        }
        private void Gol(string json)
        {
            client.SendData(json, "http://192.168.101.57:3000/evento/gol");
        }
        private void Rollata(string json)
        {
            client.SendData(json,"http://192.168.101.57:3000/evento/rollata");
        }

        private void btnGol1_Click(object sender, EventArgs e)
        {
            string json = "{\"gol\":true,\"idSquadra\":1,\"idPartita\":"+idPartita+"}";
            Gol(json);
        }

        private void btnGolMancato1_Click(object sender, EventArgs e)
        {
            string json = "{\"gol\":false,\"idSquadra\":1,\"idPartita\":" + idPartita + "}";
            Gol(json);
        }

        private void btnGol2_Click(object sender, EventArgs e)
        {
            string json = "{\"gol\":true,\"idSquadra\":2,\"idPartita\":" + idPartita + "}";
            Gol(json);
        }

        private void btnGolMancato2_Click(object sender, EventArgs e)
        {
            string json = "{\"gol\":false,\"idSquadra\":2,\"idPartita\":" + idPartita + "}";
            Gol(json);
        }

        private void btnRollataAtt1_Click(object sender, EventArgs e)
        {
            string json = "{\"rullata\":true,\"idGiocatore\":"+getIdByName(cmbAttaccante1.Text)+",\"idPartita\":" + idPartita + "}";
            Rollata(json);
        }

        private void btnRollataDif1_Click(object sender, EventArgs e)
        {
            string json = "{\"rullata\":true,\"idGiocatore\":" + getIdByName(cmbDifensore1.Text) + ",\"idPartita\":" + idPartita + "}";
            Rollata(json);
        }

        private void btnRollataAtt2_Click(object sender, EventArgs e)
        {
            string json = "{\"rullata\":true,\"idGiocatore\":" + getIdByName(cmbAttaccante2.Text) + ",\"idPartita\":" + idPartita + "}";
            Rollata(json);
        }

        private void btnRollataDif2_Click(object sender, EventArgs e)
        {
            string json = "{\"rullata\":true,\"idGiocatore\":" + getIdByName(cmbDifensore2.Text) + ",\"idPartita\":" + idPartita + "}";
            Rollata(json);
        }
    }
}
