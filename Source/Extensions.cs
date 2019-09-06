using System;
using System.Threading.Tasks;
using UnityEngine;

namespace PlayFab
{
    public static class Extensions
    {
        public static async void FireForgetLog(this Task task)
        {
            try
            {
                await task;
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }
}
