using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Schnitzeljagd_library
{
    public class QuestionList : IEnumerable
    {
        private List<Question> Questions;
        
        public QuestionList()
        {
            this.Questions = new List<Question>();
        }

        public void Add(Question q)
        {
            this.Questions.Add(q);
        }

        public void InsertAt(int i, Question q)
        {
            this.Questions.Insert(i, q);
        }

        public bool Remove(Question q)
        {
           return this.Questions.Remove(q);
        }

        public Question this[int index]
        {
            get { return this.Questions[index]; }
            set { this.Questions[index] = value; }
        }

        public int IndexOf(Question q)
        {
            return this.Questions.IndexOf(q);
        }

        public int Count()
        {
            return this.Questions.Count;
        }

        public IEnumerator<Question> GetEnumerator()
        {
            return this.Questions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
