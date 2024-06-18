using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using RugbyClubManagement.Models;

namespace RugbyClubManagement.Data
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager()
        {
            connectionString = ConfigurationManager.ConnectionStrings["RugbyClubDB"].ConnectionString;
        }

        public void ImportPlayersFromCSV(string filePath)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var reader = new StreamReader(filePath))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                var values = line.Split(',');
                                if (values.Length == 5)
                                {
                                    // Debugging logs
                                    Console.WriteLine("Reading line: " + line);

                                    int playerId = int.Parse(values[0].Trim());
                                    string firstName = values[1].Trim();
                                    string lastName = values[2].Trim();
                                    DateTime dateOfBirth = DateTime.Parse(values[3].Trim());
                                    bool isActive = bool.Parse(values[4].Trim());

                                    string query = "INSERT INTO Players (PlayerID, FirstName, LastName, DateOfBirth, IsActive) VALUES (@PlayerID, @FirstName, @LastName, @DateOfBirth, @IsActive)";
                                    using (var command = new MySqlCommand(query, connection, transaction))
                                    {
                                        command.Parameters.AddWithValue("@PlayerID", playerId);
                                        command.Parameters.AddWithValue("@FirstName", firstName);
                                        command.Parameters.AddWithValue("@LastName", lastName);
                                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                                        command.Parameters.AddWithValue("@IsActive", isActive);
                                        command.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Exception: " + ex.Message);
                        throw;
                    }
                }
            }
        }

        public void ImportTeamsFromCSV(string filePath)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var reader = new StreamReader(filePath))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                var values = line.Split(',');
                                if (values.Length == 4)
                                {
                                    // Debugging logs
                                    Console.WriteLine("Reading line: " + line);

                                    int teamId = int.Parse(values[0].Trim());
                                    string teamName = values[1].Trim();
                                    string coachName = values[2].Trim();
                                    DateTime foundedDate = DateTime.Parse(values[3].Trim());

                                    string query = "INSERT INTO Teams (TeamID, TeamName, CoachName, FoundedDate) VALUES (@TeamID, @TeamName, @CoachName, @FoundedDate)";
                                    using (var command = new MySqlCommand(query, connection, transaction))
                                    {
                                        command.Parameters.AddWithValue("@TeamID", teamId);
                                        command.Parameters.AddWithValue("@TeamName", teamName);
                                        command.Parameters.AddWithValue("@CoachName", coachName);
                                        command.Parameters.AddWithValue("@FoundedDate", foundedDate);
                                        command.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Exception: " + ex.Message);
                        throw;
                    }
                }
            }
        }

        public void InsertPlayer(Player player)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Players (PlayerID, FirstName, LastName, DateOfBirth, IsActive) VALUES (@PlayerID, @FirstName, @LastName, @DateOfBirth, @IsActive)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", player.PlayerID);
                    command.Parameters.AddWithValue("@FirstName", player.FirstName);
                    command.Parameters.AddWithValue("@LastName", player.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", player.DateOfBirth);
                    command.Parameters.AddWithValue("@IsActive", player.IsActive);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertTeam(Team team)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Teams (TeamID, TeamName, CoachName, FoundedDate) VALUES (@TeamID, @TeamName, @CoachName, @FoundedDate)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", team.TeamID);
                    command.Parameters.AddWithValue("@TeamName", team.TeamName);
                    command.Parameters.AddWithValue("@CoachName", team.CoachName);
                    command.Parameters.AddWithValue("@FoundedDate", team.FoundedDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool DeletePlayer(string playerName)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Players WHERE FirstName = @FirstName";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", playerName);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteTeam(string teamName)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Teams WHERE TeamName = @TeamName";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamName", teamName);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public List<string> GetAllPlayers()
        {
            var players = new List<string>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT FirstName FROM Players";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            players.Add(reader.GetString("FirstName"));
                        }
                    }
                }
            }
            return players;
        }

        public List<string> GetAllTeams()
        {
            var teams = new List<string>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TeamName FROM Teams";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teams.Add(reader.GetString("TeamName"));
                        }
                    }
                }
            }
            return teams;
        }

        private void SaveChanges()
        {
            // Not needed for MySQL implementation
        }
    }
}
