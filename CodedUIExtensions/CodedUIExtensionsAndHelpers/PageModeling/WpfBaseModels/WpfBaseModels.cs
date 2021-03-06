﻿using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CodedUIExtensionsAndHelpers.PageModeling
{
    /// <summary>
    /// Default implementation of a Wpf page model
    /// </summary>
    public abstract class WpfPageModelBase<T> : PageModelBase<T> where T : WpfControl
    {
        protected readonly WpfWindow parent;
        protected WpfPageModelBase(WpfWindow bw)
        {
            parent = bw;
        }

        protected WpfWindow DocumentWindow
        {
            get { return this.parent; }
        }
    }
}