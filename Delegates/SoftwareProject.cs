using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public enum ReviewStatus
    {
        pending, Approved, rejected
    }
    public class ReviewEventArgs : EventArgs
    {
        public SoftwareProject Project;
        public int Priority;
    }
    public delegate void ReviewEventHandler(SoftwareProject project, ReviewEventArgs args);
    public class SoftwareProject
    {
        public string name;
        public ReviewStatus status;

        private class ReviewHandlerInfo : IComparable<ReviewHandlerInfo>
        {
            public ReviewEventHandler Handler;
            public int Priority;
            public int CompareTo(ReviewHandlerInfo other)
            {
                return this.Priority.CompareTo(other.Priority);
            }
        }

        private new List<ReviewHandlerInfo> reviewHandlers = new List<ReviewHandlerInfo>();

        public void addReviewHandler(int priority, ReviewEventHandler handler)
        {
            ReviewHandlerInfo handlerInfo = new ReviewHandlerInfo() { Priority = priority, Handler = handler };
            reviewHandlers.Add(handlerInfo);
            reviewHandlers.Sort();
        }
        public void OnReviewEvent()
        {
            ReviewEventArgs reviewEventArgs = new ReviewEventArgs() { Project = this };
            foreach (ReviewHandlerInfo info in reviewHandlers)
            {
                if (this.status != ReviewStatus.pending) break;
                reviewEventArgs.Priority = info.Priority;
                info.Handler(this, reviewEventArgs);
            }
            
        }
    }
}
