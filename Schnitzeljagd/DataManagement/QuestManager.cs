using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Schnitzeljagd_library;

namespace Schnitzeljagd.DataManagement
{
    class QuestManager
    {

        private static QuestManager INSTANCE;

        private QuestionList List;


        private QuestManager()
        {
            this.List = new QuestionList();
        }

        public static QuestManager getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new QuestManager();
            }
            return INSTANCE;
        }

        public void AddNewQuestion(Question q)
        {
            
        }
    }
}