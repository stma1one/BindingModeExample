using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BindingModeExample
{
    class FAQ1 
    {
        

        string question;
        string answer;
        

        public string Question {
            get { return question; }

            set {
                if (question != value)
                {
                    question = value;

                   
                }
            }
        }

        public string Answer
        {
            get { return answer; }
            set
            {
                if(answer!=value)
                {
                    answer = value;
                  
                }
            }
        }
    }
}
