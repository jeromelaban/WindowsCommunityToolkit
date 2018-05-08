﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using Microsoft.Toolkit.Uwp.UI.Controls.Primitives;
using Windows.UI.Xaml.Automation.Peers;

namespace Microsoft.Toolkit.Uwp.Automation.Peers
{
    /// <summary>
    /// AutomationPeer for DataGridDetailsPresenter
    /// </summary>
    public class DataGridDetailsPresenterAutomationPeer : FrameworkElementAutomationPeer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridDetailsPresenterAutomationPeer"/> class.
        /// </summary>
        /// <param name="owner">DataGridDetailsPresenter</param>
        public DataGridDetailsPresenterAutomationPeer(DataGridDetailsPresenter owner)
            : base(owner)
        {
        }

        /// <summary>
        /// Gets the control type for the DataGridDetailsPresenter element that is associated with the UI Automation peer.
        /// </summary>
        /// <returns>The control type.</returns>
        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.Custom;
        }

        /// <summary>
        /// Called by GetClassName that gets a human readable name that, in addition to AutomationControlType,
        /// differentiates the control represented by this AutomationPeer.
        /// </summary>
        /// <returns>The string that contains the name.</returns>
        protected override string GetClassNameCore()
        {
            return this.Owner.GetType().Name;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the DataGridDetailsPresenter associated with this UIElementAutomationPeer
        /// is understood by the end user as interactive.
        /// </summary>
        /// <returns>True if the DataGridDetailsPresenter associated with this UIElementAutomationPeer
        /// is understood by the end user as interactive.</returns>
        protected override bool IsControlElementCore()
        {
            return true;
        }

        /// <summary>
        /// Gets a value that specifies whether the element is a content element.
        /// </summary>
        /// <returns>True if the element is a content element; otherwise false</returns>
        protected override bool IsContentElementCore()
        {
            return false;
        }
    }
}