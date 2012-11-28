using System;
using System.IO;

namespace OpenClosedPrinciple
{
	public class BadCommentHandler
	{
		public void CommentHandler(Comment comment)
		{
			if(string.IsNullOrEmpty(comment.EmailAddress))
			{
				throw new ArgumentException("email address is invlaid");
			}

			if(!comment.EmailAddress.Contains("@"))
			{
				throw new ArgumentException("email address is invlaid");
			}

			if(comment.Content.Length < 10)
			{
				throw new ArgumentException("you are spam");
			}
			
			File.WriteAllText(comment.EmailAddress,comment.Content);
		}

	}
}