//
// INewProjectDialogController.cs
//
// Author:
//       Matt Ward <matt.ward@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System.Collections.Generic;
using MonoDevelop.Ide.Templates;
using Xwt.Drawing;
using System.Threading.Tasks;

namespace MonoDevelop.Ide.Projects
{
	interface INewProjectDialogController
	{
		IEnumerable<TemplateCategory> TemplateCategories { get; }
		TemplateCategory SelectedSecondLevelCategory { get; }
		SolutionTemplate SelectedTemplate { get; set; }
		string SelectedLanguage { get; set; }
		FinalProjectConfigurationPage FinalConfiguration { get; }
		bool IsNewSolution { get; }

		SolutionTemplate GetSelectedTemplateForSelectedLanguage ();

		bool CanMoveToNextPage { get; }
		bool CanMoveToPreviousPage { get; }

		string NextButtonText { get; }
		string BannerText { get; }

		void MoveToPreviousPage ();
		void MoveToNextPage ();
		bool IsFirstPage { get; }
		bool IsLastPage { get; }
		bool IsWizardPage { get; }

		WizardPage CurrentWizardPage { get; }

		Task Create ();

		Image GetImage (SolutionTemplate template);

		IEnumerable<ProjectConfigurationControl> GetFinalPageControls ();
	}
}

