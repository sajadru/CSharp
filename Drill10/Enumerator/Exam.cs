using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    class Exam : IEnumerable
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public Question[] Questions { get; set; }

        public IEnumerator GetEnumerator()
        {
            //return this.Questions.GetEnumerator();
           // return new ExamEnumerator(this.Questions);
            return new ExamRandom(this.Questions,1);
        }
    }

    class ExamEnumerator : IEnumerator
    {
        int index = -2;
        public ExamEnumerator(Question[] _questions)
        {
            this.questions = _questions;
        }
        private Question[] questions { get; set; }
        public object Current {
            get
            {
                try
                {
                    return questions[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            index += 2;
            return index < questions.Length;
        }

        public void Reset()
        {
             index = -2;
        }
    }
    class ExamRandom : IEnumerator
    {
        int index = 0;
        int number = 0;
        Random r = new Random();
        public ExamRandom(Question[] _questions,int count)
        {
            this.questions = _questions;
            this.number = count;
        }
        private Question[] questions { get; set; }
        public object Current
        {
            get
            {
                try
                {
                    return questions[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
          index =  r.Next(0, questions.Length);
            return number-- > 0;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
