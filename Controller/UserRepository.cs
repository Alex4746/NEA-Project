using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEA_Math_Program.Models;
using NEA_Math_Program.View;

namespace NEA_Math_Program.Controller
{
    internal class UserRepository
    {
        private readonly string connectionString;

        internal UserRepository()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30;";
        }
        internal UserView GetUserByEmail(string email, bool isStudent)
        {
            string query = isStudent
                ? "SELECT  FirstName, LastName, StudentID, Password, Email FROM Students WHERE Email = @Email"
                : "SELECT  FirstName, LastName, TeacherID, Password, Email FROM Teachers WHERE Email = @Email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        return new UserView
                        {
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            ID = isStudent ? reader.GetInt32(reader.GetOrdinal("StudentID")) : reader.GetInt32(reader.GetOrdinal("TeacherID")),
                            Password = reader["Password"].ToString(),
                            Email = reader["Email"].ToString(),
                            IsStudent = isStudent
                        };
                    }
                }
            }

            return null;
        }
        internal int CreateClass(int teacherID, string className)
        {
            string insert = "INSERT INTO Class (ClassName, TeacherID) VALUES (@ClassName, @TeacherID)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                cmd.Parameters.AddWithValue("@ClassName", className);
                conn.Open();
                var newClassID = cmd.ExecuteScalar();
                return Convert.ToInt32(newClassID);
            }
        }
        internal void AddStudentToClass(int studentID, int classID)
        {
            string insert = "INSERT INTO ClassStudents (ClassID, StudentID) VALUES (@ClassID, @StudentID)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@ClassID", classID);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        internal int GetNumOfStudents(int classID)
        {
            string query = "SELECT COUNT(*) FROM ClassStudents WHERE ClassID = @ClassID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ClassID", classID);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        internal int GetClassID(int teacherID)
        {
            string query = "SELECT ClassID FROM Class WHERE TeacherID = @TeacherID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }
        internal List<StudentViewModel> GetStudents(int classID, int id, string name)
        {
            var results = new List<StudentViewModel>();

            string query = ("SELECT s.FirstName, s.LastName, s.StudentID, s.Email FROM Students s INNER JOIN ClassStudents cs ON s.StudentID = cs.StudentID WHERE cs.ClassID = @ClassID ORDER BY s.StudentID");

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query.ToString(), conn))
            {
                cmd.Parameters.AddWithValue("@ClassID", classID);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new StudentViewModel
                        {
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            StudentID = reader.GetInt32(reader.GetOrdinal("StudentID")),
                        });
                    }
                }
            }

            return results;
        }
        internal List<StudentViewModel> GetAllStudents(int id, string name)
        {
            var results = new List<StudentViewModel>();

            string query = ("SELECT  FirstName, LastName, Email, StudentID FROM Students");

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query.ToString(), conn))
            {

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new StudentViewModel
                        {
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            StudentID = reader.GetInt32(reader.GetOrdinal("StudentID")),
                        });
                    }
                }
            }

            return results;
        }
        internal bool RemoveStudentFromClass(int studentID, int classID)
        {
            const string delete = "DELETE FROM ClassStudents WHERE ClassID = @ClassID AND StudentID = @StudentID";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(delete, conn))
            {
                cmd.Parameters.Add("@ClassID", System.Data.SqlDbType.Int).Value = classID;
                cmd.Parameters.Add("@StudentID", System.Data.SqlDbType.Int).Value = studentID;
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine($"RemoveStudentFromClass: classID={classID}, studentID={studentID}, rowsAffected={rowsAffected}");
                return rowsAffected > 0;
            }
        }
        internal bool CreateUser(bool isStudent, string firstName, string lastName, string email, string password)
        {
            string query = isStudent
                ? "INSERT INTO Students (FirstName, LastName, Email, Password) VALUES (@FirstName, @LastName, @Email, @Password)"
                : "INSERT INTO Teachers (FirstName, LastName, Email, Password) VALUES (@FirstName, @LastName, @Email, @Password)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        internal bool HasClass(string email)
        {
            string query = "SELECT COUNT(*) FROM Class JOIN Teachers ON Class.TeacherID = Teachers.TeacherID WHERE Email = @Email";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
        internal void CreateAssignment(string title, string content, DateTime dueDate, int teacherID)
        {
            string insert = "INSERT INTO Assignments (Title, Content, DueDate, TeacherID) VALUES (@Title, @Content, @DueDate, @TeacherID)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Content", content);
                cmd.Parameters.AddWithValue("@DueDate", dueDate);
                cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        internal List<QuestionViewModel> GetQuestions()
        {
            var results = new List<QuestionViewModel>();
            string query = ("SELECT QuestionID, Difficulty, Description FROM Questions");
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query.ToString(), conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new QuestionViewModel
                        {
                            QuestionID = reader.GetInt32(reader.GetOrdinal("QuestionID")),
                            Difficulty = reader.GetInt32(reader.GetOrdinal("Difficulty")),
                            Description = reader["Description"].ToString()
                        });
                    }
                }
            }
            return results;
        }
        internal void AddQuestionToAssignment(int assignmentID, int questionID)
        {
            string insert = "INSERT INTO AssignmentQuestions (AssignmentID, QuestionID) VALUES (@AssignmentID, @QuestionID)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                cmd.Parameters.AddWithValue("@QuestionID", questionID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        internal List<QuestionViewModel> GetAssignmentQuestions(int assignmentID)
        {
            var results = new List<QuestionViewModel>();
            string query = ("SELECT q.QuestionID, q.Question, q.Answer, q.Difficulty, q.Description FROM Questions q INNER JOIN AssignmentQuestions aq ON q.QuestionID = aq.QuestionID WHERE aq.AssignmentID = @AssignmentID");
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query.ToString(), conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new QuestionViewModel
                        {
                            QuestionID = reader.GetInt32(reader.GetOrdinal("QuestionID")),
                            Question = reader["Question"].ToString(),
                            Answer = reader["Answer"].ToString(),
                            Difficulty = reader.GetInt32(reader.GetOrdinal("Difficulty")),
                            Description = reader["Description"].ToString()
                        });
                    }
                }
            }
            return results;
        }
        internal int GetAssignmentID(int teacherID)
        {
            string query = "SELECT TOP 1 AssignmentID FROM Assignments WHERE TeacherID = @TeacherID ORDER BY AssignmentID DESC";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }
        internal void AssignHomeworkToStudent(int assignmentID, int studentID)
        {
            string insert = "INSERT INTO StudentAssignments (AssignmentID, StudentID) VALUES (@AssignmentID, @StudentID)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        internal bool IsHomeworkAssigned(int studentID, int assignmentID)
        {
            string query = "SELECT COUNT(*) FROM StudentAssignments WHERE StudentID = @StudentID AND AssignmentID = @AssignmentID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        internal AssignmentViewModel GetAssignmentDetails(int teacherID)
        {
            string query = "SELECT AssignmentID, Title, Content, DueDate FROM Assignments WHERE TeacherID = @TeacherID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new AssignmentViewModel
                        {
                            AssignmentID = reader.GetInt32(reader.GetOrdinal("AssignmentID")),
                            Title = reader["Title"].ToString(),
                            Content = reader["Content"].ToString(),
                            DueDate = reader.GetDateTime(reader.GetOrdinal("DueDate"))
                        };
                    }
                }
            }
            return null;
        }
        internal int GetTeacherID(int studentID)
        {
            string query = "SELECT TeacherID FROM Class JOIN ClassStudents ON Class.ClassID = ClassStudents.ClassID WHERE ClassStudents.StudentID = @StudentID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }
        internal string GetQuestionAnswer(int questionID)
        {
            string query = "SELECT Answer FROM Questions WHERE QuestionID = @QuestionID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@QuestionID", questionID);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result?.ToString();
            }
        }
        internal void SubmitAnswer(int assignmentID, int studentID, int questionID, int timeTakenSeconds, bool isCorrect, string response)
        {
            string insert = "INSERT INTO StudentQuestionAttempts (AssignmentID, StudentID, QuestionID, TimeTakenSeconds, IsCorrect, Response) VALUES (@AssignmentID, @StudentID, @QuestionID, @TimeTakenSeconds, @IsCorrect, @Response)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@QuestionID", questionID);
                cmd.Parameters.AddWithValue("@TimeTakenSeconds", timeTakenSeconds);
                cmd.Parameters.AddWithValue("@IsCorrect", isCorrect);
                cmd.Parameters.AddWithValue("@Response", response);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        internal List<AssignmentViewModel> GetStudentAssignments(int studentID)
        {
            var results = new List<AssignmentViewModel>();
            string query = "SELECT a.AssignmentID, a.Title, a.Content, a.DueDate FROM Assignments a INNER JOIN StudentAssignments sa ON a.AssignmentID = sa.AssignmentID WHERE sa.StudentID = @StudentID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new AssignmentViewModel
                        {
                            AssignmentID = reader.GetInt32(reader.GetOrdinal("AssignmentID")),
                            Title = reader["Title"].ToString(),
                            Content = reader["Content"].ToString(),
                            DueDate = reader.GetDateTime(reader.GetOrdinal("DueDate"))
                        });
                    }
                }
            }
            return results;
        }
        internal AssignmentResultViewModel GetAssignmentResults(int assignmentID, int studentID)
        {

            string query = "SELECT Status, Result, TimeTaken, Feedback FROM StudentAssignments WHERE AssignmentID = @AssignmentID AND StudentID = @StudentID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new AssignmentResultViewModel
                        {
                            Status = reader["Status"].ToString(),
                            Result = reader["Result"].ToString(),
                            TimeTaken = reader.GetInt32(reader.GetOrdinal("TimeTaken")),
                            Feedback = reader["Feedback"].ToString()
                        };
                    }
                }
            }
            return null;
        }
        internal void AssignmentCompleted(int assignmentID, int studentID, int result, int timeTaken)
        {
            string update = "UPDATE StudentAssignments SET Status = 'Complete', Result = @Result, TimeTaken = @TimeTaken WHERE AssignmentID = @AssignmentID AND StudentID = @StudentID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand updateCmd = new SqlCommand(update, conn))
            {
                updateCmd.Parameters.AddWithValue("@Result", result);
                updateCmd.Parameters.AddWithValue("@TimeTaken", timeTaken);
                updateCmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                updateCmd.Parameters.AddWithValue("@StudentID", studentID);
                conn.Open();
                updateCmd.ExecuteNonQuery();
            }
        }
        internal QuestionResultViewModel GetQuestionResults(int assignmentID, int studentID, int questionID)
        {

            string query = "SELECT IsCorrect, Response, TimeTakenSeconds FROM StudentQuestionAttempts WHERE AssignmentID = @AssignmentID AND StudentID = @StudentID AND QuestionID = @QuestionID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@QuestionID", questionID);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new QuestionResultViewModel
                        {
                            IsCorrect = reader.GetBoolean(reader.GetOrdinal("IsCorrect")),
                            Response = reader["Response"].ToString(),
                            CorrectAnswer = GetQuestionAnswer(questionID),
                            TimeTakenSeconds = reader.GetInt32(reader.GetOrdinal("TimeTakenSeconds"))
                        };
                    }
                }
            }
            return null;
        }
        internal void SubmitFeedback(int assignmentID, int studentID, string feedback)
        {
            string update = "UPDATE StudentAssignments SET Feedback = @Feedback WHERE AssignmentID = @AssignmentID AND StudentID = @StudentID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(update, conn))
            {
                cmd.Parameters.AddWithValue("@Feedback", feedback);
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        internal bool HasFeedback(int assignmentID, int studentID)
        {
            string query = "SELECT COUNT(*) FROM StudentAssignments WHERE AssignmentID = @AssignmentID AND StudentID = @StudentID AND Feedback IS NOT NULL";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
        internal bool AssignmentCreated(int assignmentID, int teacherID)
        {
            string query = "SELECT COUNT(*) FROM Assignments WHERE AssignmentID = @AssignmentID AND TeacherID = @TeacherID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
        internal bool AssignmentHasQuestions(int assignmentID)
        {
            string query = "SELECT COUNT(*) FROM AssignmentQuestions WHERE AssignmentID = @AssignmentID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
        internal bool IsHomeworkAssigned(int assignmentID)
        {
            string query = "SELECT COUNT(*) FROM StudentAssignments WHERE AssignmentID = @AssignmentID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
        internal void RemoveQuestionFromAssignment(int assignmentID, int questionID)
        {
            string delete = "DELETE FROM AssignmentQuestions WHERE AssignmentID = @AssignmentID AND QuestionID = @QuestionID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(delete, conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                cmd.Parameters.AddWithValue("@QuestionID", questionID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        internal List<QuestionViewModel> GetQuestions(int questionID, int difficulty, string keyword)
        {
            var results = new List<QuestionViewModel>();

            List<string> conditions = new List<string>();
            if (questionID > 0)
            {
                conditions.Add("QuestionID = @QuestionID");
            }
            if (difficulty > 0)
            {
                conditions.Add("Difficulty = @Difficulty");
            }
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                conditions.Add("Description LIKE @Description");
            }
            string query = "SELECT QuestionID, Difficulty, Description FROM Questions";
            if (conditions.Count > 0)
            {
                query += " WHERE " + conditions[0];
                for (int i = 1; i < conditions.Count; i++)
                {
                    query += " AND " + conditions[i];
                }
            }
            query += " ORDER BY QuestionID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (questionID > 0)
                    cmd.Parameters.AddWithValue("@QuestionID", questionID);
                if (difficulty > 0)
                    cmd.Parameters.AddWithValue("@Difficulty", difficulty);
                if (!string.IsNullOrWhiteSpace(keyword))
                    cmd.Parameters.AddWithValue("@Description", "%" + keyword.Trim() + "%");

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new QuestionViewModel
                        {
                            QuestionID = reader.GetInt32(reader.GetOrdinal("QuestionID")),
                            Difficulty = reader.GetInt32(reader.GetOrdinal("Difficulty")),
                            Description = reader["Description"].ToString()
                        });
                    }
                }
            }
            return results;
        }
        internal QuestionViewModel GetQuestion(int questionID)
        {
            string query = "SELECT QuestionID, Question, Answer, Difficulty, Description FROM Questions WHERE QuestionID = @QuestionID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@QuestionID", questionID);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new QuestionViewModel
                        {
                            QuestionID = reader.GetInt32(reader.GetOrdinal("QuestionID")),
                            Question = reader["Question"].ToString(),
                            Answer = reader["Answer"].ToString(),
                            Difficulty = reader.GetInt32(reader.GetOrdinal("Difficulty")),
                            Description = reader["Description"].ToString()
                        };
                    }
                }
            }
            return null;
        }
        internal void CreateQuestion(int questionID, string question, string answer, int difficulty, string description)
        {
            string update = "UPDATE Questions SET Question = @Question, Answer = @Answer, Difficulty = @Difficulty, Description = @Description WHERE QuestionID = @QuestionID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(update, conn))
            {
                cmd.Parameters.AddWithValue("@QuestionID", questionID);
                cmd.Parameters.AddWithValue("@Question", question);
                cmd.Parameters.AddWithValue("@Answer", answer);
                cmd.Parameters.AddWithValue("@Difficulty", difficulty);
                cmd.Parameters.AddWithValue("@Description", description);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        internal void CreateQuestion(string question, string answer, int difficulty, string description)
        {
            string insert = "INSERT INTO Questions (Question, Answer, Difficulty, Description) VALUES (@Question, @Answer, @Difficulty, @Description)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@Question", question);
                cmd.Parameters.AddWithValue("@Answer", answer);
                cmd.Parameters.AddWithValue("@Difficulty", difficulty);
                cmd.Parameters.AddWithValue("@Description", description);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        internal bool CompletedHomework(int assignmentID, int studentID)
        {
            string query = "SELECT Status FROM StudentAssignments WHERE AssignmentID = @AssignmentID AND StudentID = @StudentID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null && result.ToString() == "Complete";
            }
        }
    }
}
//"C:\\Users\\yessi\\source\\repos\\NEA Math Program\\NEA Math Program\\Database.mdf"