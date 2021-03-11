using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BindingModeExample
{
    class FAQ : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string question;
        string answer;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Question {
            get { return question; }

            set {
                if (question != value)
                {
                    question = value;

                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
