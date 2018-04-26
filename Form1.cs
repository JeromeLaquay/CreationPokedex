using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreationPokedex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void creer_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "En cours...";
            using (var ctx = new PokedexContext())
            {
                var Poke = new Pokemon();
                Poke.Numero = Int32.Parse(NumeroBox.Text);
                Poke.Nom = NomBox.Text;
                Poke.PV = Int32.Parse(PVBox.Text);
                Poke.PD = Int32.Parse(PDBox.Text);

                ctx.Pokemons.Add(Poke);
                ctx.SaveChanges();

                labelInfo.Text = "OK !";
            }
        }

        private void ajouterAttaque_Click(object sender, EventArgs e)
        {
            using (var ctx = new PokedexContext())
            {
                AttackBox.Items.Add(ctx.Attaques);
                
            }
        }

        
    }
}
