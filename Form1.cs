using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_lab_10
{
    public partial class Form1 : Form
    {
        const double PointsForWin = 3,
                     PointsForDraw = 1.5,
                     PointsForLoose = 0;

        const int TeamsAmount = 8;
        readonly string[] TeamNames = new string[TeamsAmount] 
        {
            "Altai Basket", "Bavaria", "Valencia", "Philadelphia",
            "Toronto Raptors", "Washington Huskies", "Cleveland Cavaliers", "Detroit Pistons"
        };

        Random random = new Random();

        Team[] TournamentTeams;
        List<Match> TournamentMatches;

        private int GenerateGoals(double halflife)
        {
            int m = 0;
            double S = Math.Log(random.NextDouble() * 10);

            while (S > -halflife)
            {
                S += Math.Log(random.NextDouble());
                m++;
            }

            return m;
        }

        private void ClearAll()
        {
            TournamentTeams = new Team[TeamsAmount];
            TournamentMatches = new List<Match>();
        }

        private void CreateTeams()
        {
            for (int i = 0; i < TeamsAmount; i++)
            {
                TournamentTeams[i] = new Team() { Name = TeamNames[i] };
            }
        }

        private void SimulateMatches()
        {
            for (int Iter1 = 0; Iter1 < TeamsAmount; Iter1++)
            {
                for (int Iter2 = 0; Iter2 < TeamsAmount; Iter2++)
                {
                    if (Iter1 != Iter2)
                    {
                        int GoalsFirstTeam = GenerateGoals(random.NextDouble());
                        int GoalsSecondTeam = GenerateGoals(random.NextDouble());

                        Match newMatch = new Match()
                        {
                            Team1 = TournamentTeams[Iter1],
                            Team2 = TournamentTeams[Iter2],
                            Goals1 = GoalsFirstTeam,
                            Goals2 = GoalsSecondTeam
                        };
                        TournamentMatches.Add(newMatch);

                        TournamentTeams[Iter1].Goals += GoalsFirstTeam;
                        TournamentTeams[Iter2].Goals += GoalsSecondTeam;

                        TournamentTeams[Iter1].Games++;
                        TournamentTeams[Iter2].Games++;

                        if (GoalsFirstTeam > GoalsSecondTeam)
                        {
                            TournamentTeams[Iter1].Wins++;
                            TournamentTeams[Iter2].Losts++;
                        }
                        else if (GoalsFirstTeam < GoalsSecondTeam)
                        {
                            TournamentTeams[Iter1].Losts++;
                            TournamentTeams[Iter2].Wins++;
                        }
                        else
                        {
                            TournamentTeams[Iter1].Draws++;
                            TournamentTeams[Iter2].Draws++;
                        }
                    }
                }
            }
        }

        private void CountPoints()
        {
            for (int i = 0; i < TeamsAmount; i++)
            {
                TournamentTeams[i].Points =
                    TournamentTeams[i].Wins * PointsForWin
                    + TournamentTeams[i].Draws * PointsForDraw
                    + TournamentTeams[i].Losts * PointsForLoose;
            }
        }

        private void ShowTournamentResults()
        {
            for (int i = 0; i < TeamsAmount; i++)
            {
                dataGridViewTournament.Rows.Add(
                    TournamentTeams[i].Name, TournamentTeams[i].Games,
                    TournamentTeams[i].Wins, TournamentTeams[i].Draws,
                    TournamentTeams[i].Losts, TournamentTeams[i].Goals,
                    TournamentTeams[i].Points
                );
            }
        }

        private void ShowMatches()
        {
            foreach (var match in TournamentMatches)
            {
                dataGridViewMatches.Rows.Add(
                    match.Team1.Name,
                    match.Team2.Name,
                    $"{ match.Goals1 }:{ match.Goals2 }"
                );
            }
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            ClearAll();
            CreateTeams();
            SimulateMatches();
            CountPoints();
            ShowTournamentResults();
            ShowMatches();
        }
        public Form1()
        {
            InitializeComponent();
        }

        struct Team
        {
            public string Name;
            public int Games, Goals,
                Wins, Losts, Draws;
            public double Points;
        }

        struct Match
        {
            public Team Team1, Team2;
            public int Goals1, Goals2;
        }
    }
}
