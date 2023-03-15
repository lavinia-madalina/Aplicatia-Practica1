using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace Quizgame
{
 
	class TriviaItem
	{
	private string Question;
	private string Answer;

	public void Triviaitem(string quizquestion, string quizanswer)
		{
			Question = quizquestion;
			Answer = quizanswer;
		}

	public void AskQuestion()
		{
			// imi arata intrebarile, raspunsurile, etc
			WriteLine(Question);
		}

	}
}
