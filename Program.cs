﻿using System;

namespace project_league
{abstract public  class human {
        protected string name;
        protected float weight;
        protected float height;
    public human()
        {
            name = "";
            weight = 0;
            height = 0;


        }
   public string Name { get { return name; }
            set { name = value; }
        }
        public float Height { get { return height; } set { 
                
                if (value > 0)
                height = value; } }
        public float Weight { get { return weight; } set
            {if (value > 0)
                    weight = value;

            } }

    }
  public  class player : human
    {
       protected  string position;
     protected   float rate;
        public player()
        : base() { position = "";
            rate = 0;



        } virtual  public float avgrating() {
            return 0;
        
        
        
        }  }
  public   class goalkeeper:player  {

        int successaves;
        int totalsave;
        
        public goalkeeper():base() {
            successaves = 0;
            totalsave = 1;
            position = "goal keeper ";
        
        }
      public int Successsaves { get { return successaves; }
            set {if (value > 0)
                    successaves = value;    }
        }
      public int Totalsaves { get { return totalsave; }
            set { if (value > successaves)
                    totalsave = value;
            }
        
        }

        public override float avgrating()
        { rate = (float)(successaves / totalsave);
            rate = rate * 10;
            return rate;
        }
       

    }
    public class defender:player {



        int successtackles;
        int totaltackles;

        public defender() : base()
        {
            successtackles = 0;
            totaltackles = 1;
            position = "defender ";

        }
        public int Successtackles
        {
            get { return successtackles; }
            set
            {
                if (value > 0)
                    successtackles = value;
            }
        }
        public int Totalsaves
        {
            get { return totaltackles; }
            set
            {
                if (value > successtackles)
                    totaltackles = value;
            }

        }

        public override float avgrating()
        {
            rate = (float)(successtackles / totaltackles);
            rate = rate * 10;
            return rate;
        }



    }
    public class back:player
    {
        int successcrosses;
        int totalcrosses;

        public back() : base()
        {
            successcrosses = 0;
            totalcrosses = 1;
            position = "back ";

        }
        public int Successcrosses
        {
            get { return successcrosses; }
            set
            {
                if (value > 0)
                    successcrosses = value;
            }
        }
        public int Totalcrosses
        {
            get { return totalcrosses; }
            set
            {
                if (value > successcrosses)
                    totalcrosses = value;
            }

        }

        public override float avgrating()
        {
            rate = (float)(successcrosses / totalcrosses);
            rate = rate * 10;
            return rate;
        }
    }
    public class mid:player
    {
        int successpasses;
        int totalpasses;

        public mid() : base()
        {
            successpasses = 0;
            totalpasses = 1;
            position = "midfileder ";

        }
        public int Successpasses
        {
            get { return successpasses; }
            set
            {
                if (value > 0)
                    successpasses = value;
            }
        }
        public int Totalpasses
        {
            get { return totalpasses; }
            set
            {
                if (value > successpasses)
                    totalpasses = value;
            }

        }

        public override float avgrating()
        {
            rate = (float)(successpasses / totalpasses);
            rate = rate * 10;
            return rate;
        }
    }
    public class wing : player
    {
        int successdribbles;
        int totaldribbles;

        public wing() : base()
        {
            successdribbles = 0;
            totaldribbles = 1;
            position = "winger ";

        }
        public int Successdribbles
        {
            get { return successdribbles; }
            set
            {
                if (value > 0)
                    successdribbles = value;
            }
        }
        public int Totaldribbles
        {
            get { return totaldribbles; }
            set
            {
                if (value > successdribbles)
                    totaldribbles = value;
            }

        }

        public override float avgrating()
        {
            rate = (float)(successdribbles / totaldribbles);
            rate = rate * 10;
            return rate;
        }
    }
    public class st : player
    {
        int successshoots;
        int totalshoots;

        public st() : base()
        {
            successshoots = 0;
            totalshoots = 1;
            position = "striker ";

        }
        public int Successshoots
        {
            get { return successshoots; }
            set
            {
                if (value > 0)
                    successshoots = value;
            }
        }
        public int Totalshoots
        {
            get { return totalshoots; }
            set
            {
                if (value > successshoots)
                    totalshoots = value;
            }

        }

        public override float avgrating()
        {
            rate = (float)(successshoots / totalshoots);
            rate = rate * 10;
            return rate;
        }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
