using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            ValidateIfNull(value, "Grade");
            ValidateIfPositive(value, "Grade");
            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            ValidateIfNull(value, "Min grade");
            ValidateIfPositive(value, "Min grade");
            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }
        private set
        {
            ValidateIfNull(value, "Max grade");
            ValidateIfPositive(value, "Max grade");
            if (value <= minGrade)
            {
                throw new ArgumentException("Max grade cannot be less than or equal to min grade.");
            }
            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }
        private set
        {
            ValidateIfNull(value, "Comments");
            if (value == "")
            {
                throw new ArgumentNullException("Comments cannot be empty.");
            }
            this.comments = value;
        }
    }

    public void ValidateIfNull(object value, string message)
    {
        if (value == null)
        {
            throw new ArgumentNullException(message + " cannot be null.");
        }
    }

    public void ValidateIfPositive(int value, string message)
    {
        if (value < 0)
        {
            throw new ArgumentException(message + " cannot be less than zero.");
        }
    }
}
