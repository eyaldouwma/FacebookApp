using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public class CloseFriendsCircle : IListOfFriendFeature
    {
        private Dictionary<string, int> m_MyFriendsCount;
        private Dictionary<string, string> m_MyFriendsByID = new Dictionary<string, string>();
        public int MaxMutualFriends
        {
            get;
            set;
        }

        private LinkedList<string> m_CloseCircleOfFriends = new LinkedList<string>();

        public CloseFriendsCircle(User i_FaceBookUser)
        {
            m_MyFriendsCount = new Dictionary<string, int>(i_FaceBookUser.Friends.Count);
            MaxMutualFriends = 0;
        }

        public void AddToDictionary(User i_FacebookUser)
        {
            foreach (User friend in i_FacebookUser.Friends)
            {
                m_MyFriendsCount.Add(friend.Id, MaxMutualFriends);
                m_MyFriendsByID.Add(friend.Id, friend.Name);
            }
        }

        public void CalculateCloseCircle(User i_FacebookUser)
        {
            foreach (User friend in i_FacebookUser.Friends)
            {
                foreach (User friendOfFriend in friend.Friends)
                {
                    if (m_MyFriendsCount.ContainsKey(friendOfFriend.Id))
                    {
                        m_MyFriendsCount[friendOfFriend.Id]++;
                        MaxMutualFriends = MaxMutualFriends < m_MyFriendsCount[friendOfFriend.Id]
                            ? m_MyFriendsCount[friendOfFriend.Id]
                            : MaxMutualFriends;
                    }
                }
            }
        }

        public void CloseCircleOfFriend()
        {
            foreach (string id in m_MyFriendsCount.Keys)
            {
                if (m_MyFriendsCount[id] == MaxMutualFriends)
                {
                    m_CloseCircleOfFriends.AddFirst(m_MyFriendsByID[id]);
                }
            }
        }

        public IIterator CreateIterator()
        {
            return new CloseFriendsCircleIterator(m_CloseCircleOfFriends);
        }
    }
}
