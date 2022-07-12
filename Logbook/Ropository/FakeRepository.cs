using Logbook.Models;

namespace Logbook.Ropository;

public class FakeRepository
{
    public static List<Student> Students { get; set; } = new()
    {
        new Student(1, "1.jpg",    "Ceyhun",   "Abdullayev", "Aqil", new DateTime(2022, 05, 24), ParticipationStatus.Unknown, null, null, null, null),
        new Student(2, null,    "Ağamətləb", "Akbarzade", "Metleb", new DateTime(2022, 05, 26), ParticipationStatus.Unknown, null, null, null, null),
        new Student(3, "3.jpg",    "Fərman",   "Asadov", "Suleyman", new DateTime(2022, 05, 23), ParticipationStatus.Unknown, null, null, null, null),
        new Student(4, "4.jpg",    "Nihad",    "Axundzade", "Refi", new DateTime(2022, 05, 26), ParticipationStatus.Unknown, null, null, null, null),
        new Student(5, null,    "Cəfər",    "Imamaliyev", "Yaver", new DateTime(2022, 05, 24), ParticipationStatus.Unknown, null, null, null, null),
        new Student(6, "6.jpg",    "Kənan",    "Nebizade", "Namiq", new DateTime(2022, 05, 26), ParticipationStatus.Unknown, null, null, null, null),
        new Student(7, "7.jpg",    "Leyla",    "Qocayeva", "Zaur", new DateTime(2022, 05, 26), ParticipationStatus.Unknown, null, null, null, null),
        new Student(8, "8.jpg",    "Nihat",    "Rustemli", "Bilal", new DateTime(2022, 05, 26), ParticipationStatus.Unknown, null, null, null, null),
        new Student(9, "9.jpg",    "Elgün",    "Salmanov", "Natiq", new DateTime(2022, 05, 26), ParticipationStatus.Unknown, null, null, null, null),
        new Student(10, "10.jpg",  "Səbinə",   "Shukurova", "Bextiyar", new DateTime(2022, 05, 26), ParticipationStatus.Unknown, null, null, null, null),
    };

}
