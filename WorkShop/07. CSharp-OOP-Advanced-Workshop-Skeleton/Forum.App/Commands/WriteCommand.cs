using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Commands
{
    using Contracts;

    public class WriteCommand : Contracts.ICommand
    {
        private ISession session;

        public WriteCommand(ISession session)
        {
            this.session = session;
        }

        public IMenu Execute(params string[] args)
        {
            IMenu currentMenu = this.session.CurrentMenu;

            if (currentMenu is ITextAreaMenu textAreaMenu)
            {
                textAreaMenu.TextArea.Write();
            }

            return currentMenu;
        }
    }
}
