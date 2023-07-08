using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Team> namesTeams = new List<Team>();

            for (int i = 0; i < count; i++)
            {
                List<string> line = Console.ReadLine().Split("-").ToList();
                bool result = exists(line[1], namesTeams);

                if (result)
                {
                    if (existsCreator(line[0], namesTeams))
                    {
                        Console.WriteLine($"Team {line[1]} has been created by {line[0]}!");
                        Team team = new Team(line[1], line[0]);
                        namesTeams.Add(team);
                    } else
                    {
                        Console.WriteLine($"{line[0]} cannot create another team!");
                    }
                } else
                {
                    Console.WriteLine($"Team {line[1]} was already created!");
                }
            }

            string command = Console.ReadLine();

            while(command != "end of assignment")
            {
                List<string> line = command.Split("->").ToList();

                if (exists(line[1], namesTeams))
                {
                    Console.WriteLine($"Team {line[1]} does not exist!");
                } else
                {
                    if (!sameTeamJoining(line[0], namesTeams))
                    {
                        
                    } else
                    {
                        int num = returnNum(line[1], namesTeams);
                        namesTeams[num].Members.Add(line[0]);
                    }
                }


                command = Console.ReadLine();
            }

            List<Team> teamWithMembers = new List<Team>();
            List<Team> teamWithoutMembers = new List<Team>();

            for (int i = 0; i < namesTeams.Count; i++)
            {
                if (namesTeams[i].Members.Count == 0)
                {
                    teamWithoutMembers.Add(namesTeams[i]);
                } else
                {
                    teamWithMembers.Add(namesTeams[i]);
                }
            }

            //sort



            for (int i = 0; i < teamWithMembers.Count; i++)
            {
                teamWithMembers[i].print();
            }

            Console.WriteLine("Teams to disband:");

            for (int i = 0; i < teamWithoutMembers.Count; i++)
            {
                Console.WriteLine(teamWithoutMembers[i].Name);
            }
        }

        static void sortAscendingOrder(List<Team> teams)
        {

        }

        static bool sameTeamJoining(string name, List<Team> teams)
        {

            for (int i = 0; i < teams.Count; i++)
            {
                if (name == teams[i].Creator)
                {
                    Console.WriteLine($"Member {name} cannot join team {teams[i].Name}!");
                    return false;
                }

                for (int j = 0; j < teams[i].Members.Count; j++)
                {
                    if (name == teams[i].Members[j])
                    {
                        Console.WriteLine($"Member {name} cannot join team {teams[i].Name}!");
                        return false;
                    }
                }
            }

            return true;
        }

        static bool exists(string teamName, List<Team> names)
        {
            if (names.Count == 0)
            {
                return true;
            } else
            {
                bool exist = true;

                for (int i = 0; i < names.Count; i++)
                {
                    if (teamName == names[i].Name)
                    {
                        exist = false;
                    }
                }

                return exist;
            }
        }

        static bool existsCreator(string creator, List<Team> names)
        {
            if (names.Count == 0)
            {
                return true;
            }
            else
            {
                bool exist = true;

                for (int i = 0; i < names.Count; i++)
                {
                    if (creator == names[i].Creator)
                    {
                        exist = false;
                    }
                }

                return exist;
            }
        }

        static int returnNum(string teamName, List<Team> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (teamName == names[i].Name)
                {
                    return i;
                } 
            }

            return -1;
        }
    }

    public class Team
    {

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public void print()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"- {Creator}");
            for (int i = 0;i < Members.Count;i++)
            {
                Console.WriteLine($"-- {Members[i]}");
            }
        }
    }
}