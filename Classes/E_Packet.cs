using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Paqueteria
{
    public class Package
    {
        private int p_code;
        private string p_content;
        private string p_term;
        private DateTime p_ETA;
        private float p_weight;
        private float p_cost;
        private float p_vol;

        public int P_code { get => p_code; set => p_code = value; }
        public string P_content { get => p_content; set => p_content = value; }
        public string P_term { get => p_term; set => p_term = value; }
        public DateTime P_ETA { get => p_ETA; set => p_ETA = value; }
        public float P_weight { get => p_weight; set => p_weight = value; }
        public float P_cost { get => p_cost; set => p_cost = value; }
        public float P_vol { get => p_vol; set => p_vol = value; }
    }

    public class User 
    {
        private string u_name;
        private string u_pass;

        public string U_name { get => u_name; set => u_name = value; }
        public string U_pass { get => u_pass; set => u_pass = value; }
    }

    public class RootData
    {
        public Dictionary<string, User> users { get; set; } = new Dictionary<string, User>();
        public Dictionary<string, Package> packages { get; set; } = new Dictionary<string, Package>();
    }
}
