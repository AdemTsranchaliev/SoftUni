using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage 
    {
        private List<Rabbit> data;


        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count  => this.data.Count; 

        public Cage(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Rabbit>();
        }

        public void Add(Rabbit rabit)
        {
            if (this.Capacity>=this.data.Count+1)
            {
                this.data.Add(rabit);

            }
        }
        public bool RemoveRabbit(string name)
        {
            var rabitToRemove = this.data.FirstOrDefault(x => x.Name == name);
            if (rabitToRemove == null)
            {
                return false;
            }
            else
            {
                this.data.Remove(rabitToRemove);
                return true;
            }
        }
        public void RemoveSpecies(string species)
        {
            this.data.RemoveAll(x=>x.Species==species);
        }
        public Rabbit SellRabbit(string name)
        {
            var rabitToSell = this.data.FirstOrDefault(x => x.Name == name);
            if (rabitToSell!=null)
            {
                rabitToSell.Available = false;
            }
            return rabitToSell;
        }
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var rabits2= this.data.Where(x => x.Species == species).ToArray();
            foreach (var item in rabits2)
            {
                item.Available = false;
            }

            return rabits2;
        }

        public string Report()
        {
            var buidler = new StringBuilder();
            buidler.AppendLine($"Rabbits available at {this.Name}:");
            var notSold = this.data.Where(x => x.Available == true).ToList();
            for (int i = 0; i < notSold.Count; i++)
            {
                buidler.AppendLine($"{notSold[i].ToString()}");
            }

            return buidler.ToString().TrimEnd();
        }

    }
}
