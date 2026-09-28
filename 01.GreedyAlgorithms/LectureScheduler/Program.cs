namespace LectureScheduler;

class Lecture
{
    public int startHour;
    public int endHour;
    private int lectureNum;
    private static int lectureCount = 0;

    public Lecture(int start, int end)
    {
        Lecture.lectureCount++;
        this.startHour = start;
        this.endHour = end;
        this.lectureNum = lectureCount;
    }

    public override string ToString()
    {
        return $"Lecture number {this.lectureNum} starts at: {this.startHour} and ends at: {this.endHour}.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture1 = new Lecture(4, 6);
        Lecture lecture2 = new Lecture(1, 5);
        Lecture lecture3 = new Lecture(15, 17);
        Lecture lecture4 = new Lecture(6, 9);
        Lecture lecture5 = new Lecture(16, 19);
        Lecture lecture6 = new Lecture(3, 7);
        Lecture lecture7 = new Lecture(7, 16);
        
        List<Lecture> lectures = new List<Lecture>() {lecture1, lecture2, lecture3, lecture4, lecture5, lecture6, lecture7};
        lectures.Sort((a, b) => a.endHour.CompareTo(b.endHour));
        List<Lecture> possibleLectures = new List<Lecture>();

        foreach (Lecture lecture in lectures)
        {
            if (possibleLectures.Count == 0) {
                possibleLectures.Add(lecture);
                continue;
            }
            
            Lecture lastSaved = possibleLectures[possibleLectures.Count - 1];
            if (lastSaved.endHour <= lecture.startHour)
            {
                possibleLectures.Add(lecture);
            }
        }

        foreach (Lecture lecture in possibleLectures)
        {
            Console.WriteLine(lecture);
        }
    }
}