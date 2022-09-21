using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EverQuest
{
    public partial class Form1 : Form
    {
        PC pc;
        Wolf wolf;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Race> dataSourceRace = new List<Race>();
            dataSourceRace.Add(new Race() { Name = "Iksar" });
            dataSourceRace.Add(new Race() { Name = "Human" });
            dataSourceRace.Add(new Race() { Name = "Wood Elf" });

            this.cmbRace.DataSource = dataSourceRace;
            this.cmbRace.DisplayMember = "Name";

            List<CharacterClass> dataSourceCharacterClass = new List<CharacterClass>();
            dataSourceCharacterClass.Add(new CharacterClass() { Name = "Warrior" });
            dataSourceCharacterClass.Add(new CharacterClass() { Name = "Necromancer" });
            dataSourceCharacterClass.Add(new CharacterClass() { Name = "Bard" });

            this.cmbClass.DataSource = dataSourceCharacterClass;
            this.cmbClass.DisplayMember = "Name";

            wolf = new Wolf();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            pc = new PC(txtName.Text, cmbRace.Text, cmbClass.Text);

            txtName.Enabled = false;
            cmbRace.Enabled = false;
            cmbClass.Enabled = false;
            btnCreate.Enabled = false;

            prgHP.Maximum = pc.maxHP;
            prgHP.Value = pc.currentHP;

            txtLevel.Text = $"{pc.level} / 60";
        }

        private void btnFightWolf_Click(object sender, EventArgs e)
        {
            pc.Attack(wolf);
            wolf.Bite(pc);
            prgHP.Value = pc.currentHP;
        }
    }

    public class Being
    {
        public int maxHP { get; set; }
        public int currentHP { get; set; }
        public int level { get; set; }  
    }

    public class Character : Being
    {
        public string name;
        public string race;
        public string characterClass;
    }

    public class NPC : Character
    {
        string role;
    }

    public class PC : Character
    {
        public PC(string name, string race, string characterClass)
        {
            this.name = name;
            this.race = race;
            this.characterClass = characterClass;
            level = 1;
            maxHP = 50;
            currentHP = maxHP;
        }

        public void Attack(Monster monster)
        {
            Random dice = new Random();
            int damage = dice.Next(10, 20) * level;
            if (monster.currentHP > damage)
                monster.currentHP -= damage;
            else
                monster.Die();

        }

        public void Die()
        {
            MessageBox.Show("You have died");
            
        }
    }

    public class Monster : Being
    {
        protected int aggressionLevel;
        public int valueXP;

        public void Die()
        {
            currentHP = 0;
        }
    }

    public class Wolf : Monster
    {
        public Wolf()
        {
            Random dice = new Random();
            level = dice.Next(3, 6);

            switch (level)
            {
                case 3:
                    maxHP = dice.Next(20, 40);
                    valueXP = 30;
                    break;
                case 4:
                    maxHP = dice.Next(30, 50);
                    valueXP = 40;
                    break;
                case 5:
                    maxHP = dice.Next(40, 60);
                    valueXP = 50;
                    break;
                case 6:
                    maxHP = dice.Next(50, 70);
                    valueXP = 60;
                    break;
            }

            currentHP = maxHP;

        }

        public void Bite(PC pc)
        {
            Random dice = new Random();
            int damage = dice.Next(5, 10) * level;
            if (pc.currentHP > damage)
                pc.currentHP -= damage;
            else
                pc.Die();
        }
    }

    public class Skeleton : Monster
    {

    }

    public class Spider : Monster
    {

    }

    public class Race
    {
        public string Name { get; set; }
    }

    public class CharacterClass
    {
        public string Name { get; set; }
    }
}
