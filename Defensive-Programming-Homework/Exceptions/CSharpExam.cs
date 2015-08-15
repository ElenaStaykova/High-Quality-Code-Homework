using System;

public class CSharpExam : Exam
{
    private int score;
    public const int minScore = 0;
    public const int maxScore = 100;

    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new ArgumentException("Score cannot be a negative number.");
        }

        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }
        private set
        {
            if (value < minScore || value > maxScore)
            {
                throw new ArgumentException("Score value cannot be less than zero or greater than 100.");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
