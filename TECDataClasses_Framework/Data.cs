using System;

namespace TECDataClasses
{
    public class UserData
    {
        public UserData(string username, string discordUsername, string encryptedPassword, string email, UserRole role, bool emailConfirmed, string pronouns, DateTime birthday, int userID)
        {
            this.username = username;
            this.discordUsername = discordUsername;
            this.encryptedPassword = encryptedPassword;
            this.email = email;
            this.role = role;
            this.emailConfirmed = emailConfirmed;
            this.pronouns = pronouns;
            this.birthday = birthday;
            this.userID = userID;
        }

        public string username { get; set; }
        public string discordUsername { get; set; }
        public string encryptedPassword { get; set; }
        public string email { get; set; }
        public UserRole role { get; set; }
        public bool emailConfirmed { get; set; }
        public string pronouns { get; set; }
        public DateTime birthday { get; set; }
        public int userID { get; set; }
    }

    public enum UserRole
    {
        user,
        moderator,
        admin,
        staff,
        owner
    }

    public static class UserRoleExtentions
    {
        public static UserRole Parse(this string currentString)
        {
            switch (currentString)
            {
                case "U":
                    return UserRole.user;
                case "M":
                    return UserRole.moderator;
                case "A":
                    return UserRole.admin;
                case "S":
                    return UserRole.staff;
                case "O":
                    return UserRole.owner;
                default:
                    throw new Exception("Incorrect value for UserRole");
            }
        }
    }

    public class EventInfo
    {
        public EventInfo(
            int eventNumber,
            string eventName,
            string eventDescription,
            EventType eventType,
            bool questCompatable,
            string userPings,
            string eventLink,
            EventRating eventRating,
            DateTime eventDate,
            DateTime eventEnd,
            string eventLocation)
        {
            EventNumber = eventNumber;
            EventName = eventName;
            EventDescription = eventDescription;
            EventType = eventType;
            QuestCompatable = questCompatable;
            UserPings = userPings;
            EventLink = eventLink;
            EventRating = eventRating;
            EventDate = eventDate;
            EventEnd = eventEnd;
            EventLocation = eventLocation;
        }

        public int EventNumber { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public EventType EventType { get; set; }
        public bool? QuestCompatable { get; set; }
        public string UserPings { get; set; } //Json encoded list of pings by discord user ID
        public string EventLink { get; set; }
        public EventRating EventRating { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventEnd { get; set; }
        public string EventLocation { get; set; }
    }

    public enum EventType
    {
        Game,
        Panel,
        Special,
        GuestPanel,
        GuestGame,
        Video,
        Shop
    }
    public enum EventRating
    {
        Everyone,
        PG13,
        Adult
    }
}
