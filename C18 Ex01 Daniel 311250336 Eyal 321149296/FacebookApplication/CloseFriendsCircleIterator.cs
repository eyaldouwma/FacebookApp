using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public class CloseFriendsCircleIterator : IIterator
    {
        private LinkedList<string> m_CloseFriendList;
        private int m_Position;

        public CloseFriendsCircleIterator(LinkedList<string> i_List)
        {
            m_Position = 0;
            m_CloseFriendList = i_List;
        }

        public object First()
        {
            m_Position = 0;
            return m_CloseFriendList.ElementAt(m_Position);
        }

        public object getCurrent()
        {
            return m_CloseFriendList.ElementAt(m_Position);
        }

        public bool isDone()
        {
            return m_Position >= m_CloseFriendList.Count;
        }

        public object Next()
        {
            return m_CloseFriendList.ElementAt(m_Position++);
        }
    }
}
